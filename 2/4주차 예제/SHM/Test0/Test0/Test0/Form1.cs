using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace Test0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct SData_My
        {
            public int nData0;
            public int nData1;
        }
        private SData_My m_SMy = new SData_My();

        private struct SData_Other
        {
            public float fData0;
            public float fData1;
        }
        private SData_Other m_SOther = new SData_Other();

        private Ojw.CSystem.CShm_Var m_CShm_My = new Ojw.CSystem.CShm_Var();
        //private Ojw.CSystem.CShm_Var m_CShm_Other = new Ojw.CSystem.CShm_Var();
        private void Form1_Load(object sender, EventArgs e)
        {
            m_CShm_My.Shm_Init_Server("Shm", m_SMy);
            //m_CShm_Other.Shm_Init_Client("Shm_Other", m_SOther);

            tmrTest.Enabled = true;
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            lbData0.Text = String.Format("My = {0}, {1}", m_SMy.nData0, m_SMy.nData1);
            //lbData1.Text = String.Format("Other = {0}, {1}", m_SOther.fData0, m_SOther.fData1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_CShm_My.Shm_DInit();
            //m_CShm_Other.Shm_DInit();
        }

        private void btnDataSet0_Click(object sender, EventArgs e)
        {
            m_SMy.nData0 = Ojw.CConvert.StrToInt(txtData0.Text);
        }

        private void btnDataSet1_Click(object sender, EventArgs e)
        {
            m_SMy.nData1 = Ojw.CConvert.StrToInt(txtData1.Text);
        }
    }
}
