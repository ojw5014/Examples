using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace OjwLoad3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ojw.C3d m_C3d = new Ojw.C3d();
        private void Form1_Load(object sender, EventArgs e)
        {
            m_C3d.Init(lbDisp);
            m_C3d.CreateProb_VirtualObject(lbProp);
            
            m_C3d.SetAseFile_Path(@"..\..\..\..\..\..\..\for Me(In Secret)\OpenJigWare\OpenJigWare\Tools\Tools\bin\Release\ase\");

            m_C3d.FileOpen();
            //m_C3d.FileOpen("test.ojw");
            //m_C3d.FileOpen("Z:\\10.SW\\Bin\\C#\\GitHub\\for Me(In Secret)\\OpenJigWare\\OpenJigWare\\Tools\\Tools\\bin\\Release\\16dof.ojw");
            //m_C3d.FileOpen("Z:\\10.SW\\Bin\\C#\\GitHub\\for Me(In Secret)\\OpenJigWare\\OpenJigWare\\Tools\\Tools\\bin\\Release\\hovis_metal.ojw");
            //m_C3d.FileOpen("Z:\\10.SW\\Bin\\C#\\GitHub\\for Me(In Secret)\\OpenJigWare\\OpenJigWare\\Tools\\Tools\\bin\\Release\\humanoid_20_ecoHead.ojw");
            //m_C3d.FileOpen("Z:\\10.SW\\Bin\\C#\\GitHub\\for Me(In Secret)\\OpenJigWare\\OpenJigWare\\Tools\\Tools\\bin\\Release\\model_5dof.ojw");
            //m_C3d.FileOpen("Z:\\10.SW\\Bin\\C#\\GitHub\\for Me(In Secret)\\OpenJigWare\\OpenJigWare\\Tools\\Tools\\bin\\Release\\maraton.ojw");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_C3d.IsNoLoadedModelingFile() == false)
            {
                m_C3d.OjwDraw();
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int nIndex = Ojw.CConvert.StrToInt(txtNumber.Text);
            double dX = Ojw.CConvert.StrToDouble(txtX.Text);
            double dY = Ojw.CConvert.StrToDouble(txtY.Text);
            double dZ = Ojw.CConvert.StrToDouble(txtZ.Text);
            int nTime = Ojw.CConvert.StrToInt(txtTime.Text);
            m_C3d.SetMot_WIthInverseKinematics(nIndex, dX, dY, dZ, nTime);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            #region 로봇을 제어하기 위해 실제 시리얼 포트를 접속한다.
            if (m_C3d.m_CMotor.IsConnect() == true)
            {
                // 연결이 되어 있다면 끊어버린다.
                m_C3d.m_CMotor.DisConnect();
                btnConnect.Text = "Connect"; // 버튼의 글자를 Connect 로 바꾼다.
            }
            else
            {
                // 통신이 끊어져 있는 경우 연결한다.
                bool bConnect = m_C3d.m_CMotor.Connect(Ojw.CConvert.StrToInt(txtPort.Text), 115200);
                if (bConnect == true) // 연결이 잘 되었다면
                {
                    btnConnect.Text = "Disconnect"; // 버튼의 글자를 Disconnect 로 바꾼다.
                }
            }
            #endregion 로봇을 제어하기 위해 실제 시리얼 포트를 접속한다.
        }
    }
}
