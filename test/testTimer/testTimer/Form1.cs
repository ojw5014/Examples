using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare; // DLL

namespace testTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            lbWait.Text = "Start";
#if false
            Ojw.CTimer.Wait(5000);
#else
            for (int i = 0; i < 5; i++)
            {
                Ojw.CTimer.Wait(1000);
                lbWait.Text = (i + 1).ToString();
            }
            if (Ojw.CTimer.IsStop() == true) lbWait.Text = "Stoped";
            else lbWait.Text = "End";
#endif

            
        }

        private void btnKillWait_Click(object sender, EventArgs e)
        {
            Ojw.CTimer.KillWait(); // It just kill the current 'wait timer' only.
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Ojw.CTimer.Stop(); // Stop all timer(for breaking )
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Ojw.CTimer.Reset();
        }


        Ojw.CTimer m_CTmr = new Ojw.CTimer(); // Variable

        private void btnSet_Click(object sender, EventArgs e)
        {
            m_CTmr.Set();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lbTime.Text = Ojw.CConvert.IntToStr(m_CTmr.Get()); // Same => m_CTmr.Get().ToString()
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            lbNow.Text = Ojw.CTimer.GetYear() + "/" +
                Ojw.CConvert.FillString(Ojw.CTimer.GetMonth().ToString(), "0", 2, false) + "/" +
                //Ojw.CTimer.GetMonth() + "/" + // 3 -> 03
                Ojw.CTimer.GetDay() + "/" +
                " " +
                Ojw.CTimer.GetHour() + "/" +
                Ojw.CTimer.GetMinute() + "/" +
                Ojw.CTimer.GetSecond();
        }
    }
}
