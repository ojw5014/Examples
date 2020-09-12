using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace Param
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.CParam m_CParam = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            m_CParam = new Ojw.CParam(
                txtParam0,
                txtParam1,
                txtParam2,
                txtParam3,
                chkParam0,
                chkParam1,
                chkParam2,
                cmbParam0,
                cmbParam1,
                rdParam0,
                rdParam1,
                rdParam2,
                rdParam3,
                rdParam4,
                rdParam5
                );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_CParam.Param_Save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            m_CParam.Param_Load();
        }
    }
}
