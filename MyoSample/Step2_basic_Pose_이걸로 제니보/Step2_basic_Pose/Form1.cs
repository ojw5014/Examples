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

using OpenJigWare;
using MyoSharp.Poses; // Ojw.CMessage

using System.Threading;
using System.Net;

// 반드시 실행 경로에 Microsoft.Contracts.dll, x64폴더, x86폴더를 복사해 두도록 한다.
// 참조(reference) - 참조추가(add reference) - 찾아보기(searching tab) - MyoSharp.dll, OpenJigWare.dll 선택 - 확인

using OjwSocketFunction;
using System.IO;

namespace Step2_basic_Pose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Myo
        private IChannel m_myoChannel;
        private IHub m_myoHub;
        private IHeldPose m_myoPos;
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
        private Ojw.CTimer m_CTId0 = new Ojw.CTimer();
        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            m_CTId0.Set();
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}] has connected!", e.Myo.Handle, e.Myo.XDirectionOnArm, e.Myo.Arm);

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
        }
        private void myoHub_MyoDisconnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Myo [{0}, {1}, {2}]접속해제", e.Myo.Handle, e.Myo.XDirectionOnArm, e.Myo.Arm);

            m_myoPos.Stop();
            e.Myo.Locked -= Myo_Locked;
            e.Myo.Unlocked -= Myo_Unlocked;
            e.Myo.PoseChanged -= Myo_PoseChanged;

            m_myoPos.Stop();
            m_myoPos.Triggered -= Pose_Triggered;

            #region Orientation
            e.Myo.OrientationDataAcquired -= Myo_OrientationDataAcquired;
            #endregion Orientation

        }
        private float m_fR_Roll = 0.0f;
        private float m_fR_Pitch = 0.0f;
        private float m_fR_Yaw = 0.0f;
        private float m_fR_X = 0.0f;
        private float m_fR_Y = 0.0f;
        private float m_fR_W = 0.0f;

        private float m_fL_Roll = 0.0f;
        private float m_fL_Pitch = 0.0f;
        private float m_fL_Yaw = 0.0f;
        private float m_fL_X = 0.0f;
        private float m_fL_Y = 0.0f;
        private float m_fL_W = 0.0f;
            
        private bool m_bRight = false;
        private bool m_bLeft = false;
        private int m_nCommand = 0;
        private void Myo_OrientationDataAcquired(object sender, OrientationDataEventArgs e)
        {
            if (e.Myo.Arm == Arm.Right)
            {
                m_bRight = true;


                const float PI = (float)System.Math.PI;

                int nDev = 1; //10;
                // convert the values to a 0-9 scale (for easier digestion/understanding)
                float fRoll = (float)((e.Roll + PI) / (PI * 2.0f) * nDev);
                float fPitch = (float)((e.Pitch + PI) / (PI * 2.0f) * nDev);
                float fYaw = (float)((e.Yaw + PI) / (PI * 2.0f) * nDev);

                if (m_CTId0.Get() >= 1000)
                {
                    m_CTId0.Set();
                    Ojw.CMessage.Write("Pitch={0}", fPitch);
                    if (m_ER_Pose == Pose.FingersSpread)
                    {
                        if ((fPitch < 0.6f) && (fPitch >= 0.4f))
                        {
                            // 전진
                            Ojw.CMessage.Write("Forward");
                            m_nCommand = 1;
                            QWalk(_CNT_WALK, 0, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
                        }
                        else if (fPitch >= 0.6f)
                        {
                            // 후진
                            Ojw.CMessage.Write("Backward");
                            m_nCommand = 2;
                            QWalk(_CNT_WALK, 3, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
                        }
                        //else if (fPitch <= -20.0f)
                        //{

                        //}
                    }
                    else if (m_ER_Pose == Pose.Fist)
                    {
                        if (fPitch >= 0.6f)
                        {
                            if (m_nCommand != 3)
                            {
                                Ojw.CMessage.Write("Stand up");
                                m_nCommand = 3;
                                Ojw.CTimer.Wait(1000);
                                ActionPlay("80");
                            }
                        }
                        else if (fPitch < 0.4f)
                        {
                            if (m_nCommand != 4)
                            {
                                Ojw.CMessage.Write("have a seat");
                                m_nCommand = 4;
                                Ojw.CTimer.Wait(1000);
                                ActionPlay("40");
                            }
                        }
                        else QWalk_Stop(0); // Stop
                    }
                    else if (m_ER_Pose == Pose.WaveOut)
                    {
                        //if (m_nCommand != 5)
                        //{
                            Ojw.CMessage.Write("Right");
                            m_nCommand = 5;
                            QWalk(_CNT_WALK, 1, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0)); // Right
                        //}
                    }
                    else if (m_ER_Pose == Pose.WaveIn)
                    {
                        //if (m_nCommand != 6)
                        //{
                            Ojw.CMessage.Write("Left");
                            m_nCommand = 6;
                            QWalk(_CNT_WALK, 2, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
                        //}
                    }

                    //if (m_bFirst == true)
                    //{
                    //    m_afInitAngle[0] = e.Orientation.X;
                    //    m_afInitAngle[1] = e.Orientation.Y;
                    //    m_afInitAngle[2] = e.Orientation.W;
                    //}
                    //float fX = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.X - m_afInitAngle[0]), 3);
                    //float fY = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.Y - m_afInitAngle[1]), 3);
                    //float fW = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.W - m_afInitAngle[2]), 3);
                    //float fSwing = (float)Math.Round(Ojw.CMath.R2D(e.Roll), 3);
                    //float fTilt = (float)Math.Round(Ojw.CMath.R2D(e.Pitch), 3);
                    //float fPan = (float)Math.Round(Ojw.CMath.R2D(e.Yaw), 3);
                    //m_C3d.SetRobot_Rot(fPan - 90.0f, -fTilt, -fSwing);
                    //Ojw.CMessage.Write("[{6}]Roll[{0}], Pitch[{1}], Yaw[{2}] || X[{3}], Y[{4}], W[{5}]", fRoll, fPitch, fYaw, fX, fY, fW, e.Myo.Handle);
                }
                
                m_fR_Roll = fRoll;
                m_fR_Pitch = fPitch;
                m_fR_Yaw = fYaw;
                //m_fR_X = fX;
                //m_fR_Y = fY;
                //m_fR_W = fW;
            }
            else if (e.Myo.Arm == Arm.Left)
            {
                m_bLeft = true;


                const float PI = (float)System.Math.PI;

                int nDev = 1; //10;
                // convert the values to a 0-9 scale (for easier digestion/understanding)
                float fRoll = (float)((e.Roll + PI) / (PI * 2.0f) * nDev);
                float fPitch = (float)((e.Pitch + PI) / (PI * 2.0f) * nDev);
                float fYaw = (float)((e.Yaw + PI) / (PI * 2.0f) * nDev);

                //if (m_CTId0.Get() >= 1000)
                //{
                //m_CTId0.Set();
                //if (m_bFirst == true)
                //{
                //    m_afInitAngle[0] = e.Orientation.X;
                //    m_afInitAngle[1] = e.Orientation.Y;
                //    m_afInitAngle[2] = e.Orientation.W;
                //}
                //float fX = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.X - m_afInitAngle[0]), 3);
                //float fY = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.Y - m_afInitAngle[1]), 3);
                //float fW = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.W - m_afInitAngle[2]), 3);
                //float fSwing = (float)Math.Round(Ojw.CMath.R2D(e.Roll), 3);
                //float fTilt = (float)Math.Round(Ojw.CMath.R2D(e.Pitch), 3);
                //float fPan = (float)Math.Round(Ojw.CMath.R2D(e.Yaw), 3);
                //m_C3d.SetRobot_Rot(fPan - 90.0f, -fTilt, -fSwing);
                //Ojw.CMessage.Write("[{6}]Roll[{0}], Pitch[{1}], Yaw[{2}] || X[{3}], Y[{4}], W[{5}]", nRoll, nPitch, nYaw, fX, fY, fW, e.Myo.Handle);
                //}


                m_fL_Roll = fRoll;
                m_fL_Pitch = fPitch;
                m_fL_Yaw = fYaw;
                //m_fL_X = fX;
                //m_fL_Y = fY;
                //m_fL_W = fW;
            }
        }
        public bool GetData(
                                out bool bRight, out float fR_Pan, out float fR_Tilt, out float fR_Swing, out Pose ER_Pose,
                                out bool bLeft, out float fL_Pan, out float fL_Tilt, out float fL_Swing, out Pose EL_Pose)
        {
            //if (IsInit() == false)
            //{
            //    bRight = bLeft = false;
            //    fR_Pan = 0.0f;
            //    fR_Tilt = 0.0f;
            //    fR_Swing = 0.0f;
            //    fL_Pan = 0.0f;
            //    fL_Tilt = 0.0f;
            //    fL_Swing = 0.0f;
            //    ER_Pose = Pose.Unknown;
            //    EL_Pose = Pose.Unknown;
            //    return false;
            //}

            bRight = m_bRight;
            bLeft = m_bLeft;
            fR_Pan = m_fR_Yaw;
            fR_Tilt = m_fR_Pitch;
            fR_Swing = m_fR_Roll;
            fL_Pan = m_fL_Yaw;
            fL_Tilt = m_fL_Pitch;
            fL_Swing = m_fL_Roll;

            ER_Pose = m_ER_Pose;
            EL_Pose = m_EL_Pose;

            return true;
        }
        private void Pose_Triggered(object sender, PoseEventArgs e)
        {
            //m_nPos = (int)e.Pose;
            //Ojw.CMessage.Write("{0} arm Myo detected [{1}] pose", e.Myo.Arm, m_nPos);
        }
        private void Myo_Unlocked(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("UnLocked", e.Myo.Handle);
        }
        private void Myo_Locked(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("Locked", e.Myo.Handle);
        }
        private Pose m_ER_Pose = new Pose();
        private Pose m_EL_Pose = new Pose();
        private void Myo_PoseChanged(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write("{0} arm Myo detected {1} pose!", e.Myo.Arm, e.Myo.Pose);
            if (e.Myo.Arm == Arm.Right)
            {
                m_ER_Pose = e.Myo.Pose;

                if (m_ER_Pose == Pose.DoubleTap)
                {
                    if (m_bCamera == false) Camera(true);
                    else Camera(false);
                }
            }
            else if (e.Myo.Arm == Arm.Left)
            {
                m_EL_Pose = e.Myo.Pose;
            }
        }
        #endregion Myo

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMyo();
            chkQwm_SpeedUp.Checked = true;
            for (int i = 0; i < 10; i++) OjwSock[i] = new COjwSocket();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Genibo
        public COjwSocket[] OjwSock = new COjwSocket[10];

        public int _ROBOT = 0;
        //public int _SOUND = 1;
        public int _VISION = 2;
        public int _MOTION = 3;
        //public int _SENSOR = 4;
        //public int _EMOTICON = 5;

        public int _TEST = 9;
        private int m_nUpdate = 0;
        private bool OjwConnect()
        {
            bool bOk = false;
            if (btnConnect.Text == "Connect")
            {
                bOk = Connect();
                if (bOk == false) return false;
                // 인증////
                Ojw.CMessage.Write("Authorization Check");

                int i;
                int nSize1 = 21;
                int nSize2 = 21;
                int nSize = nSize1 + nSize2;
                byte[] byteData = new byte[nSize];
                for (i = 0; i < nSize; i++)
                {
                    byteData[i] = 0;
                }
                byte[] byteId = Encoding.Default.GetBytes(txtId.Text);
                for (i = 0; i < byteId.Length; i++)
                {
                    if (i > (nSize1 - 1)) break;
                    byteData[i] = byteId[i];
                }
                byte[] bytePasswd = Encoding.Default.GetBytes(mtxtPasswd.Text);
                for (i = 0; i < bytePasswd.Length; i++)
                {
                    if (i > (nSize2 - 1)) break;
                    byteData[i + nSize1] = bytePasswd[i];
                }
                ////
                int nUpdate = m_nUpdate;
                SendData(_ROBOT, 0x71, nSize, byteData);
                SendData(_MOTION, 0x71, nSize, byteData);
                SendData(_VISION, 0x71, nSize, byteData);
                //SendData(_TEST, 0x71, nSize, byteData);

                if ((chkConnect_Robot.Checked == true) || (chkConnect_Action.Checked == true) || (chkConnect_Test.Checked == true) || (chkConnect_Vision.Checked == true))
                {
                    Ojw.CTimer.Wait(100);
                    //Ojw.CTimer.Set(0);
                    //while ((Ojw.CTimer.Get(0) < 3000) && (nUpdate >= (m_nUpdate - nUpdateCnt))) Application.DoEvents();
                    //if (nUpdate >= (m_nUpdate - nUpdateCnt)) return false;
                }
                ///////////
                if (chkConnect_Action.Checked == true)
                {
                    //int nCmdData = 0;
                    //for (i = 0; i < 6; i++)
                    //{
                    //    nUpdate = m_nUpdate;
                    //    if (i == 5) nCmdData = i + 1;
                    //    else nCmdData = i;
                    //    SendOneData(_MOTION, 0xD9, (byte)nCmdData);
                    //    Ojw.CTimer.Set(0);
                    //    while ((Ojw.CTimer.Get(0) < 3000) && (nUpdate == m_nUpdate)) Application.DoEvents();
                    //    if (nUpdate == m_nUpdate) return false;
                    //}
                    /////////////

                    ////SendCommand(_MOTION, 0x3B);
                    //SendCmd_Etc(2); // Get Qwm3-Param

                    //Ojw.CTimer.Set(0);
                    //while ((Ojw.CTimer.Get(0) < 3000) && (nUpdate == m_nUpdate)) Application.DoEvents();
                    //if (nUpdate == m_nUpdate) return false;

                    ////rbCliff_Disable.Checked = true;
                    //DisplayCliffEn(false);
                    SendTwoData(_MOTION, 0x40 + 44, 0, 0);  // 절벽감지와 장애물를 Disable
                    //Ojw.CTimer.Wait(10);

                    //// Calibration File Reload
                    ////SendOneData(_MOTION, 0x40 + 36, 1);
                }

                //nUpdate = m_nUpdate;
                //SendData(_MOTION, 0x40 + 47, nSize, byteData);
                //Ojw.CTimer.Set(0);
                //while ((Ojw.CTimer.Get(0) < 3000) && (nUpdate == m_nUpdate)) Application.DoEvents();
                //if (nUpdate == m_nUpdate) return false;

                // 파일 데이터 저장
                //TextConfigFileSave(m_strOrgDirectory + "\\ip_qwm.ini");
            }
            else
            {
                DisConnect();
                return false;
            };
            return bOk;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (OjwConnect() == false)
            {
                DisConnect();
                //BtnEn(true);
                //BtnQwmEn(false);
            }
            else
            {
                if (chkConnect_Action.Checked == true) { Ojw.CTimer.Wait(1000); ActionPlay("8"); }
                //OjwChoose.Init(this);
            }
        }
        public bool ActionPlay(String strFileName)
        {
            return ActionPlay(true, strFileName, true, true, 100);
        }

        private int C_TCP_FILENAME_SIZE = 16;
        public bool ActionPlay(bool bMaster, String strFileName, bool bSndEn, bool bEmtEn, int nPercentValue)
        {
            try
            {
                //if (chkMp3Sync.Checked == true) Mp3Play();

                // 문자열 코드의 아스키 변환
                byte[] byteData1 = Encoding.Default.GetBytes(strFileName);// Encoding.ASCII.GetBytes(strFileName);
                int nSize = C_TCP_FILENAME_SIZE + 3;
                int nStrLength = strFileName.Length;
                //if (nStrLength >= C_TCP_FILENAME_SIZE) byteData1[15] = 0;

                int nNum = 0;
                byte[] byteData = new byte[nSize];
                for (int i = 0; i < C_TCP_FILENAME_SIZE - 1; i++)
                {
                    if (i < nStrLength) byteData[nNum++] = byteData1[i];
                    else byteData[nNum++] = 0;
                }
                // 널 종료문자
                byteData[nNum++] = 0;

                // Sound Enable
                byteData[nNum++] = (byte)((bSndEn == true) ? 1 : 0);
                // Emoticon Enable
                byteData[nNum++] = (byte)((bEmtEn == true) ? 1 : 0);
                // Speed Percent
                byteData[nNum++] = (byte)(nPercentValue & 0xff);

                int nCmd = 0x34;
                if (bMaster) nCmd = 0x33;
                SendData(_MOTION, nCmd, nSize, byteData);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private Thread[] Reader = new Thread[10];             // 읽기 쓰레드
        public bool Connect()
        {
            bool bOk = true;
            bool bConnect = false;

            bConnect = OjwSock[_MOTION].m_bConnect;
            if (!bConnect)
            {
                if (chkConnect_Action.Checked == true)
                {
                    OjwSock[_MOTION].Connect(txtIP.Text, 6100 + _MOTION);
                    Reader[_MOTION] = new Thread(new ThreadStart(Receive_Motion));
                    Reader[_MOTION].Start();
                }

                if (chkConnect_Test.Checked == true)
                {
                    OjwSock[_TEST].Connect(txtIP.Text, 6100 + _TEST);
                    Reader[_TEST] = new Thread(new ThreadStart(Receive_Test));
                    Reader[_TEST].Start();
                }


                if (chkConnect_Robot.Checked == true)
                {
                    OjwSock[_ROBOT].Connect(txtIP.Text, 6100 + _ROBOT);
                    Reader[_ROBOT] = new Thread(new ThreadStart(Receive_Robot));
                    Reader[_ROBOT].Start();
                }
                if (chkConnect_Vision.Checked == true)
                {
                    OjwSock[_VISION].Connect(txtIP.Text, 6100 + _VISION);
                    Reader[_VISION] = new Thread(new ThreadStart(Receive_Vision));
                    Reader[_VISION].Start();
                }
            }
            bool bOk_Action = true;
            if (chkConnect_Action.Checked == true)
            {
                if (OjwSock[_MOTION].m_bConnect == true)
                    Ojw.CMessage.Write("Connected Action_Task");
                else
                {
                    Ojw.CMessage.Write("Can't Connect Action_Task");
                    OjwSock[_MOTION].DisConnect();
                    Reader[_MOTION].Abort();
                    bOk_Action = false;
                }
            }
            bool bOk_Test = true;
            if (chkConnect_Test.Checked == true)
            {
                if (OjwSock[_TEST].m_bConnect == true)
                    Ojw.CMessage.Write("Connected Test_Task");
                else
                {
                    Ojw.CMessage.Write("Can't Connect Test_Task");
                    OjwSock[_TEST].DisConnect();
                    Reader[_TEST].Abort();
                    bOk_Test = false;
                }
            }

            bOk = bOk_Action & bOk_Test;
            if (bOk == false)
            {
                Ojw.CMessage.Write_Error("서버와 연결 실패");
                return false;
            }

            if (bOk == true)
            {
                btnConnect.Text = "DisConnect";

                bConnect = OjwSock[_MOTION].m_bConnect;
                bConnect &= OjwSock[_TEST].m_bConnect;
                if (bConnect)
                {
                    Ojw.CMessage.Write("Action Task Connected");
                }
                //chkEnBox[_MOTION].Enabled = false;
                tmrHeartBeat.Enabled = true;

                m_nUpdate = 0;
                //BtnEn(false);
                //BtnQwmEn(true);
            }
            else
            {
                bConnect = OjwSock[_MOTION].m_bConnect;
                bConnect = OjwSock[_TEST].m_bConnect;
                if (bConnect)
                {
                    OjwSock[_MOTION].DisConnect();
                    Reader[_MOTION].Abort();         // 쓰레드 종료
                    OjwSock[_TEST].DisConnect();
                    Reader[_TEST].Abort();         // 쓰레드 종료
                }
                //chkEnBox[i].Enabled = true;

                Ojw.CMessage.Write_Error("서버와 연결 실패");
            }
            return bOk;
        }

        public void DisConnect()
        {
            if (OjwSock[_MOTION].m_bConnect == true)
            {
                OjwSock[_MOTION].DisConnect();
                //Reader[_MOTION].Abort();
            }
            if (OjwSock[_TEST].m_bConnect == true)
            {
                OjwSock[_TEST].DisConnect();
                //Reader[_TEST].Abort();
            }
            if (OjwSock[_ROBOT].m_bConnect == true)
            {
                OjwSock[_ROBOT].DisConnect();
                //Reader[_ROBOT].Abort();
            }
            if (OjwSock[_VISION].m_bConnect == true)
            {
                OjwSock[_VISION].DisConnect();
                //Reader[_VISION].Abort();
            }

            //chkEnBox[_MOTION].Enabled = true;
            btnConnect.Text = "Connect";
            //if (m_bClosed == false) btnConnect.Text = "Connect";
            //BtnEn(true);
            //BtnQwmEn(false);
        }

        public void Receive_Robot()
        {
            int nType = _ROBOT;

            string strName = "[ROBOT]";
            try
            {
                int i;
                int nCmd;
                int nID;
                int nLength = 0;
                byte byteData;
                byte byteCheckSum = 0;
                string strMessage1;
                String strTmp;
                String[] pstrData;
                while (OjwSock[nType].m_bConnect)
                {
                    byteData = (Byte)OjwSock[nType].GetByte();
                    if (!OjwSock[nType].m_bConnect) return;
                    strTmp = Ojw.CConvert.IntToHex(byteData);

                    // Header 검색
                    if (byteData == 0xff)
                    {
                        // ID
                        nID = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Command
                        nCmd = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Data Length
                        nLength = OjwSock[nType].GetInt32(); if (!OjwSock[nType].m_bConnect) return;
                        // 실제 데이타 Get
                        byte[] byteArrayData = OjwSock[nType].GetBytes(nLength); if (!OjwSock[nType].m_bConnect) return;
                        // CheckSum Data Get
                        byteCheckSum = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;

                        string strData = System.Text.Encoding.Default.GetString(byteArrayData);

                        if (nCmd == 0xf0)
                        {
                            if (byteArrayData.Rank >= 1)
                            {
                                if ((byte)(byteArrayData[1]) == 0) strTmp = "[Receive OK]";
                                else if ((byte)(byteArrayData[1]) == 1)
                                {
                                    //m_bStart = false;
                                    strTmp = "[Process End]";
                                }
                                else if ((byte)(byteArrayData[1]) == 2) strTmp = "[Process Fail]";
                                else if ((byte)(byteArrayData[1]) == 3) strTmp = "[Check Sum Error]";
                                else if ((byte)(byteArrayData[1]) == 4) strTmp = "[Time Out Error]";
                            }
                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]" + strTmp + "size=" + Ojw.CConvert.IntToHex(nLength) + "\r\n";
                            Ojw.CMessage.Write(strMessage1);
                        }
                        else if (nCmd == 0xf1) // HeartBeat
                        {
                            //if (chkDispHearBeat.Checked)
                            //{
                            //    strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "][HeartBeat]size=" + Ojw.CConvert.IntToHex(nLength) + "\r\n";
                            //    Ojw.CMessage.Write(strMessage1);
                            //}
                            //else continue;
                        }
                        else
                        {
                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";

                            switch (nCmd)
                            {
                                case 0x71:
                                    {
                                        strMessage1 += "[인증]\r\n";
                                        if (byteArrayData[0] == 0)
                                        {
                                            strMessage1 += "=>False";
                                            DisConnect();
                                        }
                                        else
                                        {
                                            strMessage1 += "=>OK";
                                            //RobotUpdate();
                                        }
                                    }
                                    break;
                                default:
                                    strMessage1 += "테스트 명령[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";
                                    pstrData = strData.Split('\0');
                                    i = 0;
                                    foreach (string strItem in pstrData)
                                    {
                                        if ((strItem != "") && (strItem.Length >= 2))
                                        {
                                            i++;
                                            strMessage1 += strItem + "\r\n";
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        strMessage1 += "[Length=" + Convert.ToString(strData.Length) + "]\r\n";
                                    }

                                    break;

                            }
                            Ojw.CMessage.Write(strMessage1);

                        }
                    }
                    Thread.Sleep(10);
                }
            }
            catch
            {
                Ojw.CMessage.Write_Error(strName + "데이터를 읽는 과정에서 오류 발생");
                DisConnect();
            }
        }

        public void Receive_Motion()
        {
            int nType = _MOTION;

            string strName = "[MOTION]";
            try
            {
                int i;
                int nCmd;
                int nID;
                int nLength = 0;
                byte byteData;
                byte byteCheckSum = 0;
                string strMessage1;
                String strTmp;
                String[] pstrData;
                while (OjwSock[nType].m_bConnect)
                {
                    byteData = (Byte)OjwSock[nType].GetByte();
                    if (!OjwSock[nType].m_bConnect) return;
                    strTmp = Ojw.CConvert.IntToHex(byteData);

                    // Header 검색
                    if (byteData == 0xff)
                    {
                        // ID
                        nID = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Command
                        nCmd = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Data Length
                        nLength = OjwSock[nType].GetInt32(); if (!OjwSock[nType].m_bConnect) return;
                        // 실제 데이타 Get
                        byte[] byteArrayData = OjwSock[nType].GetBytes(nLength); if (!OjwSock[nType].m_bConnect) return;
                        // CheckSum Data Get
                        byteCheckSum = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;

                        string strData = System.Text.Encoding.Default.GetString(byteArrayData);

                        if (nCmd == 0xf0)
                        {
                            if (byteArrayData.Rank >= 1)
                            {
                                if ((byte)(byteArrayData[1]) == 0) strTmp = "[Receive OK]";
                                else if ((byte)(byteArrayData[1]) == 1)
                                {
                                    //m_bStart = false;
                                    strTmp = "[Process End]";
                                }
                                else if ((byte)(byteArrayData[1]) == 2) strTmp = "[Process Fail]";
                                else if ((byte)(byteArrayData[1]) == 3) strTmp = "[Check Sum Error]";
                                else if ((byte)(byteArrayData[1]) == 4) strTmp = "[Time Out Error]";
                            }
                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]" + strTmp + "size=" + Ojw.CConvert.IntToHex(nLength) + "\r\n";
                            Ojw.CMessage.Write(strMessage1);
                        }
                        else if (nCmd == 0xf1) // HeartBeat
                        {
                            //if (chkDispHearBeat.Checked)
                            //{
                            //    strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "][HeartBeat]size=" + Ojw.CConvert.IntToHex(nLength) + "\r\n";
                            //    Ojw.CMessage.Write(strMessage1);
                            //}
                            //else continue;
                        }
                        else
                        {
                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";

                            switch (nCmd)
                            {
                                case 0x3B:
                                    {
                                        //int nPos = 0;
                                        //float[] fValue = new float[5];
                                        //for (i = 0; i < 5; i++)
                                        //{
                                        //    m_afQwm_Weight[i] = BitConverter.ToSingle(byteArrayData, nPos); nPos += sizeof(float);
                                        //}
                                        //DispQwm3Data_Only_Weight();

                                        //RobotUpdate();
                                    }
                                    break;
                                case (0x40 + 20):
                                    {
                                        //switch (byteArrayData[0])
                                        //{
                                        //    case 2:
                                        //        {
                                        //            Ojw.CMessage.Write("ACT_CMD_GET_PARAM_QWM3");
                                        //            int nPos = 1;
                                        //            for (int j = 0; j < 2; j++)
                                        //            {
                                        //                for (i = 0; i < 73; i++)
                                        //                {
                                        //                    m_afQwm3[j, i] = BitConverter.ToSingle(byteArrayData, nPos);
                                        //                    nPos += sizeof(float);
                                        //                }
                                        //            }
                                        //            //i = 41;
                                        //            //int nValue = (int)Math.Round(m_afQwm3[i - 1] * 10.0f, 0);
                                        //            //nValue = (m_nQwm3_LeftValue + (m_nQwm3_LeftValue - nValue));
                                        //            //tbLeft.Value = ((nValue > 300) ? 300 : ((nValue < 0) ? 0 : (nValue)));
                                        //            //lbLeftTurn.Text = Ojw.CConvert.FloatToStr(m_afQwm3[i - 1]);

                                        //            //i = 42;
                                        //            //nValue = (int)Math.Round(m_afQwm3[i - 1] * 10.0f, 0);
                                        //            //tbRight.Value = ((nValue > 300) ? 300 : ((nValue < 0) ? 0 : (nValue)));
                                        //            //lbRightTurn.Text = Ojw.CConvert.FloatToStr(m_afQwm3[i - 1]);

                                        //            //i = 33;
                                        //            //nValue = -(int)Math.Round(m_afQwm3[i - 1] * 10.0f, 0);
                                        //            //tbLf.Value = ((nValue > 100) ? 100 : ((nValue < -100) ? -100 : (nValue)));
                                        //            //lbLf.Text = Ojw.CConvert.FloatToStr(-m_afQwm3[i - 1]);

                                        //            //i = 35;
                                        //            //nValue = -(int)Math.Round(m_afQwm3[i - 1] * 10.0f, 0);
                                        //            //tbRf.Value = ((nValue > 100) ? 100 : ((nValue < -100) ? -100 : (nValue)));
                                        //            //lbRf.Text = Ojw.CConvert.FloatToStr(-m_afQwm3[i - 1]);

                                        //            //i = 37;
                                        //            //nValue = -(int)Math.Round(m_afQwm3[i - 1] * 10.0f, 0);
                                        //            //tbLr.Value = ((nValue > 100) ? 100 : ((nValue < -100) ? -100 : (nValue)));
                                        //            //lbLr.Text = Ojw.CConvert.FloatToStr(-m_afQwm3[i - 1]);

                                        //            //i = 39;
                                        //            //nValue = -(int)Math.Round(m_afQwm3[i - 1] * 10.0f, 0);
                                        //            //tbRr.Value = ((nValue > 100) ? 100 : ((nValue < -100) ? -100 : (nValue)));
                                        //            //lbRr.Text = Ojw.CConvert.FloatToStr(-m_afQwm3[i - 1]);
                                        //            DispQwm3Data();

                                        //            RobotUpdate();
                                        //            lbDisplayCurr.Text = "현재의 데이타 => Robot";

                                        //            SendCommand(_MOTION, 0x3B);// 일반 가중치도 가져온다.
                                        //        }
                                        //        break;
                                        //    default:
                                        //        Ojw.CMessage.Write("(ETC)알수 없는 명령");
                                        //        break;
                                        //}
                                    }
                                    break;
                                case 0x71:
                                    {
                                        strMessage1 += "[인증]\r\n";
                                        if (byteArrayData[0] == 0)
                                        {
                                            strMessage1 += "=>False";
                                            DisConnect();
                                        }
                                        else
                                        {
                                            strMessage1 += "=>OK";
                                            //RobotUpdate();
                                        }
                                    }
                                    break;
                                case 0xD9:
                                    {
                                        //strMessage1 += "[Version Get]\r\n";
                                        //int nVersionType = (int)(byteArrayData[0]);
                                        //strTmp = System.Text.Encoding.Default.GetString(byteArrayData, 1, 9);
                                        //if (nVersionType == 0) // task
                                        //    lbVersion_Motion.Text = strTmp;
                                        //else if (nVersionType == 1)
                                        //    lbVersion_0.Text = strTmp;
                                        //else if (nVersionType == 2)
                                        //    lbVersion_1.Text = strTmp;
                                        //else if (nVersionType == 3)
                                        //    lbVersion_2.Text = strTmp;
                                        //else if (nVersionType == 4)
                                        //    lbVersion_3.Text = strTmp;
                                        //else if (nVersionType == 6)
                                        //    lbVersion_4.Text = strTmp;
                                        //if ((nVersionType >= 0) && (nVersionType <= 6) && (nVersionType != 5)) RobotUpdate();
                                    }
                                    break;
                                case (0x40 + 47):
                                    {
                                    //    //int nPos = 0;
                                    //    //bool bCliff = (byteArrayData[nPos] == 0)?false:true; nPos++;
                                    //    //bool bObstacle = (byteArrayData[nPos] == 0) ? false : true; nPos++;
                                    //    //i = 0;
                                    //    //m_anCliffValue[i++] = (int)byteArrayData[nPos]; nPos++;
                                    //    //m_anCliffValue[i++] = (int)byteArrayData[nPos]; nPos++;
                                    //    //m_anCliffValue[i++] = (int)byteArrayData[nPos]; nPos++;
                                    //    //rbQwmCliff_Dispaly(false, m_nCliffDir_Manual);
                                    //    //rbQwmCliff_Dispaly(true, m_nCliffDir_Auto);  
                                    //    //byteArrayData[0];
                                    //    DisplayCliffEn(((byteArrayData[0] == 0) ? false : true));
                                    //    int j;
                                    //    int nCnt = 3;
                                    //    for (i = 0; i < 2; i++)
                                    //        for (j = 0; j < nCnt; j++)
                                    //        {
                                    //            m_anCliff[i, j] = byteArrayData[2 + i * nCnt + j];
                                    //        }
                                    //    //txtCliff.Text = Ojw.CConvert.IntToStr((int)byteArrayData[2]);
                                    //    //txtCliff_Right.Text = Ojw.CConvert.IntToStr((int)byteArrayData[3]);
                                    //    //txtCliff_Left.Text = Ojw.CConvert.IntToStr((int)byteArrayData[4]);
                                    //    DisplayCliff();
                                    //    RobotUpdate();
                                    }
                                    break;
                                default:
                                    strMessage1 += "테스트 명령[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";
                                    pstrData = strData.Split('\0');
                                    i = 0;
                                    foreach (string strItem in pstrData)
                                    {
                                        if ((strItem != "") && (strItem.Length >= 2))
                                        {
                                            i++;
                                            strMessage1 += strItem + "\r\n";
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        strMessage1 += "[Length=" + Convert.ToString(strData.Length) + "]\r\n";
                                    }

                                    break;

                            }
                            Ojw.CMessage.Write(strMessage1);

                        }
                    }
                    Thread.Sleep(10);
                }
            }
            catch
            {
                Ojw.CMessage.Write_Error(strName + "데이터를 읽는 과정에서 오류 발생");
                DisConnect();
            }
        }
        public void Receive_Vision()
        {
            int nType = _VISION;
            string strName = "[VISION]";
            try
            {
                int nCmd;
                int nID;
                int nLength = 0;
                byte byteData;
                byte byteCheckSum;
                //string strMessage0;
                string strMessage1;
                String strTmp;
                while (OjwSock[nType].m_bConnect)
                {
                    byteData = (Byte)OjwSock[nType].GetByte();
                    if (!OjwSock[nType].m_bConnect) return;
                    strTmp = Ojw.CConvert.IntToHex(byteData);

                    // Header 검색
                    if (byteData == 0xff)
                    {
                        //strMessage0 = "-------------------------\r\n<=" + m_strType[nType];
                        // ID
                        nID = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Command
                        nCmd = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Data Length
                        nLength = OjwSock[nType].GetInt32(); if (!OjwSock[nType].m_bConnect) return;
                        // 실제 데이타 Get
                        byte[] byteArrayData = OjwSock[nType].GetBytes(nLength); if (!OjwSock[nType].m_bConnect) return;
                        // CheckSum Data Get
                        byteCheckSum = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;

                        //string strData = System.Text.Encoding.Default.GetString(byteArrayData);

                        //strMessage0 += "(0x" + Ojw.CConvert.IntToHex(byteData) + ")";
                        //strMessage0 += "(0x" + Ojw.CConvert.IntToHex(nCmd) + ")";
                        //strMessage0 += "(0x" + Ojw.CConvert.IntToHex((nLength >> 24) & 0xff) + ")";
                        //strMessage0 += "(0x" + Ojw.CConvert.IntToHex((nLength >> 16) & 0xff) + ")";
                        //strMessage0 += "(0x" + Ojw.CConvert.IntToHex((nLength >> 8) & 0xff) + ")";
                        //strMessage0 += "(0x" + Ojw.CConvert.IntToHex(nLength & 0xff) + ")";

                        int i;
                        string[] pstrData;

                        //strTmp = "";
                        //for (i = 0; i < nLength; i++)
                        //    strTmp += "(0x" + Ojw.CConvert.IntToHex(byteArrayData[i]) + ")";

                        //strMessage0 += strTmp + "\r\n";
                        if (nCmd == 0xf0)
                        {
                            if (byteArrayData.Rank >= 1)
                            {
                                if ((byte)(byteArrayData[1]) == 0) strTmp = "[Receive OK]";
                                else if ((byte)(byteArrayData[1]) == 1) strTmp = "[Process End]";
                                else if ((byte)(byteArrayData[1]) == 2) strTmp = "[Process OK]";
                                else if ((byte)(byteArrayData[1]) == 3) strTmp = "[Check Sum Error]";
                                else if ((byte)(byteArrayData[1]) == 4) strTmp = "[Time Out Error]";
                            }
                            //strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]" + strTmp + "\r\n";
                            //Ojw.CMessage.Write(strMessage1);
                        }
                        else if (nCmd == 0xf1) // HeartBeat
                        {
                            //if (chkDispHearBeat.Checked)
                            //{
                            //    strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "][HeartBeat]\r\n";
                            //    Ojw.CMessage.Write(strMessage1);
                            //}
                            //else continue;
                        }
                        else if ((nCmd == 0x04) || (nCmd == 0x06)) // GrabConti
                        {
                            //Ojw.CMessage.Write("0x04, 0x06");
                            //strMessage1 += "[연속 영상 확인]\r\n";

                            MemoryStream streamData = new MemoryStream(byteArrayData);
                            streamData.Read(byteArrayData, 0, nLength);

                            //Image image;
                            Graphics gr = picImage.CreateGraphics(); //CreateGraphics();
                            Image image = Image.FromStream(streamData);
                            gr.DrawImage(image, 1, 1, image.Width*4, image.Height*4);

                            gr.Dispose();

                        }
                        else if ((nCmd == 0x14) || (nCmd == 0x16)) // GrabConti
                        {
                            //Ojw.CMessage.Write("0x14, 0x16");
                            //strMessage1 += "[연속 영상 확인]\r\n";

                            //MemoryStream streamData = new MemoryStream(byteArrayData);
                            //streamData.Read(byteArrayData, 0, nLength);

                            //Image image;
                            //Graphics gr = CreateGraphics();

                            Color cData;
                            Bitmap bmpData = new Bitmap(320, 240);
                            for (int y = 0; y < 240; y++)
                                for (int x = 0; x < 320; x++)
                                {
                                    cData = Color.FromArgb(byteArrayData[x + 320 * y], byteArrayData[x + 320 * y], byteArrayData[x + 320 * y]);
                                    bmpData.SetPixel(x, y, cData);
                                }
                            //m_image = Image.FromStream(streamData);
                            //m_gr.DrawImage(bmpData, 1, 1, bmpData.Width, bmpData.Height);

                            Graphics gr = picImage.CreateGraphics(); //CreateGraphics();
                            gr.DrawImage(bmpData, 1, 1, bmpData.Width, bmpData.Height);

                            gr.Dispose();
                            //gr.Dispose();

                        }
                        else
                        {
                            string strData = System.Text.Encoding.Default.GetString(byteArrayData);

                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";

                            //strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";
                            switch (nCmd)
                            {
                                //case 0x01:
                                //    strMessage1 += "[모션재생]\r\n";
                                //    break;

                                case 0x71:
                                    {
                                        strMessage1 += "[인증]\r\n";
                                        if (byteArrayData[0] == 0)
                                        {
                                            strMessage1 += "=>False";
                                            DisConnect();
                                        }
                                        else
                                        {
                                            strMessage1 += "=>OK";
                                            //RobotUpdate();
                                        }
                                    }
                                    break;
                                case 0xD9:
                                    {
                                        //strMessage1 += "[Version Get]\r\n";

                                        //strTmp = "[ID=" + Ojw.CConvert.IntToHex(byteArrayData[0]) + "]" + System.Text.Encoding.Default.GetString(byteArrayData, 1, 9);
                                        //lbVersion_Vision.Text = strTmp;
                                    }
                                    break;
                                default:
                                    strMessage1 += "테스트 명령[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";
                                    pstrData = strData.Split('\0');
                                    i = 0;
                                    foreach (string strItem in pstrData)
                                    {
                                        if ((strItem != "") && (strItem.Length >= 2))
                                        {
                                            i++;
                                            strMessage1 += strItem + "\r\n";
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        strMessage1 += "[Length=" + Convert.ToString(strData.Length) + "]\r\n";
                                    }

                                    break;

                            }
                            //Ojw.CMessage.Write(strMessage1);
                        }
                        //Ojw.CMessage.Write(strMessage0);
                    }
                    Thread.Sleep(10);
                }
            }
            catch
            {
                Ojw.CMessage.Write_Error(strName + "데이터를 읽는 과정에서 오류 발생");
                DisConnect();
            }
        }

        public void Receive_Test()
        {
            int nType = _TEST;

            string strName = "[TEST]";
            try
            {
                int i;
                int nCmd;
                int nID;
                int nLength = 0;
                byte byteData;
                byte byteCheckSum = 0;
                string strMessage1;
                String strTmp;
                String[] pstrData;
                while (OjwSock[nType].m_bConnect)
                {
                    byteData = (Byte)OjwSock[nType].GetByte();
                    if (!OjwSock[nType].m_bConnect) return;
                    strTmp = Ojw.CConvert.IntToHex(byteData);

                    // Header 검색
                    if (byteData == 0xff)
                    {
                        // ID
                        nID = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Command
                        nCmd = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;
                        // Data Length
                        nLength = OjwSock[nType].GetInt32(); if (!OjwSock[nType].m_bConnect) return;
                        // 실제 데이타 Get
                        byte[] byteArrayData = OjwSock[nType].GetBytes(nLength); if (!OjwSock[nType].m_bConnect) return;
                        // CheckSum Data Get
                        byteCheckSum = OjwSock[nType].GetByte(); if (!OjwSock[nType].m_bConnect) return;

                        string strData = System.Text.Encoding.Default.GetString(byteArrayData);

                        if (nCmd == 0xf0)
                        {
                            if (byteArrayData.Rank >= 1)
                            {
                                if ((byte)(byteArrayData[1]) == 0) strTmp = "[Receive OK]";
                                else if ((byte)(byteArrayData[1]) == 1)
                                    strTmp = "[Process End]";
                                else if ((byte)(byteArrayData[1]) == 2) strTmp = "[Process Fail]";
                                else if ((byte)(byteArrayData[1]) == 3) strTmp = "[Check Sum Error]";
                                else if ((byte)(byteArrayData[1]) == 4) strTmp = "[Time Out Error]";
                                //m_nTestCmd++;
                            }
                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]" + strTmp + "size=" + Ojw.CConvert.IntToHex(nLength) + "\r\n";
                            //Ojw.CMessage.Write(strMessage1);
                        }
                        else if (nCmd == 0xf1) // HeartBeat
                        {
                            //if (chkDispHearBeat.Checked)
                            //{
                            //    strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "][HeartBeat]size=" + Ojw.CConvert.IntToHex(nLength) + "\r\n";
                            //    Ojw.CMessage.Write(strMessage1);
                            //}
                            //else continue;
                        }
                        else
                        {
                            strMessage1 = "<=[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";

                            switch (nCmd)
                            {
                                case 0x71:
                                    {
                                        strMessage1 += "[인증]\r\n";
                                        if (byteArrayData[0] == 0)
                                        {
                                            strMessage1 += "=>False";
                                            DisConnect();
                                        }
                                        else
                                        {
                                            strMessage1 += "=>OK";
                                            //RobotUpdate();
                                        }
                                    }
                                    break;
                                default:
                                    strMessage1 += "테스트 명령[Cmd=" + Ojw.CConvert.IntToHex(nCmd) + "][ID=" + Ojw.CConvert.IntToHex(nID) + "]";
                                    pstrData = strData.Split('\0');
                                    i = 0;
                                    foreach (string strItem in pstrData)
                                    {
                                        if ((strItem != "") && (strItem.Length >= 2))
                                        {
                                            i++;
                                            strMessage1 += strItem + "\r\n";
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        strMessage1 += "[Length=" + Convert.ToString(strData.Length) + "]\r\n";
                                    }

                                    break;

                            }
                            //Ojw.CMessage.Write(strMessage1);

                        }
                    }
                    Thread.Sleep(10);
                }
            }
            catch
            {
                Ojw.CMessage.Write_Error(strName + "데이터를 읽는 과정에서 오류 발생");
                DisConnect();
            }
        }
        public void SendCmd_Etc(int nCommand)
        {
            int i, nNum;

            // 프레임 수
            int nSize = 1;
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];
            int nType = _MOTION;
            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + nType) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)((0x40 + 20) & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            // Command
            byteData[nNum++] = (byte)(nCommand & 0xff);

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        public void SendDataEtc(int nCommand, int nSize, byte[] byteArrayData)
        {
            int i, nNum;
            int nCommandSize = 1;
            // 프레임 수
            //int nSize = nSize;
            nSize += nCommandSize;
            int nPacketSize = nSize + 8 + 1;
            byte[] byteData = new byte[nPacketSize];
            int nType = _MOTION;
            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + nType) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)((0x40 + 20) & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            //byteArrayData.CopyTo(byteData, nNum);
            //nNum += nSize;
            byteData[nNum++] = (byte)(nCommand & 0xff);
            for (i = 0; i < nSize - nCommandSize; i++)
            {
                byteData[nNum++] = byteArrayData[i];
            }

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }
        public void SendCommand(int nType, int nCommand)
        {
            int i, nNum;

            // 프레임 수
            int nSize = 0;
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];

            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + ((nType == _TEST) ? 8 : nType)) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)(nCommand & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        public void SendOneData(int nType, int nCommand, byte byteOneData)
        {
            int i, nNum;

            // 프레임 수
            int nSize = 1;
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];

            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + ((nType == _TEST) ? 8 : nType)) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)(nCommand & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            // Data
            byteData[nNum++] = (byte)(byteOneData & 0xff);

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        public void SendTwoData(int nType, int nCommand, byte byteData1, byte byteData2)
        {
            int i, nNum;

            // 프레임 수
            int nSize = 2;
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];

            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + ((nType == _TEST) ? 8 : nType)) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)(nCommand & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            // Data
            byteData[nNum++] = (byte)(byteData1 & 0xff);
            byteData[nNum++] = (byte)(byteData2 & 0xff);

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        public void SendThreeData(int nType, int nCommand, byte byteData1, byte byteData2, byte byteData3)
        {
            int i, nNum;

            // 프레임 수
            int nSize = 3;
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];

            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + ((nType == _TEST) ? 8 : nType)) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)(nCommand & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            // Data
            byteData[nNum++] = (byte)(byteData1 & 0xff);
            byteData[nNum++] = (byte)(byteData2 & 0xff);
            byteData[nNum++] = (byte)(byteData3 & 0xff);

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        public void SendFourData(int nType, int nCommand, byte byteData1, byte byteData2, byte byteData3, byte byteData4)
        {
            int i, nNum;

            // 프레임 수
            int nSize = 4;
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];

            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            byteData[nNum++] = (Byte)((0x90 + ((nType == _TEST) ? 8 : nType)) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)(nCommand & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            // Data
            byteData[nNum++] = (byte)(byteData1 & 0xff);
            byteData[nNum++] = (byte)(byteData2 & 0xff);
            byteData[nNum++] = (byte)(byteData3 & 0xff);
            byteData[nNum++] = (byte)(byteData4 & 0xff);

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        public void SendData(int nType, int nCommand, int nSize, byte[] byteArrayData)
        {
            int i, nNum;

            // 프레임 수
            int nPacketSize = nSize + 8;
            byte[] byteData = new byte[nPacketSize];

            nNum = 0;
            byteData[nNum++] = 0xff;
            // ID
            //if (nType == _TEST) byteData[nNum++] = (Byte)(0x98);
            //else 
            byteData[nNum++] = (Byte)((0x90 + ((nType == _TEST) ? 8 : nType)) & 0xff);
            // Cmd
            byteData[nNum++] = (Byte)(nCommand & 0xff);

            // Data Size
            byteData[nNum++] = (byte)((nSize >> 24) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 16) & 0xff);
            byteData[nNum++] = (byte)((nSize >> 8) & 0xff);
            byteData[nNum++] = (byte)(nSize & 0xff);

            for (i = 0; i < nSize; i++)
            {
                byteData[nNum++] = byteArrayData[i];
            }

            // CheckSum
            byte byteCheckSum = byteData[1];
            for (i = 2; i < nPacketSize - 1; i++)
            {
                byteCheckSum ^= byteData[i];
            }
            byteData[nNum++] = (byte)(byteCheckSum & 0x7f);

            OjwSock[nType].Send(byteData);
        }

        private void tmrHeartBeat_Tick(object sender, EventArgs e)
        {
            if (OjwSock[_ROBOT].m_bConnect) SendCommand(_ROBOT, 0xf1);
            if (OjwSock[_MOTION].m_bConnect) SendCommand(_MOTION, 0xf1);
            if (OjwSock[_VISION].m_bConnect) SendCommand(_VISION, 0xf1);
            if (OjwSock[_TEST].m_bConnect) SendCommand(_TEST, 0xf1);
        }

        private void btnPos8_Click(object sender, EventArgs e)
        {
            ActionPlay("8");
        }

        private void btnQwm3_Forward_Click(object sender, EventArgs e)
        {
            QWalk(_CNT_WALK, 0, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
        }

        private void btnTurnLeft_Click(object sender, EventArgs e)
        {
            ActionPlay("8828");
        }

        private void btnTurnRight_Click(object sender, EventArgs e)
        {
            ActionPlay("8829");
        }
        private const int _CNT_WALK = 10;
        private void btnQwm3_Left_Click(object sender, EventArgs e)
        {
            QWalk(_CNT_WALK, 2, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
        }

        private void btnQwm3_Right_Click(object sender, EventArgs e)
        {
            QWalk(_CNT_WALK, 1, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
        }

        private void btnQwm3_Stop_Click(object sender, EventArgs e)
        {
            QWalk_Stop(0);
        }

        private bool m_bCamera = false;
        private void Camera(bool bOn)
        {
            if (bOn == true)
            {
                Ojw.CMessage.Write("Camera On");
                // 연속영상 전송 시작
                SendCommand(_VISION, 0x04);
                m_bCamera = true;
            }
            else
            {
                Ojw.CMessage.Write("Camera Off");
                // 연속영상 전송 정지
                SendCommand(_VISION, 0x05);
                m_bCamera = true;
            }
        }
        private void btnGrapConti_Click(object sender, EventArgs e)
        {
            Camera(true);
        }

        private void btnGrapStop_Click(object sender, EventArgs e)
        {
            Camera(false);
        }
        public void QWalk(int nWalkCnt, int nDir, int nMode)
        {
            int nSize = sizeof(int) * 3, nNum = 0, i;
            byte[] byteData = new byte[nSize];

            byte[] byteTmpData = BitConverter.GetBytes(nWalkCnt);
            for (i = 0; i < byteTmpData.Length; i++) byteData[nNum++] = byteTmpData[i];

            byteTmpData = BitConverter.GetBytes(nDir);
            for (i = 0; i < byteTmpData.Length; i++) byteData[nNum++] = byteTmpData[i];

            byteTmpData = BitConverter.GetBytes(nMode);
            for (i = 0; i < byteTmpData.Length; i++) byteData[nNum++] = byteTmpData[i];
            //if (OjwSock[_MOTION].m_bConnect == true) m_bStart = true;
            SendData(_MOTION, 0x40 + 40, nSize, byteData);
        }
        public void QWalk_Stop(int nMode)
        {
            SendOneData(_MOTION, 0x40 + 41, (byte)(nMode & 0xff));
        }

        private void btnPos7_Click(object sender, EventArgs e)
        {
            ActionPlay("7");
        }
        #endregion Genibo

        private void btnTest_Click(object sender, EventArgs e)
        {
            Camera(true);
        }
    }
}
