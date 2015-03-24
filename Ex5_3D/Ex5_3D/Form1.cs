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
//  3. 다른 예제들과 다르게 3d 에서는 Tao 관련 DLL 전부를 Add 해야 한다.
//  4. freeglut.dll 파일을 실행 폴더에 같이 복사해 두어야 한다.
using OpenJigWare;

namespace Ex5_3D
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
    }
}
