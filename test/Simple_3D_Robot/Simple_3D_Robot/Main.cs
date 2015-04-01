using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

// For Use
//  1. 참조(reference) - 참조추가(add reference) - 찾아보기(search) - DLL 선택(OpenJigWare.dll)
//  2. add "using OpenJigWare" as follow
//  3. 다른 예제들과 다르게 3d 에서는 Tao 관련 DLL 전부를 Add 해야 한다.(Add all [Tao....dll] files)
//  4. freeglut.dll 파일을 실행 폴더에 같이 복사해 두어야 한다.(You need to copy freeglut.dll file to your [release folder].
using OpenJigWare;

namespace Simple_3D_Robot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private void Main_Load(object sender, EventArgs e)
        {
            // 이것만 선언하면 기본 선언은 끝.
            m_C3d.Init(picDisp);

            Ojw.CMessage.Init(txtMessage);

            // property window
            m_C3d.CreateProb_VirtualObject(pnProperty);
            
            if (m_C3d.FileOpen(@"16dof_ecoHead.ojw") == true) // 모델링 파일이 잘 로드 되었다면 
            {
                Ojw.CMessage.Write("File Opened");
                // 그림을 그리기 위한 timer 가동
                tmrDraw.Enabled = true;

                // 설정된 마우스 이벤트를 사용할 것인지...(기본은 사용하도록 되어 있다. User의 Function만 사용하길 원한다면 false)
                //m_C3d.SetMouseEventEnable(true); // you can remove the default mouse events.
                
                // Add User Function
                m_C3d.AddMouseEvent_Down(OjwMouseDown);
                m_C3d.AddMouseEvent_Move(OjwMouseMove);
                m_C3d.AddMouseEvent_Up(OjwMouseUp);
                m_C3d.Gridview_Init(dgAngle, 70, 999);
                //InitGridView
            }
            else Application.Exit();
            Ojw.CMessage.Write("Ready");
            CheckForIllegalCrossThreadCalls = false;
        }
        private bool m_bRequestPick = false;
        private void OjwMouseDown(object sender, MouseEventArgs e)
        {
            m_bRequestPick = true;
        }
        private void OjwMouseMove(object sender, MouseEventArgs e)
        {
        }
        private void OjwMouseUp(object sender, MouseEventArgs e)
        {
        }
        private bool m_bProgEnd = false;

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_bProgEnd = true;
        }
        private void ShowData(bool bPick)
        {
            txtTest.Text = String.Empty;

            if (bPick == false)
            {
                Ojw.CMessage.Write2(txtTest, "There is no any parts for controlling");
                return;
            }
            // 클릭했으니 메세지를 한번 보여주자(show messages when it click)	
            Ojw.CMessage.Write2(txtTest, "Current Joint Group = " + Ojw.CConvert.IntToStr(m_nGroupA) + "\r\n");
            Ojw.CMessage.Write2(txtTest, "Current Motor Number = " + Ojw.CConvert.IntToStr(m_nGroupB) + "\r\n");
            Ojw.CMessage.Write2(txtTest, "Current Serve Group Number = " + Ojw.CConvert.IntToStr(m_nGroupC) + "\r\n");
            Ojw.CMessage.Write2(txtTest, "Connected Function number(but, 255 is None)=" + Ojw.CConvert.IntToStr(m_nKinematicsNumber) + "\r\n");
            Ojw.C3d.COjwDesignerHeader CHeader = m_C3d.GetHeader();

            // 수식부분이 선택된게 아니라면...(if there is no function number...)
            if ((m_nKinematicsNumber == 255) && (m_nGroupB < CHeader.nMotorCnt))
            {
                if (m_nGroupA > 0) // Is there a data?
                {
                    Ojw.CMessage.Write2(txtTest, Ojw.CConvert.IntToStr(m_nGroupB) + "번모터(Name : " + Ojw.CConvert.RemoveChar(CHeader.pSMotorInfo[m_nGroupB].strNickName, (char)0) + ")\r\n");
                    Ojw.CMessage.Write2(txtTest, "MotorID =" + Ojw.CConvert.IntToStr(CHeader.pSMotorInfo[m_nGroupB].nMotorID) + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Direction =" + ((CHeader.pSMotorInfo[m_nGroupB].nMotorDir == 0) ? "Forward" : "Inverse"));
                    Ojw.CMessage.Write2(txtTest, "Limit(Max : but 0 -> there is no Limit)=" + ((CHeader.pSMotorInfo[m_nGroupB].fLimit_Up != 0.0f) ? Ojw.CConvert.FloatToStr(CHeader.pSMotorInfo[m_nGroupB].fLimit_Up) + " 도" : "리미트 없음") + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Limit(Min : but 0 -> there is no Limit)=" + ((CHeader.pSMotorInfo[m_nGroupB].fLimit_Down != 0.0f) ? Ojw.CConvert.FloatToStr(CHeader.pSMotorInfo[m_nGroupB].fLimit_Down) + " 도" : "리미트 없음") + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Center(EVD) : 0도에 해당하는 EVD 값 =" + Ojw.CConvert.IntToStr(CHeader.pSMotorInfo[m_nGroupB].nCenter_Evd) + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Mech Mov=" + Ojw.CConvert.IntToStr(CHeader.pSMotorInfo[m_nGroupB].nMechMove) + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Angle of Mech M =" + Ojw.CConvert.FloatToStr(CHeader.pSMotorInfo[m_nGroupB].fMechAngle) + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Initial Position =" + Ojw.CConvert.FloatToStr(CHeader.pSMotorInfo[m_nGroupB].fInitAngle) + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "NickName =" + Ojw.CConvert.RemoveChar(CHeader.pSMotorInfo[m_nGroupB].strNickName, (char)0) + "\r\n");
                    Ojw.CMessage.Write2(txtTest, "Motor\'s Group Number =" + Ojw.CConvert.IntToStr(CHeader.pSMotorInfo[m_nGroupB].nGroupNumber) + "\r\n");
                    //Ojw.CMessage.Write2(txtTest, );
                    //Ojw.CMessage.Write2(txtTest, );

                    // Motor Check(relationship)
                    int nMotID = m_nGroupB;
                    if (CHeader.pSMotorInfo[nMotID].nAxis_Mirror == -1) Ojw.CMessage.Write2(txtTest, "이 모터는 Mirror 시 값의 변형을 주지 않는다.(No Changing when it has command [flip]");
                    else if (CHeader.pSMotorInfo[nMotID].nAxis_Mirror == -2) Ojw.CMessage.Write2(txtTest, "이 모터는 Mirror 시 Motor 의 Center Point 를 중심으로 뒤집도록 한다.(ex: -30 도 -> 30 도)");
                    else Ojw.CMessage.Write2(txtTest, "Current Motor number = " + Ojw.CConvert.IntToStr(nMotID) + ", Mirroring Motor number = " + Ojw.CConvert.IntToStr(CHeader.pSMotorInfo[nMotID].nAxis_Mirror));
                }
                else
                {
                    Ojw.CMessage.Write2(txtTest, "There is a part without controlling");
                }
            }
            else if (m_nKinematicsNumber != 255) // 수식 번호가 선택된 경우
            {
                float fX, fY, fZ;
                Ojw.CKinematics.CForward.CalcKinematics(CHeader.pDhParamAll[m_nKinematicsNumber], m_C3d.GetData(), out fX, out fY, out fZ);
                Ojw.CMessage.Write2(txtTest, "연동되는 수식의 번호(Connected Function Number) = " + Ojw.CConvert.IntToStr(m_nKinematicsNumber) + "\r\n");
                Ojw.CMessage.Write2(txtTest, "Current Position (x,y,z)=" + Ojw.CConvert.FloatToStr((float)Ojw.CMath.Round(fX, 3)) + "," + Ojw.CConvert.FloatToStr((float)Ojw.CMath.Round(fY, 3)) + "," + Ojw.CConvert.FloatToStr((float)Ojw.CMath.Round(fZ, 3)) + "\r\n");
            }
            else Ojw.CMessage.Write2(txtTest, "There is no any parts for controlling");
        }

        private int m_nGroupA, m_nGroupB, m_nGroupC;
        private int m_nKinematicsNumber;
        private bool m_bPick;
        private bool m_bLimit;

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
#if false
            m_C3d.OjwDraw();
#else
            //bool bPick = false;
            m_C3d.OjwDraw(out m_nGroupA, out m_nGroupB, out m_nGroupC, out m_nKinematicsNumber, out m_bPick, out m_bLimit);
            if (m_bRequestPick == true)
            {
                m_bRequestPick = false;

                ShowData(m_bPick);
            }
#endif
        }

        private void dgAngle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgAngle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Ojw.CMessage.Write(e.RowIndex.ToString() + "," + e.ColumnIndex.ToString());
            //m_C3d.Gridview_Draw(e.RowIndex);
        }

        private void btnValueIncrement_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Plus, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueDecrement_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Minus, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueMul_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Mul, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueDiv_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Div, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueStackIncrement_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Inc, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueStackDecrement_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Dec, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueChange_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Change, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnValueFlip_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Flip_Value, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Interpolation, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnInterpolation2_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._S_Curve, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Calc(Ojw.ECalc_t._Flip_Position, Ojw.CConvert.StrToFloat(txtChangeValue.Text)); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_Clear();
        }

        private void btnGroup1_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_SetSelectedGroup(1);
        }

        private void btnGroup2_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_SetSelectedGroup(2);
        }

        private void btnGroup3_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_SetSelectedGroup(3);
        }

        private void btnGroupDel_Click(object sender, EventArgs e)
        {
            m_C3d.GridView_SetSelectedGroup(0);
        }

        private bool m_bStop = false;
        private Thread m_thRun;
        private void btnRun_Click(object sender, EventArgs e)
        {
            m_bStop = false;
            Ojw.CTimer.Reset(); // Clear the Stop bit;

            m_thRun = new Thread(new ThreadStart(Run));
            m_thRun.Start();
        }
        private void Run()
        {
            for (int i = 0; i < m_C3d.GridView_GetLines(); i++)
            {
                if (m_C3d.GridView_GetEnable(i) == true)
                {
                    int nTime = m_C3d.GridView_GetTime(i);
                    int nDelay = m_C3d.GridView_GetDelay(i);
                    int nWait = nTime + nDelay;

                    m_C3d.Gridview_Draw(i);
                    if (nWait > 0)
                        Ojw.CTimer.Wait(nWait);

                    if ((m_bStop == true) || (m_bProgEnd == true))
                    {
                        Ojw.CMessage.Write("Motion Stoped by Stop Message");
                        return;
                    }
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_bStop = true;
            Ojw.CTimer.Stop();
        }
    }
}
