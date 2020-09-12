#define _3D
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

        #region 변수 선언
#if _3D
        // 변수 선언
        private Ojw.C3d m_C3d = new Ojw.C3d();
#endif
        #endregion 변수 선언

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 3D 그림
#if _3D
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);

            if (m_C3d.FileOpen(@"test.dhf") == true) // 모델링 파일이 잘 로드 되었다면 
            {
                //m_C3d.OjwDraw(); // 3D 모델을 화면에 출력한다.
                timer1.Enabled = true;
            }
#endif
            #endregion 3D 그림
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 그리자
#if _3D
            m_C3d.OjwDraw();
#endif
            #endregion 그리자
        }
    }
}
