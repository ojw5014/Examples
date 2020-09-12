using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace testCamera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private Ojw.CCamera m_CCam = new Ojw.CCamera();
        private void Form1_Load(object sender, EventArgs e)
        {
            m_CCam.Init(picDisp, 1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            m_CCam.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_CCam.Stop();
        }
    }
}
