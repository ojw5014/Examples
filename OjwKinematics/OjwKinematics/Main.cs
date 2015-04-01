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
        TextBox[] m_atxtAngle = new TextBox[256];
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private Ojw.CGridView m_CGridView = new Ojw.CGridView();
        private float[] m_afAngle = new float[4096]; // save the angles (value)
        #endregion Step 1 - Var
        #region Init / DInit
        private void Init()
        {
            Array.Clear(m_afAngle, 0, m_afAngle.Length);
            InitMessage();
            Init3D();
            InitGridView();
        }
        private void Init3D()
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);
            m_C3d.CreateProb_VirtualObject(pnProperty);

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

            cmbDhRefresh(0);

            tmrDraw.Enabled = true;
        }

        private void cmbDhRefresh(int nNum)
        {
            if ((nNum >= 0) && (nNum < cmbDh.Items.Count))
            {
                Ojw.CEncryption.SetEncrypt("OJW5014"); // 암호화 해제는 보안이 필요
                String strForward = Encoding.Default.GetString(Ojw.CEncryption.Encryption(false, m_C3d.GetHeader_pSEncryptKinematics_encryption()[nNum].byteEncryption));

                if (strForward != null)
                {
                    CDhParamAll CDh = new CDhParamAll();
                    if (strForward.Length > 0)
                    {
                        Ojw.CKinematics.CForward.MakeDhParam(strForward, out CDh);

                        SetDHString(strForward);//CDh);
                    }
                }

                Ojw.CEncryption.SetEncrypt("OJW5014"); // 암호화 해제는 보안이 필요
                txtInverseKinematics.Text = Encoding.Default.GetString(Ojw.CEncryption.Encryption(false, m_C3d.GetHeader_pSEncryptInverseKinematics_encryption()[nNum].byteEncryption));

                txtGroupName.Text = m_C3d.GetHeader_pstrGroupName()[nNum];
                cmbDh.SelectedIndex = nNum;

                cmbSecret.SelectedIndex = m_C3d.GetHeader_pnSecret()[nNum];
                cmbKinematicsType.SelectedIndex = m_C3d.GetHeader_pnType()[nNum];
            }
        }
        private void InitGridView()
        {
            // GridView
            int nWidth = 65;
            int nLines = 0;
            m_CGridView.Create(dgAngle, nLines,
                new Ojw.SGridTable_t("a", nWidth, 0, -1, Color.DarkOrange, 0),
                new Ojw.SGridTable_t("d", nWidth, 0, -1, Color.DarkOrange, 0),
                new Ojw.SGridTable_t("Theta", nWidth, 0, -1, Color.Orange, 0),
                new Ojw.SGridTable_t("alpha", nWidth, 0, -1, Color.DarkOrange, 0),
                new Ojw.SGridTable_t("axis", nWidth, 0, -1, Color.Green, -1),
                new Ojw.SGridTable_t("dir", nWidth, 0, -1, Color.YellowGreen, 0)
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

        private Label [] m_albAngle = null;
        private void MakeBox(int nCnt)
        {            
            if (nCnt > 0)
            {
                int nColCount = 6;
                int nRowCount = 5;
                int nMax = nColCount * nRowCount;

                m_albAngle = new Label[nCnt];
                m_atxtAngle = new TextBox[nCnt];

                int nGapLeft = 40;// 80;// 12;
                //int nGapRight = 0;// -42;// 5;
                int nWidth = 60;// 35;
                int nHeight = 18;
                
                int nLableWidth = 32;
                int nLableOffset = nLableWidth;// 29;


                int nWidth_Offset = nLableWidth + 10;// (this.Width - (nGapLeft + nGapRight) - (nWidth * nCnt)) / nCnt;
                int nHeight_Offset = 5;

                TabPage tp = null;//new TabPage();
                int nPage = 0;
                for (int i = 0; i < nCnt; i++)
                {
                    nPage = i / nMax;
                    try
                    {
                        String strName = "tabPg" + Ojw.CConvert.IntToStr(nPage);
                        if (this.Controls.Find("tabPg" + Ojw.CConvert.IntToStr(nPage), true).Length > 0)
                        {
                            if ((tp == null) || (tp.Name != strName))
                            {
                                tp = (TabPage)(this.Controls.Find("tabPg" + Ojw.CConvert.IntToStr(nPage), true)[0]);
                                tp.BackColor = Color.White;
                                tp.Text = Ojw.CConvert.IntToStr(nMax * nPage) +
                                    " ~ " +
                                    Ojw.CConvert.IntToStr(((nMax * (nPage + 1) - 1) < nCnt) ? (nMax * (nPage + 1) - 1) : nCnt - 1);
                            }
                        }
                        else
                        {
                            if ((tp == null) || (tp.Name != strName))
                            {
                                tp = new TabPage();
                                tp.Name = strName;
                                tp.BackColor = Color.White;
                                tp.Text = Ojw.CConvert.IntToStr(nMax * nPage) +
                                " ~ " +
                                Ojw.CConvert.IntToStr(((nMax * (nPage + 1) - 1) < nCnt) ? (nMax * (nPage + 1) - 1) : nCnt - 1);
                                tabAngle.Controls.Add(tp);
                            }
                        }
                    }
                    catch
                    {
                     //   if (tp == null)
                     //   {
                        tp = new TabPage("tabPg" + Ojw.CConvert.IntToStr(nPage));
                        tp.Text = Ojw.CConvert.IntToStr(nMax * nPage) +
                                " ~ " +
                                Ojw.CConvert.IntToStr(((nMax * (nPage + 1) - 1) < nCnt) ? (nMax * (nPage + 1) - 1) : nCnt - 1);
                        tabAngle.Controls.Add(tp);
                     //   }
                    }

                    if (tp == null) break;

                    int nPos = i % nColCount;
                    int nLine = (i % (nColCount * nRowCount)) / nColCount;
                    m_atxtAngle[i] = new TextBox();
                    m_atxtAngle[i].Top = (nHeight_Offset) * (nLine + 1) + (nHeight + nHeight_Offset) * nLine;
                    m_atxtAngle[i].Left = nGapLeft + nWidth * nPos + nWidth_Offset * nPos;
                    m_atxtAngle[i].Width = nWidth;
                    m_atxtAngle[i].Height = nHeight;
                    m_atxtAngle[i].Name = "txtAngle" + Ojw.CConvert.IntToStr(nPos);
                    m_atxtAngle[i].Text = "0.0";
                    m_atxtAngle[i].Visible = true;
                    m_atxtAngle[i].TextAlign = HorizontalAlignment.Center;
                    m_atxtAngle[i].TextChanged += new System.EventHandler(m_atxtAngle_TextChanged);
                    tp.Controls.Add(m_atxtAngle[i]);

                    m_albAngle[i] = new Label();
                    m_albAngle[i].Top = 5 + m_atxtAngle[i].Top;
                    m_albAngle[i].Height = nHeight;
                    m_albAngle[i].Width = nLableWidth;
                    m_albAngle[i].Name = "lbAngle" + Ojw.CConvert.IntToStr(nPos);
                    m_albAngle[i].Text = Ojw.CConvert.IntToStr(i, 3);
                    m_albAngle[i].Left = m_atxtAngle[i].Left - nLableOffset;// m_albPos[i].Width - 1;
                    tp.Controls.Add(m_albAngle[i]);
                    //tp = null;
                }
            }
        }

        private bool m_bAngle_NoUpdate = false;
        private void BlockUpdate(bool bBlock) { m_bAngle_NoUpdate = bBlock; }
        private void m_atxtAngle_TextChanged(object sender, EventArgs e)
        {
            if (m_bAngle_NoUpdate == true) return;
            int nCnt = m_atxtAngle.Length;
            for (int i = 0; i < nCnt; i++)
            {
                if (m_atxtAngle[i].Focused == true)
                {
                    m_afAngle[i] = Ojw.CConvert.StrToFloat(m_atxtAngle[i].Text);
                    MoveToDhPosition(m_fBallSize, 1.0f, Color.Red, m_afAngle);
                    break;
                }
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            txtBallSize.Text = Ojw.CConvert.FloatToStr(m_fBallSize);
            txtStickSize.Text = Ojw.CConvert.FloatToStr(m_fStickSize);

            #region 각도 테스트용 텍스트 박스 배열 매핑
            MakeBox(256);
            //for (int i = 0; i < m_atxtAngle.Length; i++) m_atxtAngle[i] = (TextBox)(this.Controls.Find("txtAngle" + Ojw.CConvert.IntToStr(i), true)[0]);
            #endregion 각도 테스트용 텍스트 박스 배열 매핑

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

            m_C3d.OjwDraw(m_afAngle);

            m_btmrDraw = false;
            tmrDraw.Enabled = true;
        }
        #endregion Drawing

        private void btnCheckDH_Click(object sender, EventArgs e)
        {
            BlockUpdate(true);
            for (int i = 0; i < 256; i++)
                m_atxtAngle[i].Text = Ojw.CConvert.FloatToStr(m_C3d.GetData(i));
            BlockUpdate(false);
            MoveToDhPosition(Ojw.CConvert.StrToFloat(txtBallSize.Text), 1.0f, Color.Red, m_afAngle);
        }
        private void SetDHString(String strDh)
        {
            String [] astrLines = strDh.Split('\n');
            int nLine = 0;
            m_bMiddleOfInserting = true;
            //m_CGridView.Clear();
            m_CGridView.Delete();
            foreach (string strLine in astrLines)
            {
                string strTmp = 
                    Ojw.CConvert.RemoveChar(
                        Ojw.CConvert.RemoveChar(
                            Ojw.CConvert.RemoveChar(
                                Ojw.CConvert.RemoveCaption(strLine, true, true), 
                            '\r'),
                        '['), 
                    ']');
                if (strTmp.Length > 0)
                {
                    int nIndex = 0;
                    String[] astrDatas = strTmp.Split(',');

                    m_CGridView.Add(1);
#if true
                    m_CGridView.SetEnable(nLine, true);
                    
#if false
                    foreach (string strItem in astrDatas)
                    {
                        switch(nIndex)
                        {
                            case 0: Ojw.CMessage.Write2("A(" + strItem + ")"); break;
                            case 1: Ojw.CMessage.Write2("D(" + strItem + ")"); break;
                            case 2: Ojw.CMessage.Write2("Theta(" + strItem + ")"); break;
                            case 3: Ojw.CMessage.Write2("Alpha(" + strItem + ")"); break;
                            case 4: Ojw.CMessage.Write2(",Axis(" + strItem + ")"); break;
                            case 5: Ojw.CMessage.Write2("Dir(" + strItem + ")"); break;
                        }
                        nIndex++;
                    }
                    Ojw.CMessage.Write2("\r\n");
#else
                    foreach (string strItem in astrDatas) m_CGridView.Set(nLine, nIndex++, strItem);
                    nLine++;
#endif

#else
                    
                    m_CGridView.Set(nIndex, 0, strItem); // A
                    m_CGridView.Set(nIndex, 1, strItem); // D
                    m_CGridView.Set(nIndex, 2, strItem); // Theta
                    m_CGridView.Set(nIndex, 3, strItem); // Alpha

                    m_CGridView.Set(nIndex, 4, strItem); // Axis
                    m_CGridView.Set(nIndex, 5, strItem); // Dir
#endif

                    m_bMiddleOfInserting = false;
                }
            }
        }
        private void SetDHString(CDhParamAll CDh)
        {

            m_bMiddleOfInserting = true;
            m_CGridView.Clear();
            m_CGridView.Add(CDh.GetCount());
            for (int i = 0; i < CDh.GetCount(); i++)
            {
                m_CGridView.SetEnable(i, true);
                m_CGridView.Set(i, 0, CDh.GetData(i).dA); // A
                m_CGridView.Set(i, 1, CDh.GetData(i).dD); // D
                m_CGridView.Set(i, 2, CDh.GetData(i).dTheta); // Theta
                m_CGridView.Set(i, 3, CDh.GetData(i).dAlpha); // Alpha

                m_CGridView.Set(i, 4, CDh.GetData(i).nAxisNum); // Axis
                m_CGridView.Set(i, 5, CDh.GetData(i).nAxisDir); // Dir
            }
            m_bMiddleOfInserting = false;
        }
        private String GetDHString()
        {
            String strData = String.Empty;
            String strDisp = String.Empty;
            m_C3d.SetHeader_strDrawModel(String.Empty);
            for (int i = 0; i < m_CGridView.GetLineCount(); i++)
            {
                if (m_CGridView.GetEnable(i) == true)
                {                        
                    float fA = 0.0f;
                    float fD = 0.0f;
                    float fTheta = 0.0f;
                    float fAlpha = 0.0f;
                    int nAxis = -1;
                    int nDir = 0;
                    //m_C3d.Prop_Set_Height_Or_Depth(
                    for (int j = 0; j < m_CGridView.GetTableCount(); j++)
                    {
                        try
                        {
                            switch (j)
                            {
                                case 0: fA = Ojw.CConvert.StrToFloat(m_CGridView.GetData(i, j).ToString()); break;
                                case 1: fD = Ojw.CConvert.StrToFloat(m_CGridView.GetData(i, j).ToString()); break;
                                case 2: fTheta = Ojw.CConvert.StrToFloat(m_CGridView.GetData(i, j).ToString()); break;
                                case 3: fAlpha = Ojw.CConvert.StrToFloat(m_CGridView.GetData(i, j).ToString()); break;
                                case 4: nAxis = Ojw.CConvert.StrToInt(m_CGridView.GetData(i, j).ToString()); break;
                                case 5: nDir = Ojw.CConvert.StrToInt(m_CGridView.GetData(i, j).ToString()); break;
                            }
                        }
                        catch
                        {
                            switch (j)
                            {
                                case 0: fA = 0.0f; break;
                                case 1: fD = 0.0f; break;
                                case 2: fTheta = 0.0f; break;
                                case 3: fAlpha = 0.0f; break;
                                case 4: nAxis = 0; break;
                                case 5: nDir = 0; break;
                            }
                        }
                        strData += Convert.ToString(m_CGridView.GetData(i, j)) + ((j < m_CGridView.GetTableCount() - 1) ? "," : String.Empty);                    
                    }
                    if (i < m_CGridView.GetLineCount() - 1) strData += "\r\n";

                    
                        //m_C3d.Prop_Set_DispObject("#2");


                    m_C3d.Prop_Set_DispObject("#9");
                    m_C3d.Prop_Set_Width_Or_Radius(m_fStickSize);
                    m_C3d.AddVirtualClassToReal();

                    m_C3d.Prop_Set_DispObject("#8");
                    if (fD < 0)
                    {
                        //m_C3d.Prop_Set_Offset_Trans(new Ojw.SVector3D_t(fA, 0, 0));
                        m_C3d.Prop_Set_Offset_Rot(new Ojw.SAngle3D_t(180, 0, 0));
                        m_C3d.Prop_Set_Width_Or_Radius(m_fStickSize);
                        m_C3d.Prop_Set_Height_Or_Depth(-fD);
                    }
                    else m_C3d.Prop_Set_Height_Or_Depth(fD);
                    m_C3d.AddVirtualClassToReal();


                    m_C3d.Prop_Set_DispObject("#9");
                    m_C3d.Prop_Set_Width_Or_Radius(m_fStickSize);
                    m_C3d.Prop_Set_Offset_Trans(new Ojw.SVector3D_t(0, 0, fD));


                    m_C3d.Prop_Set_Name(nAxis);
                    if ((nDir == 0) || (nDir == 1)) m_C3d.Prop_Set_AxisMoveType(2);
                    else if ((nDir == 2) || (nDir == 3)) m_C3d.Prop_Set_AxisMoveType(3);
                    if ((nDir == 0) || (nDir == 2)) m_C3d.Prop_Set_Dir(0);
                    else if ((nDir == 1) || (nDir == 3)) m_C3d.Prop_Set_Dir(1);
                    
                    m_C3d.AddVirtualClassToReal();

                    m_C3d.Prop_Set_DispObject("#8");
                    if (fA < 0)
                    {
                        m_C3d.Prop_Set_Offset_Trans(new Ojw.SVector3D_t(0, 0, fD));
                        m_C3d.Prop_Set_Offset_Rot(new Ojw.SAngle3D_t(-90, fTheta, 0));
                        m_C3d.Prop_Set_Width_Or_Radius(m_fStickSize);
                        m_C3d.Prop_Set_Height_Or_Depth(-fA);
                    }
                    else
                    {
                        m_C3d.Prop_Set_Offset_Trans(new Ojw.SVector3D_t(0, 0, fD));
                        m_C3d.Prop_Set_Offset_Rot(new Ojw.SAngle3D_t(90, -fTheta, 0));
                        m_C3d.Prop_Set_Width_Or_Radius(m_fStickSize);
                        m_C3d.Prop_Set_Height_Or_Depth(fA);
                    }
                    m_C3d.AddVirtualClassToReal();
                    
                    //float fAngle = ((nAxis >= 0) ? m_afAngle[i] : 0.0f) * (float)Math.Pow(-1, nDir);
                    //float fDist = fAngle;
                    //if (nDir < 2) fDist = 0.0f;
                    //else fAngle = 0.0f;



                    m_C3d.Prop_Set_DispObject("#9");
                    //m_C3d.Prop_Set_Name(nAxis);
                    //if ((nDir == 0) || (nDir == 1)) m_C3d.Prop_Set_AxisMoveType(1);
                    //else if ((nDir == 2) || (nDir == 3)) m_C3d.Prop_Set_AxisMoveType(3);
                    //if ((nDir == 0) || (nDir == 2)) m_C3d.Prop_Set_Dir(1); // 반대각으로 돈다. 실제와 다르게... -_-;;;
                    //else if ((nDir == 1) || (nDir == 3)) m_C3d.Prop_Set_Dir(0);
                    
                    m_C3d.Prop_Set_Width_Or_Radius(m_fStickSize);
                    //m_C3d.Prop_Set_Height_Or_Depth(fA);
                    m_C3d.Prop_Set_Trans_1(new Ojw.SVector3D_t(0, 0, fD));
                    m_C3d.Prop_Set_Rot_1(new Ojw.SAngle3D_t(0, 0, fTheta));
                    m_C3d.Prop_Set_Trans_2(new Ojw.SVector3D_t(fA, 0, 0));
                    m_C3d.Prop_Set_Rot_2(new Ojw.SAngle3D_t(0, fAlpha, 0));

                    m_C3d.AddVirtualClassToReal();
                    strDisp = m_C3d.GetHeader_strDrawModel();
                }
            }
            //m_C3d.SetHeader_strDrawModel(txtDraw.Text);
            

            m_C3d.SetHeader_strDrawModel(strDisp);
            m_C3d.CompileDesign();
            return strData;
        }
        private bool m_bMiddleOfInserting = false;
        private void dgAngle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (m_bMiddleOfInserting == false)
            {
                chkDh.Checked = true;
                m_C3d.SetTestDh(chkDh.Checked);

                //m_C3d.User_Clear();
                String strData = GetDHString();

                //if (dgAngle.Focused == true)
                //{
                int nNum = 0;

                // 나중을 위해서 실제 해석 헤더에도 넣어둔다.
                m_C3d.GetHeader_pstrKinematics()[nNum] = strData;

                byte[] byteData = Encoding.Default.GetBytes(strData);
                m_C3d.GetHeader_pSEncryptKinematics_encryption()[nNum].byteEncryption = Ojw.CEncryption.Encryption(true, byteData);
                byteData = null;

                // Compile
                Compile_DhNotation();

                // and Next... Show the compiling result
                // show string Matrix
                MakeString_CalcKinematics();

                // Show result(3d Ball)
                m_C3d.SetTestDh(chkDh.Checked);
                //float fBallSize = 2.0f;
                MoveToDhPosition(m_fBallSize, 1.0f, Color.Red);
                //}

                //m_C3d.Prop
            }
        }
        private float m_fBallSize = 10.0f;
        private float m_fStickSize = 10.0f;
        private CDhParamAll m_COjwDhParamAll = new CDhParamAll();
        private void Compile_DhNotation()
        {
            Ojw.CKinematics.CForward.MakeDhParam(GetDHString(), out m_COjwDhParamAll);
        }
        private void MakeString_CalcKinematics(params float[] afAngle)
        {
            String strResult;
            // 만들어진 수식을 알고 싶다면 여기 결과값을 리턴받는다.
            double[] adMot = new double[afAngle.Length];
            Array.Clear(adMot, 0, adMot.Length);
            for (int i = 0; i < afAngle.Length; i++) adMot[i] = (double)afAngle[i];//(double)m_C3d.GetData(i);
            Ojw.CKinematics.CForward.CalcKinematics_ToString(m_COjwDhParamAll, adMot, out strResult);
            txtKinematicsString.Text = strResult;
        }
        private void MoveToDhPosition(float fSize, float fAlpha, Color cColor, params float [] afAngle)
        {
            int i;
            double dX, dY, dZ;
            double[] dcolX;
            double[] dcolY;
            double[] dcolZ;

            double[] adMot = new double[afAngle.Length];
            Array.Clear(adMot, 0, adMot.Length);            
            for (i = 0; i < afAngle.Length; i++) adMot[i] = (double)afAngle[i];//(double)m_C3d.GetData(i);
            Ojw.CKinematics.CForward.CalcKinematics(m_COjwDhParamAll, adMot, out dcolX, out dcolY, out dcolZ, out dX, out dY, out dZ);
                      
            // DH 결과 눈으로 확인
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

        private void btnCompile_Kinematics_Click(object sender, EventArgs e)
        {

        }

        private void chkDh_CheckedChanged(object sender, EventArgs e)
        {
            m_C3d.SetTestDh(chkDh.Checked);
        }

        private void txtBallSize_TextChanged(object sender, EventArgs e)
        {
            m_fBallSize = Ojw.CConvert.StrToFloat(txtBallSize.Text);
        }

        private void txtStickSize_TextChanged(object sender, EventArgs e)
        {
            m_fStickSize = Ojw.CConvert.StrToFloat(txtStickSize.Text);
        }

        private void dgAngle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MoveToDhPosition(m_fBallSize, 1.0f, Color.Red, m_afAngle);
        }

        private void txtInverseKinematics_TextChanged(object sender, EventArgs e)
        {
            if (txtInverseKinematics.Focused == true)
            {
                int nNum = ((cmbDh.SelectedIndex < 0) ? 0 : cmbDh.SelectedIndex);
                m_C3d.GetHeader_pstrInverseKinematics()[nNum] = txtInverseKinematics.Text;

                byte[] byteData = Encoding.Default.GetBytes(txtInverseKinematics.Text);
                m_C3d.GetHeader_pSEncryptInverseKinematics_encryption()[nNum].byteEncryption = Ojw.CEncryption.Encryption(true, byteData);
                byteData = null;
            }
        }

        private void dgAngle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            FileOpenEvent();
        }
        private void FileOpenEvent()
        {
            OpenFileDialog ofdDesign = new OpenFileDialog();

            m_C3d.SetAseFile_Path("ase"); // set ase file path

            ofdDesign.FileName = "*." + Ojw.C3d._STR_EXT;
            ofdDesign.Filter = "디자인 파일(*." + Ojw.C3d._STR_EXT + ")|*." + Ojw.C3d._STR_EXT;

            ofdDesign.DefaultExt = Ojw.C3d._STR_EXT;
            if (ofdDesign.ShowDialog() == DialogResult.OK)
            {
                String fileName = ofdDesign.FileName;
                if (m_C3d.FileOpen(fileName) == false)
                {
                    MessageBox.Show("It's not a our Modeling File.");
                }
                else
                {
                    this.Text = "Design File - " + fileName + "(v" + m_C3d.m_strVersion + ")";

                    #region DH
                    cmbDhRefresh(0);
                    #endregion DH

                    //cmbVersion.SelectedIndex = m_C3d.m_strVersion - 11;
                    float[] afData = new float[3];
                    m_C3d.GetPos_Display(out afData[0], out afData[1], out afData[2]);
                    int i = 0;
                    //txtDisplay_X.Text = Ojw.CConvert.FloatToStr(afData[i++]);
                    //txtDisplay_Y.Text = Ojw.CConvert.FloatToStr(afData[i++]);
                    //txtDisplay_Z.Text = Ojw.CConvert.FloatToStr(afData[i++]);
                    m_C3d.GetAngle_Display(out afData[0], out afData[1], out afData[2]);
                    i = 0;
                    //txtDisplay_Pan.Text = Ojw.CConvert.FloatToStr(afData[i++]);
                    //txtDisplay_Tilt.Text = Ojw.CConvert.FloatToStr(afData[i++]);
                    //txtDisplay_Swing.Text = Ojw.CConvert.FloatToStr(afData[i++]);
                    //DispModelString(); // make a tree
                    //txtDraw.Text = m_C3d.GetHeader_strDrawModel();

                    //m_strFileName = fileName;
                }
            }
        }

        private void cmbDh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDh.Focused == true)
            {
                cmbDhRefresh(cmbDh.SelectedIndex);
            }
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGroupName.Focused == true) m_C3d.GetHeader_pstrGroupName()[cmbDh.SelectedIndex] = txtGroupName.Text;
            }
            catch
            {
            }
        }

        private void cmbSecret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSecret.Focused == true)
            {
                m_C3d.GetHeader_pnSecret()[cmbDh.SelectedIndex] = cmbSecret.SelectedIndex;
            }
        }

        private void cmbKinematicsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKinematicsType.Focused == true) m_C3d.GetHeader_pnType()[cmbDh.SelectedIndex] = cmbKinematicsType.SelectedIndex;
        }

        private void btnChangePos_Click(object sender, EventArgs e)
        {
            int nNum = ((cmbDh.SelectedIndex < 0) ? 0 : cmbDh.SelectedIndex);
            //cmbDhRefresh(nNum);
            
            float fX = Ojw.CConvert.StrToFloat(txtPos_X.Text);
            float fY = Ojw.CConvert.StrToFloat(txtPos_Y.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtPos_Z.Text);

            // 집어넣기 전에 내부 메모리를 클리어 한다.
            Ojw.CKinematics.CInverse.SetValue_ClearAll(ref m_C3d.GetHeader_pSOjwCode()[nNum]);
            Ojw.CKinematics.CInverse.SetValue_X(fX);
            Ojw.CKinematics.CInverse.SetValue_Y(fY);
            Ojw.CKinematics.CInverse.SetValue_Z(fZ);
            //m_COjwDhParamAll

            // 테스트 시작
            m_C3d.SetTestCircle(true);
            //m_C3d.Settes
            m_C3d.SetColor_Test(Color.Red);
            // 테스트 값 입력
            m_C3d.SetSize_Test(Ojw.CConvert.StrToFloat(txtBallSize.Text));
            m_C3d.SetPos_Test(fX, fY, fZ);

            // 현재의 모터각을 전부 집어 넣도록 한다.
            //UpdateMotorCommand();
            for (int i = 0; i < 256; i++)
            {
                // 모터값을 3D에 넣어주고
                m_C3d.SetData(i, Ojw.CConvert.StrToFloat(m_atxtAngle[i].Text));
                // 그 값을 꺼내 수식 계산에 넣어준다.
                Ojw.CKinematics.CInverse.SetValue_Motor(i, m_C3d.GetData(i));
            }

            // 실제 수식계산
            Ojw.CKinematics.CInverse.CalcCode(ref m_C3d.GetHeader_pSOjwCode()[nNum]);

            //lbV.Text = String.Empty;
            //for (int i = 0; i < 10; i++)
            //{
            //    lbV.Text += "V" + i.ToString() + ":" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(i)) + ",";
            //}
            // 나온 결과값을 옮긴다.
            int nMotCnt = m_C3d.GetHeader_pSOjwCode()[nNum].nMotor_Max;
            for (int i = 0; i < nMotCnt; i++)
            {
                int nMotNum = m_C3d.GetHeader_pSOjwCode()[nNum].pnMotor_Number[i];
                m_C3d.SetData(nMotNum, (float)Ojw.CKinematics.CInverse.GetValue_Motor(nMotNum));
                m_afAngle[nMotNum] = m_C3d.GetData(nMotNum);
                //m_txtAngle[nMotNum].Text = Ojw.CConvert.FloatToStr((float)Ojw.CKinematics.CInverse.GetValue_Motor(nMotNum));
            }
            BlockUpdate(true);
            for (int i = 0; i < 256; i++)
            {
                m_atxtAngle[i].Text = Ojw.CConvert.FloatToStr(m_C3d.GetData(i));
            }
            BlockUpdate(false);
        }

        private void btnCompile_Kinematics_Click_1(object sender, EventArgs e)
        {
            m_C3d.CheckForward();
            m_C3d.CheckInverse();
        }

        private void btnGroup1_Click(object sender, EventArgs e)
        {
            m_CGridView.SetSelectedGroup(1);
        }

        private void btnGroup2_Click(object sender, EventArgs e)
        {
            m_CGridView.SetSelectedGroup(2);
        }

        private void btnGroup3_Click(object sender, EventArgs e)
        {
            m_CGridView.SetSelectedGroup(3);
        }

        private void btnGroupDel_Click(object sender, EventArgs e)
        {
            m_CGridView.SetSelectedGroup(0);
        }
    }
}
