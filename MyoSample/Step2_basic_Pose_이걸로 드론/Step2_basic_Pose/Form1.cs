#define _ENABLE_DRONE
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
        private Ojw.CTimer m_CTId1 = new Ojw.CTimer();
        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            m_CTId0.Set();
            m_CTId1.Set();
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
            if (e.Myo.Arm == Arm.Left)
            {
                m_bLeft = true;


                const float PI = (float)System.Math.PI;

                int nDev = 1; //10;
                // convert the values to a 0-9 scale (for easier digestion/understanding)
                float fRoll = (float)((e.Roll + PI) / (PI * 2.0f) * nDev);
                float fPitch = (float)((e.Pitch + PI) / (PI * 2.0f) * nDev);
                float fYaw = (float)((e.Yaw + PI) / (PI * 2.0f) * nDev);
                                
                if (m_CTId0.Get() >= 1000)
                {
                    m_CTId0.Set();
                    
#if false
                    Ojw.CMessage.Write("Pitch={0}", fPitch);
                    if (m_ER_Pose == Pose.FingersSpread)
                    {
                        if ((fPitch < 0.6f) && (fPitch >= 0.4f))
                        {
                            // 전진
                            Ojw.CMessage.Write("Forward");
                            m_nCommand = 1;
                            MoveForward();
                            //QWalk(_CNT_WALK, 0, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
                        }
                        else if (fPitch >= 0.6f)
                        {
                            // 후진
                            Ojw.CMessage.Write("Backward");
                            m_nCommand = 2;
                            MoveBackward();
                            //QWalk(_CNT_WALK, 3, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
                        }
                    }
                    else if (m_ER_Pose == Pose.Fist)
                    {
                        if (fPitch >= 0.6f)
                        {
                            //if (m_nCommand != 3)
                            {
                                Ojw.CMessage.Write("Stand up");
                                m_nCommand = 3;
                                //Ojw.CTimer.Wait(1000);
                                //ActionPlay("80");
                                //Stop();
                                MoveTurnLeft();
                            }
                        }
                        else if (fPitch < 0.4f)
                        {
                            if (m_nCommand != 4)
                            {
                                Ojw.CMessage.Write("have a seat");
                                m_nCommand = 4;
                                //Ojw.CTimer.Wait(1000);
                                //ActionPlay("40");
                                MoveTurnRight();// Stop();
                            }
                        }
                        else Stop();// QWalk_Stop(0); // Stop
                    }
                    else if (m_ER_Pose == Pose.WaveIn)
                    {
                        if (m_nCommand != 5)
                        {
                            Ojw.CMessage.Write("Right");
                            m_nCommand = 5;
                            MoveRight();
                            //QWalk(_CNT_WALK, 1, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0)); // Right
                        }
                    }
                    else if (m_ER_Pose == Pose.WaveOut)
                    {
                        if (m_nCommand != 6)
                        {
                            Ojw.CMessage.Write("Left");
                            m_nCommand = 6;
                            Move_Up();
                            //QWalk(_CNT_WALK, 2, ((chkQwm_SpeedUp.Checked == true) ? 1 : 0));
                        }
                    }
#endif
                    //else if (m_ER_Pose == Pose.Rest
                }
                
                m_fR_Roll = fRoll;
                m_fR_Pitch = fPitch;
                m_fR_Yaw = fYaw;
            }
            else if (e.Myo.Arm == Arm.Right)
            {
                m_bRight = true;


                const float PI = (float)System.Math.PI;

                int nDev = 10; //10;
                // convert the values to a 0-9 scale (for easier digestion/understanding)
                float fRoll = (float)((e.Roll + PI) / (PI * 2.0f) * nDev);
                float fPitch = (float)((e.Pitch + PI) / (PI * 2.0f) * nDev);
                float fYaw = (float)((e.Yaw + PI) / (PI * 2.0f) * nDev);


                //Ojw.CMessage.Write("Roll[{0}], Pitch[{1}], Yaw[{2}]", fRoll, fPitch, fYaw);

                if (m_CTId1.Get() >= 100)
                {
                    m_CTId1.Set();
                    if (m_nFistCommand == 1)
                    {
                        int nDir0 = 0x00;// 0x20;
                        int nDir1 = 0x80;// 0xa0;
                        int[] anValue = new int[4] { 0x00, 0x00, 0x00, 0x00 };

                        if (fRoll > 0.6f)
                        {
                            int nValue = (int)(fRoll * 10) - 6;
                            anValue[0] = 0x20;// nDir0 + nValue;
                            //anValue[1] = nDir1 - nValue;
                            Move_Left();
                            //Ojw.CMessage.Write("Left");
                        }
                        else if (fRoll < 0.4f)
                        {
                            int nValue = 4 - (int)(fRoll * 10) + nDir1;
                            anValue[0] = 0xa0;// nDir1 + nValue;
                            //anValue[1] = nDir0 - nValue;
                            Move_Right();
                            //Ojw.CMessage.Write("Right");
                        }
                        else
                        {


                            if (fPitch > 0.6f)
                            {
                                anValue[3] = (int)(fPitch * 10) - 6 + nDir0;
                                Move_Up();
                                Ojw.CTimer.Wait(100);
                                Hovering();
                                //Ojw.CMessage.Write("Up");
                            }
                            else if (fPitch < 0.4f)
                            {
                                anValue[3] = 0;// 4 - (int)(fPitch * 10) + nDir1;
                                Hovering();
                                //Ojw.CMessage.Write("Down");
                            }
                            //else Hovering();

                        }
                        
                        //else Hovering();

                        //Send((byte)anValue[0], (byte)anValue[1], (byte)anValue[2], (byte)anValue[3], (byte)0x00);
                    }
                    //else Hovering();
                }

                m_fL_Roll = fRoll;
                m_fL_Pitch = fPitch;
                m_fL_Yaw = fYaw;
            }
        }
        public bool GetData(
                                out bool bRight, out float fR_Pan, out float fR_Tilt, out float fR_Swing, out Pose ER_Pose,
                                out bool bLeft, out float fL_Pan, out float fL_Tilt, out float fL_Swing, out Pose EL_Pose)
        {
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
            if (e.Myo.Arm == Arm.Left)
            {
                m_ER_Pose = e.Myo.Pose;

                if (m_ER_Pose == Pose.DoubleTap)
                {
                    //if (m_bCamera == false) Camera(true);
                    //else Camera(false);
                }
            }
            else if (e.Myo.Arm == Arm.Right)
            {
                m_EL_Pose = e.Myo.Pose;
                if (e.Myo.Pose == Pose.DoubleTap)
                {
                    Ready();
                }
                else
                {
                    if (m_nFistCommand == 0)
                    {
                        if (m_fL_Roll < 3)
                        {
                            if (e.Myo.Pose == Pose.FingersSpread)
                            {
                                Stop();
                            }
                            else if (e.Myo.Pose == Pose.WaveOut)
                            {
                                Move_Up();
                                //Ojw.CTimer.Wait(100);
                                //Hovering();
                            }
                            else if (e.Myo.Pose == Pose.Rest)
                            {
                                Hovering();
                            }
                        }
                    }

                    if (e.Myo.Pose == Pose.Fist)
                    {
                        m_nFistCommand = 1;
                    }
                    else
                    {
                        if (m_nFistCommand == 1)
                        {

                            Hovering();
                        }
                        m_nFistCommand = 0;
                    }

                }
            }
        }
        private int m_nFistCommand = 0;
        #endregion Myo

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMyo();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Step3 - Variable
#if _ENABLE_DRONE
        Ojw.CSerial m_CSerial = new Ojw.CSerial();
        
#else
        private Ojw.CHerculex m_CMotor = new Ojw.CHerculex();
#endif
        #endregion Step3 - Variable

        private void btnConnect_Click(object sender, EventArgs e)
        {
#if _ENABLE_DRONE
            //serialPort1.Open();
            //if (serialPort1.IsOpen == false)
            //{
            //    // Ojw.CConvert.StrToInt() => [ String -> Integer ]

            //    serialPort1.Open();
            //    if (serialPort1.IsOpen == true)
            //    {
            //        btnConnect.Text = "Disconnect";
            //        Ojw.CMessage.Write("Connected");
            //    }
            //    else
            //    {
            //        serialPort1.Close();
            //        btnConnect.Text = "Connect";
            //        Ojw.CMessage.Write_Error("Connect Fail -> Check your COMPORT first");
            //    }
            //}
            //else
            //{
            //    serialPort1.Close();
            //    btnConnect.Text = "Connect";
            //    Ojw.CMessage.Write("Disconnected");
            //}
            if (m_CSerial.IsConnect() == false)
            {
                // Ojw.CConvert.StrToInt() => [ String -> Integer ]
                m_CSerial.Connect(Ojw.CConvert.StrToInt(txtPort.Text), Ojw.CConvert.StrToInt(txtBaud.Text), true);
                if (m_CSerial.IsConnect() == true)
                {
                    btnConnect.Text = "Disconnect";
                    Ojw.CMessage.Write("Connected");
                }
                else
                {
                    m_CSerial.DisConnect();
                    btnConnect.Text = "Connect";
                    Ojw.CMessage.Write_Error("Connect Fail -> Check your COMPORT first");
                }
            }
            else
            {
                m_CSerial.DisConnect();
                btnConnect.Text = "Connect";
                Ojw.CMessage.Write("Disconnected");
            }
#else
            if (m_CMotor.IsConnect() == false)
            {
                // Ojw.CConvert.StrToInt() => [ String -> Integer ]
                m_CMotor.Connect(Ojw.CConvert.StrToInt(txtPort.Text), Ojw.CConvert.StrToInt(txtBaud.Text));
                if (m_CMotor.IsConnect() == true)
                {
                    bool bSpeedType = true;
                    for (int i = 0; i < 4; i++)
                    {                        
                        m_CMotor.SetModel(i, Ojw.CHerculex._DRS_0101, bSpeedType);
                        m_CMotor.SetParam_Dir(i, ((i % 2 == 0) ? true : false));//((cmbDir.SelectedIndex != 0) ? true : false));
                    }
                    m_CMotor.DrvSrv(true, true);

                    btnConnect.Text = "Disconnect";
                    Ojw.CMessage.Write("Connected");
                }
                else
                {
                    m_CMotor.DisConnect();
                    btnConnect.Text = "Connect";
                    Ojw.CMessage.Write_Error("Connect Fail -> Check your COMPORT first");
                }
            }
            else
            {
                m_CMotor.DisConnect();
                btnConnect.Text = "Connect";
                Ojw.CMessage.Write("Disconnected");
            }
#endif
        }

        private int m_nData = 400;
        private void btnUp_Click(object sender, EventArgs e)
        {
            Move_Up();
            //MoveForward();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
#if _ENABLE_DRONE
            //if (serialPort1.IsOpen == true)
            //{
            //    serialPort1.Close();
            //    btnConnect.Text = "Connect";
            //    Ojw.CMessage.Write("Disconnected");
            //}
            if (m_CSerial.IsConnect() == true)
            {
                m_CSerial.DisConnect();
                btnConnect.Text = "Connect";
                Ojw.CMessage.Write("Disconnected");
            }
#else
            if (m_CMotor.IsConnect() == true)
            {
                m_CMotor.DisConnect();
                btnConnect.Text = "Connect";
                Ojw.CMessage.Write("Disconnected");
            }
#endif
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        #region Move
        private void Ready() { Send(0, 0, 0, 0, 0xb1); }
        private void Move_Up() { Send(0, 0, 0, 0x20, 0); }
        private void Hovering() { Send(0, 0, 0, 0x00, 0); }
        private void Move_Left() { Send(0x20, 0, 0, 0x00, 0); }
        private void Move_Right() { Send(0xa0, 0, 0, 0x00, 0); }
        private void Stop()
        {
#if _ENABLE_DRONE
            //String strData = "s";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
            Send(0, 0, 0, 0, STOP);
#else
            int nData = 0;
            int i = 0;
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Stop();
            m_CMotor.ResetFlag();
#endif
        }
        private void MoveForward()
        {
#if _ENABLE_DRONE
            Send(0, 0, 0, 0x20, 0);
            //String strData = "f";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
#else
            int nData = m_nData;
            for (int i = 0; i < 4; i++)
            {
                m_CMotor.Move(1000, i, -nData);
            }
#endif
        }
        private void MoveBackward()
        {
#if _ENABLE_DRONE
            //String strData = "b";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
#else
            int nData = m_nData;
            for (int i = 0; i < 4; i++)
            {
                m_CMotor.Move(1000, i, nData);
            }
#endif
        }
        private void MoveTurnLeft()
        {
#if _ENABLE_DRONE
            //String strData = "[";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
#else
            int nData = m_nData;
            int i = 0;
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, -nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, -nData);
#endif
        }
        private void MoveTurnRight()
        {
#if _ENABLE_DRONE
            //String strData = "]";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
#else
            int nData = m_nData;
            int i = 0;
            m_CMotor.Move(1000, i++, -nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, -nData);
            m_CMotor.Move(1000, i++, nData);
#endif
        }
        #endregion Move
        private void MoveLeft()
        {
#if _ENABLE_DRONE
            //String strData = "l";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
#else
            int nData = m_nData;
            int i = 0;
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, -nData);
            m_CMotor.Move(1000, i++, -nData);
            m_CMotor.Move(1000, i++, nData);
#endif
        }
        private void MoveRight()
        {
#if _ENABLE_DRONE
            //String strData = "r";
            //m_CSerial.SendPacket(Encoding.UTF8.GetBytes(strData));
#else
            int nData = m_nData;
            int i = 0;
            m_CMotor.Move(1000, i++, -nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, nData);
            m_CMotor.Move(1000, i++, -nData);
#endif
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Move_Left();   
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Move_Right();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveBackward();
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            MoveTurnLeft();
        }


        //START CODE
        private static readonly byte START1 =         	0x0A;
        private static readonly byte START2 =         	0x55;

//HEADER TYPE
        private static readonly byte CONTROL =         	0x20;
        private static readonly byte STATE   =         	0x21;

        private static readonly byte LENGTH  =         	0x05;

//EVENT
        private static readonly byte  NONE		=	0x00;
        private static readonly byte  MISSILE	=	0x10;
        private static readonly byte  SHIELD	=		0x11;
        private static readonly byte  DEMON		=	0x12;
        private static readonly byte  WATERBOMB	=	0x13;
        private static readonly byte  BOOSTER	=	0x14;
        private static readonly byte  HEADINGLOCK=		0x15;

        private static readonly byte  TRIM_RESET	=	0x80;
        private static readonly byte  TRIM_PITCH_INCREASE=	0x81;
        private static readonly byte  TRIM_PITCH_DECREASE	=0x82;
        private static readonly byte  TRIM_YAW_INCREASE=	0x83;
        private static readonly byte  TRIM_YAW_DECREASE=	0x84;
        private static readonly byte  TRIM_ROLL_INCREASE=	0x85;
        private static readonly byte  TRIM_ROLL_DECREASE=	0x86;

        private static readonly byte  TAKE_OFF=		0xA0;
        private static readonly byte  STOP		=	0xA1;  //Landing

        private static readonly byte  GYROBIAS	=	0xB0;
        private static readonly byte  RESET_YAW		=0xB1;
        private static readonly byte  PAIRING		=0xB2;

        private static readonly byte  TEAM_RED		=0xC0;
        private static readonly byte  TEAM_BLUE		=0xC1;

        private static readonly byte  LEVEL_BEGINNER		=0xD0;
        private static readonly byte  LEVEL_EXPERT		=0xD1;

        private static readonly byte  ABSOLUTE		=0xE0;
        private static readonly byte  RC			=0xE1;

        private static readonly byte  OFF			=0x00;
        private static readonly byte  ON			=0x01;
	
	
        private static readonly byte READY			=0x00;
        private static readonly byte FLY			=0x01;
        private static readonly byte TRIM			=0x02;

        private static readonly byte DOWN                    =0x00;
        private static readonly byte UP                      =0x01;


        private static readonly byte PACKET_LENGTH 		=10;
        private static readonly byte MAX_CMD_LENGTH 		=11;
        private void Send(byte roll, byte pitch, byte yaw, byte throttle, byte byEvent)
        {
          byte checkSum = 0x00;
          byte [] packet = new byte[PACKET_LENGTH];
          //START CODE
          packet[0] = START1;
          packet[1] = START2;

          //header
          packet[2] = CONTROL;
          packet[3] = LENGTH;

          //data
          packet[4] = roll;
          packet[5] = pitch;
          packet[6] = yaw;
          packet[7] = throttle;
          packet[8] = byEvent;//event;

          for (int i = 2; i < 9; i++)
          {
            checkSum = (byte)((checkSum + packet[i]) & 0xff);
          }
          packet[9] = checkSum;

          //serialPort1.Write(packet, 0, PACKET_LENGTH);//
          m_CSerial.SendPacket(packet, PACKET_LENGTH);
          //roll = 0x00;
          //pitch = 0x00;
          //yaw = 0x00;
          //throttle = 0x00;
          //byEvent = 0x00;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Send(0, 0, 0, 0, 0xb1);
        }

        private void btnHovering_Click(object sender, EventArgs e)
        {
            Hovering();
        }
    }
}
