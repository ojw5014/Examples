using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;
using System.Diagnostics;

namespace Ex14_Exe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 메세지 출력 준비
            Ojw.CMessage.Init(txtMessage);
            
        }

        private Process m_ps = null;
        private void btnVirtualKeyboard_Click(object sender, EventArgs e)
        {
#if false
            // 화상키보드 실행
            //%windir%\system32\osk.exe
            //Process ps = Ojw.CSystem.RunProgram(pnKeyboard.Handle, @"C:\Windows\System32\osk.exe");
            //Process ps = Ojw.CSystem.RunProgram(pnKeyboard.Handle, @"C:\Windows\System32\notepad.exe");
            //Process ps = Ojw.CSystem.RunProgram(@"C:\Windows\System32\notepad.exe");



            string strPath = String.Format("TabTip.exe", Ojw.CSystem.GetPath_Windows());
            //string strPath = String.Format(@"{0}\System32\osk.exe", Ojw.CSystem.GetPath_Windows());
            m_ps = Ojw.CSystem.RunProgram(strPath);
            //Ojw.CSystem.MoveProgram(ps.MachineName, 0, 0, 100, 200);
            //Ojw.CSystem.RunProgram(pnKeyboard.Handle, @"C:\Windows\System32\notepad.exe");
#endif
            Ojw.CSystem.ScreenKeyboard(-500, 0, 300, 100);

            string strPath = String.Format(@"{0}\System32\osk.exe", Ojw.CSystem.GetPath_Windows());
            m_ps = Ojw.CSystem.RunProgram(strPath);

            //Ojw.CTimer.Wait(1000);
            //Ojw.CSystem.RunVirtualKeyboard(0, 0, 100, 200);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (m_ps != null)
            //{
            //    Ojw.CSystem.KillProgram(m_ps);
            //}
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int nX = Ojw.CConvert.StrToInt(txtX.Text);
            int nY = Ojw.CConvert.StrToInt(txtY.Text);
            //Ojw.CSystem.MoveProgram(m_ps.MachineName, nX, nY, 100, 200);
            Ojw.CSystem.ScreenKeyboard(nX, nY);
        }

        private void btnMove2_Click(object sender, EventArgs e)
        {
            int nX = Ojw.CConvert.StrToInt(txtX2.Text);
            int nY = Ojw.CConvert.StrToInt(txtY2.Text);
            int nW = Ojw.CConvert.StrToInt(txtWidth2.Text);
            int nH = Ojw.CConvert.StrToInt(txtHeight2.Text);
            Ojw.CSystem.ScreenKeyboard(nX, nY, nW, nH);
        }
    }
}
