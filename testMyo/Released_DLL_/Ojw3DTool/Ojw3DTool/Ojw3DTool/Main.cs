using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

namespace Ojw3DTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void 예제함수()
        //{
        //    try
        //    {
        //        Assembly assem = Assembly.LoadFile(@"DLL경로및파일명");
        //        object obj = assem.CreateInstance("namespace명.class명");
        //        Type objType = obj.GetType();

        //        textBox3.Text = objType.GetMethod("함수명").Invoke(obj, new object[] { 매게변수1, 매게변수2, ... }).ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        textBox3.Text = "dll에 문제있음";
        //    }
        //} 

    }
}
