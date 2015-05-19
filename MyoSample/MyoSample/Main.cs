using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

using MyoSharp.Poses;
using MyoSharp.Communication;
using MyoSharp.Device;
//using MyoSharp.ConsoleSample.Internal;
using MyoSharp.Exceptions;

namespace MyoSample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Myo Step(1)
        private IChannel m_myoChannel;
        private IHub m_myoHub;
        private IHeldPose m_myoPos;

        private void InitMyo()
        {
            CheckForIllegalCrossThreadCalls = false;

            m_myoChannel = Channel.Create(ChannelDriver.Create(ChannelBridge.Create(), MyoErrorHandlerDriver.Create(MyoErrorHandlerBridge.Create())));
            m_myoHub = Hub.Create(m_myoChannel);

            // 이벤트 등록            
            m_myoHub.MyoConnected += new EventHandler<MyoEventArgs>(myoHub_MyoConnected); // 접속했을 때 myoHub_MyoConnected() 함수가 동작하도록 등록
            m_myoHub.MyoDisconnected += new EventHandler<MyoEventArgs>(myoHub_MyoDisconnected); // 접속했을 때 myoHub_MyoDisconnected() 함수가 동작하도록 등록

            // start listening for Myo data
            m_myoChannel.StartListening();
        }
        private void DInitMyo()
        {
            m_myoChannel.StopListening();

            m_myoHub.Dispose();
            m_myoChannel.Dispose();
        }
        private void Myo_Unlocked(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("UnLocked", e.Myo.Handle);
        }
        private void Myo_Locked(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Locked", e.Myo.Handle);
        }
        private void Myo_PoseChanged(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("{0} arm Myo detected {1} pose!", e.Myo.Arm, e.Myo.Pose);
        }
        private void Pose_Triggered(object sender, PoseEventArgs e)
        {
            m_nPos = (int)e.Pose;

            //Ojw.CMessage.Write("{0} arm Myo detected [{1}] pose", e.Myo.Arm, m_nPos);
        }
        private Ojw.CTimer m_CTId0 = new Ojw.CTimer();
        private float[] m_afInitAngle = new float[3];
        private bool m_bFirst = true;
        private void Myo_OrientationDataAcquired(object sender, OrientationDataEventArgs e)
        {
            const float PI = (float)System.Math.PI;

            int nDev = 1; //10;
            // convert the values to a 0-9 scale (for easier digestion/understanding)
            float nRoll = (float)((e.Roll + PI) / (PI * 2.0f) * nDev);
            float nPitch = (float)((e.Pitch + PI) / (PI * 2.0f) * nDev);
            float nYaw = (float)((e.Yaw + PI) / (PI * 2.0f) * nDev);

            if (m_CTId0.Get() >= 1000)
            {
                m_CTId0.Set();
                //if (m_bFirst == true)
                //{
                //    m_afInitAngle[0] = e.Orientation.X;
                //    m_afInitAngle[1] = e.Orientation.Y;
                //    m_afInitAngle[2] = e.Orientation.W;
                //}
                float fX = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.X - m_afInitAngle[0]), 3);
                float fY = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.Y - m_afInitAngle[1]), 3);
                float fW = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.W - m_afInitAngle[2]), 3);
                //float fSwing = (float)Math.Round(Ojw.CMath.R2D(e.Roll), 3);
                //float fTilt = (float)Math.Round(Ojw.CMath.R2D(e.Pitch), 3);
                //float fPan = (float)Math.Round(Ojw.CMath.R2D(e.Yaw), 3);
                //m_C3d.SetRobot_Rot(fPan - 90.0f, -fTilt, -fSwing);
                Ojw.CMessage.Write("[{6}]Roll[{0}], Pitch[{1}], Yaw[{2}] || X[{3}], Y[{4}], W[{5}]", nRoll, nPitch, nYaw, fX, fY, fW, e.Myo.Handle);
            }
        }
        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}] has connected!", e.Myo.Handle, e.Myo.XDirectionOnArm.ToString(), e.Myo.Arm.ToString());

            e.Myo.Vibrate(VibrationType.Short); // 접속에 성공했으니 짧게 진동 출력


            e.Myo.Locked += Myo_Locked;
            e.Myo.Unlocked += Myo_Unlocked; 
            //e.Myo.Locked += new EventHandler<MyoEventArgs>(Myo_Locked);
            //e.Myo.Unlocked += new EventHandler<MyoEventArgs>(Myo_Unlocked);
            #region Pose(Edge - 자세가 변하는 순간에만 기록)
            e.Myo.PoseChanged += Myo_PoseChanged;
            #endregion Pose(Edge - 자세가 변하는 순간에만 기록)

            #region Pose(자세가 계속적으로 기록...)
            // setup for the pose we want to watch for
            m_myoPos = HeldPose.Create(e.Myo, Pose.Fist, Pose.FingersSpread, Pose.WaveIn, Pose.WaveOut, Pose.Rest);
            // set the interval for the event to be fired as long as 
            // the pose is held by the user
            m_myoPos.Interval = TimeSpan.FromSeconds(0.5);
                        
            m_myoPos.Start();
            m_myoPos.Triggered += Pose_Triggered;
            #endregion Pose(자세가 계속적으로 기록...)

            e.Myo.Unlock(UnlockType.Hold); // 이걸 마지막에 선언하면 Myo 가 내버려 두어도 Lock 이 되지 않는다.

            #region Orientation
            e.Myo.OrientationDataAcquired += Myo_OrientationDataAcquired;
            #endregion Orientation

#if false //_DEF_EMG
            e.Myo.EmgDataAcquired += Myo_EmgDataAcquired;
            e.Myo.SetEmgStreaming(true);
            //tmrPulse.Enabled = true;
#endif
        }
        //private float[] m_afAcc = new float[3];
        //private float[] m_afGyro = new float[3];
        //private float[] m_afAngle = new float[3];
        private float[] m_afOrientation = new float[3];
        private int m_nPos = -1;
        private void myoHub_MyoDisconnected(object sender, MyoEventArgs e)
        {
            e.Myo.Locked -= Myo_Locked;
            e.Myo.Unlocked -= Myo_Unlocked;
            e.Myo.PoseChanged -= Myo_PoseChanged;
            
            m_myoPos.Stop();
            m_myoPos.Triggered -= Pose_Triggered;

            #region Orientation
            e.Myo.OrientationDataAcquired -= Myo_OrientationDataAcquired;
            #endregion Orientation
#if _DEF_EMG
            e.Myo.SetEmgStreaming(false);
            e.Myo.EmgDataAcquired -= Myo_EmgDataAcquired;
            //tmrPulse.Enabled = false;
#endif
            Ojw.CMessage.Write("접속해제");
        }
        #endregion Myo Step(1)

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 출력을 기록할 메세지 박스 지정
            Ojw.CMessage.Init(txtMessage);

            #region Myo Step(2)
            InitMyo();
            #endregion MyoStep(2)

            tmrMyo.Enabled = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region Myo Step(End)
            DInitMyo();
            #endregion MyoStep(End)
        }

        private void tmrMyo_Tick(object sender, EventArgs e)
        {
            tmrMyo.Enabled = false;

            

            tmrMyo.Enabled = true;
        }
    }
}
