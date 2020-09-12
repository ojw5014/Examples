using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace CHerkulex2_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variable
        
        private Ojw.CHerkulex2 m_CMotor = new Ojw.CHerkulex2();

        #endregion Variable

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);

            cmbMotorType.SelectedIndex = 5;
            cmbMotorType_Second.SelectedIndex = 5;


        }

        private void cmbMotorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonEn(bool bEn)
        {
            txtComport.Enabled = bEn;
            txtBaudrate.Enabled = bEn;

            txtID.Enabled = bEn;
            cmbMotorType.Enabled = bEn;

            txtID_Second.Enabled = bEn;
            cmbMotorType_Second.Enabled = bEn;            
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            int nPort = Ojw.CConvert.StrToInt(txtComport.Text);
            int nBaud = Ojw.CConvert.StrToInt(txtBaudrate.Text);
            if (m_CMotor.Open(nPort, nBaud) == true)
            {
                int nID = Ojw.CConvert.StrToInt(txtID.Text);
                int nID2 = Ojw.CConvert.StrToInt(txtID_Second.Text);
                int nType = cmbMotorType.SelectedIndex + 1;
                int nType2 = cmbMotorType_Second.SelectedIndex + 1;
#if false
                int nModel = 0;
                if (nType == 0)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0101;
                }
                else if (nType == 1)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0102;
                }
                else if (nType == 2)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0201;
                }
                else if (nType == 3)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0202;
                }
                else if (nType == 4)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0401;
                }
                else if (nType == 5)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0402;
                }
                else if (nType == 6)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0601;
                }
                else if (nType == 7)
                {
                    nModel = (int)Ojw.CHerkulex2._MODEL_DRS_0602;
                }
                m_CMotor.SetParam(nID, nModel);
#else
                m_CMotor.SetParam(nID, nType);
                m_CMotor.SetParam(nID2, nType2);
#endif
                ButtonEn(false);
                Ojw.CMessage.Write("Connected SerialPort");
            }
            else
            {
                ButtonEn(true);
                Ojw.CMessage.Write_Error("Connection Error(Port = {0}, Baud = {1}", nPort, nBaud);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (m_CMotor.IsOpen() == true)
            {
                m_CMotor.Close();
                ButtonEn(true);
                Ojw.CMessage.Write("Disconnect()");
            }
        }

        private void btnTorqOn_Click(object sender, EventArgs e)
        {
            m_CMotor.SetTorque(true, true);
        }

        private void btnTorqOff_Click(object sender, EventArgs e)
        {
            m_CMotor.SetTorque(false, false);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nID = Ojw.CConvert.StrToInt(txtID.Text);
            float fAngle = Ojw.CConvert.StrToFloat(txtAngle.Text);
            int nTime = Ojw.CConvert.StrToInt(txtTime.Text);
            ////// Data Set
            m_CMotor.Set_Angle(nID, fAngle);

            /////// Move
            m_CMotor.Send_Motor(nTime);
        }

        private void btnGo_Second_Click(object sender, EventArgs e)
        {
            int nID = Ojw.CConvert.StrToInt(txtID_Second.Text);
            float fAngle = Ojw.CConvert.StrToFloat(txtAngle_Second.Text);
            int nTime = Ojw.CConvert.StrToInt(txtTime_Second.Text);
            ////// Data Set
            m_CMotor.Set_Angle(nID, fAngle);

            /////// Move
            m_CMotor.Send_Motor(nTime);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_CMotor.IsOpen() == true)
            {
                m_CMotor.Close();
                Ojw.CMessage.Write_Error("Form Closing -> Disconnect Serial Port");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            m_CMotor.Reset();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // if you want to get a posture, you can get it like below... but you can get it also with m_C
            int nID = Ojw.CConvert.StrToInt(txtID.Text);
            m_CMotor.Read_Motor(nID);
            Ojw.CMessage.Write("Get Position");
            Ojw.CTimer CTmr = new Ojw.CTimer();
            CTmr.Set();

            while (m_CMotor.Read_Motor_IsReceived() == false)
            {
                if (CTmr.Get() > 1000)
                {
                    Ojw.CMessage.Write_Error("TimeOut");
                    break;
                }
                Ojw.CTimer.Wait(1);
            }
            if (m_CMotor.Read_Motor_IsReceived() == true) Ojw.CMessage.Write("Position={0}", m_CMotor.Get_Pos_Angle(nID));
            else Ojw.CMessage.Write_Error("Position=[TimeOver]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nID = Ojw.CConvert.StrToInt(txtID.Text);
            int nID_Second = Ojw.CConvert.StrToInt(txtID_Second.Text);

            float fAngle0 = Ojw.CConvert.StrToFloat(txtAngle0.Text);
            float fAngle0_Second = Ojw.CConvert.StrToFloat(txtAngle0_Second.Text);
            int nTime0 = Ojw.CConvert.StrToInt(txtTime0.Text);

            float fAngle1 = Ojw.CConvert.StrToFloat(txtAngle1.Text);
            float fAngle1_Second = Ojw.CConvert.StrToFloat(txtAngle1_Second.Text);
            int nTime1 = Ojw.CConvert.StrToInt(txtTime1.Text);

            float fAngle2 = Ojw.CConvert.StrToFloat(txtAngle2.Text);
            float fAngle2_Second = Ojw.CConvert.StrToFloat(txtAngle2_Second.Text);
            int nTime2 = Ojw.CConvert.StrToInt(txtTime2.Text);

            #region Move 0
            ////// Data Set
            m_CMotor.Set_Angle(nID, fAngle0);
            m_CMotor.Set_Angle(nID_Second, fAngle0_Second);

            /////// Move
            m_CMotor.Send_Motor(nTime0);
            m_CMotor.Wait_Delay(nTime0); // [auto-request posture] -> in this function

            Ojw.CMessage.Write("Posture[0] Command = {0}, Get = {1}", m_CMotor.Get_Angle(nID), m_CMotor.Get_Pos_Angle(nID));
            #endregion Move 0

            #region Move 1
            ////// Data Set
            m_CMotor.Set_Angle(nID, fAngle1);
            m_CMotor.Set_Angle(nID_Second, fAngle1_Second);

            /////// Move
            m_CMotor.Send_Motor(nTime1);
            m_CMotor.Wait_Delay(nTime1); // [auto-request posture] -> in this function

            Ojw.CMessage.Write("Posture[1] Command = {0}, Get = {1}", m_CMotor.Get_Angle(nID), m_CMotor.Get_Pos_Angle(nID));
            #endregion Move 1

            #region Move 2
            ////// Data Set
            m_CMotor.Set_Angle(nID, fAngle2);
            m_CMotor.Set_Angle(nID_Second, fAngle2_Second);

            /////// Move
            m_CMotor.Send_Motor(nTime2);
            m_CMotor.Wait_Delay(nTime2); // [auto-request posture] -> in this function

            Ojw.CMessage.Write("Posture[2] Command = {0}, Get = {1}", m_CMotor.Get_Angle(nID), m_CMotor.Get_Pos_Angle(nID));
            #endregion Move 2

            Ojw.CMessage.Write("Done:Test");
        }

        
    }
}
