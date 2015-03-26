using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare; // DLL

namespace testMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);
            Ojw.CMessage.Init_Error(txtMessage_Error);

            // File
            Ojw.CMessage.Init_File(true);
            Ojw.CMessage.Init_FilePath("test_Folder");
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write(txtCmd.Text);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write_Error(txtCmd.Text);
        }

        private void btnErrorCheck_Click(object sender, EventArgs e)
        {
            if (Ojw.CMessage.GetError_Count() > 0) // Checking Errors(Are there some errors?)
            {
                string strErrors = Ojw.CMessage.GetErrorMessaes();
                Ojw.CMessage.Write2(txtTest0, strErrors);
            }
            else
            {
                Ojw.CMessage.Write(txtTest1, "We have no any errors.");
            }
        }

        private void btnResetErrors_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Reset();
        }

    }
}
