using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenJigWare;
using OpenJigWare.LattePanda;
namespace Arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CArduino m_CArduino;// = new Ojw.CLattePanda.CArduino();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool bOpen = ((m_CArduino == null) || (m_CArduino.IsOpen() == false)) ? false : true;
            if (bOpen == true)
            {
                btnOpen.Text = "Open";
                m_CArduino.Close();
            }
            else
            {
                m_CArduino = new CArduino("COM34", 57600, true, 100, true);
                if (m_CArduino.IsOpen() == true)
                {
                    btnOpen.Text = "Close";

                    m_CArduino.pinMode(9, CArduino.INPUT);
                    Ojw.Log("Pin={0}", m_CArduino.digitalRead(9));

                    m_CArduino.digitalPinUpdated += new DigitalPinUpdated(m_CArduino_digitalPinUpdated);
                    m_CArduino.StartListen();

                }
                else btnOpen.Text = "Open";
            }
        }

        void m_CArduino_digitalPinUpdated(byte pin, byte state)
        {
            //throw new NotImplementedException();
            Ojw.Log("Pin[{0}]={1}", pin, state);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.Log_Init(txtMessage);
            Ojw.C3d m_C3d = new Ojw.C3d();
            m_C3d.Init();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            Ojw.Log("Pin={0}", m_CArduino.digitalRead(9));
        }
    }
}
