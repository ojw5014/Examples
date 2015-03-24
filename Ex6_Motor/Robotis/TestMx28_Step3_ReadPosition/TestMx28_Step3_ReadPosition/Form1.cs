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

namespace TestMx28_Step3_ReadPosition
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
        // Read Motor
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void btnRead_Click(object sender, EventArgs e)
        {
            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            // Read First Position for Timer control
            m_CMx28.ReadMot(nMotorID);
            bool bRet = m_CMx28.WaitReceive(nMotorID, 2000);
            if (bRet == true)
            {
                Ojw.CMessage.Write("Position(Raw) : " + Ojw.CConvert.IntToStr(m_CMx28.GetPos(nMotorID)));
                Ojw.CMessage.Write("Position(Angle) : " + Ojw.CConvert.FloatToStr(m_CMx28.GetPos_Angle(nMotorID)));
            }
        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            int nMotorID = Ojw.CConvert.StrToInt(txtMotorID.Text);
            // Read First Position for Timer control
            bool bRet = m_CMx28.ReadMotAndWait(nMotorID);
            if (bRet == true)
            {
                Ojw.CMessage.Write("Position(Raw) : " + Ojw.CConvert.IntToStr(m_CMx28.GetPos(nMotorID)));
                Ojw.CMessage.Write("Position(Angle) : " + Ojw.CConvert.FloatToStr(m_CMx28.GetPos_Angle(nMotorID)));
            }
        }
    }
}
