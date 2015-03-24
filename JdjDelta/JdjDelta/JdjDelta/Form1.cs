using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenJigWare;



namespace JdjDelta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox[] m_txtAngle = new TextBox[9];

        private Ojw.C3d m_C3d = new Ojw.C3d();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < m_txtAngle.Length; i++) m_txtAngle[i] = (TextBox)(this.Controls.Find("txtT" + Ojw.CConvert.IntToStr(i), true)[0]);
            
            InitMesssage();
            Ojw.CMessage.Write("message 의 시작"); 
            Init3D();
        }

        private Ojw.CProperty m_CProp = new Ojw.CProperty();
        private void InitProperty()
        {
            m_C3d.CreateProb_VirtualObject(pnProperty);
            ///////////////// Property Open
            m_C3d.Prop_Set_MotorControl_MousePoint(1); // 0: 화면이동,   1: 제어타입
            m_C3d.Prop_Update_VirtualObject(); // 변경 사항 업데이트

            Ojw.CMessage.Write("Property 초기화 완료");
        }
        private void InitMesssage()
        {
            // 메세지 사용
            Ojw.CMessage.Init(txtMessage);
            // 파일저장모드 사용
            Ojw.CMessage.Init_File(true);
        }
        private bool Open3DFile(int nModel)
        {
            bool bRet = false;
            if (m_C3d.FileOpen((nModel == 0)? @"jdj_standard.ojw" : @"jdj_15L.ojw") == true) // 모델링 파일이 잘 로드 되었다면 
            {
                #region 0번 수식을 텍스트 박스로 옮긴다.
                cmbDhRefresh(0);
                #endregion 0번 수식을 텍스트 박스로 옮긴다.
                bRet = true;
            }
            return bRet;
        }
        private void Init3D()
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);
            
            // 프로퍼티도 선언하자
            InitProperty();

            //if (m_C3d.FileOpen(@"jdj_15L.ojw") == true) // 모델링 파일이 잘 로드 되었다면 
            //if (m_C3d.FileOpen(@"jdj_standard.ojw") == true) // 모델링 파일이 잘 로드 되었다면 
            if (Open3DFile(0) == true)
            {
                #region 0번 수식을 텍스트 박스로 옮긴다.
                cmbDhRefresh(0);
                #endregion 0번 수식을 텍스트 박스로 옮긴다.


                // 초기자세를 강제로 잡아보자
                MoveXYZ(false, 1.0f, 0.0f, 15.0f, 0.0f);
                tmrDisp.Enabled = true; // 그리기 시작
            }

            // 클릭한 부분 색 / 투명도 지정(굳이 할 필요는 없다.)
            m_C3d.SetPick_ColorMode(true);
            m_C3d.SetPick_ColorValue(Color.Green);
            m_C3d.SetPick_AlphaMode(true);
            m_C3d.SetPick_AlphaValue(0.5f);

            // 너무 작은 그림이니 확대를 해야 할 듯.
            m_C3d.SetScale(0.02f);
            m_C3d.SetAngle_Display(10.0f, 10.0f, 0.0f);
            m_C3d.SetPos_Display(0.0f, -8.0f, 0.0f);

            m_C3d.Prop_Set_Main_MouseControlMode(1); // 0:화면이동,   1: 제어타입
            m_C3d.Prop_Set_Main_ShowStandardAxis(false); // 화면에 보이는 기준축 보이지 않게 설정
            m_C3d.Prop_Set_Main_ShowVirtualAxis(false); // 가상 오브젝트 삭제
            m_C3d.Prop_Set_Main_MouseControlMode(1); // 0:화면이동,   1: 제어타입
            m_C3d.Prop_Update_VirtualObject(); // 변경 사항 업데이트

        }

        private void OjwDraw()
        {
            m_C3d.OjwDraw();
        }

        private bool m_btmrDraw = false;
        private void tmrDisp_Tick(object sender, EventArgs e)
        {
            if (m_btmrDraw == true) return;
            tmrDisp.Enabled = false;
            m_btmrDraw = true;
            Application.DoEvents();

            //for (int i = 0; i < 256; i++) m_C3d.SetData(i, Ojw.CConvert.StrToFloat(m_txtAngle[i].Text));
            m_C3d.OjwDraw();
            m_btmrDraw = false;
            tmrDisp.Enabled = true;
        }

        private enum EType_t
        {
            EType_Normal,
            EType_0,
            EType_M90,
            EType_90,
            EType_120,
            EType_240,
            EType_Top,
            EType_Bottom
        }
        private void ViewSide(EType_t EType)
        {
            m_C3d.SetScale(0.02f);
            m_C3d.SetPos_Display(0.0f, -8.0f, 0.0f);
            if (EType == EType_t.EType_Normal) m_C3d.SetAngle_Display(10.0f, 10.0f, 0.0f);
            else if (EType == EType_t.EType_0) m_C3d.SetAngle_Display(0.0f, 0.0f, 0.0f);
            else if (EType == EType_t.EType_M90) m_C3d.SetAngle_Display(90.0f, 0.0f, 0.0f);
            else if (EType == EType_t.EType_90) m_C3d.SetAngle_Display(-90.0f, 0.0f, 0.0f);
            else if (EType == EType_t.EType_120) m_C3d.SetAngle_Display(-90 - 120.0f, 0.0f, 0.0f);
            else if (EType == EType_t.EType_240) m_C3d.SetAngle_Display(-90 - 240.0f, 0.0f, 0.0f);
            else if (EType == EType_t.EType_Top) m_C3d.SetAngle_Display(0.0f, 90.0f, 0.0f);
            else if (EType == EType_t.EType_Bottom) m_C3d.SetAngle_Display(0.0f, -90.0f, 0.0f);
        }
        private void btnDraw_Front_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_0); }
        private void btnDraw_90_inverse_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_M90); }
        private void btnDraw_90_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_90); }
        private void btnDraw_120_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_120); }
        private void btnDraw_240_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_240); }
        private void btnDraw_Top_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_Top); }
        private void btnDraw_Bottom_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_Bottom); }
        private void btnDraw_Normal_Click(object sender, EventArgs e) { ViewSide(EType_t.EType_Normal); }

        private void chkUserControl_CheckedChanged(object sender, EventArgs e)
        {
            bool bEn = chkUserControl.Checked;
            m_C3d.SetMouseEventEnable(bEn);
            if (bEn == false)
            {
                m_C3d.AddMouseEvent_Down(OjwMouseDown);
                m_C3d.AddMouseEvent_Move(OjwMouseMove);
                m_C3d.AddMouseEvent_Up(OjwMouseUp);
            }
            else
            {
                m_C3d.RemoveMouseEvent_Down(OjwMouseDown);
                m_C3d.RemoveMouseEvent_Move(OjwMouseMove);
                m_C3d.RemoveMouseEvent_Up(OjwMouseUp);
            }
        }

        private bool m_bMouseClick = false;
        private void OjwMouseDown(object sender, MouseEventArgs e)
        {
            if (m_bMouseClick == false)
            {
                m_bMouseClick = true;
                if (e.Button == MouseButtons.Left)
                {
                    
                }
                else
                {
                    
                }
            }
        }
        private void OjwMouseMove(object sender, MouseEventArgs e)
        {
            if (m_bMouseClick == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    
                }
            }
        }
        private void OjwMouseUp(object sender, MouseEventArgs e)
        {
            m_bMouseClick = false;
        }

        private void rd5_CheckedChanged(object sender, EventArgs e)
        {
            tmrDisp.Enabled = false;
            //if (m_C3d.FileOpen(@"jdj_standard.ojw") == true) // 모델링 파일이 잘 로드 되었다면 
            if (Open3DFile(0) == true)
            {
                #region 0번 수식을 텍스트 박스로 옮긴다.
                //cmbDhRefresh(0);
                #endregion 0번 수식을 텍스트 박스로 옮긴다.

                tmrDisp.Enabled = true; // 그리기 시작
                MoveXYZ(false, 1.0f, 0.0f, 15.0f, 0.0f);
            }
            else Ojw.CMessage.Write_Error("파일 오픈 에러");
        }

        private void rd15_CheckedChanged(object sender, EventArgs e)
        {
            tmrDisp.Enabled = false;
            //if (m_C3d.FileOpen(@"jdj_15L.ojw") == true) // 모델링 파일이 잘 로드 되었다면
            if (Open3DFile(1) == true)
            {
                #region 0번 수식을 텍스트 박스로 옮긴다.
                //cmbDhRefresh(0);
                #endregion 0번 수식을 텍스트 박스로 옮긴다.

                tmrDisp.Enabled = true; // 그리기 시작
                MoveXYZ(false, 1.0f, 0.0f, 15.0f, 0.0f);
            }
            else Ojw.CMessage.Write_Error("파일 오픈 에러");
        }

        private void btnChangePos_Click(object sender, EventArgs e)
        {
            MoveXYZ(false, 1.0f, Ojw.CConvert.StrToFloat(txtPos_X.Text), Ojw.CConvert.StrToFloat(txtPos_Y.Text), Ojw.CConvert.StrToFloat(txtPos_Z.Text));
        }
        private void Draw_Clear()
        {
            m_C3d.User_Clear();
        }
        private void Draw_Point(Color cColor, float fX, float fY, float fZ)
        {
            m_C3d.User_Set_Color(Color.Red);
            m_C3d.User_Set_Init(true); // 초기좌표 기준
            m_C3d.User_Set_Model("#15"); // 15: Point, 16: Points
            m_C3d.User_Set_Points_Clear();
            m_C3d.User_Set_Points_Add(fX, fY, fZ);
            m_C3d.User_Add();
        }
        private void Draw_Line(Color cColor, float fX0, float fY0, float fZ0, float fX1, float fY1, float fZ1)
        {
            m_C3d.User_Set_Color(Color.Red);
            m_C3d.User_Set_Init(true); // 초기좌표 기준
            m_C3d.User_Set_Model("#17"); // 17: Line, 18 : Lines
            m_C3d.User_Set_Points_Clear();
            m_C3d.User_Set_Points_Add(fX0, fY0, fZ0);
            m_C3d.User_Set_Points_Add(fX1, fY1, fZ1);
            m_C3d.User_Add();
        }
        private void Draw_Ball(Color cColor, float fRadius, float fX, float fY, float fZ)
        {
            m_C3d.User_Set_Color(Color.Red);
            m_C3d.User_Set_Init(true); // 초기좌표 기준
            m_C3d.User_Set_Model("#9");
            m_C3d.User_Set_Width_Or_Radius(fRadius);
            //m_C3d.User_Set_Model("#15");
            m_C3d.User_Set_Translation(0, fX, fY, fZ);
            m_C3d.User_Add();
        }

        private bool MoveXYZ(float fX, float fY, float fZ)
        {
            bool bRet = false;

            #region Inverse
            int nNum = 0;
            int i;
            // 좌표축 바꿔준다. 동준이 사용 하는 좌표계로...
            //float fTmp = fY;
            //fY = fZ;
            //fZ = fTmp;

            // 집어넣기 전에 내부 메모리를 클리어 한다.
            Ojw.CKinematics.CInverse.SetValue_ClearAll(ref m_C3d.GetHeader_pSOjwCode()[nNum]);
            Ojw.CKinematics.CInverse.SetValue_X(fX);
            Ojw.CKinematics.CInverse.SetValue_Y(fY);
            Ojw.CKinematics.CInverse.SetValue_Z(fZ);

            // 실제 수식계산
            Ojw.CKinematics.CInverse.CalcCode(ref m_C3d.GetHeader_pSOjwCode()[nNum]);

            // 나온 결과값을 옮긴다.(실 모델링 그림에 적용)
            int nMotCnt = m_C3d.GetHeader_pSOjwCode()[nNum].nMotor_Max;
            for (i = 0; i < nMotCnt; i++)
            {
                int nMotNum = m_C3d.GetHeader_pSOjwCode()[nNum].pnMotor_Number[i];
                m_C3d.SetData(nMotNum, (float)Ojw.CKinematics.CInverse.GetValue_Motor(nMotNum));
            }
            #endregion Inverse

            #region Forward
            double[] adX = new double[3];
            double[] adY = new double[3];
            double[] adZ = new double[3];
            double dTmp = 0.0;
            for (i = 0; i < 3; i++)
                MoveToDhPosition(i, out adX[i], out adY[i], out adZ[i]);
            #endregion Forward

            #region 검증
            for (i = 0; i < 3; i++)
            {
                int nIndex0 = i;
                int nIndex1 = (i + 1) % 3;
                dTmp += Math.Pow(adX[nIndex0] - adX[nIndex1], 2) +
                        Math.Pow(adY[nIndex0] - adY[nIndex1], 2) +
                        Math.Pow(adZ[nIndex0] - adZ[nIndex1], 2);
                    //Math.Abs(adX[nIndex0] -  adX[nIndex1]) + 
                        //Math.Abs(adY[nIndex0] -  adY[nIndex1]) + 
                        //Math.Abs(adZ[nIndex0] -  adZ[nIndex1]);
            }
            //if (dTmp <= 0.0001) bRet = true;
            //if (dTmp <= 0.01) bRet = true;
            if (dTmp <= 0.1) bRet = true;
            #endregion 검증

            return bRet;
        }
        private void MoveXYZ(bool bShowBall, float fBallSize, float fX, float fY, float fZ)
        {
            int nNum = 0;

            // 좌표축 바꿔준다. 동준이 사용 하는 좌표계로...
            //float fTmp = fY;
            //fY = fZ;
            //fZ = fTmp;

            // 집어넣기 전에 내부 메모리를 클리어 한다.
            Ojw.CKinematics.CInverse.SetValue_ClearAll(ref m_C3d.GetHeader_pSOjwCode()[nNum]);
            Ojw.CKinematics.CInverse.SetValue_X(fX);
            Ojw.CKinematics.CInverse.SetValue_Y(fY);
            Ojw.CKinematics.CInverse.SetValue_Z(fZ);
            
            // 테스트 시작
            m_C3d.SetTestCircle(bShowBall);
            //m_C3d.Settes
            m_C3d.SetColor_Test(Color.Red);
            // 테스트 값 입력
            m_C3d.SetSize_Test(fBallSize);
            m_C3d.SetPos_Test(fX, fY, fZ);

            // 현재의 모터각을 전부 집어 넣도록 한다.
            //for (int i = 0; i < 10; i++)
            //{
            //    // 모터값을 3D에 넣어주고
            //    m_C3d.SetData(i, Ojw.CConvert.StrToFloat(m_txtAngle[i].Text));
            //    // 그 값을 꺼내 수식 계산에 넣어준다.
            //    Ojw.CKinematics.CInverse.SetValue_Motor(i, m_C3d.GetData(i));
            //}

            // 실제 수식계산
            Ojw.CKinematics.CInverse.CalcCode(ref m_C3d.GetHeader_pSOjwCode()[nNum]);

            //lbV.Text = String.Empty;
            //for (int i = 0; i < 10; i++)
            //{
            //    lbV.Text += "V" + i.ToString() + ":" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(i)) + ",";
            //}

            // 나온 결과값을 옮긴다.(실 모델링 그림에 적용)
            int nMotCnt = m_C3d.GetHeader_pSOjwCode()[nNum].nMotor_Max;
            for (int i = 0; i < nMotCnt; i++)
            {
                int nMotNum = m_C3d.GetHeader_pSOjwCode()[nNum].pnMotor_Number[i];
                m_C3d.SetData(nMotNum, (float)Ojw.CKinematics.CInverse.GetValue_Motor(nMotNum));
            }

            BlockUpdate(true);
            for (int i = 0; i < m_txtAngle.Length; i++)
            {
                m_txtAngle[i].Text = Ojw.CConvert.FloatToStr(m_C3d.GetData(i));
            }
            BlockUpdate(false);
        }

        private void chkMouseControl_CheckedChanged(object sender, EventArgs e)
        {
            m_C3d.Prop_Set_Main_MouseControlMode(((chkMouseControl.Checked == true) ? 0 : 1)); // 0:화면이동,   1: 제어타입
            m_C3d.Prop_Update_VirtualObject(); // 변경 사항 업데이트
        }

        private void btnCheckDH_Click(object sender, EventArgs e)
        {
            float fBallSize = 2.0f;
            MoveToDhPosition(fBallSize, 1.0f, Color.Red);
        }
        private void MoveToDhPosition(int nNum, out double dX, out double dY, out double dZ)
        {
            int i;
            double[] dcolX;
            double[] dcolY;
            double[] dcolZ;

            double[] adMot = new double[256];
            Array.Clear(adMot, 0, adMot.Length);
            for (i = 0; i < m_C3d.GetHeader_nMotorCnt(); i++) adMot[i] = (double)m_C3d.GetData(i);//Ojw.CConvert.StrToDouble(m_txtAngle[i].Text);
            
            Ojw.CKinematics.CForward.CalcKinematics(m_C3d.GetHeader_pDhParamAll()[nNum], adMot, out dcolX, out dcolY, out dcolZ, out dX, out dY, out dZ);
            
            //String strResult;
            // 만들어진 수식을 알고 싶다면 여기 결과값을 리턴받는다.
            //Ojw.CKinematics.CForward.CalcKinematics_ToString(m_C3d.GetHeader_pDhParamAll()[nNum], adMot, out strResult);
            //txtKinematicsString.Text = strResult;

            #region Checking Direction
            // 방향 확인
            //float[] afX = new float[3];
            //float[] afY = new float[3];
            //float[] afZ = new float[3];

            //double dLength = 30.0;
            //dX = dLength;
            //dY = 0.0f;
            //dZ = 0.0f;
            //for (i = 0; i < 3; i++) afX[i] = (float)(dcolX[i] * dX + dcolY[i] * dY + dcolZ[i] * dZ);
            //dX = 0.0f;
            //dY = dLength;
            //dZ = 0.0f;
            //for (i = 0; i < 3; i++) afY[i] = (float)(dcolX[i] * dX + dcolY[i] * dY + dcolZ[i] * dZ);
            //dX = 0.0f;
            //dY = 0.0f;
            //dZ = dLength;
            //for (i = 0; i < 3; i++) afZ[i] = (float)(dcolX[i] * dX + dcolY[i] * dY + dcolZ[i] * dZ);


            //m_C3d.SetTestDh_Angle(afX, afY, afZ);

            #endregion Checking Direction
        }
        private void MoveToDhPosition(float fSize, float fAlpha, Color cColor)
        {
            int i;
            CDhParamAll COjwDhParamAll = new CDhParamAll();
            Ojw.CKinematics.CForward.MakeDhParam(txtForwardKinematics.Text, out COjwDhParamAll);
            double dX, dY, dZ;
            double[] dcolX;
            double[] dcolY;
            double[] dcolZ;

            double[] adMot = new double[256];
            Array.Clear(adMot, 0, adMot.Length);
            for (i = 0; i < m_C3d.GetHeader_nMotorCnt(); i++) adMot[i] = (double)m_C3d.GetData(i);//Ojw.CConvert.StrToDouble(m_txtAngle[i].Text);

            Ojw.CKinematics.CForward.CalcKinematics(COjwDhParamAll, adMot, out dcolX, out dcolY, out dcolZ, out dX, out dY, out dZ);
            
            String strResult;
            // 만들어진 수식을 알고 싶다면 여기 결과값을 리턴받는다.
            Ojw.CKinematics.CForward.CalcKinematics_ToString(COjwDhParamAll, adMot, out strResult);
            txtKinematicsString.Text = strResult;

            m_C3d.SetTestDh_Size(fSize);
            m_C3d.SetTestDh_Color(cColor);
            m_C3d.SetTestDh_Alpha(fAlpha);
            m_C3d.SetTestDh_Pos((float)dX, (float)dY, (float)dZ);
            lbTestDh.Text = "[x=" + Ojw.CConvert.DoubleToStr((double)Math.Round(dX, 3)) + ", y=" + Ojw.CConvert.DoubleToStr((double)Math.Round(dY, 3)) + ", z=" + Ojw.CConvert.DoubleToStr((double)Math.Round(dZ, 3)) + "]";

            #region Checking Direction
            // 방향 확인
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


            m_C3d.SetTestDh_Angle(afX, afY, afZ);

            #endregion Checking Direction
        }

        private void btnKinematicsCompile_Click(object sender, EventArgs e)
        {
            m_C3d.CheckForward();
            m_C3d.CheckInverse();
        }

        private void cmbDhRefresh(int nNum)
        {
            if ((nNum >= 0) && (nNum < 255))
            {
                Ojw.CEncryption.SetEncrypt("OJW5014"); // 암호화 해제는 보안이 필요
                txtForwardKinematics.Text = Encoding.Default.GetString(Ojw.CEncryption.Encryption(false, m_C3d.GetHeader_pSEncryptKinematics_encryption()[nNum].byteEncryption));

                Ojw.CEncryption.SetEncrypt("OJW5014"); // 암호화 해제는 보안이 필요
                txtInverseKinematics.Text = Encoding.Default.GetString(Ojw.CEncryption.Encryption(false, m_C3d.GetHeader_pSEncryptInverseKinematics_encryption()[nNum].byteEncryption));
            }
        }

        private void txtInverseKinematics_TextChanged(object sender, EventArgs e)
        {
            if (txtInverseKinematics.Focused == true)
            {
                int nNum = 0;
                m_C3d.GetHeader_pstrInverseKinematics()[nNum] = txtInverseKinematics.Text;

                byte[] byteData = Encoding.Default.GetBytes(txtInverseKinematics.Text);
                m_C3d.GetHeader_pSEncryptInverseKinematics_encryption()[nNum].byteEncryption = Ojw.CEncryption.Encryption(true, byteData);
                byteData = null;
            }
        }

        private void chkDh_CheckedChanged(object sender, EventArgs e)
        {
            m_C3d.SetTestDh(chkDh.Checked);
            float fBallSize = 2.0f;
            MoveToDhPosition(fBallSize, 1.0f, Color.Red);
        }

        private void txtForwardKinematics_TextChanged(object sender, EventArgs e)
        {
            if (txtForwardKinematics.Focused == true)
            {
                int nNum = 0;
                m_C3d.GetHeader_pstrKinematics()[nNum] = txtForwardKinematics.Text;

                byte[] byteData = Encoding.Default.GetBytes(txtForwardKinematics.Text);
                m_C3d.GetHeader_pSEncryptKinematics_encryption()[nNum].byteEncryption = Ojw.CEncryption.Encryption(true, byteData);
                byteData = null;
            }
        }

        private bool m_bAngle_NoUpdate = false;
        private void BlockUpdate(bool bBlock) { m_bAngle_NoUpdate = bBlock; }
        private void UpdateMotorCommand()
        {
            if (m_bAngle_NoUpdate == true) return;
            for (int i = 0; i < m_txtAngle.Length; i++) m_C3d.SetData(i, Ojw.CConvert.StrToFloat(m_txtAngle[i].Text));
        }
        private void txtT0_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT1_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT2_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT3_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT4_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT5_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT6_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT7_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT8_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void GetPosition_Click(object sender, EventArgs e)
        {
            BlockUpdate(true);
            for (int i = 0; i < m_txtAngle.Length; i++) m_txtAngle[i].Text = Ojw.CConvert.FloatToStr(m_C3d.GetData(i));
            BlockUpdate(false);
        }
        private float m_fZ = 15.0f;
        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            int nW = 5000;// 1000;
            int nH = 5000;// 1000;
            int nHeightRange = 5000;// 1000;
            float fX = 0.0f;
            float fY = 0.0f;
            float fZ = m_fZ;//0.0f;
            
            m_fZ += 5.0f; // For test
            
            Draw_Clear();

            #region Points
#if true
            List<Ojw.SVector3D_t> SVec_True = new List<Ojw.SVector3D_t>();
            List<Ojw.SVector3D_t> SVec_False = new List<Ojw.SVector3D_t>();
            SVec_True.Clear();
            SVec_False.Clear();

            int nStep = 200;
            int i = 0, j = 0, k = 0;
            for (i = -nW / 2; i < nW / 2; i += nStep)
                for (j = -nH / 2; j < nH / 2; j += nStep)
                    for (k = -nHeightRange / 2; k < nHeightRange / 2; k += nStep)
                {
                    fX = (float)i / 1000.0f;
                    fY = (float)j / 1000.0f;
                    fZ = m_fZ + (float)k / 1000.0f;
                    if (MoveXYZ(fX, fZ, fY) == true) SVec_True.Add(new Ojw.SVector3D_t(fX, fZ, fY));
                    else SVec_False.Add(new Ojw.SVector3D_t(fX, fZ, fY)); 

                    //if (
                    //    ((fX > -1) && (fX < 1)) &&
                    //    ((fY > -1) && (fY < 1))
                    //)
                    //    SVec_True.Add(new Ojw.SVector3D_t(fX, fZ, fY));
                    //else
                    //    SVec_False.Add(new Ojw.SVector3D_t(fX, fZ, fY));                    
                }

            // 보기 좋게 디바이스 위치를 좀 내려둔다.
            MoveXYZ(0, 5, 0);

            m_C3d.User_Set_Color(Color.Red);
            m_C3d.User_Set_Init(true); // 초기좌표 기준
            m_C3d.User_Set_Model("#16"); // 15: Point, 16: Points
            m_C3d.User_Set_Points_Clear();
            foreach (Ojw.SVector3D_t SVec in SVec_True)
            {
                m_C3d.User_Set_Points_Add(SVec.x, SVec.y, SVec.z);
            }
            m_C3d.User_Add();

            m_C3d.User_Set_Color(Color.Blue);
            m_C3d.User_Set_Init(true); // 초기좌표 기준
            m_C3d.User_Set_Model("#16"); // 15: Point, 16: Points
            m_C3d.User_Set_Points_Clear();
            foreach (Ojw.SVector3D_t SVec in SVec_False)
            {
                m_C3d.User_Set_Points_Add(SVec.x, SVec.y, SVec.z);
            }
            m_C3d.User_Add();
#endif
            #endregion Points
            #region Balls
#if false
            for (int i = -nW / 2; i < nW / 2; i++)
                for (int j = -nH / 2; j < nH / 2; j++)
                {
                    fX = (float)i / 10.0f;
                    fY = (float)j / 10.0f;

                    //Draw_Point(Color.Red, fX, fZ, fY);
                    //Draw_Line(Color.Red, 0, 0, 0, fX, fZ, fY);
                    Draw_Ball(Color.Red, 0.01f, fX, fZ, fY);
                }
#endif
            #endregion Balls
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
