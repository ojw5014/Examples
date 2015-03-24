using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For Use
//  1. 참조(reference) - 참조추가(add reference) - 찾아보기(searching tab) - DLL 선택(OpenJigWare.dll)
//  2. add "using OpenJigWare" as follow
using OpenJigWare;

namespace Ex7_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Ojw.CGraph m_CGrap = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Graph
            m_CGrap = new Ojw.CGraph(lbDisp, lbDisp.Width, Color.White, null, Color.Red, Color.Blue);

            timer1.Enabled = true;
        }

        private int m_nTest0 = 0, m_nTest1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Making some random data for testing
            int nTarget = 50;
            m_nTest0 = (m_nTest0 + 1) % nTarget;
            int nTarget2 = 80;
            m_nTest1 = (m_nTest1 + 1) % nTarget2;

            lbTest0.Text = m_nTest0.ToString();
            lbTest1.Text = m_nTest1.ToString();

            // push your datas...
            m_CGrap.Push(m_nTest0, m_nTest1);

            // Drawing...
            m_CGrap.OjwDraw();
        }
    }
}
