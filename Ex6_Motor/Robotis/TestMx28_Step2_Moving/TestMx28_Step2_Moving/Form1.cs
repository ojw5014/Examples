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

namespace TestMx28_Step2_Moving
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

            //// Test Code for message checking
            //Ojw.CMessage.Write("Test: Write()");
            //Ojw.CMessage.Write2("Test: Write2()\r\n");
            //Ojw.CMessage.Write_Error("Test: Write_Error()");
            
            // Remove CrossThreadChecking
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion Step2 - Init(Using Message Command) : It's up to you if you want to use some message commands like a "printf"

        #region Step3 - Variable
        private Ojw.CMx28 m_CMx28 = new Ojw.CMx28();
        #endregion Step3 - Variable

        #region Step4 - Connect / Disconnect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (m_CMx28.IsConnect() == false)
            {
                // Ojw.CConvert.StrToInt() => [ String -> Integer ]
                m_CMx28.Connect(Ojw.CConvert.StrToInt(txtComport.Text), Ojw.CConvert.StrToInt(txtBaudrate.Text));
                if (m_CMx28.IsConnect() == true)
                {
                    btnConnect.Text = "Disconnect";
                    Ojw.CMessage.Write("Connected");
                }
                else
                {
                    m_CMx28.DisConnect();
                    btnConnect.Text = "Connect";
                    Ojw.CMessage.Write_Error("Connect Fail -> Check your COMPORT first");
                }
            }
            else
            {
                m_CMx28.DisConnect();
                btnConnect.Text = "Connect";
                Ojw.CMessage.Write("Disconnected");
            }
        }
        #endregion Step4 - Connect / Disconnect

        #region Step5 - Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ojw.CMessage.Write("Form Closing...");

            if (m_CMx28.IsConnect() == true)
                m_CMx28.DisConnect();

            Ojw.CMessage.Write("Disconnected");
        }
        #endregion Step5 - Form Closing
        
        /////////////////////////////////////////////////////////////////////////////////////////////
        // Motor Control
        /////////////////////////////////////////////////////////////////////////////////////////////
        private void btnMove_Speed_Click(object sender, EventArgs e)
        {
            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            float fAngle = Ojw.CConvert.StrToFloat(txtAngle.Text);
            float fRpm = Ojw.CConvert.StrToInt(txtSpeed.Text);
            m_CMx28.SetMot_Rpm(nMotorID, fAngle, fRpm);
        }

        private void btnMove_Time_Click(object sender, EventArgs e)
        {
            // Cautions..
            // if you use it at first time. 
            // it cannot calc exactly time value for moving. 
            // because It has only destination position. 
            // It needs source position for calcing every time.
            // so the [SetMot_Rpm] function is better when you control it at first.
            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            float fAngle = Ojw.CConvert.StrToFloat(txtAngle.Text);
            int nTime = Ojw.CConvert.StrToInt(txtTime.Text);
            m_CMx28.SetMot(nMotorID, fAngle, nTime);
        }

        private void btnTorqOn_Click(object sender, EventArgs e)
        {
            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            m_CMx28.MotTorq(nMotorID, true);
        }

        private void btnTorqOff_Click(object sender, EventArgs e)
        {
            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            m_CMx28.MotTorq(nMotorID, false);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            m_CMx28.Reset();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_CMx28.Stop();
        }

        private void btnStartMotion_Click(object sender, EventArgs e)
        {
            m_CMx28.Reset();
            m_CMx28.MotTorq(true);

            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            
            // Read First Position for Timer control
            m_CMx28.ReadMot(nMotorID);
            bool bRet = m_CMx28.WaitReceive(nMotorID, 2000);

            if (bRet == true)
            {
                int nMovingTime = Ojw.CConvert.StrToInt(txtMovingTime.Text);
                int nDelayTime = Ojw.CConvert.StrToInt(txtDelay.Text);
                int nCnt = Ojw.CConvert.StrToInt(txtLoop.Text);
                float fPos = 0.0f;
                for (int i = 0; i < nCnt; i++)
                {
                    // First
                    fPos = Ojw.CConvert.StrToFloat(txtPos0.Text);
                    m_CMx28.SetMot(nMotorID, fPos, nMovingTime);
                    m_CMx28.WaitTime(nMovingTime);

                    m_CMx28.WaitTime(nDelayTime);

                    // Second
                    fPos = Ojw.CConvert.StrToFloat(txtPos1.Text);
                    m_CMx28.SetMot(nMotorID, fPos, nMovingTime);
                    m_CMx28.WaitTime(nMovingTime);

                    m_CMx28.WaitTime(nDelayTime);

                    // Third
                    fPos = Ojw.CConvert.StrToFloat(txtPos2.Text);
                    m_CMx28.SetMot(nMotorID, fPos, nMovingTime);
                    m_CMx28.WaitTime(nMovingTime);

                    m_CMx28.WaitTime(nDelayTime);

                    // Fourth
                    fPos = Ojw.CConvert.StrToFloat(txtPos3.Text);
                    m_CMx28.SetMot(nMotorID, fPos, nMovingTime);
                    m_CMx28.WaitTime(nMovingTime);

                    m_CMx28.WaitTime(nDelayTime);
                }
            }
        }
    }
}
