using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region Step1 - Using
// For Use
//  1. reference - add reference - search - Choose a DLL(OpenJigWare.dll)
//  2. add "using OpenJigWare" as follow
using OpenJigWare;
using System.IO.Ports;
using System.Threading; // Using DLL
#endregion Step1 - Using

namespace LaserDisplay
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Step2 - Init(Using Message Command) : It's up to you if you want to use some message commands like a "printf"
        // Init
        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage); // Initialize ( You can use some commends ... -> Ojw.CMessage.Write(), Ojw.CMessage.Write2(), Ojw.CMessage.Write_Error()  )
            //cmbModel.SelectedIndex = 1;
            //cmbDir.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion Step2 - Init(Using Message Command) : It's up to you if you want to use some message commands like a "printf"

        #region Step3 - Variable
        private Ojw.CHerculex m_CMotor = new Ojw.CHerculex();
        #endregion Step3 - Variable
        #region Step4 - Connect / Disconnect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (m_CMotor.IsConnect() == false)
            {
                // Ojw.CConvert.StrToInt() => [ String -> Integer ]
                m_CMotor.Connect(Ojw.CConvert.StrToInt(txtComport.Text), Ojw.CConvert.StrToInt(txtBaudrate.Text));
                if (m_CMotor.IsConnect() == true)
                {
                    btnConnect.Text = "Disconnect";
                    Ojw.CMessage.Write("Connected");

                    // 모터 셋팅(안하면 기본값 drs-0101, 정방향)
                    m_CMotor.SetModel(Ojw.EType_t._0102);
                    m_CMotor.SetParam_Dir(0, true);  // X
                    m_CMotor.SetParam_Dir(1, false); // Y
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
        }
        #endregion Step4 - Connect / Disconnect

        #region Step5 - Form Closing
        private bool m_bProgEnd = false;
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ojw.CMessage.Write("Form Closing...");

            if (m_CMotor.IsConnect() == true)
                m_CMotor.DisConnect();

            m_bProgEnd = true;
            Ojw.CMessage.Write("Disconnected");
        }
        #endregion Step5 - Form Closing
        private const float _X0 = 45.0f;//-60.0f;
        private const float _Y0 = -45.0f;//-5.0f;
        private const float _Z0 = 0.0f;
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void btnMoveInit_Click(object sender, EventArgs e)
        {
            m_CMotor.DrvSrv(true, true);
            MotMove(0, 0, 1000);
        }
        private float m_fStep = 0.1f;
        private void Jump(float fX, float fY, int nTime)
        {
            if (IsLaser() == true) Laser(false);
            //Move(fX, fY, nTime);
            Move(fX, fY, m_fStep, true);
        }
        private void Draw(float fX, float fY, int nTime)
        {
            if (IsLaser() == false) Laser(true);
            //MotMove(fX, fY, nTime);
            Move(fX, fY, m_fStep, true);
        }
        private int m_nSpeed = 20;
        private float m_fX = 0;
        private float m_fY = 0;
        private void Move(float fX, float fY, float fStep, bool bContinue)
        {
            Move(m_fX, m_fY, fX, fY, fStep, bContinue);
        }
        private void Move(float fX0, float fY0, float fX1, float fY1, float fStep, bool bContinue)
        {
            // y 높이 편차
            float fLength = (float)Math.Sqrt((fX1 - fX0) * (fX1 - fX0) + (fY1 - fY0) * (fY1 - fY0));
            float fX, fY, fZ;
            float [] afAngle = new float[3];

            //double dRange = 2.0;
            //if (m_nSpeed <= (int)m_dParam_Jump_Speed) dStep = dRange;

            float fTmp = fLength / fStep;
            int nCnt = (int)Math.Round(fTmp);
            int nStart = ((bContinue == true) ? 1 : 0);
            for (int i = nStart; i <= nCnt; i++)
            {
                if ((m_CMotor.IsStop() == true) || (m_CMotor.IsEmg() == true)) return;
                if (i == 0)
                {
                    fX = fX0;
                    fY = fY0;
                }
                else if (i == nCnt)
                {
                    fX = fX1;
                    fY = fY1;
                }
                else
                {
                    fX = fX0 + (fX1 - fX0) / fLength * fStep * i;
                    fY = fY0 + (fY1 - fY0) / fLength * fStep * i;
                }
                MotMove(fX, fY, 0);//m_nSpeed);//_SPD);                
            }
        }
        private void MotMove(float fAngle0, float fAngle1, int nSpeed)
        {
            if (m_CMotor.IsStop() == true) return;

            // 실제로 모터의 동작/
            m_CMotor.Move(nSpeed, (new Ojw.SAxis_t(0, _X0 + fAngle0)), (new Ojw.SAxis_t(1,  _Y0 + fAngle1)));//, (new Ojw.SAxis_t(2, _Z0 + fAngle2)));
            m_fX = fAngle0;
            m_fY = fAngle1;
            // Wait
            //m_CMotor.Wait(nSpeed);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            m_CMotor.DrvSrv(true, true);
            int nSpeed = 1000;
            float fAngle0 = Ojw.CConvert.StrToFloat(txtX.Text);
            float fAngle1 = Ojw.CConvert.StrToFloat(txtY.Text);
            //float fAngle2 = 0.0f;
            // 실제로 모터의 동작/
            MotMove(fAngle0, fAngle1, nSpeed);
        }

        private void btnReset_Click(object sender, EventArgs e) { m_CMotor.Reset(); }
        private void btnStop_Click(object sender, EventArgs e) { m_CMotor.Stop(); }
        private void btnEmergencySwitch_Click(object sender, EventArgs e) { m_CMotor.Emg(); }

        private void SendPacket(char cCmd)
        {
            byte[] buffer = new byte[1];
            buffer[0] = (byte)(cCmd & 0xff);
            if (m_SerialLaser.IsOpen == true) m_SerialLaser.Write(buffer, 0, 1);
        }

        private bool IsLaser() { return m_bLaserOn; }
        private bool m_bLaserOn = false;
        private void Laser(bool bOn)
        {
            m_bLaserOn = bOn;
            SendPacket((bOn == true) ? '1' : '0');
        }
        private void btnLaserOn_Click(object sender, EventArgs e)
        {
            Laser(true);
        }
        private void btnLaserOff_Click(object sender, EventArgs e)
        {
            Laser(false);
        }


        private SerialPort m_SerialLaser = new SerialPort();
        private void btnLaserConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_SerialLaser.IsOpen == false)
                {
                    m_SerialLaser.PortName = "COM" + txtLaserPort.Text;
                    m_SerialLaser.BaudRate = Ojw.CConvert.StrToInt(txtLaserBaudrate.Text);
                    m_SerialLaser.Parity = Parity.None;
                    m_SerialLaser.DataBits = 8;
                    m_SerialLaser.StopBits = StopBits.One;
                    m_SerialLaser.ReceivedBytesThreshold = 1;
                    //m_SerialLaser.ReadExisting
                    //m_SerialLaser.ReadBufferSize = 256;
                    m_SerialLaser.Open();
                    btnLaserConnect.Text = "Disconnect2";
                }
                else
                {
                    m_SerialLaser.Close();
                    btnLaserConnect.Text = "Connect2";
                }
            }
            catch
            {
                btnLaserConnect.Text = "Connect2";
            }
        }
        private Thread m_thRun;
        private void btnTest_Click(object sender, EventArgs e)
        {
            m_thRun = new Thread(new ThreadStart(Thread_Run));
            m_thRun.Start();
        }
        private void Thread_Run()
        {
            Laser(false);
            m_CMotor.DrvSrv(true, true);
            float fRang = 0.5f;
            int nTime = 40;
            long lTmr = 0;
            Ojw.CTimer CTmr = new Ojw.CTimer();
            CTmr.Set();
            // Move
            Jump(-fRang, -fRang, nTime);
            lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }

            for (int i = 0; i < 20; i++)
            {
                Draw(-fRang, fRang, nTime);
                lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
                Draw(fRang, fRang, nTime);
                lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
                Draw(fRang, -fRang, nTime);
                lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
                Draw(-fRang, -fRang, nTime);
                lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
            }

            float fXc = 0.0f;
            float fYc = 0.0f;
            //float fZc = 0.0f;
            float fLength = 2.5f;

            // 만들기
            int nCircle = 50;
            Ojw.SVector3D_t[] aCVec = new Ojw.SVector3D_t[nCircle];
            for (int i = 0; i < nCircle; i++)
            {
                aCVec[i].x = fXc + fLength * (float)Ojw.CMath.Cos(360.0f / (float)nCircle * (i + 1));
                aCVec[i].y = fYc + fLength * (float)Ojw.CMath.Sin(360.0f / (float)nCircle * (i + 1));
            }


            nTime = 500;
            Jump(0, 0, nTime);

            lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
            nTime = 20;

            Jump(aCVec[nCircle - 1].x, aCVec[nCircle - 1].y, nTime);
            //for (int j = 0; j < 10; j++)
            //{
            //    for (int i = 0; i < nCircle; i++)
            //    {
            //        Draw(aCVec[i].x, aCVec[i].y, nTime);
            //        lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
            //    }
            //}
            float fRatio = (float)nCircle;// 30.0f;
            Laser(true);
            nTime = 10;// 10;
            Ojw.C2D m_C2d = new Ojw.C2D();
            float fX, fY, fZ;
            int nX, nY;
            m_C2d.Create(pic2D);
                m_C2d.SetAngleX(0);
                m_C2d.SetAngleY(0);
                m_C2d.SetAngleZ(0);
                m_C2d.SetScale(10);
            float fScale = 20.0f;
            int nCnt = 20;
            for (int j = 0; j < nCnt; j++)
            {
                //m_C2d.SetScale((double)fScale * Ojw.CMath.Cos((360 / nCnt) * j));
                //m_C2d.SetAngleY((360 / nCnt) * j);
                for (int i = 0; i < fRatio; i++)
                {
                    
                    fX = aCVec[i].x;
                    fY = aCVec[i].y;
                    fZ = 0;
                    m_C2d.Rotation(((360 / nCnt) * j), ((360 / nCnt) * j), ((360 / nCnt) * j), fX, fY, fZ, out nX, out nY);
                    fX = (float)nX / 10.0f;
                    fY = (float)nY / 10.0f;
                    if (i == 0) Laser(false);
                    else Laser(true);

                    if (i == 0) Thread.Sleep(1000);
                    //else Thread.Sleep(20); //Ojw.CTimer.Wait(1);//lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }

                    Move(
                        fX,//aCVec[i].x,//fXc + fLength * (float)Ojw.CMath.Cos(360.0f / fRatio * ((float)i + 1.0f)),
                        fY,//aCVec[i].y,//fYc + fLength * (float)Ojw.CMath.Sin(360.0f / fRatio * ((float)i + 1.0f)), 
                        m_fStep, false
                        );
                    Thread.Sleep(10);
                }
            }
            Laser(false);
            Jump(0, 0, 50);

            List<Ojw.SVector3D_t> lstBox = new List<Ojw.SVector3D_t>();
            lstBox.Add(new Ojw.SVector3D_t(-5, -5, -5));
            lstBox.Add(new Ojw.SVector3D_t(-5, -5,  5));
            lstBox.Add(new Ojw.SVector3D_t( 5, -5,  5));
            lstBox.Add(new Ojw.SVector3D_t( 5, -5, -5));
            lstBox.Add(new Ojw.SVector3D_t(-5, -5, -5));

            lstBox.Add(new Ojw.SVector3D_t(-5,  5, -5));
            lstBox.Add(new Ojw.SVector3D_t(-5,  5,  5));
            lstBox.Add(new Ojw.SVector3D_t( 5,  5,  5));
            lstBox.Add(new Ojw.SVector3D_t( 5,  5, -5));
            lstBox.Add(new Ojw.SVector3D_t(-5,  5, -5));

            float fX2, fY2, fZ2;
            int nX2, nY2;
            for (int j = 0; j < nCnt; j++)
            {
                for (int i = 1; i < lstBox.Count; i++)
                {
                    fX = lstBox[i - 1].x;
                    fY = lstBox[i - 1].y;
                    fZ = lstBox[i - 1].z;
                    fX2 = lstBox[i].x;
                    fY2 = lstBox[i].y;
                    fZ2 = lstBox[i].z;
                    m_C2d.Rotation(((360 / nCnt) * j), ((360 / nCnt) * j), ((360 / nCnt) * j), fX, fY, fZ, out nX, out nY);
                    m_C2d.Rotation(((360 / nCnt) * j), ((360 / nCnt) * j), ((360 / nCnt) * j), fX2, fY2, fZ2, out nX2, out nY2);
                    fX = (float)nX / 100.0f;
                    fY = (float)nY / 100.0f; 
                    fX2 = (float)nX2 / 100.0f;
                    fY2 = (float)nY2 / 100.0f;

                    if (i == 0) Laser(false);
                    else Laser(true);

                    if (i == 0) Thread.Sleep(1000);
                    //else Thread.Sleep(20); //Ojw.CTimer.Wait(1);//lTmr += nTime; while (m_bProgEnd == false) { if (CTmr.Get() > lTmr) break; Thread.Sleep(1); }
                    Move(fX, fY, fX2, fY2, 0.02f, true);
                    //Move(
                        //fX,//aCVec[i].x,//fXc + fLength * (float)Ojw.CMath.Cos(360.0f / fRatio * ((float)i + 1.0f)),
                        //fY,//aCVec[i].y,//fYc + fLength * (float)Ojw.CMath.Sin(360.0f / fRatio * ((float)i + 1.0f)), 
                        //m_fStep, false
                        //);
                    Thread.Sleep(100);
                }
            }
            Laser(false);

            // Display
            Ojw.CMessage.Write("Done");
        }
    }
}
