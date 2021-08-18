using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace Kinematics
{
    public partial class frmMain : Form
    {
        private string m_strExample =   "[50,0,0,0],[-1,0,0]\r\n" + 
                                        "[0,0,90,0],[1,0,0]\r\n" + 
                                        "[50,0,0,0],[-1,0,0]\r\n" + 
                                        "[0,0,0,0],[2,0,0]\r\n" + 
                                        "[50,0,0,0],[-1,0,0]\r\n" + 
                                        "[30,0,0,0],[-1,0,0,2,0]\r\n" + 
                                        "[0,0,0,0],[3,0,0]\r\n" + 
                                        "[50,0,0,0],[-1,0,0]\r\n";
        /*
[50,0,0,0],[-1,0,0]
[0,0,90,0],[1,0,0]
[50,0,0,0],[-1,0,0]
[0,0,0,0],[2,0,0]
[50,0,0,0],[-1,0,0]
[30,0,0,0],[-1,0,0,2,0]
[0,0,0,0],[3,0,0]
[50,0,0,0],[-1,0,0]
         */
        private Ojw.C3d m_C3d = new Ojw.C3d();
        List<int> g_lstIDs = new List<int>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);
            m_C3d.Init(pnDisp);
                        
            m_C3d.SetFilePath_Design(Application.StartupPath);

            m_C3d.SetVirtualClass_Enable(false);
            rdMode1.Checked = true;
            InitValue();

            cmbCalcInv_Mode.SelectedIndex = 0;
            m_C3d.CalcInv_SetMode(cmbCalcInv_Mode.SelectedIndex);
        }

        private void btnDesigner_Click(object sender, EventArgs e)
        {
            Ojw.CTools CTool = new Ojw.CTools();
            CTool.ShowTools_Modeling();
        }

        private void tmrDisp_Tick(object sender, EventArgs e)
        {
            m_C3d.OjwDraw();
        }

        private void CheckAll()
        {
            int nForward_Count = 0;
            int nInverse_Count = 0;
            m_C3d.GetCount_Kinematics(out nForward_Count, out nInverse_Count);

            int[] anFoward = m_C3d.GetForward_Numbers();
            int[] anInverse = m_C3d.GetInverse_Numbers();
            string strForward = "\r\n[사용하는 수식번호 : ";
            for (int i = 0; i < anFoward.Length; i++) strForward += Ojw.CConvert.IntToStr(anFoward[i]) + "번, ";
            strForward += "]";

            string strInverse = "\r\n[사용하는 수식번호 : ";
            for (int i = 0; i < anInverse.Length; i++) strInverse += Ojw.CConvert.IntToStr(anInverse[i]) + "번, ";
            strInverse += "]";

            Ojw.printf(txtInfo, "\r\nForward = {0} 개{1}, Inverse = {2} 개{3}", nForward_Count, strForward, nInverse_Count, strInverse);


            Ojw.newline(txtInfo);
            Ojw.printf(txtInfo, "*****************************************\r\n");
            Ojw.printf(txtInfo, "*****************************************\r\n");
            g_lstIDs.Clear();
            for (int i = 0; i < anFoward.Length; i++)
            {
                int nFunctionNumber = i;
                int[] anMotors = m_C3d.GetHeader_pDhParamAll()[nFunctionNumber].GetMotors();
                string strMotors = "Motors = ";
                int nCnt = 0;
                if (anMotors != null)
                {
                    for (int j = 0; j < anMotors.Length; j++)
                    {
                        if (i == 0) // 이 프로그램에서는 0번 수식만 해결한다.
                            g_lstIDs.Add(anMotors[j]);
                        strMotors += Ojw.CConvert.IntToStr(anMotors[j]) + " ";
                    }
                    nCnt = anMotors.Length;
                }
                Ojw.printf(txtInfo, "{0} 번 Forward 수식에 들어있는 모터는 모두 {1} 개로 {2} 입니다.", nFunctionNumber, nCnt, strMotors);
                Ojw.newline(txtInfo);
            }

            Ojw.printf(txtInfo, "#############################################\r\n");
            for (int i = 0; i < anInverse.Length; i++)
            {
                int nFunctionNumber = i;
                int nMotorCnt = m_C3d.m_CHeader.pSOjwCode[i].nMotor_Max;
                //int [] anMots = m_C3d.GetHeader_pSOjwCode()[nNum].pnMotor_Number[i];
                int[] anMotors = m_C3d.m_CHeader.pSOjwCode[i].pnMotor_Number;
                string strMotors = "Motors = ";
                int nCnt = 0;
                if (anMotors != null)
                {
                    for (int j = 0; j < anMotors.Length; j++)
                    {
                        strMotors += Ojw.CConvert.IntToStr(anMotors[j]) + " ";
                    }
                    nCnt = anMotors.Length;
                }
                Ojw.printf(txtInfo, "{0} 번 Inverse 수식에 들어있는 모터는 모두 {1} 개로 {2} 입니다.", nFunctionNumber, nCnt, strMotors);
                Ojw.newline(txtInfo);
            }
            Ojw.printf(txtInfo, "#############################################\r\n"); 
        }
        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            m_C3d.FileOpen();
            CheckAll();
        }

        private void btnSetForward_Click(object sender, EventArgs e)
        {
            MakeAll();
            CheckAll();
            for (int i = 0; i < 256; i++) m_C3d.SetData(i, 0);
            string [] pstrRes = Ojw.CKinematics.CForward.Make_XYZString_By_Forward(txtForward.Text);
            Ojw.printf(txtInfo, "<<수식의 결과>>\r\n  [C(각도)-Cos(각도), S(각도)-Sin(각도), t[번호]-모터[번호]의 각도\r\n  각도는 0~360의 Degree입니다.\r\n\r\n");
            for (int i = 0; i < pstrRes.Length; i++)
            {
                if (i == 0) Ojw.printf(txtInfo, "X=");
                else if (i == 1) Ojw.printf(txtInfo, "Y=");
                else if (i == 2) Ojw.printf(txtInfo, "Z=");
                else if (i == 3) Ojw.printf(txtInfo, "X축이 가리키는 방향벡터=");
                else if (i == 4) Ojw.printf(txtInfo, "Y축이 가리키는 방향벡터=");
                else if (i == 5) Ojw.printf(txtInfo, "Z축이 가리키는 방향벡터=");
                Ojw.printf(txtInfo, pstrRes[i]);
                Ojw.newline(txtInfo);
            }
        }
        private void MakeAll(string str = "")
        {
            if (str.Length == 0) m_C3d.m_CHeader.pstrKinematics[0] = txtForward.Text;
            else m_C3d.m_CHeader.pstrKinematics[0] = str;
            
            m_C3d.CheckForward();

            float fSize = 10.0f;
            m_C3d.m_CHeader.strDrawModel = m_C3d.MakeDHSkeleton(true, fSize, Color.Violet, m_C3d.m_CHeader.pstrKinematics[0]);
            m_C3d.CompileDesign();
        }

        private void rdMode0_CheckedChanged(object sender, EventArgs e)
        {
#if true
            m_C3d.SetMouseMode(0);
#else
            m_C3d.Prop_Set_Main_MouseControlMode(0);
            m_C3d.Prop_Update_VirtualObject();
#endif
        }
        private void rdMode1_CheckedChanged(object sender, EventArgs e)
        {
#if true
            m_C3d.SetMouseMode(1);
#else
            m_C3d.Prop_Set_Main_MouseControlMode(1);
            m_C3d.Prop_Update_VirtualObject();
#endif
        }

        private string MakeDh(string a, string d, string theta, string alpha, string axis, int nDir, int nInit, string functionnumber)
        {
            string str="";
            int nFunctionNumber = Ojw.CConvert.StrToInt(txtFunction.Text);
            if ((nFunctionNumber >= 0) && (nFunctionNumber != 255))
            {
                str = string.Format(",2,{0}", nFunctionNumber);
            }
            return m_strDh = string.Format("[{0},{1},{2},{3}],[{4},{5},{6}{7}]\r\n", a, d, theta, alpha, axis, nDir, nInit, str);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtForward.Text += MakeDh(txtA.Text,
                txtD.Text,
                txtTheta.Text,
                txtAlpha.Text,
                txtAxis.Text,
                cmbDir.SelectedIndex,
                ((chkInit.Checked == false) ? 0 : 1),
                txtFunction.Text);

            InitValue();

            MakeAll();
            CheckAll();
        }
        private void InitValue()
        {
            txtA.Text = "0";
            txtD.Text = "0";
            txtTheta.Text = "0";
            txtAlpha.Text = "0";
            txtAxis.Text = "-1";
            cmbDir.SelectedIndex = 0;
            chkInit.Checked = false;
            txtFunction.Text = "255";
        }

        private int m_nMouse = 0;
        private Point m_pntMouse = new Point(0, 0);
        private void MouseDown(object sender, MouseEventArgs e)
        {
            m_nMouse = 1;
            m_pntMouse.X = e.X;
            m_pntMouse.Y = e.Y;
        }
        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (m_nMouse == 1) m_nMouse = 2;
            if (m_nMouse == 2)
            {
                float fDelta = m_pntMouse.X - e.X;
                ((TextBox)sender).Text = Ojw.CConvert.FloatToStr(Ojw.CConvert.StrToFloat(((TextBox)sender).Text) - fDelta);
                                
                m_pntMouse.X = e.X;
                m_pntMouse.Y = e.Y;
            }
        }
        private void MouseUp(object sender, MouseEventArgs e)
        {
            m_nMouse = 0;

            ModelingChanged(sender, e);
        }
        private void ModelingChanged(object sender, EventArgs e)
        {
            MakeAll(
                    txtForward.Text + "\r\n" + MakeDh(
                        txtA.Text,
                        txtD.Text,
                        txtTheta.Text,
                        txtAlpha.Text,
                        txtAxis.Text,
                        cmbDir.SelectedIndex,
                        ((chkInit.Checked == false) ? 0 : 1),
                        txtFunction.Text
                    )
                );
        }
        private void txtA_MouseDown(object sender, MouseEventArgs e) { MouseDown(sender, e); }
        private void txtA_MouseMove(object sender, MouseEventArgs e) { MouseMove(sender, e); }
        private void txtA_MouseUp(object sender, MouseEventArgs e) { MouseUp(sender, e); }

        string m_strForward = "";
        private void txtForward_TextChanged(object sender, EventArgs e)
        {
            m_strForward = txtForward.Text;
        }
        string m_strDh = "";

        
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
                ModelingChanged(sender, e);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nNum = Ojw.CConvert.StrToInt(txtFunctionNumber.Text);
            float fX = Ojw.CConvert.StrToFloat(txtX.Text);
            float fY = Ojw.CConvert.StrToFloat(txtY.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtZ.Text);
            
            int[] anMotodIDs = m_C3d.CalcInv_MotorIDs(nNum);
            
            float [] afAngles = m_C3d.CalcInv(nNum, fX, fY, fZ);

            string str = String.Empty;
            for (int i = 0; i < anMotodIDs.Length; i++)
            {
                str += String.Format("[{0}]{1}\r\n", anMotodIDs[i], afAngles[i]);
            }
            Ojw.printf(str);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int nNum = Ojw.CConvert.StrToInt(txtFunctionNumber.Text);
            float fX, fY, fZ;

            int nLimitID = -1; // -1 : all

            m_C3d.CalcF(nNum, nLimitID, true, out fX, out fY, out fZ);
            txtX.Text = Ojw.CConvert.FloatToStr(fX);
            txtY.Text = Ojw.CConvert.FloatToStr(fY);
            txtZ.Text = Ojw.CConvert.FloatToStr(fZ);
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            txtForward.Text = m_strExample;
            MessageBox.Show("예제를 만들었습니다.\r\n이제 아래의 \"Set Forward\" 버튼을 눌러 활성화 시켜주세요");
        }

        private void btnReset_Angle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
            {
                m_C3d.SetData(i, 0);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_C3d.CalcInv_SetMode(cmbCalcInv_Mode.SelectedIndex);
        }
        
    }
}
