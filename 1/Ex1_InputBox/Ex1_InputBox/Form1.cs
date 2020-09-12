using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For Use
//  1. 참조(reference) - 참조추가(add reference) - 찾아보기(searching tab) - DLL 선택(OpenJigWare.dll)
//  2. add "using OpenJigWare" as follow
using OpenJigWare;

namespace Ex1_InputBox
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

        private void btnInputBox_Show_Click(object sender, EventArgs e)
        {
            String strValue = txtValue.Text;
            if (Ojw.CInputBox.Show(Ojw.CConvert.StrToInt(txtX.Text), Ojw.CConvert.StrToInt(txtY.Text), txtTitle.Text, txtPrompt.Text, ref strValue) == DialogResult.OK)
            {
                txtValue.Text = strValue;
            }
        }
        private void btnInputBox_Show2_Click(object sender, EventArgs e)
        {
            String strValue = txtValue.Text;
            if (Ojw.CInputBox.Show(txtTitle.Text, txtPrompt.Text, ref strValue) == DialogResult.OK)
            {
                txtValue.Text = strValue;
            }
        }

        private void btnInputBox_Show_Pswd_Click(object sender, EventArgs e)
        {
            String strValue = txtValue.Text;
            if (Ojw.CInputBox.Show_PasswordType(Ojw.CConvert.StrToInt(txtX.Text), Ojw.CConvert.StrToInt(txtY.Text), txtTitle.Text, txtPrompt.Text, ref strValue) == DialogResult.OK)
            {
                txtValue.Text = strValue;
            }
        }

        private void btnInputBox_Show2_Pswd_Click(object sender, EventArgs e)
        {
            String strValue = txtValue.Text;
            if (Ojw.CInputBox.Show_PasswordType(txtTitle.Text, txtPrompt.Text, ref strValue) == DialogResult.OK)
            {
                txtValue.Text = strValue;
            }
        }

    }
}
