using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace SimManipulator
{
    public partial class Form1 : Form
    {
        private int m_nNum = 0; // 수식이 저장될 번호
        private Ojw.C3d m_C3d = new Ojw.C3d(); // 3D 를 표현, Kinematics 를 계산하기 위한 변수 선언

        private Ojw.CParam m_CParam; // 파라미터들을 자동으로 저장할 파라미터 변수 선언

        private Ojw.CFile m_CFile_Forward = new Ojw.CFile(); // DH 를 저장할 텍스트 박스
        private Ojw.CFile m_CFile_Forward2 = new Ojw.CFile(); // DH 이후 순전히 그림만을 그리기 위한 텍스트 박스
        private Ojw.CFile m_CFile_Inverse = new Ojw.CFile(); // Inverse Kinematics 수식을 담기 위한 텍스트 박스
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string strDraw = txtSkeleton.Text + "\r\n" + txtSkeleton_2.Text;
            // 3D 그림을 그린다.
            m_C3d.MakeDHSkeleton(
                10.0f, 
                Color.FromArgb(0xf0f0f0),
                strDraw,
                    0,
                    0,0,0
                    );

            // DH 수식이 실제로 계산되도록 넣어준다.
            SetDh(10.0f, 1.0f, Color.Red, txtSkeleton.Text);

            // DH 계산 행렬에서 X,Y,Z 만 뽑아낸다.
            ShowXYZ();

            // 3D 가 작으니 크기를 키워준다.
            m_C3d.SetScale(Ojw.CConvert.StrToFloat(txtScale.Text));
            // 위치를 아래로 좀 내려서 보기 편하게 한다.
            m_C3d.SetPos_Display(0, -500, 0);


            // Inverse Kinematics 를 0번 수식에 넣어둔다.
            Ojw.CKinematics.CInverse.Compile(txtInverse.Text, out m_C3d.m_CHeader.pSOjwCode[m_nNum]);
        }

        private void tmrDisp_Tick(object sender, EventArgs e)
        {
            // 일정 시간마다 3D 를 그려준다. (이게 실행 되어야 실제로 3D 가 그려진다.)
            m_C3d.OjwDraw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // printf 가 쓰여질 위치를 선언한다.
            Ojw.printf_Init(txtMessage);

            // 자동으로 저장할 것들(텍스트박스, 콤보박스, 체크박스, 라디오버튼 가능)을 선언한다.
            // [저장한 적이 있으면 이때 선언과 동시에 데이터가 자동으로 로드 된다.]
            m_CParam = new Ojw.CParam(
                txtPos_X,
                txtPos_Y,
                txtPos_Z,
                txtScale,
                
                rdMode0,
                rdMode1,

                txtX0,
                txtY0,
                txtZ0,
                txtX1,
                txtY1,
                txtZ1
                );

            // 3D 를 실제로 그릴 위치를 정한다.(패널, Label, 그림판 등)
            m_C3d.Init(pnDisp);

            // 기준축 보이기
            m_C3d.SetStandardAxis(true);
            bool bFill_true = true;
            float fAlpha_1f = 1.0f;
            float fThick_1 = 5.0f;
            float fLength_40000f = 40000.0f;
            m_C3d.SetStandardAxis(bFill_true, fAlpha_1f, fThick_1, fLength_40000f);

            // 투명한 상태의 스켈레톤축을 보기위해...
            m_C3d.SetSkeletonView(true);

            // 마우스를 클릭 및 드래그를 할 때의 동작을 정한다.
            if (rdMode0.Checked)
                m_C3d.SetMouseMode(0); // 화면이 움직인다.
            else
                m_C3d.SetMouseMode(1); // 로봇의 관절이 움직인다.

            // 타이머가 동작하면서 실제로 3D 를 그려주도록 한다.
            tmrDisp.Enabled = true;

            byte[] abyteData;
            
            m_CFile_Forward.Load("forward.dat", out abyteData);
            txtSkeleton.Text = Ojw.CConvert.BytesToStr(abyteData);

            m_CFile_Forward2.Load("forward2.dat", out abyteData);
            txtSkeleton_2.Text = Ojw.CConvert.BytesToStr(abyteData);

            m_CFile_Inverse.Load("inverse.dat", out abyteData);
            txtInverse.Text = Ojw.CConvert.BytesToStr(abyteData);

        }



        //CDhParamAll m_CForward = new CDhParamAll();
        private void SetDh(float fSize, float fAlpha, Color cColor, string strDH)
        {
            Ojw.CKinematics.CForward.MakeDhParam(strDH, out m_C3d.m_CHeader.pDhParamAll[m_nNum]);
        }
        private void ShowXYZ()
        {
            double[] adMot = new double[256];
            String strResult;
            Ojw.CKinematics.CForward.CalcKinematics_ToString(m_C3d.m_CHeader.pDhParamAll[m_nNum], adMot, out strResult);

            ////////////////////////////// ( 행렬에서 X,Y,Z 값 뽑아내기)
            string[] pstrResult = strResult.Split('\n');
            txtResult.Clear();
            string[] astrHeader = new string[3];
            astrHeader[0] = "X = ";
            astrHeader[1] = "Y = ";
            astrHeader[2] = "Z = ";
            for (int k = 0; k < 3; k++)
            {
                // 뒤의 3개는 설명이라 그것 마저 제하면 -7 이 된다.
                string strDatas = Ojw.CConvert.RemoveChar(pstrResult[k + pstrResult.Length - 3 - 1 - 3], '\r');
                string[] pstrDatas = strDatas.Split(' ');
                int nPass = 0;
                foreach (string strItem in pstrDatas)
                {
                    if (strItem.Length > 0)
                    {
                        if (nPass < 3)
                        {
                        }
                        else
                        {
                            txtResult.Text += astrHeader[k] + pstrDatas[pstrDatas.Length - nPass - 1] + "\r\n";
                        }
                        nPass++;
                    }
                }
                txtResult.Text += pstrDatas[pstrDatas.Length - 1] + "\r\n";
            }

#if false
            m_C3d.SetTestDh_Size(fSize);
            m_C3d.SetTestDh_Color(cColor);
            m_C3d.SetTestDh_Alpha(fAlpha);
            m_C3d.SetTestDh_Pos((float)dX, (float)dY, (float)dZ);

            #region Checking Direction
            // 방향 확인(방향에 따른 End Point 의 기준축 위치)
            float[] afX = new float[3];
            float[] afY = new float[3];
            float[] afZ = new float[3];

            double dLength = 30.0;
            dX = dLength;
            dY = 0.0f;
            dZ = 0.0f;
            for (i = 0; i < 3; i++) afX[i] = (float)(dcolX[i] * dX + dcolY[i] * dY + dcolZ[i] * dZ);
            dX = 0.0f;
            dY = dLength;
            dZ = 0.0f;
            for (i = 0; i < 3; i++) afY[i] = (float)(dcolX[i] * dX + dcolY[i] * dY + dcolZ[i] * dZ);
            dX = 0.0f;
            dY = 0.0f;
            dZ = dLength;
            for (i = 0; i < 3; i++) afZ[i] = (float)(dcolX[i] * dX + dcolY[i] * dY + dcolZ[i] * dZ);
            #endregion Checking Direction
#endif
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 파라미터를 저장(이걸 호출해야 실제로 파라미터가 저장된다)
            m_CParam.Param_Save();
            
            // 각 수식의 파일을 저장
            m_CFile_Forward.Clear();
            m_CFile_Forward.Add_Raw(txtSkeleton.Text);
            m_CFile_Forward.Save("forward.dat");

            m_CFile_Forward2.Clear();
            m_CFile_Forward2.Add_Raw(txtSkeleton_2.Text);
            m_CFile_Forward2.Save("forward2.dat");

            m_CFile_Inverse.Clear();
            m_CFile_Inverse.Add_Raw(txtInverse.Text);
            m_CFile_Inverse.Save("inverse.dat");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double dX = Ojw.CConvert.StrToDouble(txtPos_X.Text);
            double dY = Ojw.CConvert.StrToDouble(txtPos_Y.Text);
            double dZ = Ojw.CConvert.StrToDouble(txtPos_Z.Text);

            m_C3d.SetData_XYZ(m_nNum, dX, dY, dZ);

            float[] afDatas = m_C3d.GetData();
            Ojw.Log("위치로 이동");
            for (int i = 1; i < 10; i++)
                Ojw.printf("{0} ", Math.Round(afDatas[i],3));
            Ojw.newline();
#if false

            float fX = Ojw.CConvert.StrToFloat(txtPos_X.Text);
            float fY = Ojw.CConvert.StrToFloat(txtPos_Y.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtPos_Z.Text);

            // 집어넣기 전에 내부 메모리를 클리어 한다.
            Ojw.CKinematics.CInverse.SetValue_ClearAll(ref m_C3d.GetHeader_pSOjwCode()[m_nNum]);
            Ojw.CKinematics.CInverse.SetValue_X(fX);
            Ojw.CKinematics.CInverse.SetValue_Y(fY);
            Ojw.CKinematics.CInverse.SetValue_Z(fZ);


            //// 테스트 시작
            //SetTestCircle(m_chkTestObject.Checked);
            ////Settes
            //SetColor_Test(Color.Red);
            //// 테스트 값 입력
            //SetSize_Test(Ojw.CConvert.StrToFloat(m_txtTestObjectSize.Text));
            //SetPos_Test(
            //    fX + Ojw.CConvert.StrToFloat(m_txtDH_Offset_X.Text),
            //    fY + Ojw.CConvert.StrToFloat(m_txtDH_Offset_Y.Text),
            //    fZ + Ojw.CConvert.StrToFloat(m_txtDH_Offset_Z.Text)
            //    );

            // 현재의 모터각을 전부 집어 넣도록 한다.
            //UpdateMotorCommand();
            for (int i = 0; i < 256; i++)
            {
                // 모터값을 3D에 넣어주고
                //SetData(i, Ojw.CConvert.StrToFloat(m_txtAngle[i].Text));
                // 그 값을 꺼내 수식 계산에 넣어준다.
                Ojw.CKinematics.CInverse.SetValue_Motor(i, m_C3d.GetData(i));
            }

            // 실제 수식계산
            if (Ojw.CKinematics.CInverse.CalcCode(ref m_C3d.GetHeader_pSOjwCode()[m_nNum]) == false) MessageBox.Show(String.Format("Compile Error - {0}", Ojw.CKinematics.CInverse.GetErrorString_Error_Etc()));

            // 나온 결과값을 옮긴다.
            int nMotCnt = m_C3d.GetHeader_pSOjwCode()[m_nNum].nMotor_Max;
            for (int i = 0; i < nMotCnt; i++)
            {
                int nMotNum = m_C3d.GetHeader_pSOjwCode()[m_nNum].pnMotor_Number[i];
                m_C3d.SetData(nMotNum, (float)Ojw.CKinematics.CInverse.GetValue_Motor(nMotNum));
                float fVal = (float)Ojw.CKinematics.CInverse.GetValue_Motor(nMotNum);
                string strVal = Ojw.CConvert.FloatToStr(fVal);
                //Ojw.printf(strVal);
                Ojw.CMessage.Write("T" + nMotNum.ToString() + ":" + strVal);
            }
#endif
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            float [] afDatas = m_C3d.GetData();
            for (int i = 1; i < 10; i++)
                Ojw.printf("{0} ", Math.Round(afDatas[i], 3));
            Ojw.newline();

            double dX, dY, dZ;
            m_C3d.GetData_Forward(0, out dX, out dY, out dZ);

            txtPos_X.Text = Ojw.CConvert.DoubleToStr(Math.Round(dX, 3));
            txtPos_Y.Text = Ojw.CConvert.DoubleToStr(Math.Round(dY, 3));
            txtPos_Z.Text = Ojw.CConvert.DoubleToStr(Math.Round(dZ, 3));

            //double dX, dY, dZ;
            //double[] dcolX;
            //double[] dcolY;
            //double[] dcolZ;

            //double[] adMot = new double[256];
            //Array.Clear(adMot, 0, adMot.Length);
            //for (int i = 0; i < 256; i++) adMot[i] = (double)m_C3d.GetData(i);// Ojw.CConvert.StrToDouble(m_txtAngle[i].Text);

            //Ojw.CKinematics.CForward.CalcKinematics(m_C3d.m_CHeader.pDhParamAll[m_nNum], adMot, out dcolX, out dcolY, out dcolZ, out dX, out dY, out dZ);



            ////double dX, dY, dZ;
            ////Ojw.CKinematics.CForward.CalcKinematics()
            ////m_C3d.GetData_Forward(0, out dX, out dY, out dZ);
            //txtPos_X.Text = Ojw.CConvert.DoubleToStr(Math.Round(dX,3));
            //txtPos_Y.Text = Ojw.CConvert.DoubleToStr(Math.Round(dY, 3));
            //txtPos_Z.Text = Ojw.CConvert.DoubleToStr(Math.Round(dZ, 3));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int nDelay = 10;

            //m_C3d.SetData(1, 30);
            float fX0 = Ojw.CConvert.StrToFloat(txtX0.Text);
            float fY0 = Ojw.CConvert.StrToFloat(txtY0.Text);
            float fZ0 = Ojw.CConvert.StrToFloat(txtZ0.Text);


            float fX1 = Ojw.CConvert.StrToFloat(txtX1.Text);
            float fY1 = Ojw.CConvert.StrToFloat(txtY1.Text);
            float fZ1 = Ojw.CConvert.StrToFloat(txtZ1.Text);

            m_C3d.SetData_XYZ(m_nNum, fX0, fY0, fZ0);
            Ojw.CTimer.Wait(nDelay);

            float fLength = 100;
            // Start -> End 로 천천히 이동
            for (int i = 1; i <= fLength; i++)
            {
                float fX = fX0 + (fX1 - fX0) / fLength * i;
                float fY = fY0 + (fY1 - fY0) / fLength * i;
                float fZ = fZ0 + (fZ1 - fZ0) / fLength * i;
                m_C3d.SetData_XYZ(m_nNum, fX, fY, fZ);
                Ojw.CTimer.Wait(nDelay);
            }

            Ojw.printf("Done");
        }

        private void btnGo0_Click(object sender, EventArgs e)
        {
            float fX0 = Ojw.CConvert.StrToFloat(txtX0.Text);
            float fY0 = Ojw.CConvert.StrToFloat(txtY0.Text);
            float fZ0 = Ojw.CConvert.StrToFloat(txtZ0.Text);
            
            m_C3d.SetData_XYZ(0, fX0, fY0, fZ0);
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            float fX1 = Ojw.CConvert.StrToFloat(txtX1.Text);
            float fY1 = Ojw.CConvert.StrToFloat(txtY1.Text);
            float fZ1 = Ojw.CConvert.StrToFloat(txtZ1.Text);

            m_C3d.SetData_XYZ(0, fX1, fY1, fZ1);
        }

        private void rdMode0_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMode0.Focused)
            {
                m_C3d.SetMouseMode(0);
            }
        }

        private void rdMode1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMode1.Focused)
            {
                m_C3d.SetMouseMode(1);
            }
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            m_C3d.SetData(5, -10);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            m_C3d.SetData(5, -70);
        }

        private void tbTilt_Scroll(object sender, EventArgs e)
        {
            float fAngle = (float)(tbTilt.Value / 100.0f * 120.0f);
            m_C3d.SetData(4, fAngle);
        }

        private void tbTurn_Scroll(object sender, EventArgs e)
        {
            float fAngle = (float)(tbTurn.Value / 100.0f * 160.0f);
            m_C3d.SetData(6, fAngle);
        }
    }
}
