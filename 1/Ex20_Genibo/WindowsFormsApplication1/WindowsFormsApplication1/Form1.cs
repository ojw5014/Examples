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

        private Ojw.CGenibo_Bt m_CGenibo = new Ojw.CGenibo_Bt();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //if (m_CGenibo.Connect(txtIp.Text) == true)
            //{
            //    m_CGenibo.Auth("geniibo", "1234");
            //    m_CGenibo.ActionPlay(true, "7.act", false, false, 100);
            //    m_CGenibo.DisConnect();
            //}
            if (m_CGenibo.connected() == false)
            {
                if (m_CGenibo.connect(5, 115200) == true)
                {
                    btnConnect.Text = "Disconnect";
                }
            }
            else
            {
                btnConnect.Text = "Connect";
                m_CGenibo.disconnect();
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (m_CGenibo.connect(5, 115200) == true)
            {
                m_CGenibo.Cmd_Bluetooth_Play(0x20, 0, txtMotion.Text); m_CGenibo.disconnect();
            }
        }

        private Ojw.COjwMotor m_CMotor = new Ojw.COjwMotor();
        private void btnMoveMpsu_Click(object sender, EventArgs e)
        {
            if (m_CMotor.Connect(5, 115200) == true)
            {
                int nId = Ojw.CConvert.StrToInt(txtId.Text);
                m_CMotor.DrvSrv(true, true);
                m_CMotor.Mpsu_Play_Motion(nId, Ojw.CConvert.StrToInt(txtMotionNumber.Text), false);
                m_CMotor.DisConnect();
            }
        }
    }
}
