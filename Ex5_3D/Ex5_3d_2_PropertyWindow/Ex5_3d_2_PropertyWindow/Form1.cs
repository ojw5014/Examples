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

namespace Ex5_3d_2_PropertyWindow
{
    public partial class Form1 : Form
    {
        // 변수 선언
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private Ojw.CProperty m_CProp = new Ojw.CProperty(); // For Property(with Virtual object)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);
            // 프로퍼티창 생성
            m_C3d.CreateProb(pnProperty);




            #region 아무것도 안보이면 이상하니까 .....

            // 기준축 보이기(아무것도 안보이면 이상하니까...)
            m_C3d.SetStandardAxis(true);

            

            // 가상 object 가 나타나도록 한다.
            m_C3d.SetVirtualClass_Enable(true);

            // 처음 나타난 가상 object 는 너무 작아서 잘 안보이니까 좀 크게 수정한다.
            m_C3d.Prop_Set_Color(Color.Red);
            m_C3d.Prop_Set_Width_Or_Radius(100);
            m_C3d.Prop_Set_Height_Or_Depth(100);
            m_C3d.Prop_Set_Depth_Or_Cnt(100);

            // 종류는 육면체로
            // #0 - Offset 없는 육면체(기본), #1 - Offset 없는 원기둥, #2 - Offset 없는 구, #3 - 클립1, #4 - 클립2, #5 - 반클립1, #6 - 반클립2, 
            // #7 - 육면체, #8 - 원기둥, #9 - 구, #10 - 꼬깔, #11 - X축, #12 - Y축, #13 - Z축, #14 - XYZ축
            // 그외 - #이 앞에 없으면 해당 이름의 ase 파일을 자동으로 로드해서 확인한다.
            m_C3d.Prop_Set_DispObject("#7");

            // 형상의 시작 위치를 약간 변경한다.
            m_C3d.Prop_Set_Offset_Trans_Y(-100);
            
            // 만들어진걸 살짝 이동한다.
            m_C3d.Prop_Set_Trans_X1(100);
                        
            // Update
            m_C3d.Prop_Update();


            #endregion 아무것도 안보이면 이상하니까 .....


            // 계속 그릴 수 있게 타이머 가동
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 100 ms 간격으로 그려보자
            m_C3d.OjwDraw();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_C3d.AddVirtualClassToReal();
        }
    }
}
