using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace OpenJigHand
{
    public partial class Main : Form
    {
        private Ojw.C3d m_C3d = new Ojw.C3d();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            m_C3d.FileOpen();
        }
    }
}
