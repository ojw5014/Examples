using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace testDelta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Ojw.CMonster2 m_CMon = new Ojw.CMonster2();
        private Ojw.CParam m_CParam;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (m_CMon.IsOpen())
            {
                m_CMon.Close();
                btnConnect.Text = "Connect";
            }
            else
            {
                int nPort = Ojw.CConvert.StrToInt(txtPort.Text);
                int nBaud = Ojw.CConvert.StrToInt(txtBaud.Text);

                int nID_Front = Ojw.CConvert.StrToInt(txtID0.Text);
                int nID_Left = Ojw.CConvert.StrToInt(txtID1.Text);
                int nID_Right = Ojw.CConvert.StrToInt(txtID2.Text);

                m_CMon.Open(nPort, nBaud);
                if (m_CMon.IsOpen())
                {
                    btnConnect.Text = "Disconnect";
                    m_CMon.AutoSet();

                    m_CMon.SetTorq(true);

                    m_CMon.Delta_Clear();
                    m_CMon.Delta_Add(0, nID_Front, nID_Left, nID_Right, 55, 100, 320, 20);

                    m_CMon.SetDelta(0, 0, 0, 200);

                    m_CMon.Send_Motor(1000);
                }
            }
            //m_CMon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.printf_Init(txtPrint);
            m_CParam = new Ojw.CParam(
                txtPort,
                txtBaud,
                txtID0,
                txtID1,
                txtID2,
                txtX,
                txtY,
                txtZ);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_CParam.Param_Save();
            m_CMon.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            float fX = Ojw.CConvert.StrToFloat(txtX.Text);
            float fY = Ojw.CConvert.StrToFloat(txtY.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtZ.Text);




            //m_CMon.SetDelta(0, 0, 0, 200);


#if true
            m_CMon.Delta_Clear();
            m_CMon.Delta_Add(0, 1, 2, 3, 55, 100, 320, 20);
#endif


            //float fX2, fY2, fZ2;
            m_CMon.SetDelta(0, fX, fY, fZ);
            //m_CMon.GetDelta(0, out fX2, out fY2, out fZ2);
            //float fD = (float)Math.Sqrt((float)Math.Pow(fX - fX2, 2) + (float)Math.Pow(fY - fY2, 2) + (float)Math.Pow(fZ - fZ2, 2));
            
            //if (fD < 0.01)
            //{
                m_CMon.Send_Motor(1000);
            //}
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            float fX2, fY2, fZ2;

#if true
            m_CMon.Delta_Clear();
            m_CMon.Delta_Add(0, 1, 2, 3, 55, 100, 320, 20);
#endif



            float fX = Ojw.CConvert.StrToFloat(txtX.Text);
            float fY = Ojw.CConvert.StrToFloat(txtY.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtZ.Text);

            m_CMon.GetDelta(0, out fX2, out fY2, out fZ2);
            float fD = (float)Math.Sqrt((float)Math.Pow(fX - fX2, 2) + (float)Math.Pow(fY - fY2, 2) + (float)Math.Pow(fZ - fZ2, 2));

            Ojw.printf("XYZ = {0}, {1}, {2}, diff = {3}\r\n", fX2, fY2, fZ2, fD);
        }
    }
}
