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

namespace Ext_3d_1_Init
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 변수 선언
        private Ojw.C3d m_C3d = new Ojw.C3d();

        private void Form1_Load(object sender, EventArgs e)
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);




            #region 아무것도 안보이면 이상하니까 .....
            
            // 기준축 보이기(아무것도 안보이면 이상하니까...)
            m_C3d.SetStandardAxis(true);

            #endregion 아무것도 안보이면 이상하니까 .....





            // 계속 그릴 수 있게 타이머 가동
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 100 ms 간격으로 그려보자
            m_C3d.OjwDraw();
        }
    }
}
