using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;
using System.Threading;

#if false
using Microsoft.Xna.Framework.Input;
Microsoft.Xna.Framework.Input.GamePad.SetVibration(0, (float)0.0, (float)0.0);
#endif


namespace Joystic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Ojw.C3d m_C3d = new Ojw.C3d();

        private Ojw.CJoystick m_CJoy;// = new Ojw.CJoystick(JOYSTICKID1);
        private Thread thRun;
        private void frmMain_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);
            m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

            m_C3d.Init(lbDisp);// (picDisp);
            m_C3d.SetScale(0.3f);
            m_C3d.SetPos_Display(0, 50, 0);
            //CheckForIllegalCrossThreadCalls = false;
            if (m_C3d.FileOpen(@"Joystick.ojw") == true)
            {
                m_C3d.OjwDraw();

#if false
                m_bThread = true;
                thRun = new Thread(new ThreadStart(Thread_Run));
                thRun.Start();
#else
                tmrDisp.Enabled = true;
#endif
            }
            else Application.Exit();
        }
        private bool m_bThread = false;
        private void Thread_Run()
        {
            while (m_bThread)
            {
                m_C3d.OjwDraw();
                Application.DoEvents();
                //Thread.Sleep(1000);
            }
        }

        private float[] m_afAngle = new float[20];
        private Ojw.CTimer m_CTmrJoystick = new Ojw.CTimer();
        private void tmrDisp_Tick(object sender, EventArgs e)
        {
            //int nGa, nGb, nGc;
            //int nNum;
            //bool bPick, bLimit;
            //m_C3d.OjwDraw(m_afAngle, out nGa, out nGb, out nGc, out nNum, out bPick, out bLimit);

            //if ((bPick == true) && (nGa > 0))
            //{
            //    m_afAngle[nGb] = 10;
            //    //if (nGb == 0) // 0번 축 선택
            //    //{
            //    //}
            //}
            //else
            //{
            //    Array.Clear(m_afAngle, 0, m_afAngle.Length);
            //}
            m_CJoy.Update();

            if ((m_CTmrJoystick.IsTimer() == false) || (m_CTmrJoystick.Get() > 1000))
            {
                Ojw.CMessage.Write("{0}, {1}, {2}, {3}, {4}, {5}",
                    m_CJoy.GetPos(0),
                    m_CJoy.GetPos(1),
                    m_CJoy.GetPos(2),
                    m_CJoy.GetPos(3),
                    m_CJoy.GetPos(4),
                    m_CJoy.GetPos(5));

                m_CTmrJoystick.Set();
            }
            //lbX0.Text = m_CJoy.X.ToString();
            //lbY0.Text = m_CJoy.Y.ToString();

            //lbX1.Text = m_CJoy.SpinX.ToString();
            //lbY1.Text = m_CJoy.SpinY.ToString();
            //lbUp.Text = ((m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true) ? "true" : "false");
            //lbDown.Text = ((m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button2) == true) ? "true" : "false");

            // 스틱좌상단, 0+ - 좌, 1+ - 하
            // 패드 2+ - 좌, 3+ - 하
            // 스틱우하단, 4+ - 좌, 5+ - 하
            // 버튼
            // Top 6 - -3 : 클릭
            // Left 7 - -3 : 클릭
            // Right 8 - -3 : 클릭
            // Bottom 9 - -3 : 클릭
            // 전면우측 10 - -3 : 클릭
            // 전면좌측 11 - -3 : 클릭
            // 전면우측아래 12- : 클릭
            // 전면좌측아래 13- : 클릭
            float fDown = -3.0f;
            float fUp = 0.0f;
            int nNum = 0;
            // Up
            nNum = 4;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button4) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Left
            nNum = 3;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button3) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Right
            nNum = 2;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button2) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Down
            nNum = 1;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Front Left
            nNum = 6;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button6) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Front Right
            nNum = 5;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button5) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;


            // Back
            nNum = 7;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button7) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;

            // Start
            nNum = 8;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button8) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;

            // 좌상단 조이스틱
            nNum = 9;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button9) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            m_afAngle[13] = (float)(20.0 * (m_CJoy.dX0 - 0.5));
            m_afAngle[14] = (float)(20.0 * (m_CJoy.dY0 - 0.5));

            // 우하단 조이스틱
            nNum = 10;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button10) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            m_afAngle[15] = (float)(20.0 * (m_CJoy.dX1 - 0.5));
            m_afAngle[16] = (float)(20.0 * (m_CJoy.dY1 - 0.5));

            // 슬라이드
            m_afAngle[17] = ((m_CJoy.Slide >= 0.5) ? (float)(20.0 * (0.5 - m_CJoy.Slide)) : 0.0f); // 좌
            m_afAngle[18] = ((m_CJoy.Slide <= 0.5) ? (float)(20.0 * (m_CJoy.Slide - 0.5)) : 0.0f); // 우

            // 패드 11+ - 좌, 12+ - 하
            nNum = 11;
            m_afAngle[nNum] = 0.0f;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVLeft) == true) m_afAngle[nNum] = -10.0f;
            //else m_afAngle[nNum] = fUp;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVRight) == true) m_afAngle[nNum] = 10.0f;
            //else m_afAngle[nNum] = fUp;
            nNum = 12;
            m_afAngle[nNum] = 0.0f;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVUp) == true) m_afAngle[nNum] = -10.0f;
            //else m_afAngle[nNum] = fUp;
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVDown) == true) m_afAngle[nNum] = 10.0f;
            //else m_afAngle[nNum] = fUp;

            for (int i = 0; i < 20; i++)
            {
                //if (m_CJoy.IsDown((Ojw.CJoystick.PadKey)((int)Ojw.CJoystick.PadKey.Button7 + i)) == true)
                if (m_CJoy.IsDown((Ojw.CJoystick.PadKey)((int)Ojw.CJoystick.PadKey.Button1 + i)) == true)
                    Ojw.CMessage.Write((7 + i).ToString());
            }

            m_C3d.OjwDraw(m_afAngle);
        }

        private bool m_bProgEnd = false;
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_bProgEnd = true;
            m_bThread = false;
        }
    }
}
