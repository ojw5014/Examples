using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare; // DLL

namespace test3D
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
            m_C3d.Init(pictureBox1); // Init
            m_C3d.CreateProb_VirtualObject(panel1);
            // Add Standard Axis
            m_C3d.SetStandardAxis(true);

            if (m_C3d.FileOpen("test3d.ojw") == true)
            {
                // We did draw a boat.stl in test3d.ojw file
                timer1.Enabled = true;
            }
            else Application.Exit();

        }

        private float fAngle = 0.0f;
        private void timer1_Tick(object sender, EventArgs e)
        {
            fAngle += 10.0f; // For Rotation
            m_C3d.SetData(0, fAngle);
            m_C3d.OjwDraw();
        }
    }
}
