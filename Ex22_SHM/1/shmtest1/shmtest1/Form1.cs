using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace shmtest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.CSystem.CShm m_shmData = new Ojw.CSystem.CShm();
        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);

            m_shmData.Shm_Open(txtShmName.Text, 100);
        }

        // make a structure for testing
        private struct STest_T
        {
            public int nTest;
            public float fTest;
            public char cTest;
        }
        private STest_T m_STest = new STest_T();

        private void btnCmd_Click(object sender, EventArgs e)
        {
#if false
            //m_shmData.Shm_Write(1, txtCmd.Text);//Ojw.CConvert.StrToInt(txtCmd.Text));
            Ojw.CMessage.Write("{0}", m_shmData.Shm_Read_Int(1));
#else
            m_STest.cTest = (txtStruct_Char.Text.Length > 0) ? txtStruct_Char.Text[0] : (char)0;
            m_STest.nTest = Ojw.CConvert.StrToInt(txtStruct_Int.Text);
            m_STest.fTest = Ojw.CConvert.StrToFloat(txtStruct_Float.Text);
            m_shmData.Shm_Write_Struct(0, m_STest);
#endif
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
#if false
            //m_shmData.Shm_Open("test", 1000);

            Ojw.CMessage.Write("{0}", m_shmData.Shm_Read_Str(1));

           // m_shmData.Shm_Close();
#else
            m_STest = (STest_T)m_shmData.Shm_Read_Structure(0, typeof(STest_T));
            Ojw.CMessage.Write("[Shm]{0}, {1}. {2}", m_STest.nTest, m_STest.fTest, m_STest.cTest);
#endif
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            m_shmData.Shm_Open(txtShmName.Text, 100);
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            m_shmData.Shm_Close();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Ojw.CSystem.SendMessage(txtProgName.Text, txtSendMessage.Text);
        }
        protected override void WndProc(ref Message m)
        {
            string strData;

            if (Ojw.CSystem.CheckEvent_WndProc(m, out strData) == true)
            {
                Ojw.CMessage.Write("SendMessage: {0}", strData);
            }

            base.WndProc(ref m);
        }
    }
}
