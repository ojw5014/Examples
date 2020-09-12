using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace Ex13_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Panel[] m_pnPage = new Panel[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                m_pnPage[i] = new Panel();
            }

            #region Docking
            i = 0;
            Ojw.CSystem.Docking_Init();
            Form2 frmPage2 = new Form2();
            Form3 frmPage3 = new Form3();
            Form4 frmPage4 = new Form4();
            Ojw.CSystem.Docking(false, frmPage2, ref pn0);
            Ojw.CSystem.Docking(false, frmPage3, ref pn1);
            Ojw.CSystem.Docking(false, frmPage4, ref pn2);
            #endregion region Docking


        }
    }
}
