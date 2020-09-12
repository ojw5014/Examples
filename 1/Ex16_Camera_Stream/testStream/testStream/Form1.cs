using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace testStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.CStream_Server m_CStreamServer = new Ojw.CStream_Server();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Cam_Click(object sender, EventArgs e)
        {
            int nCam = Ojw.CConvert.StrToInt(txtCam.Text);
            int nPort = Ojw.CConvert.StrToInt(txtPort.Text);
            int nWidth = Ojw.CConvert.StrToInt(txtW.Text);
            int nHeight = Ojw.CConvert.StrToInt(txtH.Text);
            m_CStreamServer.Start(nCam, nPort, nWidth, nHeight);
        }

        private void btnStart_Screen_Click(object sender, EventArgs e)
        {
            int nPort = Ojw.CConvert.StrToInt(txtPort.Text);
            int nWidth = Ojw.CConvert.StrToInt(txtW.Text);
            int nHeight = Ojw.CConvert.StrToInt(txtH.Text);
            m_CStreamServer.Start(nPort, nWidth, nHeight);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_CStreamServer.Stop();
        }
    }
}
