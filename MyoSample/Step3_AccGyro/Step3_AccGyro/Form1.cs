using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MyoSharp.Communication; // IChannel
using MyoSharp.Exceptions; // MyoErrorHandlerDriver
using MyoSharp.Device; // IHub

using OpenJigWare; // Ojw.CMessage & Ojw.CGraph

// 반드시 실행 경로에 Microsoft.Contracts.dll, x64폴더, x86폴더를 복사해 두도록 한다.
// 참조 - 참조추가 - 찾아보기 - MyoSharp.dll, OpenJigWare.dll 선택 - 확인

namespace Step3_AccGyro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IChannel m_myoChannel;
        private IHub m_myoHub;
        private void InitMyo()
        {
            #region Step1
            // For Message
            Ojw.CMessage.Init(txtMessage);

            m_myoChannel = Channel.Create(ChannelDriver.Create(ChannelBridge.Create(), MyoErrorHandlerDriver.Create(MyoErrorHandlerBridge.Create())));
            m_myoHub = Hub.Create(m_myoChannel);

            // 이벤트 등록            
            m_myoHub.MyoConnected += new EventHandler<MyoEventArgs>(myoHub_MyoConnected); // 접속했을 때 myoHub_MyoConnected() 함수가 동작하도록 등록
            m_myoHub.MyoDisconnected += new EventHandler<MyoEventArgs>(myoHub_MyoDisconnected); // 접속했을 때 myoHub_MyoDisconnected() 함수가 동작하도록 등록
            #endregion Step1


            // start listening for Myo data
            m_myoChannel.StartListening();
            Ojw.CMessage.Write("Form Loaded...");
        }
        private void DInitMyo()
        {
            m_myoChannel.StopListening();

            m_myoHub.Dispose();
            m_myoChannel.Dispose();
        }
        private int[] m_anHandle = new int[2];
        //private bool[] m_abHandle = new bool[2];
        private int m_nCnt_Handle = 0;
        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}] has connected!", e.Myo.Handle, e.Myo.XDirectionOnArm, e.Myo.Arm);
            //m_abHandle[m_nCnt_Handle] = true;
            m_anHandle[m_nCnt_Handle] = e.Myo.Handle.ToInt32();
            e.Myo.Vibrate(VibrationType.Short); // 접속에 성공했으니 짧게 진동 출력

            #region Sensor
            e.Myo.AccelerometerDataAcquired += Myo_AccelerometerDataAcquired;
            e.Myo.GyroscopeDataAcquired += Myo_GyroscopeDataAcquired;
            //e.Myo.OrientationDataAcquired += Myo_OrientationDataAcquired;
            #endregion Sensor

            m_nCnt_Handle++;
        }
        private void myoHub_MyoDisconnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}]접속해제", e.Myo.Handle, e.Myo.XDirectionOnArm, e.Myo.Arm);
            m_nCnt_Handle = 0;
            //m_abHandle[0] = false;
            //m_abHandle[1] = false;
            #region Sensor
            e.Myo.AccelerometerDataAcquired -= Myo_AccelerometerDataAcquired;
            e.Myo.GyroscopeDataAcquired -= Myo_GyroscopeDataAcquired;
            //e.Myo.OrientationDataAcquired -= Myo_OrientationDataAcquired;
            #endregion Sensor
        }
        #region Acc
        private float[] m_afAcc = new float[3];
        private void Myo_AccelerometerDataAcquired(object sender, AccelerometerDataEventArgs e)
        {
            //float fMulti = 10.0f;
            //m_CGrap.Push((int)Math.Round(e.Accelerometer.X * fMulti), (int)Math.Round(e.Accelerometer.Y * fMulti), (int)Math.Round(e.Accelerometer.Z * fMulti));
            if (m_anHandle[0] == e.Myo.Handle.ToInt32())
            {
                m_afAcc[0] = e.Accelerometer.X;// / 57.1f * 90.0f;
                m_afAcc[1] = e.Accelerometer.Y;// / 57.1f * 90.0f;
                m_afAcc[2] = e.Accelerometer.Z;/// 57.1f * 90.0f;
            }
#if false
            if (m_CTIdAcc.Get() >= 1000)
            {
                m_CTIdAcc.Set();
                float[] afAngle = new float[3];
                afAngle[0] = (float)Ojw.CMath.R2D((double)m_afAcc[0]);//(float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2]));
                afAngle[1] = (float)Ojw.CMath.R2D((double)m_afAcc[1]);//(float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0]));
                afAngle[2] = (float)Ojw.CMath.R2D((double)m_afAcc[2]);//(float)Math.Atan(m_afAcc[2] / (float)Math.Sqrt(m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1]));
                Ojw.CMessage.Write("Acc : {0}, {1}, {2}", afAngle[0], afAngle[1], afAngle[2]);

            }
#endif
        }
        #endregion Acc
        #region Gyro
        private float[] m_afGyro = new float[3];
        private void Myo_GyroscopeDataAcquired(object sender, GyroscopeDataEventArgs e)
        {
            //float fMulti = 10.0f;
            //m_CGrap.Push(m_afAcc(int)Math.Round(e.Gyroscope.X * fMulti), (int)Math.Round(e.Gyroscope.Y * fMulti), (int)Math.Round(e.Gyroscope.Z * fMulti));
            if (m_anHandle[0] == e.Myo.Handle.ToInt32())
            {
                m_afGyro[0] = e.Gyroscope.X;
                m_afGyro[1] = e.Gyroscope.Y;
                m_afGyro[2] = e.Gyroscope.Z;
            }
#if false
            #region Message display on every 1 second
            if (m_CTIdGyro.Get() >= 1000)
            {
                m_CTIdGyro.Set();
                float[] afAngle = new float[3];
                Ojw.CMessage.Write("Gyro : {0}, {1}, {2}", m_afGyro[0], m_afGyro[1], m_afGyro[2]);
            }
            #endregion Message display on every 1 second
#endif
        }
        #endregion Gyro

        private Ojw.CTimer m_CTId0 = new Ojw.CTimer();
        private Ojw.CTimer m_CTIdAcc = new Ojw.CTimer();
        private Ojw.CTimer m_CTIdGyro = new Ojw.CTimer();
        private float[] m_afInitAngle = new float[3];
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

        private Ojw.CGraph m_CGrap = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Graph
            m_CGrap = new Ojw.CGraph(lbDisp, lbDisp.Width, Color.White, null, 
                Color.Red, Color.Blue, Color.Black,
                Color.Red, Color.Blue, Color.Black);

            InitMyo();

            tmrDraw.Enabled = true;
        }

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            float fMulti = 1.0f;
            float[] afAngle = new float[3];
            //afAngle[0] = (float)Ojw.CMath.R2D((double)m_afAcc[0]);//(float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2]));
            //afAngle[1] = (float)Ojw.CMath.R2D((double)m_afAcc[1]);//(float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0]));
            //afAngle[2] = (float)Ojw.CMath.R2D((double)m_afAcc[2]);//(float)Math.Atan(m_afAcc[2] / (float)Math.Sqrt(m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1]));
#if false
            float fTmp;
            fTmp = ((m_afAcc[2] == 0.0f) ? (float)Ojw.CMath.Zero() : m_afAcc[2]);
            afAngle[0] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[1] / fTmp));
            fTmp = ((m_afAcc[0] == 0.0f) ? (float)Ojw.CMath.Zero() : m_afAcc[0]);
            afAngle[1] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[2] / fTmp));
            fTmp = ((m_afAcc[1] == 0.0f) ? (float)Ojw.CMath.Zero() : m_afAcc[1]);
            afAngle[2] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[0] / fTmp));
#else
            float fTmp = m_afAcc[1] * m_afAcc[1] + m_afAcc[2] * m_afAcc[2];
            if (fTmp == 0.0f) fTmp = (float)Ojw.CMath.Zero();
            afAngle[0] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[0] / (float)Math.Sqrt(fTmp)));
            fTmp = m_afAcc[2] * m_afAcc[2] + m_afAcc[0] * m_afAcc[0];
            if (fTmp == 0.0f) fTmp = (float)Ojw.CMath.Zero(); 
            afAngle[1] = (float)Ojw.CMath.R2D((float)Math.Atan(m_afAcc[1] / (float)Math.Sqrt(fTmp)));
            fTmp = m_afAcc[0] * m_afAcc[0] + m_afAcc[1] * m_afAcc[1];
            float fTmp2 = m_afAcc[2];
            if (fTmp2 == 0.0f) fTmp2 = (float)Ojw.CMath.Zero();
            afAngle[2] = (float)Ojw.CMath.R2D((float)Math.Atan((float)Math.Sqrt(fTmp) / fTmp2));
#endif
            m_CGrap.Push(
                (int)Math.Round(afAngle[0] * fMulti), (int)Math.Round(afAngle[1] * fMulti), (int)Math.Round(afAngle[2] * fMulti),
                //(int)Math.Round(m_afAcc[0] * fMulti), (int)Math.Round(m_afAcc[1] * fMulti), (int)Math.Round(m_afAcc[2] * fMulti),
                (int)Math.Round(m_afGyro[0] * fMulti), (int)Math.Round(m_afGyro[1] * fMulti), (int)Math.Round(m_afGyro[2] * fMulti)
                );
            m_CGrap.OjwDraw();
        }
    }
}
