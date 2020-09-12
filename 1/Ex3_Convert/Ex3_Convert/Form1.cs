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

namespace Ex3_Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ojw.CConvert.IsDigit(txtIsDigit.Text) == true)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("Not");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            float fValue = Ojw.CConvert.StrToFloat(txtFloat.Text);
            int nHex = Ojw.CConvert.HexStrToInt(txtHex.Text);
            int nValue = Ojw.CConvert.StrToInt(txtInt.Text);
            double dValue = Ojw.CConvert.StrToDouble(txtDouble.Text);

            float fRet = fValue + (float)nHex + (float)nValue * (float)dValue;

            txtResult.Text = Ojw.CConvert.FloatToStr(fRet);
        }

        private void btnRemoveString_Click(object sender, EventArgs e)
        {
            txtResult_RemoveString.Text = Ojw.CConvert.RemoveString(txtRemoveString.Text, "kk");
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            txtResult2.Text = Ojw.CConvert.FillString(txtTest2.Text, "0", 4, false);
        }
    }
}
