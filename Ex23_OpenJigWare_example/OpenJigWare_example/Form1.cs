using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace OpenJigWare_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.CParam m_CParam;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Message
            Ojw.CMessage.Init(txtMessage);
            Ojw.CMessage.Init_File(true);
            #endregion Message

            m_CParam = new Ojw.CParam(checkBox1, checkBox2, radioButton1, radioButton2, textBox1, textBox2, textBox3, comboBox1);
            Init3d();

            // 노트패드(notepad.exe) 를 내가 지정한 곳에 출력되게 하기
            Ojw.CSystem.RunProgram(lbNotepad.Handle, "notepad.exe", 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_CStreamServer.IsRunning() == true) m_CStreamServer.Stop();
            if (m_CStream.IsStreaming == true) m_CStream.Stop();
            if (m_CCam.IsRunning() == true) m_CCam.Stop();

            m_CParam.Param_Save();
        }

        #region Camera
        private Ojw.CCamera m_CCam = new Ojw.CCamera();
        private void btnCamStart_Click(object sender, EventArgs e)
        {
            m_CCam.Init(lbCam, 0);
            m_CCam.Start();
        }

        private void btnCamStop_Click(object sender, EventArgs e)
        {
            m_CCam.Stop();
        }
        #endregion Camera

        #region Stream
        private Ojw.CStream_Server m_CStreamServer = new Ojw.CStream_Server();
        private void btnCamServerStart_Click(object sender, EventArgs e)
        {
            // 이버튼을 클릭하고 크롬에서 http://127.0.0.1:8080 에서 확인해 볼것.

            if (m_CStreamServer.IsRunning() == true) m_CStreamServer.Stop();
            if (m_CStream.IsStreaming == true) m_CStream.Stop();

            m_CStreamServer.Start(8080); // 0번 카메라 영상 송출
            
            // 인터넷에 올라간 영상을 가져와서 내 컴퓨터에 뿌린다.
            m_CStream.Start_MJpeg(lbCam2, "http://127.0.0.1:8080", lbCam2.Width, lbCam2.Height);
        }
        private void btnCamServerStart2_Click(object sender, EventArgs e)
        {
            // 이버튼을 클릭하고 크롬에서 http://127.0.0.1:8080 에서 확인해 볼것.

            if (m_CStreamServer.IsRunning() == true) m_CStreamServer.Stop();
            if (m_CStream.IsStreaming == true) m_CStream.Stop();

            m_CStreamServer.Start(0, 8080); // 0번 카메라 영상 송출

            // 인터넷에 올라간 영상을 가져와서 내 컴퓨터에 뿌린다.
            m_CStream.Start_MJpeg(lbCam2, "http://127.0.0.1:8080", lbCam2.Width, lbCam2.Height);
        }
        private Ojw.CStream m_CStream = new Ojw.CStream();
        private void btnCamServerStop_Click(object sender, EventArgs e)
        {
            if (m_CStreamServer.IsRunning() == true) m_CStreamServer.Stop();
            if (m_CStream.IsStreaming == true) m_CStream.Stop();
        }
        #endregion Stream

        

        #region 3D
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private void Init3d()
        {
            m_C3d.Init(lb3d);
            m_C3d.CreateProb_VirtualObject(lb3d_property);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            m_C3d.FileOpen();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            m_C3d.OjwDraw();
        }
        #endregion 3D

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Ojw.ShowKeyPad_Number(sender);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Ojw.ShowKeyPad_Alpha(sender);
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Ojw.CTools_Keyboard m_CKeyboard = new Ojw.CTools_Keyboard();
            m_CKeyboard.SetOpacity(0.5f); // 반투명하게
            m_CKeyboard.ShowKeyboard(0.5f); // 크기를 반으로
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string strArgument = String.Format(@"//select, {0}", Application.StartupPath);

            Ojw.CMessage.Write("Clicked btnHistoryFolder -> Open path ({0})", strArgument);
            Ojw.CSystem.RunProgram("explorer.exe", strArgument, 0); // 0 : 중복 허용, 1 : 기존 탐색기 전부 종료, 중복 실행 허용 안함
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Ojw.CSystem.ShutDown(0);
        }
    }
}
