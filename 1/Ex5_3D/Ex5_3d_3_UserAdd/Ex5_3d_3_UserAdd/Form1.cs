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

namespace Ex5_3d_3_UserAdd
{
    public partial class Form1 : Form
    {
        // 변수 선언
        private Ojw.C3d m_C3d = new Ojw.C3d();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);
            
            // 기준축 보이기(아무것도 안보이면 이상하니까...)
            m_C3d.SetStandardAxis(true);

            #region 내 맘대로 그리기
            // 일단 화면청소
            m_C3d.User_Clear();

            int nIndex = 0;
            // 1 개 추가
            m_C3d.User_Set_Width_Or_Radius(300.0f);
            m_C3d.User_Set_Depth_Or_Cnt(300.0f);
            m_C3d.User_Add();
            nIndex++;

            // 다른 1개 추가
            m_C3d.User_Set_Color(Color.Red);
            m_C3d.User_Set_Width_Or_Radius(100.0f);
            m_C3d.User_Set_Height_Or_Depth(100.0f);
            m_C3d.User_Set_Depth_Or_Cnt(100.0f);
            m_C3d.User_Set_Translation(nIndex, 0, 120.0f, 0);
            m_C3d.User_Add();
            nIndex++;

            // 다른 1개 추가
            m_C3d.User_Set_Color(Color.Green);
            m_C3d.User_Set_Model("내꺼");
            m_C3d.User_Set_Translation(nIndex, 0, 50.0f, 0);
            m_C3d.User_Add();
            nIndex++;

            #endregion 내 맘대로 그리기

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_C3d.OjwDraw();
        }
    }
}
