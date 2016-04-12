using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.C3d m_C3d = new Ojw.C3d();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Init
            m_C3d.Init(picDisp);

            // PropertyWindow
            m_C3d.CreateProb_VirtualObject(pnProperty);

            if (m_C3d.FileOpen("16dof_ecoHead.ojw") == true) // Modeling file open(it has 18.ase cad data)
            {
                m_C3d.Gridview_Init(dgAngle, 70, 999);

                tmrDraw.Enabled = true;
            }
        }

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            m_C3d.OjwDraw();
        }
    }
}
