using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare; // DLL

namespace testGraph
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
            m_CGrap = new Ojw.CGraph(label1, label1.Width, Color.White, null, Color.Red, Color.Blue); // Red & Blue

            timer1.Enabled = true;
        }


        private int m_nTest_Red = 0;
        private int m_nTest_Blue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int nTarget = 50;
            m_nTest_Blue = (m_nTest_Blue + 1) % nTarget;
            lbBlue.Text = m_nTest_Blue.ToString();

            nTarget = 80;
            m_nTest_Red = (m_nTest_Red + 1) % nTarget;
            lbRed.Text = m_nTest_Red.ToString();

            // push your datas ...
            m_CGrap.Push(m_nTest_Red, m_nTest_Blue);

            // Drawing...
            m_CGrap.OjwDraw();
        }
    }
}
