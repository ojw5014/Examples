using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace shmtest0
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
            m_shmData.Shm_Write_Struct(1, txtStruct_Int.Text);//Ojw.CConvert.StrToInt(txtCmd.Text));
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
            Ojw.CMessage.Write("{0}", m_shmData.Shm_Read_Str(1));
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
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public byte [] lpData;
        }
        private const int WM_COPYDATA = 0x004A;
        public static bool SendMessage(String strProgram, byte [] pbyteData)
        {
            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            cds.dwData = IntPtr.Zero;
            cds.cbData = pbyteData.Length;
            cds.lpData = pbyteData;

            //String strTitle = Ojw.CFile.GetTitle(strProgram);
            //Process[] pro = Process.GetProcessesByName(strTitle);

            //SendMessage(pro[0].MainWindowHandle, WM_COPYDATA, 0, ref cds);
            //return true;

            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            String strTitle = Ojw.CFile.GetName(strProgram); //Ojw.CFile.GetTitle(strProgram);
            Process[] processes = System.Diagnostics.Process.GetProcesses();
            bool bRunning = false;

            foreach (System.Diagnostics.Process process in processes)
            {

                if (process.ProcessName.ToLower() == strTitle.ToLower())
                {
                    //IntPtr handle = FindWindowEx(process.MainWindowHandle, new IntPtr(0), strTitle, null);

                    //if (handle.ToInt32() > 0)
                    //{
                    //SendMessage(process.MainWindowHandle, WM_COPYDATA, 0, pbyData);
                    SendMessage(process.MainWindowHandle, WM_COPYDATA, 0, ref cds);

                    bRunning = true;
                    //}
                    break;
                }
            }
            return bRunning;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, ref COPYDATASTRUCT lParam);
        protected override void WndProc(ref Message m) 
        {
            string strData;
            
            if (Ojw.CSystem.CheckEvent_WndProc(m, out strData) == true)
            {
                Ojw.CMessage.Write("SendMessage: {0}", strData);
            }

            base.WndProc(ref m); 
        }

        private void btnSendProc_Click(object sender, EventArgs e)
        {
            byte[] pbyteData = Ojw.CConvert.StrToBytes(txtSend.Text);
            Ojw.CSystem.SendMessage(txtProgram.Text, (uint)(Ojw.CConvert.StrToInt(txtAddress0.Text) + Ojw.CConvert.StrToInt(txtAddress1.Text)), pbyteData);
        }
    }
}
