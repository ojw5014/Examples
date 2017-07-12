using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.COjwMotor m_CMotor = new Ojw.COjwMotor();
        private Ojw.CParam m_CParam = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);
            m_CParam = new Ojw.CParam(
                txtPort,
                txtBaud,
                txtID2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_CParam.Param_Save();
            if (m_CMotor.IsConnect() == true) m_CMotor.DisConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_CMotor.IsConnect() == true) 
            {
                Ojw.CMessage.Write_Error("포트가 이미 연결되어 있습니다.");
                return;
            }
            int nPort = Ojw.CConvert.StrToInt(txtPort.Text);
            int nBaud = Ojw.CConvert.StrToInt(txtBaud.Text);
            if (m_CMotor.Connect(nPort, nBaud) == true)
            {
                //if (m_CMotor.Controller_GetStatus1()
                Ojw.CMessage.Write("포트오픈");

                
            }
            else Ojw.CMessage.Write_Error("포트 안열림");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_CMotor.DisConnect();
            Ojw.CMessage.Write("Port 종료");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //Request
            bool bFind = false;
            Ojw.CMessage.Write2("Progress=");
            int i = 0;
            for (int nPos = -1; nPos < 253; nPos++)
            {
                if (nPos == -1)
                {
                    i = 253;
                }
                else i = nPos;

                m_CMotor.ReadMpsuRam(i, 0, 2);
                if (m_CMotor.WaitReceive_Mpsu(30) == true)
                {
                    bFind = true;
                    int nID = m_CMotor.GetData_Mpsu_Ram(0);
                    txtID.Text = Ojw.CConvert.IntToStr(nID);
                    Ojw.CMessage.Write("Found : ID = {0}", nID);

                    break;
                }
                if ((i % 25) == 0)
                {
                    Ojw.CMessage.Write2("#");
                    Application.DoEvents();
                }
            }
            Ojw.CMessage.Write2("\r\n");
            Ojw.CMessage.Write2("\r\n");
            Ojw.CMessage.Write2("\r\n");
            if (bFind == false)
            {
                Ojw.CMessage.Write("Cannot find");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int nID = Ojw.CConvert.StrToInt(txtID.Text);
            int nID2 = Ojw.CConvert.StrToInt(txtID2.Text);
            m_CMotor.Mpsu_Write_Rom(nID, 7, (byte)nID2);
            m_CMotor.Mpsu_Write_Ram(nID, 0, (byte)nID2);
        }
    }
}
