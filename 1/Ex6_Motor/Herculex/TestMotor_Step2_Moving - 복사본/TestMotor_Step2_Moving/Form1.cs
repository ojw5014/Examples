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
using OpenJigWare; // Using DLL
#endregion Step1 - Using

namespace TestMotor_Step2_Moving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Step2 - Init(Using Message Command) : It's up to you if you want to use some message commands like a "printf"
        // Init
        private void Form1_Load(object sender, EventArgs e)
        {
            // If you want to see your messages on your program... just use below one.
            Ojw.CMessage.Init(txtMessage); // Initialize ( You can use some commends ... -> Ojw.CMessage.Write(), Ojw.CMessage.Write2(), Ojw.CMessage.Write_Error()  )

            //Ojw.CMessage.Write("Test: Write()");
            //Ojw.CMessage.Write2("Test: Write2()\r\n");
            //Ojw.CMessage.Write_Error("Test: Write_Error()");

            // Remove CrossThreadChecking

            // 
            cmbModel.SelectedIndex = 1;
            cmbDir.SelectedIndex = 0;
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ojw.CMessage.Write("Form Closing...");

            if (m_CMotor.IsConnect() == true)
                m_CMotor.DisConnect();
            
            m_bProgEnd = true;
            Ojw.CMessage.Write("Disconnected");
        }
        #endregion Step5 - Form Closing

        #region Buttons
        private void btnServoOn_Click(object sender, EventArgs e) { m_CMotor.DrvSrv(true, true); }
        private void btnServoOff_Click(object sender, EventArgs e) { m_CMotor.DrvSrv(true, false); }
        private void btnDriverOn_Click(object sender, EventArgs e) { m_CMotor.DrvSrv(true, true); }
        private void btnDriverOff_Click(object sender, EventArgs e) { m_CMotor.DrvSrv(false, true); } 
        private void btnReset_Click(object sender, EventArgs e) { m_CMotor.Reset(); } 
        private void btnStop_Click(object sender, EventArgs e) { m_CMotor.Stop(); } 
        private void btnEmergencySwitch_Click(object sender, EventArgs e) { m_CMotor.Emg(); }
        #endregion Buttons

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_CMotor.SetModel(cmbModel.SelectedIndex);
        }

        private void cmbDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_CMotor.SetParam_Dir(m_nAxis, ((cmbDir.SelectedIndex != 0) ? true : false));
        }

        private int m_nAxis = 0;
        private float m_fAngle = 0.0f;
        private int m_nTime = 100;
        private void txtAxis_TextChanged(object sender, EventArgs e)
        {
            m_nAxis = Ojw.CConvert.StrToInt(txtAxis.Text);
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {
            m_fAngle = Ojw.CConvert.StrToFloat(txtAngle.Text);
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            m_nTime = Ojw.CConvert.StrToInt(txtTime.Text);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // Move
            m_CMotor.Move(m_nTime, (new Ojw.SAxis_t(m_nAxis, m_fAngle)));

            // Wait
            m_CMotor.Wait(m_nTime);

            //Request
            m_CMotor.Request_MotorData(m_nAxis);
            m_CMotor.Request_Version(m_nAxis);

            // Display
            Ojw.CMessage.Write(
                m_CMotor.GetVersion(m_nAxis).ToString() + "," +
                m_CMotor.GetAngle(m_nAxis).ToString() + "," +
                m_CMotor.GetTemp(m_nAxis).ToString()
                );
        }

        private void btnRed_Click(object sender, EventArgs e)       { m_CMotor.SetLed_Red(m_nAxis, true);    }
        private void btnBlue_Click(object sender, EventArgs e)      { m_CMotor.SetLed_Blue(m_nAxis, true);   }
        private void btnGreen_Click(object sender, EventArgs e)     { m_CMotor.SetLed_Green(m_nAxis, true);  }
        private void btnRedOff_Click(object sender, EventArgs e)    { m_CMotor.SetLed_Red(m_nAxis, false);   }
        private void btnBlueOff_Click(object sender, EventArgs e)   { m_CMotor.SetLed_Blue(m_nAxis, false);  }
        private void btnGreenOff_Click(object sender, EventArgs e)  { m_CMotor.SetLed_Green(m_nAxis, false); }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Request
            m_CMotor.Request_MotorData(m_nAxis);

            // Display
            Ojw.CMessage.Write(
                m_CMotor.GetAngle(m_nAxis).ToString() + "," +
                m_CMotor.GetTemp(m_nAxis).ToString()
                );
        }

        private const float _X0 = -60.0f;
        private const float _Y0 = -5.0f;
        private const float _Z0 = 0.0f;
        private void button1_Click(object sender, EventArgs e)
        {

            // X : Axis1, -5 ~ +5
            // Y : Axis0, -50 ~ -60





            Ojw.CTimer CTmr = new Ojw.CTimer();
            CTmr.Set();
            float fRang = 10;

            // Move
            Move(0, 10, 0, 100);
            Move(10, 10, 0, 100);
            Move(10, 0, 0, 100);
            Move(0, 0, 0, 100);

            float fXc = 5.0f;
            float fYc = 5.0f;
            float fZc = 0.0f;
            float fLength = 2.5f;

            float fRatio = 50.0f;
            int nTime = 10;// 10;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < fRatio; i++)
                {
                    Move(
                        fXc + fLength * Ojw.CMath.Cos(360.0f / fRatio * (i + 1)),
                        fYc + fLength * Ojw.CMath.Sin(360.0f / fRatio * (i + 1)),
                        fZc, nTime
                        );
                }
            }
            //Move(0, 0, 0, 10, 10, 0, 1.0f, false);
            //Move(10, 0, 0, 10, 10, 0, 1.0f, false);
            //Move(10, 10, 0, 10, 10, 0, 1.0f, false);
            //Move(10, 10, 0, 10, 0, 0, 1.0f, false);
            //Move(10, 10, 0, 0, 0, 0, 1.0f, false);
            //Move(10, 10, 0, 0, 0, 0, 1.0f, false);


            Move(0, 0, 0, 1000);

            // Wait
            m_CMotor.Wait(m_nTime);

            //Request
            m_CMotor.Request_MotorData(m_nAxis);
            m_CMotor.Request_Version(m_nAxis);

            // Display
            Ojw.CMessage.Write(
                m_CMotor.GetVersion(m_nAxis).ToString() + "," +
                m_CMotor.GetAngle(m_nAxis).ToString() + "," +
                m_CMotor.GetTemp(m_nAxis).ToString()
                );
        }

        /////////////////////////
        //////// Control ////////
        /////////////////////////
        #region 
        private void Move(double dX0, double dY0, double dZ0, double dX1, double dY1, double dZ1, double dStep, bool bContinue)
        {
            double dLength = Math.Sqrt((dX1 - dX0) * (dX1 - dX0) + (dY1 - dY0) * (dY1 - dY0) + (dZ1 - dZ0) * (dZ1 - dZ0));
            double dX, dY, dZ;
            double[] adAngle = new double[3];
            double dTmp = dLength / dStep;
            int nCnt = (int)Math.Round(dTmp);
            int nStart = ((bContinue == true) ? 1 : 0);
            for (int i = nStart; i <= nCnt; i++)
            {
                if (m_CMotor.IsStop() == true) return;
                if (i == 0)
                {
                    dX = dX0;
                    dY = dY0;
                    dZ = dZ0;
                }
                else if (i == nCnt)
                {
                    dX = dX1;
                    dY = dY1;
                    dZ = dZ1;
                }
                else
                {
                    dX = dX0 + (dX1 - dX0) / dLength * dStep * i;
                    dY = dY0 + (dY1 - dY0) / dLength * dStep * i;
                    dZ = dZ0 + (dZ1 - dZ0) / dLength * dStep * i;
                }
                //if (InverseKinematics(dZ, -dX, -dY, out adAngle[0], out adAngle[1], out adAngle[2]) == false) m_CMotor.IsStop() = true;
                //Move(adAngle[0], adAngle[1], adAngle[2], m_nSpeed);//_SPD);   
                Move(dX, dY, dZ, m_nSpeed);//_SPD);   
            }
        }
        private const int _SPD = 30;//10;//30;//20;
        private const double _STEP = 0.1;//0.1;//0.008;//2;//1.0;//0.5;//1.0;
        private int m_nSpeed = _SPD;
        private double m_dStep = _STEP;
        private void Move(double dAngle0, double dAngle1, double dAngle2, int nSpeed)
        {
            if (m_CMotor.IsStop() == true) return;

            // 실제로 모터의 동작/
            m_CMotor.Move(nSpeed, (new Ojw.SAxis_t(0, _X0 + (float)dAngle0)), (new Ojw.SAxis_t(1,  _Y0 + (float)dAngle1)), (new Ojw.SAxis_t(2, _Z0 + (float)dAngle2)));

            // Wait
            m_CMotor.Wait(nSpeed);
        }
        #endregion
    }
}
