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

        /////////////////////////
        //////// Control ////////
        /////////////////////////

    }
}
