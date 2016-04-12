using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region Step1 - Using OpenJigWare
using OpenJigWare;
#endregion Step1 - Using OpenJigWare

namespace VirtualKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Step2 - Hide Main Window
            this.Opacity = 0;
            this.Visible = false;
            this.ShowInTaskbar = false;
            #endregion Step2 - Hide Main Window
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Step3 - Show a Virtual Keyboard
            Ojw.CTools_Keyboard CKeyboard = new Ojw.CTools_Keyboard();
            CKeyboard.SetCloseEvent(true);
            CKeyboard.ShowKeyboard();
            #endregion Step3 - Show a Virtual Keyboard
        }
    }
}
