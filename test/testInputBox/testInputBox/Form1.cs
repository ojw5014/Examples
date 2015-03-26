using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare; // DLL

namespace testInputBox
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

        private void btnShow0_Click(object sender, EventArgs e)
        {
            string strValue = txtValue.Text;

            if (Ojw.CInputBox.Show_PasswordType(
                                    Ojw.CConvert.StrToInt(txtX.Text), Ojw.CConvert.StrToInt(txtY.Text), // X, Y
                                    txtTitle.Text,
                                    txtText.Text,
                                    ref strValue
                                    ) == DialogResult.OK)
            {
                txtValue.Text = strValue;
            }
                                    
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            string strValue = txtValue.Text;
            if (Ojw.CInputBox.Show_PasswordType(txtTitle.Text, txtText.Text, ref strValue) == DialogResult.OK)
            {
                txtValue.Text = strValue;
            }
        }
    }
}
