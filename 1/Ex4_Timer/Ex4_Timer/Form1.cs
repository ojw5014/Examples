using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For Use
//  1. 참조 - 참조추가 - 찾아보기 - DLL 선택(OpenJigWare.dll)
//  2. add "using OpenJigWare" as follow
using OpenJigWare;

namespace Ex4_Timer
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
            btnWait.Enabled = false;
            lbWait.Text = "Running...";

            // Wait sample
            Ojw.CTimer.Wait(5000);

            lbWait.Text = "End";
            btnWait.Enabled = true;
        }

        private Ojw.CTimer m_CTId_0 = new Ojw.CTimer();
        private void btnSet_Click(object sender, EventArgs e)
        {
            m_CTId_0.Set();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            long lData = m_CTId_0.Get();
            lbGet.Text = lData.ToString() + " ms";
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            lbCurrent.Text = Ojw.CTimer.GetYear() + "/" +
                Ojw.CTimer.GetMonth() + "/" +
                Ojw.CTimer.GetDay() +
                " " +
                Ojw.CTimer.GetHour() + ":" +
                Ojw.CTimer.GetMinute() + ":" +
                Ojw.CTimer.GetSecond();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Ojw.CTimer.KillWait();
        }
    }
}
