using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace testGetStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.CStream m_CStream = new Ojw.CStream();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            m_CStream.Start_MJpeg(picDisp, "192.168.20.117", 8081, 640, 480);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_CStream.Stop();
        }
    }
}
