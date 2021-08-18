//#define _LEAP_ENABLE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

//using Leap;

namespace Delta_Dog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private const int _X_DIR = 1;
        private const int _Y_DIR = 1;
        private const int _Z_DIR = 1;
#if _LEAP_ENABLE
        #region Leap
        // 좌표축 회전. 원래는 오픈지그웨어의 축과 동일.(Leap motion을 바닥에 놓은 경우)
#if true
        float m_fAngle_X = 0.0f;
#else
        float m_fAngle_X = 90.0f;
#endif
        float m_fAngle_Y = 0.0f;
        float m_fAngle_Z = 0.0f;

        bool m_bLeapEnable = true; // 립모션을 중지시키고 싶으면 이걸 false 로 하면 됨

        // 값이 0에 가까울 수록 둔감
        //float m_fWeight_For_Lowpass = 0.2f;

        float[] m_afPos = new float[3];
        float[] m_afPos_Prev = new float[3];

        private void OjwClear()
        {
            m_C3d.User_Clear();
        }
        private void OjwDraw(Color cColor, float fX, float fY, float fZ)//, Vector vtHand)
        {

            Ojw.C3d.COjwDisp CDisp = new Ojw.C3d.COjwDisp();

            CDisp.InitData();
            CDisp.bInit = true;
            CDisp.cColor = cColor;
            CDisp.strDispObject = "#9";
            CDisp.fWidth_Or_Radius = 10.0f;
            CDisp.fHeight_Or_Depth = 10.0f;
            CDisp.fDepth_Or_Cnt = 10.0f;

            CDisp.afTrans[0].x = fX;
            CDisp.afTrans[0].y = fY;
            CDisp.afTrans[0].z = fZ;

            m_C3d.User_Add_Ex(CDisp);


            CDisp.InitData();
            CDisp.bInit = true;
            CDisp.cColor = cColor;
            CDisp.strDispObject = "#17";
            CDisp.fWidth_Or_Radius = 10.0f;
            CDisp.fHeight_Or_Depth = 10.0f;
            CDisp.fDepth_Or_Cnt = 10.0f;

            //CDisp.Points.Clear();
            //CDisp.Points.Add(new Ojw.SVector3D_t(vtHand.x, vtHand.y, vtHand.z));
            //CDisp.Points.Add(new Ojw.SVector3D_t(fX, fY, fZ));

            m_C3d.User_Add_Ex(CDisp);
        }
        private void OjwFlush()
        {
            m_C3d.OjwDraw();
        }

        private void FlmInit()
        {
            using (Leap.IController controller = new Leap.Controller())
            {
                controller.SetPolicy(Leap.Controller.PolicyFlag.POLICY_ALLOW_PAUSE_RESUME);

                // Set up our listener:
                controller.Connect += FlmOnServiceConnect;
                controller.Disconnect += FlmOnServiceDisconnect;
                controller.FrameReady += FlmOnFrame;
                controller.Device += FlmOnConnect;
                controller.DeviceLost += FlmOnDisconnect;
                controller.DeviceFailure += FlmOnDeviceFailure;
                controller.LogMessage += FlmOnLogMessage;

                // Keep this process running until Enter is pressed
                //Ojw.CMessage.Write("Press any key to quit...");
                //Console.ReadLine();
            }
        }

        public void FlmOnInit(Controller controller)
        {
            Ojw.CMessage.Write("Initialized");
        }

        private Ojw.CTimer m_CTmr_Leap_OnFrame = new Ojw.CTimer();
        public void FlmOnConnect(object sender, DeviceEventArgs args)
        {
            Ojw.CMessage.Write("Connected");
            m_CTmr_Leap_OnFrame.Set();
        }

        public void FlmOnDisconnect(object sender, DeviceEventArgs args)
        {
            Ojw.CMessage.Write("Disconnected");
        }


        private int m_nSeq_Mouse = 0;
        private int m_nSeq_Mouse_Back = 0;
        private int m_nMouse = -1;
        private Ojw.CTimer m_CTmr_Click = new Ojw.CTimer();
        private Ojw.CTimer m_CTmr_Find = new Ojw.CTimer();
        private Ojw.CTimer m_CTmr_Message = new Ojw.CTimer();
        private bool bCommand = false;
        private const int _LOSS = 5;//10;
        private int nCommandLoss = _LOSS;

        private bool m_bOnFrame = false;
        public void FlmOnFrame(object sender, FrameEventArgs args)
        {
            if (m_bLeapEnable == false) return;
            if (m_bOnFrame == true) return;
            m_bOnFrame = true;
            Application.DoEvents();

            bool bShow = this.Visible;
            // 손의 위치를 잃어버린 시간이 1초가 넘으면 클릭을 없앤다.
            if (m_CTmr_Click.Get() > 1000)
            {
                if (m_nMouse > 0) // 이미 클릭한 상황이라면
                {

                }
                m_nMouse = -1;
                m_CTmr_Find.Set();
            }
            m_CTmr_Click.Set();

            float fAngle_X = m_fAngle_X;
            float fAngle_Y = m_fAngle_Y;
            float fAngle_Z = m_fAngle_Z;


#if _TEST
            if (m_CTmr_Leap_OnFrame.Get() >= 10)//50)
#else
            if (m_CTmr_Leap_OnFrame.Get() >= 100)//50)
#endif
            {
                m_CTmr_Leap_OnFrame.Set();
                // Get the most recent frame and report some basic information
                Frame frame = args.frame;

                if (frame.Hands.Count > 0)
                {
                    OjwClear();

                    foreach (Hand hand in frame.Hands)
                    {
                        Vector vtHand = new Vector(hand.PalmPosition);
                        m_C3d.Rotation(fAngle_X, fAngle_Y, fAngle_Z, ref vtHand.x, ref vtHand.y, ref vtHand.z);

                        Vector [] avtFinger_Position = new Vector[5];

                        //if (hand.IsRight == true)
                        {
                            int nSum = 0;
                            //bool bIndex = false;
                            foreach (Finger finger in hand.Fingers)
                            {
                                if (finger.Type < 0) continue;
                                int nType = (int)finger.Type;
                                //vtFinger_Velocity = new Vector(finger.TipVelocity);
                                avtFinger_Position[nType] = new Vector(finger.TipPosition);
                                //m_C3d.Rotation(fAngle_X, fAngle_Y, fAngle_Z, ref vtFinger_Velocity.x, ref vtFinger_Velocity.y, ref vtFinger_Velocity.z);
                                m_C3d.Rotation(fAngle_X, fAngle_Y, fAngle_Z, ref avtFinger_Position[nType].x, ref avtFinger_Position[nType].y, ref avtFinger_Position[nType].z);
                                nSum++;
                                if (finger.Type == Finger.FingerType.TYPE_INDEX)
                                {
                                    //bIndex = true;
                                    if (bShow == true) OjwDraw(Color.Red, avtFinger_Position[nType].x, avtFinger_Position[nType].y, avtFinger_Position[nType].z, vtHand);
                                }
                                else
                                {                                   
                                    if (bShow == true) OjwDraw(Color.Blue, avtFinger_Position[nType].x, avtFinger_Position[nType].y, avtFinger_Position[nType].z, vtHand);
                                }
                            }
                            
                            if (bShow == true) OjwDraw(Color.Green, vtHand.x, vtHand.y, vtHand.z, vtHand);

                            double[] adDelta = new double[5];
                            for (int i = 0; i < adDelta.Length; i++)
                            {
                                adDelta[i] = Math.Sqrt(
                                   Math.Pow(avtFinger_Position[i].x - vtHand.x, 2) +
                                   Math.Pow(avtFinger_Position[i].y - vtHand.y, 2) +
                                   Math.Pow(avtFinger_Position[i].z - vtHand.z, 2)
                                   );
                            }

                            if (
                                (adDelta[0] > 10) &&
                                (adDelta[1] > 10) &&
                                (adDelta[2] > 10) &&
                                (adDelta[3] > 10) &&
                                (adDelta[4] > 10)
                                //(adDelta[0] > 60) &&
                                //(adDelta[1] > 60) &&
                                //(adDelta[2] < 60) &&
                                //(adDelta[3] < 60) &&
                                //(adDelta[4] < 60)
                                )
                            {
                                if (bCommand == false)
                                {
                                    bCommand = true;

                                    m_afPos_Prev[0] = (float)Math.Round(vtHand.x / 10);
                                    m_afPos_Prev[1] = (float)Math.Round(vtHand.y / 10);
                                    m_afPos_Prev[2] = (float)Math.Round(vtHand.z / 10);
                                }
                            }
                            else if (bCommand == true)
                            {
                                nCommandLoss--;
                                if (nCommandLoss < 0)
                                {
                                    bCommand = false;
                                    nCommandLoss = _LOSS;

                                    m_nDirX = 0;
                                    m_nDirY = 0;
                                    m_nDirZ = 0;
                                }
                                //m_nDirX = 0;
                                //m_nDirY = 0;
                                //m_nDirZ = 0;
                            }
                            //lbPos.Text = ((bCommand == true) ? "*****" : "") + 
                            //    String.Format("{0}, {1}, {2}, [{3},{4},{5},{6},{7}]",
                            //             Math.Round(vtHand.x/10),
                            //             Math.Round(vtHand.y/10),
                            //             Math.Round(vtHand.z/10),
                            //             Math.Round(adDelta[0], 1),
                            //             Math.Round(adDelta[1], 1),
                            //             Math.Round(adDelta[2], 1),
                            //             Math.Round(adDelta[3], 1),
                            //             Math.Round(adDelta[4], 1)
                            //             );
                            m_afPos[0] = (float)Math.Round(vtHand.x / 10);
                            m_afPos[1] = (float)Math.Round(vtHand.y / 10);
                            m_afPos[2] = (float)Math.Round(vtHand.z / 10);

                            if (bCommand == true)
                            {
                                m_CTmr_Find.Set();

                                m_nSeq_Mouse++;

                                float fRange = 2.0f;
                                if ((m_afPos[2] - m_afPos_Prev[2]) > fRange)
                                {
                                    m_nDirZ = _Z_DIR;
                                }
                                else if ((m_afPos[2] - m_afPos_Prev[2]) < -fRange)
                                {
                                    m_nDirZ = -_Z_DIR;
                                }
                                if ((m_afPos[1] - m_afPos_Prev[1]) > fRange)
                                {
                                    m_nDirY = _Y_DIR;
                                }
                                else if ((m_afPos[1] - m_afPos_Prev[1]) < -fRange)
                                {
                                    m_nDirY = -_Y_DIR;
                                }
                                if ((m_afPos[0] - m_afPos_Prev[0]) > fRange)
                                {
                                    m_nDirX = _X_DIR;
                                }
                                else if ((m_afPos[0] - m_afPos_Prev[0]) < -fRange)
                                {
                                    m_nDirX = -_X_DIR;
                                }
                            }
                            else
                            {
                                m_nDirX = 0;
                                m_nDirY = 0;
                                m_nDirZ = 0;
                            }
                        } 
                        
                    }
                    if (bShow == true) OjwFlush();
                }
                else
                {
                    //g_CShm_Leap.SData.nRunning = 0;
                    //g_CShm_Leap.SData.nSeq++;
                }
            }
            m_bOnFrame = false;
        }

        public void FlmOnServiceConnect(object sender, ConnectionEventArgs args)
        {
            Ojw.CMessage.Write("Service Connected");
        }

        public void FlmOnServiceDisconnect(object sender, ConnectionLostEventArgs args)
        {
            Ojw.CMessage.Write("Service Disconnected");
        }

        public void FlmOnServiceChange(Controller controller)
        {
            Ojw.CMessage.Write("Service Changed");
        }

        public void FlmOnDeviceFailure(object sender, DeviceFailureEventArgs args)
        {
            Ojw.CMessage.Write("Device Error");
            Ojw.CMessage.Write("  PNP ID:" + args.DeviceSerialNumber);
            Ojw.CMessage.Write("  Failure message:" + args.ErrorMessage);
        }

        public void FlmOnLogMessage(object sender, LogEventArgs args)
        {
            switch (args.severity)
            {
                case Leap.MessageSeverity.MESSAGE_CRITICAL:
                    Ojw.CMessage.Write("[Critical]");
                    break;
                case Leap.MessageSeverity.MESSAGE_WARNING:
                    Ojw.CMessage.Write("[Warning]");
                    break;
                case Leap.MessageSeverity.MESSAGE_INFORMATION:
                    Ojw.CMessage.Write("[Info]");
                    break;
                case Leap.MessageSeverity.MESSAGE_UNKNOWN:
                    Ojw.CMessage.Write("[Unknown]");
                    break;
            }
            Ojw.CMessage.Write("[{0}] {1}", args.timestamp, args.message);
        }
        #endregion Leap
#endif
        private Ojw.CParam m_CParam;
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private double[,] m_adPos = new double[4,3]; 
        private void Main_Load(object sender, EventArgs e)
        {
            Ojw.Log_Init(txtMessage);

            m_CParam = new Ojw.CParam(
                txtX,
                txtY,
                txtZ,
                txtTime
                );

            UpdateComport();

            m_C3d.Init(lbDisp);
            if (m_C3d.FileOpen(Application.StartupPath + "\\delta_dog.ojw") == false)
            {
                Ojw.LogErr("FileOpen Error");
                Application.Exit();
            }
            else
            {
#if _LEAP_ENABLE
                //m_C3d.SetAngle_Display(-10, 60, 0);
                FlmInit();
                //tmrDisp.Enabled = true;
#endif
            }
        }

        private bool m_bTmrDisp = false;
        private void tmrDisp_Tick(object sender, EventArgs e)
        {
            if (m_bTmrDisp == true) return;
            tmrDisp.Enabled = false;
            m_bTmrDisp = true;

            m_C3d.OjwDraw();

            m_bTmrDisp = false;
            tmrDisp.Enabled = false;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            tmrControl.Enabled = false;
            Ojw.CTimer.Wait(10);
            float fX = Ojw.CConvert.StrToFloat(txtX.Text);
            float fY = Ojw.CConvert.StrToFloat(txtY.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtZ.Text);
            int nTime = Ojw.CConvert.StrToInt(txtTime.Text);
            for (int i = 0; i < 4; i++) Move(i, fX, fY, fZ, nTime);
            Ojw.CTimer.Wait(nTime);

            tmrControl.Enabled = true;
        }
        private Ojw.CMonster m_CMon = new Ojw.CMonster();
        private void Move(int nLeg, double dX, double dY, double dZ, int nTime)
        {
            //Ojw.CMath.Delta_Parallel_Init(55, 107, 217, 21);
            m_C3d.SetData_XYZ(m_CMon, nLeg, dX, dY, dZ, nTime);
            //Ojw.CMath.Delta_Parallel_Init(55, 107, 306, 21);
            //double[] adAngle = new double[3];
            //Ojw.CMath.Delta_Parallel_InverseKinematics(dX, dY, dZ, out adAngle[0], out adAngle[1], out adAngle[2]);
            //m_CMon.Move(1, (float)adAngle[0], 2, (float)adAngle[1], 3, (float)adAngle[2], nTime);
            //lbPos.Text = String.Format("{0}, {1}, {2}", Math.Round(adAngle[0], 3), Math.Round(adAngle[1], 3), Math.Round(adAngle[2], 3));
            //Ojw.CMath.Delta_Parallel_ForwardKinematics(adAngle[0], adAngle[1], adAngle[2], out dX, out dY, out dZ);
            //lbPos2.Text = String.Format("X,Y,Z({0}, {1}, {2})", dX, dY, dZ);

            m_adPos[nLeg, 0] = dX;
            m_adPos[nLeg, 1] = dY;
            m_adPos[nLeg, 2] = dZ;
        }

        private void cmbComport_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateComport();
        }
        private void UpdateComport()
        {
            cmbComport.Items.Clear();
            List<string> lstComport = new List<string>();
            lstComport.Clear();
            lstComport.AddRange(Ojw.CSerial.GetPortNames());
            lstComport.Reverse();
            cmbComport.Items.AddRange(lstComport.ToArray());
            cmbComport.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbComport.SelectedIndex >= 0)
            {
                if (btnConnect.Text == "Disconnect")
                {
                    btnConnect.Text = "Connect";
                    m_CMon.Close();
                    //tmrJoystick.Enabled = false;
                }
                else
                {
                    string strItem = ((String)cmbComport.Items[cmbComport.SelectedIndex]).Substring(3);
                    int nPort = Ojw.CConvert.StrToInt(strItem);
                    //MessageBox.Show(Ojw.CConvert.IntToStr(nPort));
                    if (m_CMon.Open(nPort, 1000000) == true)
                    {
                        btnConnect.Text = "Disconnect";
                        for (int i = 1; i <= 12; i++)
                            m_CMon.SetParam(i, Ojw.CMonster.EMotor_t.XL_430);
                        //m_CMon.SetParam(2, Ojw.CMonster.EMotor_t.XL_430);
                        //m_CMon.SetParam(3, Ojw.CMonster.EMotor_t.XL_430);
                        //m_CMon.SetParam(4, Ojw.CMonster.EMotor_t.XL_430);
                        //m_CMon.SetTorq(false);
                        //m_CMon.Write_One(1, 

                        m_CMon.SetTorq(false);

                        m_CMon.SetTimeControl(true);
                        

                        m_CMon.SetTorq(true);



                        Move(0, 0, 200, 0, 2000);
                        Move(1, 0, 200, 0, 2000);
                        Move(2, 0, 200, 0, 2000);
                        Move(3, 0, 200, 0, 2000);
                        Ojw.CTimer.Wait(2000);
                        //tmrJoystick.Enabled = true;
                        m_bFirst = true; // 첫 움직임을 부드럽게 만들어 준다.
                        tmrControl.Enabled = true;
                    }
                    else
                    {
                        btnConnect.Text = "Connect";
                    }
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_CParam.Param_Save();
            if (m_CMon.IsOpen() == true) m_CMon.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tmrControl.Enabled = false;
            for (int k = 0; k < 500; k++)
            {
                float fX = 0;
                float fY = 150;
                float fZ = 0;
                int nTime = 600;
                for (int j = 0; j < 1; j++)
                {
                    for (int i = 0; i < 4; i++) Move(i, -30, fY, 30, nTime);
                    Ojw.CTimer.Wait(nTime);
                    for (int i = 0; i < 4; i++) Move(i, -30, fY, -30, nTime);
                    Ojw.CTimer.Wait(nTime);
                    for (int i = 0; i < 4; i++) Move(i, 30, fY, -30, nTime);
                    Ojw.CTimer.Wait(nTime);
                    for (int i = 0; i < 4; i++) Move(i, 30, fY, 30, nTime);
                    Ojw.CTimer.Wait(nTime);
                }
                fY += 50;
                for (int j = 0; j < 1; j++)
                {
                    for (int i = 0; i < 4; i++) Move(i, -30, fY, 30, nTime);
                    Ojw.CTimer.Wait(nTime);
                    for (int i = 0; i < 4; i++) Move(i, -30, fY, -30, nTime);
                    Ojw.CTimer.Wait(nTime);
                    for (int i = 0; i < 4; i++) Move(i, 30, fY, -30, nTime);
                    Ojw.CTimer.Wait(nTime);
                    for (int i = 0; i < 4; i++) Move(i, 30, fY, 30, nTime);
                    Ojw.CTimer.Wait(nTime);
                }
            }

            tmrControl.Enabled = true;
        }
        private bool m_bFirst = true;
        private int m_nDirX = 0;
        private int m_nDirZ = 0;
        private int m_nDirY = 0;
        private bool m_bTmrControl = false;
        private void tmrControl_Tick(object sender, EventArgs e)
        {
            if (m_bTmrControl == true) return;
            m_bTmrControl = true;

            tmrControl.Enabled = false;
#if _LEAP_ENABLE
            // 높이 230 ~ 310
            double dDelta_H = 5;
            double dDelta_X = 5;
            double dDelta_Z = 5;
            double dHeight_Max = 250;
            double dHeight_Min = 150;

            double dRange = 20;// 25;

            //if (m_nMouse < 0)
            if (m_CTmr_Find.Get() > 10000)
            {
                if (
                    //(m_adPos[0, 1] > dHeight_Min) ||
                    //(m_adPos[1, 1] > dHeight_Min) ||
                    //(m_adPos[2, 1] > dHeight_Min) ||
                    (m_adPos[3, 1] > dHeight_Min)
                    )
                {
                    m_nDirY = -1;
                }
                else m_nDirY = 0;

                if (
                    //(m_adPos[0, 0] > (dDelta_X+2)) ||
                    //(m_adPos[1, 0] > (dDelta_X+2)) ||
                    //(m_adPos[2, 0] > (dDelta_X+2)) ||
                    (m_adPos[3, 0] > (dDelta_X+2))
                    )
                {
                    m_nDirX = -1;
                }
                else if (
                    //(m_adPos[0, 0] < -(dDelta_X+2)) ||
                    //(m_adPos[1, 0] < -(dDelta_X+2)) ||
                    //(m_adPos[2, 0] < -(dDelta_X+2)) ||
                    (m_adPos[3, 0] < -(dDelta_X + 2))
                    )
                {
                    m_nDirX = 1;
                }
                else m_nDirX = 0;

                if (
                    //(m_adPos[0, 2] > (dDelta_Z+2)) ||
                    //(m_adPos[1, 2] > (dDelta_Z+2)) ||
                    //(m_adPos[2, 2] > (dDelta_Z+2)) ||
                    (m_adPos[3, 2] > (dDelta_Z + 2))
                    )
                {
                    m_nDirZ = -1;
                }
                else if (
                    //(m_adPos[0, 2] < -(dDelta_Z+2)) ||
                    //(m_adPos[1, 2] < -(dDelta_Z+2)) ||
                    //(m_adPos[2, 2] < -(dDelta_Z+2)) ||
                    (m_adPos[3, 2] < -(dDelta_Z + 2))
                    )
                {
                    m_nDirZ = 1;
                }
                else m_nDirZ = 0;
            }
            else
            {
                
            }

            for (int i = 0; i < 4; i++)
            {
                #region Height
                if (m_nDirY > 0)
                {
                    m_adPos[i, 1] += dDelta_H;
                    if (m_adPos[i, 1] > dHeight_Max) m_adPos[i, 1] = dHeight_Max;
                }
                else if (m_nDirY < 0)
                {
                    m_adPos[i, 1] -= dDelta_H;
                    if (m_adPos[i, 1] < dHeight_Min) m_adPos[i, 1] = dHeight_Min;
                }
                #endregion Height

                // 전후 -30 ~ 30
                if (m_nDirZ > 0)
                {
                    m_adPos[i, 2] += dDelta_Z;
                    if (m_adPos[i, 2] > dRange) m_adPos[i, 2] = dRange;
                }
                else if (m_nDirZ < 0)
                {
                    m_adPos[i, 2] -= dDelta_Z;
                    if (m_adPos[i, 2] < -dRange) m_adPos[i, 2] = -dRange;
                }
                // 좌우 -120 ~ 120
                //dDelta = 5;
                if (m_nDirX > 0)
                {
                    m_adPos[i, 0] += dDelta_X;
                    if (m_adPos[i, 0] > dRange) m_adPos[i, 0] = dRange;
                }
                else if (m_nDirX < 0)
                {
                    m_adPos[i, 0] -= dDelta_X;
                    if (m_adPos[i, 0] < -dRange) m_adPos[i, 0] = -dRange;
                }
                
                Move(i, m_adPos[i, 0], m_adPos[i, 1], m_adPos[i, 2], 100);
            }
#endif
            m_bTmrControl = false;

            tmrControl.Enabled = true;
        }

        private void btnForward_MouseUp(object sender, MouseEventArgs e)
        {
            m_nDirX = 0;
            m_nDirY = 0;
            m_nDirZ = 0;
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            m_nDirX = 0;
            m_nDirY = 0;
            m_nDirZ = 0;
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            m_nDirX = 0;
            m_nDirY = 0;
            m_nDirZ = 0;
        }

        private void btnBackward_MouseUp(object sender, MouseEventArgs e)
        {
            m_nDirX = 0;
            m_nDirY = 0;
            m_nDirZ = 0;
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            m_nDirX = 0;
            m_nDirY = 0;
            m_nDirZ = 0;
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            m_nDirX = 0;
            m_nDirY = 0;
            m_nDirZ = 0;
        }
        
        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            m_nDirX = 1;
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            m_nDirX = -1;
        }

        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            m_nDirZ = 1;
        }

        private void btnBackward_MouseDown(object sender, MouseEventArgs e)
        {
            m_nDirZ = -1;
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            m_nDirY = 1;
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            m_nDirY = -1;
        }

        private void lbDisp_Click(object sender, EventArgs e)
        {

        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            m_CMon.Reboot();
        }

        private void btnTorqOn_Click(object sender, EventArgs e)
        {
            m_CMon.SetTorq(true);
        }

        private void btnTorqOff_Click(object sender, EventArgs e)
        {
            m_CMon.SetTorq(false);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
