using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenJigWare;

namespace OjwKinematics
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private int m_nWidth = 1280;
        private int m_nHeight = 768;
        private int m_nDrawWidth = 0;
        private int m_nDrawHeight = 0;

        #region Step 1 - Var
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private Ojw.CGridView m_CGridView = new Ojw.CGridView();
        #endregion Step 1 - Var
        #region Init / DInit
        private void Init()
        {
            InitMessage();
            Init3D();
            InitGridView();
        }
        private void Init3D()
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);

            // 기준축 보이기
            m_C3d.SetStandardAxis(true);//(!chkHideAxis.Checked);
            // 빛 사용
            m_C3d.Enable_Light(true);//(chkLight.Checked);

            // 클릭한 부분 색 / 투명도 지정
            m_C3d.SetPick_ColorMode(true);
            m_C3d.SetPick_ColorValue(Color.Green);
            m_C3d.SetPick_AlphaMode(true);
            m_C3d.SetPick_AlphaValue(0.5f);

            m_C3d.SetVirtualClass_Enable(false);
            m_C3d.SetAseFile_Path("cad_files");

            tmrDraw.Enabled = true;
        }
        private void InitGridView()
        {
            // GridView
            int nWidth = 80;
            m_CGridView.Create(dgAngle, 3,
                new Ojw.SGridTable_t("a", nWidth, 0, -1),
                new Ojw.SGridTable_t("d", nWidth, 0, -1),
                new Ojw.SGridTable_t("alpha", nWidth, 0, -1),
                new Ojw.SGridTable_t("Theta", nWidth, 0, -1),
                new Ojw.SGridTable_t("axis", nWidth, 0, -1),
                new Ojw.SGridTable_t("dir", nWidth, 0, -1)
                );
        }
        private void DInit3d()
        {
            tmrDraw.Enabled = false;
        }
        private void InitMessage()
        {
            Ojw.CMessage.Init(txtMessage); // 메세지 박스 기본 출력위치 지정
            Ojw.CMessage.Init_Error(txtMessage_Error); // 메세지 박스 에러 출력위치 지정
        }
        private void DInit()
        {
            DInit3d();
        }
        #endregion Init / DInit

        private void Main_Load(object sender, EventArgs e)
        {
            Init();
            m_nWidth = this.Width;
            m_nHeight = this.Height;
            m_nDrawWidth = picDisp.Width;
            m_nDrawHeight = picDisp.Height;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            int nW = (this.Width - m_nWidth);
            int nH = (this.Height - m_nHeight);

            // Block to change from the original size
            if (nW < 0) nW = 0;
            if (nH < 0) nH = 0;

            //tabParam.Left = m_pntPos_TabParam.X + nW;
            ////tabParam.Height = m_pntSize_TabParam.Y + nH;

            //txtDraw.Width = m_pntSize_DrawBox.X + nW;
            //txtDraw.Top = m_pntPos_DrawBox.Y + nH;

            //btnAdd.Top = txtDraw.Top;
            ////btnAdd.Height = txtDraw.Height;

            picDisp.Width = m_nDrawWidth + nW;
            picDisp.Height = m_nDrawHeight + nH;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DInit();
        }

        #region Drawing
        private bool m_btmrDraw = false;
        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            if (m_btmrDraw == true) return;
            tmrDraw.Enabled = false;
            m_btmrDraw = true;
            Application.DoEvents();

            m_C3d.OjwDraw();
            m_btmrDraw = false;
            tmrDraw.Enabled = true;
        }
        #endregion Drawing
    }
}
