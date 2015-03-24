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

namespace Ex2_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Ojw.CMessage.Init(txtMessage); // 메세지 박스 기본 출력위치 지정
            
            // 아래부터는 선택.
            Ojw.CMessage.Init_Error(txtMessage_Error); // 메세지 박스 에러 출력위치 지정
            Ojw.CMessage.Init_File(true); // Save History files(Default : false)
            Ojw.CMessage.Init_FilePath(Application.StartupPath + "\\" + "test"); // change the history file path, (default = current)


        }

        private void btnMessage1_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("Message1");
            
            Ojw.CMessage.Write2("Test1, ");
            Ojw.CMessage.Write2("Test2, ");
            Ojw.CMessage.Write2("Test3, ");

            Ojw.CMessage.Write2("\r\n");
        }

        private void btnMessage2_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("Message2");

            Ojw.CMessage.Write2("Test1, ");
            Ojw.CMessage.Write2("Test2, ");
            Ojw.CMessage.Write2("Test3, ");

            Ojw.CMessage.Write2("\r\n");
        }

        private void btnErrorMessage1_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write_Error("Error 1");
        }

        private void btnErrorMessage2_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write_Error("Error 2");
        }

        private void btnCheckError_Click(object sender, EventArgs e)
        {
            if (Ojw.CMessage.GetError_Count() > 0)
                MessageBox.Show(Ojw.CMessage.GetErrorMessaes(), "Error List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("We have no any errors.", "Error List", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnResetMessage_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Reset();
        }
    }
}
