// made by Jinwook, On - ojw5014@hanmail.net
// using with Open Jigware(by Jinwook, On)
// License - GPL v2(everything is free)

//#define _DEF_NORMAL
//#define _DEF_POSE // Defined Motion : need to Unlock Motion(Double tab)
#define _DEF_ORIENTATION
#define _DEF_EMG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MyoSharp.Communication;
using MyoSharp.Device;
//using MyoSharp.ConsoleSample.Internal;
using MyoSharp.Exceptions;

using OpenJigWare;
using MyoSharp.Poses;

namespace testMyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Ojw.C3d m_C3d = new Ojw.C3d();

        IChannel m_myoChannel;
        IHub m_myoHub;
        IHeldPose m_myoPos;

        private static Ojw.CGraph m_CGrap = null;
        private TextBox[] m_txtAngle = new TextBox[15];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < m_txtAngle.Length; i++) m_txtAngle[i] = (TextBox)(this.Controls.Find("txtT" + Ojw.CConvert.IntToStr(i), true)[0]);
#if _DEF_EMG
            InitJesture();

            m_bFilter = chkFilter.Checked;
            m_fAlpha = Ojw.CConvert.StrToFloat(txtAlpha.Text);
            m_bAnother = chkAnother.Checked;
            m_bStep2 = chkStep2.Checked;

            //InitHistory(lbGraph.Width/10);
            // Graph
            m_CGrap = new Ojw.CGraph(lbGraph, lbGraph.Width, Color.White, null, 
                Color.Red, 
                Color.Blue, 
                Color.Green, 
                Color.Cyan, 
                Color.Violet, 
                Color.Purple, 
                Color.Magenta, 
                Color.Orange
                );
#endif
            Ojw.CMessage.Init(txtMessage);

            m_myoChannel = Channel.Create(ChannelDriver.Create(ChannelBridge.Create(), MyoErrorHandlerDriver.Create(MyoErrorHandlerBridge.Create())));
            m_myoHub = Hub.Create(m_myoChannel);

            // 이벤트 등록            
            m_myoHub.MyoConnected += new EventHandler<MyoEventArgs>(myoHub_MyoConnected);
            m_myoHub.MyoDisconnected += new EventHandler<MyoEventArgs>(myoHub_MyoDisconnected);

            // start listening for Myo data
            m_myoChannel.StartListening();

            // wait on user input
            //ConsoleHelper.UserInputLoop(m_myoHub);
            CheckForIllegalCrossThreadCalls = false;

            #region Init 3D
            m_C3d.Init(picDisp);
            if (m_C3d.FileOpen("hand.ojw") == true)
            //if (m_C3d.FileOpen("model_5dof.ojw") == true)
            //if (m_C3d.FileOpen("16dof.ojw") == true)
            //if (m_C3d.FileOpen("4-leg.ojw") == true)
            {
                // 프로퍼티도 선언하자
                InitProperty();

                float fPan, fTilt, fSwing;
                //m_C3d.GetAngle_Display(out fPan, out fTilt, out fSwing);
                //m_C3d.SetAngle_Display(fPan, fTilt, fSwing);
                m_C3d.SetScale(0.3f);



                #region For Kinematics
                #region 0번 수식을 텍스트 박스로 옮긴다.
                cmbDhRefresh(0);
                #endregion 0번 수식을 텍스트 박스로 옮긴다.

                MoveXYZ(false, 1.0f, 0.0f, 15.0f, 0.0f);
                #endregion For Kinematics

                tmrPulse.Enabled = true;
            }
            #endregion Init 3D
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
        private bool m_bAngle_NoUpdate = false;
        private void BlockUpdate(bool bBlock) { m_bAngle_NoUpdate = bBlock; }
        private void UpdateMotorCommand()
        {
            if (m_bAngle_NoUpdate == true) return;
            for (int i = 0; i < m_txtAngle.Length; i++) m_C3d.SetData(i, Ojw.CConvert.StrToFloat(m_txtAngle[i].Text));
        }
        private void InitProperty()
        {
            m_C3d.CreateProb_VirtualObject(pnProperty);
            ///////////////// Property Open
            m_C3d.Prop_Set_MotorControl_MousePoint(0); // 0: 화면이동,   1: 제어타입
            m_C3d.Prop_Update_VirtualObject(); // 변경 사항 Update

            Ojw.CMessage.Write("Property 초기화 완료");
        }
        #region Event Handlers
        private static void Myo_PoseChanged(object sender, PoseEventArgs e)
        {
            Ojw.CMessage.Write(String.Format("{0} arm Myo detected {1} pose!", e.Myo.Arm, e.Myo.Pose));
        }

        private static void Myo_Unlocked(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write(String.Format("{0} arm Myo has unlocked!", e.Myo.Arm));
        }

        private static void Myo_Locked(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write(String.Format("{0} arm Myo has locked!", e.Myo.Arm));
        }
        private static Ojw.CTimer m_CTId0 = new Ojw.CTimer();
        private static Ojw.CTimer m_CTId1 = new Ojw.CTimer();
        private static Ojw.CTimer m_CTId2 = new Ojw.CTimer();
        private static Ojw.CTimer m_CTId3 = new Ojw.CTimer();
        private static void Myo_OrientationDataAcquired(object sender, OrientationDataEventArgs e)
        {
            const float PI = (float)System.Math.PI;

            int nDev = 1; //10;
            // convert the values to a 0-9 scale (for easier digestion/understanding)
            var roll = (int)((e.Roll + PI) / (PI * 2.0f) * nDev);
            var pitch = (int)((e.Pitch + PI) / (PI * 2.0f) * nDev);
            var yaw = (int)((e.Yaw + PI) / (PI * 2.0f) * nDev);

            if (m_CTId0.Get() >= 1000)
            {
                m_CTId0.Set();
                float fX = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.X), 3);
                float fY = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.Y), 3);
                float fW = (float)Math.Round(Ojw.CMath.R2D(e.Orientation.W), 3);
                float fSwing = (float)Math.Round(Ojw.CMath.R2D(e.Roll), 3);
                float fTilt = (float)Math.Round(Ojw.CMath.R2D(e.Pitch), 3);
                float fPan = (float)Math.Round(Ojw.CMath.R2D(e.Yaw), 3);
                m_C3d.SetRobot_Rot(fPan - 90.0f, -fTilt, -fSwing);
                Ojw.CMessage.Write("Pan[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fPan), " ", 7, false) + 
                    "], Tilt[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fTilt), " ", 7, false) +
                    "], Swing[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fSwing), " ", 7, false) + "]" +
                    "Oriental(X[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fX), " ", 7, false) +
                    "], Y[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fY), " ", 7, false) +
                    "], W[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fW), " ", 7, false) + "])");
                //Ojw.CMessage.Write("Oriental(Swing[" + Ojw.CConvert.IntToStr(roll) + "], Tilt[" + Ojw.CConvert.IntToStr(pitch) + "], Pan[" + Ojw.CConvert.IntToStr(yaw) + "], X[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fX), " ", 7, false) + "], Y[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fY), " ", 7, false) + "], W[" + Ojw.CConvert.FillString(Ojw.CConvert.FloatToStr(fW), " ", 7, false) + "]");
                //Ojw.CMessage.Write(String.Format("Oriental(Swing, Tilt, Pan): {0}\t{1}\t{2}\t*****]t{3}\t{4}\t{5}", roll, pitch, yaw, e.Orientation.X, e.Orientation.Y, e.Orientation.W));
            }
        }
        #region Event Handlers
        private static int m_nMyoJesture = -1;
        private static void Pose_Triggered(object sender, PoseEventArgs e)
        {
            //if (m_CTId1.Get() >= 100)
            {
                m_CTId1.Set();
                //Ojw.CMessage.Write(String.Format("{0} arm Myo is holding pose {1}!", e.Myo.Arm, e.Pose));
                //if (e.Pose = 
                m_nMyoJesture = (int)e.Pose;
                //m_nMyoJesture = 
            }
        }
        #endregion
        #region Event Handlers
        private const float _REST = 25.0f;
        private static int[] m_anData = new int[8];
        private static int[] m_anData_Back = new int[8];
        private const int _DATA_HISTORY = 10;
        private static bool[] m_abData_Set = new bool[8];
        private static int [,] m_anValue_Back = new int[8, _DATA_HISTORY];
        private static bool m_bCapture = false;
        private static void Myo_EmgDataAcquired(object sender, EmgDataEventArgs e)
        {
            if (m_CTId2.Get() >= 1000)
            {
                m_CTId2.Set();
                // TODO: write your code to interpret EMG data!
                Ojw.CMessage.Write(String.Format("Emg = {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", 
                    e.EmgData.GetDataForSensor(0),
                    e.EmgData.GetDataForSensor(1),
                    e.EmgData.GetDataForSensor(2),
                    e.EmgData.GetDataForSensor(3),
                    e.EmgData.GetDataForSensor(4),
                    e.EmgData.GetDataForSensor(5),
                    e.EmgData.GetDataForSensor(6), 
                    e.EmgData.GetDataForSensor(7)));
            }
#if _DEF_EMG
            if (m_CTId3.Get() >= 100)
            {
                m_CTId3.Set();

                float fAlpha = m_fAlpha;
                for (int i = 0; i < 8; i++)
                {
                    //m_anData[i] = e.EmgData.GetDataForSensor(i);
                    if (m_bFilter == true)
                    {
                        if (m_bAnother == true)
                            m_anData[i] = (int)Ojw.CMath.LowPassFilter(fAlpha, (float)m_anData[i], (int)Math.Abs(e.EmgData.GetDataForSensor(i)) + (int)Math.Abs(e.EmgData.GetDataForSensor(i) - m_anData_Back[i]) + (int)Math.Abs(m_anData_Back[i]));
                        else
                            m_anData[i] = (int)Ojw.CMath.LowPassFilter(fAlpha, (float)m_anData[i], (float)e.EmgData.GetDataForSensor(i));
                    }
                    else
                    {
                        if (m_bAnother == true)
                            m_anData[i] = (int)Math.Abs(e.EmgData.GetDataForSensor(i)) + (int)Math.Abs(e.EmgData.GetDataForSensor(i) - m_anData_Back[i]);
                        else
                            m_anData[i] = e.EmgData.GetDataForSensor(i);
                    }

                    m_anData_Back[i] = e.EmgData.GetDataForSensor(i);
                }
                if (m_bStep2 == true)
                {
                    int nValue = 30;// 30;// 50;
                    //int nRange = 25;
                    //m_CGrap.Push(
                    //    (int)(m_anData[0] / nValue) * nValue,
                    //    (int)(m_anData[1] / nValue) * nValue,
                    //    (int)(m_anData[2] / nValue) * nValue,
                    //    (int)(m_anData[3] / nValue) * nValue,
                    //    (int)(m_anData[4] / nValue) * nValue,
                    //    (int)(m_anData[5] / nValue) * nValue,
                    //    (int)(m_anData[6] / nValue) * nValue,
                    //    (int)(m_anData[7] / nValue) * nValue
                    //);
                    int[] anValue = new int[m_anData.Length];
                    //Array.Copy(m_anValue_Back, 1, m_anValue_Back.Le

                    for (int i = 0; i < m_anData.Length; i++)
                    {
                        int nCnt = 0;
                        for (int j = 0; j < _DATA_HISTORY - 1; j++)
                        {
                            m_anValue_Back[i, _DATA_HISTORY - 1 - j] = m_anValue_Back[i, _DATA_HISTORY - 1 - (j + 1)];                            
                        }
                        anValue[i] = (int)(m_anData[i] / nValue) * nValue;
                        if (anValue[i] >= nValue) anValue[i] = nValue;
                        else anValue[i] = 0;
                        m_anValue_Back[i, 0] = anValue[i];
                        for (int j = 0; j < _DATA_HISTORY; j++)
                        {
                            if (m_anValue_Back[i, j] != 0) nCnt++;                            
                        }


                        if (m_abData_Set[i] == false)
                        {
                            if (nCnt >= 7) m_abData_Set[i] = true;
                        }
                        else
                        {
                            if (nCnt <= 2) m_abData_Set[i] = false;
                        }

                        //if ((nCnt * 100 / _DATA_HISTORY) > 60) anValue[i] = nValue;
                        //else if ((nCnt * 100 / _DATA_HISTORY) < 40) anValue[i] = 0;
                        //else anValue[i] = m_anValue_Back[i, 1];
                    }

                    m_CGrap.Push(
                        ((m_abData_Set[0] == true) ? nValue : 0),
                        ((m_abData_Set[1] == true) ? nValue : 0),
                        ((m_abData_Set[2] == true) ? nValue : 0),
                        ((m_abData_Set[3] == true) ? nValue : 0),
                        ((m_abData_Set[4] == true) ? nValue : 0),
                        ((m_abData_Set[5] == true) ? nValue : 0),
                        ((m_abData_Set[6] == true) ? nValue : 0),
                        ((m_abData_Set[7] == true) ? nValue : 0)
                    );

                    if (m_bCapture == true)
                    {
                        RememberPose(m_nPos);
                    }

                    //m_CGrap.Push(
                    //    anValue[0],
                    //    anValue[1],
                    //    anValue[2],
                    //    anValue[3],
                    //    anValue[4],
                    //    anValue[5],
                    //    anValue[6],
                    //    anValue[7]
                    //);

                    int nPos = CheckJesture();
                    //int nPos = CheckJesture(
                    //    ((m_abData_Set[0] == true) ? nValue : 0),
                    //    ((m_abData_Set[1] == true) ? nValue : 0),
                    //    ((m_abData_Set[2] == true) ? nValue : 0),
                    //    ((m_abData_Set[3] == true) ? nValue : 0),
                    //    ((m_abData_Set[4] == true) ? nValue : 0),
                    //    ((m_abData_Set[5] == true) ? nValue : 0),
                    //    ((m_abData_Set[6] == true) ? nValue : 0),
                    //    ((m_abData_Set[7] == true) ? nValue : 0)
                    //);
                    if (nPos >= 0) Ojw.CMessage.Write2("Pos => " + nPos.ToString());
                    m_nJesture = nPos;
#if false
                    #region Pos
                    if ((nPos >= 0) && (nPos != (int)EMyoPos_t.Fist) && (nPos != (int)EMyoPos_t.Spread))// && (m_nMyoJesture != (int)Pose.Rest))
                    {
                        int i;
                        if (nPos == (int)EMyoPos_t.FirstFinger)
                        {
                            Ojw.CMessage.Write("First Finger");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            i += 2;
                            // 검지
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.MiddleFinger)
                        {
                            Ojw.CMessage.Write("Middle Finger");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            i += 2;
                            // 검지
                            i += 3;
                            // 중지
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.LittleFinger)
                        {
                            Ojw.CMessage.Write("Little Finger");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            i += 2;
                            // 검지
                            i += 3;
                            // 중지
                            i += 3;
                            // 약지
                            i += 3;
                            // 새끼
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.Fist)
                        {
                            Ojw.CMessage.Write("Fist");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 80.0f);
                            m_C3d.SetData(14, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.Spread)
                        {
                            Ojw.CMessage.Write("Spread");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 0.0f);
                            m_C3d.SetData(14, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.V)
                        {
                            Ojw.CMessage.Write("Jesture V");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            m_C3d.SetData(i++, _REST);
                            m_C3d.SetData(i++, _REST);
                            // 검지
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            // 중지
                            i += 3;
                            // 약지
                            i += 3;
                            // 새끼
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else
                        {
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                        }
                    }
                    else
                    {
                        int i;
                        if (m_nMyoJesture == (int)Pose.Fist)
                        {
                            Ojw.CMessage.Write("(Myo)Fist");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 80.0f);
                            m_C3d.SetData(14, 0.0f);
                        }
                        else if (m_nMyoJesture == (int)Pose.FingersSpread)
                        {
                            Ojw.CMessage.Write("(Myo)Finger Spread");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 0.0f);
                        }
                        else if (m_nMyoJesture == (int)Pose.WaveIn)
                        {
                            Ojw.CMessage.Write("(Myo)Wave in");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 0.0f);
                            m_C3d.SetData(14, 70.0f);
                        }
                        else if (m_nMyoJesture == (int)Pose.WaveOut)
                        {
                            Ojw.CMessage.Write("(Myo)Wave out");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 0.0f);
                            m_C3d.SetData(14, -70.0f);
                        }
                        else
                        {
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                        }
                    }
                    #endregion Pos
#else
                    if (nPos >= 0)
                    {
                        int i;
                        if (nPos == (int)EMyoPos_t.FirstFinger)
                        {
                            Ojw.CMessage.Write("First Finger");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            i += 2;
                            // 검지
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.MiddleFinger)
                        {
                            Ojw.CMessage.Write("Middle Finger");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            i += 2;
                            // 검지
                            i += 3;
                            // 중지
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.LittleFinger)
                        {
                            Ojw.CMessage.Write("Little Finger");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            i += 2;
                            // 검지
                            i += 3;
                            // 중지
                            i += 3;
                            // 약지
                            i += 3;
                            // 새끼
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.Fist)
                        {
                            Ojw.CMessage.Write("Fist");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 80.0f);
                            m_C3d.SetData(14, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.Spread)
                        {
                            Ojw.CMessage.Write("Spread");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, 0.0f);
                            m_C3d.SetData(14, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.V)
                        {
                            Ojw.CMessage.Write("Jesture V");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            m_C3d.SetData(i++, _REST);
                            m_C3d.SetData(i++, _REST);
                            // 검지
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            // 중지
                            i += 3;
                            // 약지
                            i += 3;
                            // 새끼
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                            m_C3d.SetData(i++, 0.0f);
                        }
                        else if (nPos == (int)EMyoPos_t.Thumb)
                        {
                            Ojw.CMessage.Write("Jesture Thumb");
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                            i = 0;
                            // 엄지
                            m_C3d.SetData(i++, 0);
                            m_C3d.SetData(i++, 0);
                            // 검지
                            i += 3;
                            // 중지
                            i += 3;
                            // 약지
                            i += 3;
                            // 새끼
                            i += 3;
                        }
                        else
                        {
                            for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                            m_C3d.SetData(14, 0.0f);
                        }
                    }
                    else
                    {
                        int i;
                        for (i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                        m_C3d.SetData(14, 0.0f);
                    }
#endif
                }
                else
                {
                    for (int i = 0; i < 20; i++) m_C3d.SetData(i, _REST);
                    m_C3d.SetData(14, 0.0f);
                    m_CGrap.Push(
                        m_anData[0],
                        m_anData[1],
                        m_anData[2],
                        m_anData[3],
                        m_anData[4],
                        m_anData[5],
                        m_anData[6],
                        m_anData[7]
                    );
                }
                m_CGrap.OjwDraw();
            }
#endif
        }
        #endregion
        #endregion

        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            m_CTId0.Set();
            m_CTId1.Set();
            m_CTId2.Set();
            m_CTId3.Set();
            Ojw.CMessage.Write(String.Format("Myo {0} has connected!", e.Myo.Handle));
            e.Myo.Vibrate(VibrationType.Short);
            e.Myo.Unlock(UnlockType.Hold); 
            Ojw.CMessage.Write("접속");
#if _DEF_NORMAL
            e.Myo.PoseChanged += Myo_PoseChanged;
            e.Myo.Locked += Myo_Locked;
            e.Myo.Unlocked += Myo_Unlocked;
#endif
#if _DEF_ORIENTATION
            e.Myo.OrientationDataAcquired += Myo_OrientationDataAcquired;
#endif
#if _DEF_EMG
            e.Myo.EmgDataAcquired += Myo_EmgDataAcquired;
            e.Myo.SetEmgStreaming(true);
            //tmrPulse.Enabled = true;
#endif
            #region Pose
#if _DEF_POSE
            // unlock the Myo so that it doesn't keep locking between our poses
            //e.Myo.Unlock(UnlockType.Hold);

            // setup for the pose we want to watch for
            m_myoPos = HeldPose.Create(e.Myo, Pose.Fist, Pose.FingersSpread, Pose.WaveIn, Pose.WaveOut, Pose.Rest);
            // set the interval for the event to be fired as long as 
            // the pose is held by the user
            m_myoPos.Interval = TimeSpan.FromSeconds(0.5);

            e.Myo.Unlock(UnlockType.Timed);
            m_myoPos.Start();
            m_myoPos.Triggered += Pose_Triggered;
#endif
            #endregion
        }
        private void myoHub_MyoDisconnected(object sender, MyoEventArgs e)
        {
#if _DEF_NORMAL
            e.Myo.PoseChanged -= Myo_PoseChanged;
            e.Myo.Locked -= Myo_Locked;
            e.Myo.Unlocked -= Myo_Unlocked;
#endif
#if _DEF_ORIENTATION
            e.Myo.OrientationDataAcquired -= Myo_OrientationDataAcquired;
#endif
#if _DEF_POSE
            m_myoPos.Stop();
            m_myoPos.Triggered -= Pose_Triggered;
#endif
#if _DEF_EMG
            e.Myo.SetEmgStreaming(false);
            e.Myo.EmgDataAcquired -= Myo_EmgDataAcquired;
            //tmrPulse.Enabled = false;
#endif
            Ojw.CMessage.Write("접속해제");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_myoHub.Dispose();
            m_myoChannel.Dispose();
        }

        private bool m_btmrPulse = false;
        private void tmrPulse_Tick(object sender, EventArgs e)
        {
            if (m_btmrPulse == true) return;
            m_btmrPulse = true;
            tmrPulse.Enabled = false;
            OjwDraw();
            m_btmrPulse = false;
            tmrPulse.Enabled = true;
        }
                
        private void OjwDraw()
        {
            m_C3d.OjwDraw();
#if _DEF_EMG
#if false
            int[] anPos = new int[8];
            int nMax = 700;
            int nMin = 50;
            for (int i = 0; i < anPos.Length; i++)
            {
                anPos[i] = nMax - (nMax - nMin) / anPos.Length * i;
            }
            //DrawPixel(m_nHistory_Max, 300, 200, 100, 1, 2, lbGraph, true, true, true, m_anX, m_anY, m_anZ);
            DrawPixel(m_nHistory_Max, anPos, 1, 1, lbGraph,
                m_anData0,
                m_anData1,
                m_anData2,
                m_anData3,
                m_anData4,
                m_anData5,
                m_anData6,
                m_anData7);   
#else
#endif
#endif
        }
        private static bool m_bFilter = false;
        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            m_bFilter = chkFilter.Checked;
            if (m_bFilter == true)
                m_fAlpha = Ojw.CConvert.StrToFloat(txtAlpha.Text);
        }

        private static float m_fAlpha = 0.2f;
        private void txtAlpha_TextChanged(object sender, EventArgs e)
        {
            m_fAlpha = Ojw.CConvert.StrToFloat(txtAlpha.Text);
        }
        private static bool m_bAnother = false;
        private void chkAnother_CheckedChanged(object sender, EventArgs e)
        {
            m_bAnother = chkAnother.Checked;
        }

        private static bool m_bStep2 = false;
        private void chkStep2_CheckedChanged(object sender, EventArgs e)
        {
            m_bStep2 = chkStep2.Checked;
        }
#if _DEF_EMG
#if false
        Pen penRed = new Pen(Color.Red, 2);
        Pen penBlue = new Pen(Color.Blue, 2);
        Pen penGreen = new Pen(Color.Green, 2);
        Pen penBlack = new Pen(Color.Black, 2);
        Pen penViolet = new Pen(Color.Violet, 2);
        Pen penOrange = new Pen(Color.Orange, 2);
        Pen penCyan = new Pen(Color.Cyan, 2);
        Pen penGray = new Pen(Color.Gray, 2);
        Pen[] ppenPen = new Pen[8];
        private void InitColor()
        {
            int i = 0;
            ppenPen[i++] = penBlack;
            ppenPen[i++] = penRed;
            ppenPen[i++] = penBlue;
            ppenPen[i++] = penGreen;
            ppenPen[i++] = penViolet;
            ppenPen[i++] = penOrange;
            ppenPen[i++] = penCyan;
            ppenPen[i++] = penGray;
        }
        private void DrawPixel(int nMax, int [] anPos, int nStretchWidth, int nStretchHeight, Label lb,            
            int[] anData0, 
            int[] anData1, 
            int[] anData2, 
            int[] anData3, 
            int[] anData4, 
            int[] anData5, 
            int[] anData6, 
            int[] anData7)
        {
            //Bitmap bmpDisp = this.Properties.Resources.Graph_Back;
            Bitmap bmpDisp = new Bitmap(lb.Width, lb.Height);
            using (Graphics g = Graphics.FromImage(bmpDisp))
            {
                int kkk;
                //Graphics g = Graphics.FromHwnd(lb.Handle);
                int i = 0;

                int nCnt = 8;
                int[] anOffsetY = new int[nCnt];
                for (kkk = 0; kkk < nCnt; kkk++)
                {
                    anOffsetY[kkk] = lb.Height - anPos[kkk];
                }
                int nStretch = nStretchWidth;
                int nMulti = nStretchHeight;
                int nPos0, nPos1;
                //int nPen = 0;

                g.Clear(Color.White);
#if false
                #region 기준선
            int nRange = 4;
            
            // 기준선 그리기
            for (kkk = 0; kkk < nCnt; kkk++)
            {
                g.DrawLine(penBlack, 0, anOffsetY[kkk], lb.Width, anOffsetY[kkk]);
                for (int j = 1; j < nRange; j++)
                {
                    g.DrawLine(penCyan, 0, anOffsetY[kkk] + j * 10, lb.Width, anOffsetY[kkk] + j * 10);
                    g.DrawLine(penCyan, 0, anOffsetY[kkk] - j * 10, lb.Width, anOffsetY[kkk] - j * 10);
                }
            }
            
            nRange--;
            // 세로 기준선 그리기

            for (int j = 1; j < lb.Width / 50; j++)
                g.DrawLine(penBlack, j * 50, anOffsetY[0] - nRange * 10, j * 50, anOffsetY[nCnt - 1] + nRange * 10);


            nPen++;
                #endregion 기준선
#endif
                #region 세로라인들...
                Pen pen = new Pen(Color.Orange, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                int nX = 0;
                float fTimeVal = 5000; // 초단위 격자 만들기
                int nInterval_Time_Value = 50;
                float fStretchWidth = 1.0f;
                for (i = 1; i <= 10; i++)
                {
                    nX = (int)Math.Round((float)i * fTimeVal / (float)nInterval_Time_Value * fStretchWidth, 0);
                    g.DrawLine(pen, nX, 0, nX, lbGraph.Height - 1);
                }
                pen.Dispose();
                #endregion 세로라인들...

                //for (kkk = 0; kkk < nCnt; kkk++)
                //{
                //    for (i = 1; i < m_nHistory_Max; i++)
                //    {
                //        nPos0 = lb.Width - (i - 1);// *nStretch;
                //        nPos1 = lb.Width - i;// *nStretch;

                //        //if ((nPos0 < nMax) && (nPos1 < nMax) && (nPos0 >= 0) && (nPos1 >= 0))
                //        //{
                //            int nData0 = ((kkk == 0) ? anData0[i - 1] : ((kkk == 1) ? anData1[i - 1] : ((kkk == 2) ? anData2[i - 1] : ((kkk == 3) ? anData3[i - 1] : ((kkk == 4) ? anData4[i - 1] : ((kkk == 5) ? anData5[i - 1] : ((kkk == 6) ? anData6[i - 1] : anData7[i - 1])))))));
                //            int nData1 = ((kkk == 0) ? anData0[i] : ((kkk == 1) ? anData1[i] : ((kkk == 2) ? anData2[i] : ((kkk == 3) ? anData3[i] : ((kkk == 4) ? anData4[i] : ((kkk == 5) ? anData5[i] : ((kkk == 6) ? anData6[i] : anData7[i])))))));
                //            //g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - nData0 * nMulti, nPos1, anOffsetY[kkk] - nData1 * nMulti);
                //            g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - nData0, nPos1, anOffsetY[kkk] - nData1);
                //        //}                    
                //    }
                //    //nPen++;
                //}
                kkk = 0;

                for (i = 1; i < m_nHistory_Max; i++)
                {
                    nPos0 = lb.Width - (i - 1);// *nStretch;
                    nPos1 = lb.Width - i;// *nStretch;

                    //if ((nPos0 < nMax) && (nPos1 < nMax) && (nPos0 >= 0) && (nPos1 >= 0))
                    //{
                    kkk = 0;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData0[i - 1], nPos1, anOffsetY[kkk] - anData0[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData1[i - 1], nPos1, anOffsetY[kkk] - anData1[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData2[i - 1], nPos1, anOffsetY[kkk] - anData2[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData3[i - 1], nPos1, anOffsetY[kkk] - anData3[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData4[i - 1], nPos1, anOffsetY[kkk] - anData4[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData5[i - 1], nPos1, anOffsetY[kkk] - anData5[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData6[i - 1], nPos1, anOffsetY[kkk] - anData6[i]);
                    kkk++;
                    g.DrawLine(ppenPen[kkk], nPos0, anOffsetY[kkk] - anData7[i - 1], nPos1, anOffsetY[kkk] - anData7[i]);
                    kkk++;
                    //}                    
                }

                //if (
                //    (bX == true) || (bY == true) || (bZ == true)
                //    ) OjwMessage("\r\n");

                //g.Dispose();
            }
            lb.Image = bmpDisp;
        }
#endif
#endif



        private static int[] m_anIndex = new int[8];
        //private bool bThumb = false;
        //private bool 
        public enum EMyoPos_t
        {
            Spread,
            Fist,
            V,
            FirstFinger,
            MiddleFinger,
            LittleFinger,
            Left,
            Right,
            Thumb,
            _Count
        }

        private static int m_nJesture = -1;
        public static int GetJesture()
        {
            return m_nJesture;
        }
        private static int[,] m_anJesture = new int[(int)EMyoPos_t._Count, 8];//{{},
        
        private static int[,] m_anHand = new int[2,(int)EMyoPos_t._Count];
        private static void RememberPose(int nHand)
        {
            m_anHand[0, nHand] =
                (
                ((m_abData_Set[0] == false) ? 0 : 0x80) |
                ((m_abData_Set[1] == false) ? 0 : 0x40) |
                ((m_abData_Set[2] == false) ? 0 : 0x20) |
                ((m_abData_Set[3] == false) ? 0 : 0x10) |
                ((m_abData_Set[4] == false) ? 0 : 0x08) |
                ((m_abData_Set[5] == false) ? 0 : 0x04) |
                ((m_abData_Set[6] == false) ? 0 : 0x02) |
                ((m_abData_Set[7] == false) ? 0 : 0x01)
                );
            m_anHand[1, nHand] =
                (
                ((m_abData_Set[7] == false) ? 0 : 0x80) |
                ((m_abData_Set[6] == false) ? 0 : 0x40) |
                ((m_abData_Set[5] == false) ? 0 : 0x20) |
                ((m_abData_Set[4] == false) ? 0 : 0x10) |
                ((m_abData_Set[3] == false) ? 0 : 0x08) |
                ((m_abData_Set[2] == false) ? 0 : 0x04) |
                ((m_abData_Set[1] == false) ? 0 : 0x02) |
                ((m_abData_Set[0] == false) ? 0 : 0x01)
                );
        }
        //private static bool m_bMakedPos = false;
        private static int CheckJesture()//params int[] anData)
        {
            if (m_nMask != 0xff) return -1;
            int i = 0;
            //if (m_bMakedPos == false) return -1;
            /*
                    1,2,3,8 = 1110 0001     = 0xe1       1000 0111 = 0x87 => 엄지
            1,4,8 - 주먹 ( 1001 0001 = 0x91 <=> 1000 1001 = 0x89 )
            //1,3 - 보자기 ( 1010 0000 = 0xa0 <=> 0000 0101 = 0x05 )
            3,4,7 - 보자기 ( 0011 0010 = 0x32 <=> 0100 1100 = 0x4c )
            1,4,8 - 검지 ( 1001 0001 = 0x91 <=> 1000 1001 = 0x89 )
            3,4,8 - 중지 ( 0011 0001 = 0x31 <=> 1000 1100 = 0x8c )
            3,8 - 새끼   ( 0010 0001 = 0x21 <=> 1000 0100 = 0x84 }
            3,7 - 좌     ( 0010 0010 = 0x22 <=> 0100 0100 = 0x44 )
            3,4 - 우     ( 0011 0000 = 0x30 <=> 0000 1100 = 0x0c )
            */
            int nRet = -1;
            int nCnt = 4;// 10;
            int nModelCount = m_CGrap.GetCount_Model();
            int nHistoryCount = m_CGrap.GetCount_History();
            int [] anHistory = new int[nModelCount];
            Array.Clear(anHistory, 0, anHistory.Length);
            // Data 수집
            int nData = 0;
            for (i = 0; i < nModelCount; i++)
            {
                nData = 0;
                //for (int j = nHistoryCount - nCnt; j < nHistoryCount; j++)
                if (nCnt == 1)
                {
                    anHistory[i] = ((m_abData_Set[i] == true) ? 1 : 0); // Current Data
                }
                else
                {
                    for (int j = 0; j < nCnt; j++)
                    {
                        nData += (m_CGrap.Pop(i, j) > 0) ? 1 : 0;
                    }
                    //nData += ((m_abData_Set[i] == true) ? 1 : 0); // Current Data
                    anHistory[i] = (nData >= nCnt / 2) ? 1 : 0;
                }
            }
            // Pose Check
            int nIndex = 0;
            int nTmp = 0;
            int nTmpData = 0;
            //for (int i = 0; i < nModelCount; i++)
            i = 0;
            {
                nData = 0;
                nTmpData = 0;
                for (int j = 0; j < nModelCount; j++)
                {
                    nTmp = (j + nIndex) % nModelCount;
                    nTmpData |= (anHistory[nTmp] << j);
                }

                if (nRet == -1)
                {
                    if (((nTmpData & m_anHand[0, (int)EMyoPos_t.Thumb]) == m_anHand[0, (int)EMyoPos_t.Thumb]) || ((nTmpData & m_anHand[1, (int)EMyoPos_t.Thumb]) == m_anHand[1, (int)EMyoPos_t.Thumb])) nRet = (int)EMyoPos_t.Thumb; // 엄지
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.Fist]) == m_anHand[0, (int)EMyoPos_t.Fist]) || ((nTmpData & m_anHand[1, (int)EMyoPos_t.Fist]) == m_anHand[1, (int)EMyoPos_t.Fist])) nRet = (int)EMyoPos_t.Fist; // 주먹
                    //else if (((nTmpData & 0xa0) == 0xa0) || ((nTmpData & 0x05) == 0x05)) nRet = (int)EMyoPos_t.Spread; // 보
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.Spread])       == m_anHand[0, (int)EMyoPos_t.Spread])      || ((nTmpData & m_anHand[1, (int)EMyoPos_t.Spread])         == m_anHand[1, (int)EMyoPos_t.Spread]))         nRet = (int)EMyoPos_t.Spread; // 보
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.FirstFinger])  == m_anHand[0, (int)EMyoPos_t.FirstFinger]) || ((nTmpData & m_anHand[1, (int)EMyoPos_t.FirstFinger])    == m_anHand[1, (int)EMyoPos_t.FirstFinger]))    nRet = (int)EMyoPos_t.FirstFinger; // 검지
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.MiddleFinger]) == m_anHand[0, (int)EMyoPos_t.MiddleFinger])|| ((nTmpData & m_anHand[1, (int)EMyoPos_t.MiddleFinger])   == m_anHand[1, (int)EMyoPos_t.MiddleFinger]))   nRet = (int)EMyoPos_t.MiddleFinger; // 중지
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.LittleFinger]) == m_anHand[0, (int)EMyoPos_t.LittleFinger])|| ((nTmpData & m_anHand[1, (int)EMyoPos_t.LittleFinger])   == m_anHand[1, (int)EMyoPos_t.LittleFinger]))   nRet = (int)EMyoPos_t.LittleFinger; // 새끼
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.Left])         == m_anHand[0, (int)EMyoPos_t.Left])        || ((nTmpData & m_anHand[1, (int)EMyoPos_t.Left])           == m_anHand[1, (int)EMyoPos_t.Left]))           nRet = (int)EMyoPos_t.Left; // Left
                    else if (((nTmpData & m_anHand[0, (int)EMyoPos_t.Right])        == m_anHand[0, (int)EMyoPos_t.Right])       || ((nTmpData & m_anHand[1, (int)EMyoPos_t.Right])          == m_anHand[1, (int)EMyoPos_t.Right]))          nRet = (int)EMyoPos_t.Right; // Right
                }
                //else
                //{
                //    if (nRet == (int)EMyoPos_t.Left)
                //    {
                //        if (((nTmpData & 0x32) == 0x32) || ((nTmpData & 0x4c) == 0x4c)) nRet = (int)EMyoPos_t.Spread; // 보
                //    }
                //    else if (nRet == (int)EMyoPos_t.Right)
                //    {
                //        if (((nTmpData & 0x32) == 0x32) || ((nTmpData & 0x4c) == 0x4c)) nRet = (int)EMyoPos_t.Spread; // 보
                //        //else if (((nTmpData & 0x31) == 0x31) || ((nTmpData & 0x8c) == 0x8c)) nRet = (int)EMyoPos_t.MiddleFinger; // 중지
                //    }
                //}
                nIndex++;
            }
            return nRet;
        }
#if false
        private static int CheckJesture(params int[] anData)
        {
            int nRet = -1;
            List<int> lstTmp = new List<int>();
            int nCnt = 0;
            int nCnt_Prev = 0;
            for (int i = 0; i < anData.Length; i++)
            {
                if (anData[i] == 0)
                {
                    nCnt++;
                }
                else
                {
                    nCnt++;
                    if (nCnt_Prev == 0)
                        nCnt_Prev = nCnt;
                    else
                        lstTmp.Add(nCnt);
                    nCnt = 0;
                }
                //if ((anData[i] > 0) && (anData[i - 1] > 0))
                //{
                //    nCnt++;
                //}
                //else
                //{
                //}

            }
            if (nCnt_Prev != 0) lstTmp.Add(nCnt_Prev + nCnt);
            nCnt = lstTmp.Count;
            for (int i = lstTmp.Count; i < 8; i++)
            {
                lstTmp.Add(0);
            }
            if (nCnt > 0)
            {
                //nRet = -1;
                for (int nIndex = 0; nIndex < (int)EMyoPos_t._Count; nIndex++)
                {
                    int k = 0;
                    bool bPass = true;
                    for (int i = 0; i < m_anJesture[nIndex, 0]; i++)
                    {
                        for (int j = 0; j < m_anJesture[nIndex, 0]; j++)
                        {
                            if (m_anJesture[nIndex, j + 1] != lstTmp[(j + k) % m_anJesture[nIndex, 0]]) { bPass = false; break; }
                        }
                        if (bPass == true)
                        {
                            nRet = nIndex;
                            break;
                        }
                        k++;
                    }
                    if (bPass == true)
                    {
                        nRet = nIndex;
                        break;
                    }
                }
            }

            return nRet;
        }
#endif
        private static void InitJesture()
        {
            InitData();
            int i = 0;
            // Spread
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 3;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 1;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 2;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 5;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 0;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 0;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 0;
            m_anJesture[(int)EMyoPos_t.Spread, i++] = 0;
            i = 0;
            // Fist
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 5;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 1;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 2;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 1;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 1;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 3;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 0;
            m_anJesture[(int)EMyoPos_t.Fist, i++] = 0;
            i = 0;
            // V
            m_anJesture[(int)EMyoPos_t.V, i++] = 3;
            m_anJesture[(int)EMyoPos_t.V, i++] = 4;
            m_anJesture[(int)EMyoPos_t.V, i++] = 3;
            m_anJesture[(int)EMyoPos_t.V, i++] = 1;
            m_anJesture[(int)EMyoPos_t.V, i++] = 0;
            m_anJesture[(int)EMyoPos_t.V, i++] = 0;
            m_anJesture[(int)EMyoPos_t.V, i++] = 0;
            m_anJesture[(int)EMyoPos_t.V, i++] = 0;
            i = 0;
            // MiddleFinger
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 4;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 3;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 1;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 3;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 1;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.MiddleFinger, i++] = 0;
            i = 0;
            // FirstFinger
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 4;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 3;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 2;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 2;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 1;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.FirstFinger, i++] = 0;
            i = 0;
            // LittleFinger
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 2;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 3;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 5;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 0;
            m_anJesture[(int)EMyoPos_t.LittleFinger, i++] = 0;            
        }
        private static void InitData()
        {
            Array.Clear(m_anData, 0, m_anData.Length);
            Array.Clear(m_anData_Back, 0, m_anData.Length);
            Array.Clear(m_abData_Set, 0, m_anData.Length);
            //Array.Clear(m_anValue_Back, 0, m_anData.GetLength(0) * m_anData.GetLength(1));
        }

        private void chkDh_CheckedChanged(object sender, EventArgs e)
        {
            m_C3d.SetTestDh(chkDh.Checked);
            float fBallSize = 2.0f;
            MoveToDhPosition(fBallSize, 1.0f, Color.Red);
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

        private void btnCheckDH_Click(object sender, EventArgs e)
        {
            float fBallSize = 50.0f;
            MoveToDhPosition(fBallSize, 1.0f, Color.Red);
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

        private void btnChangePos_Click(object sender, EventArgs e)
        {
            MoveXYZ(false, 1.0f, 0.0f, 15.0f, 0.0f);
        }

        private void btnKinematicsCompile_Click(object sender, EventArgs e)
        {
            m_C3d.CheckForward();
            m_C3d.CheckInverse();
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
            m_C3d.SetScale(0.3f);
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

        private void txtT0_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT1_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT2_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT3_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT4_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT5_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT6_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT7_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT8_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT9_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT10_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT11_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT12_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT13_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void txtT14_TextChanged(object sender, EventArgs e) { UpdateMotorCommand(); }
        private void GetPosition_Click(object sender, EventArgs e)
        {
            BlockUpdate(true);
            for (int i = 0; i < m_txtAngle.Length; i++) m_txtAngle[i].Text = Ojw.CConvert.FloatToStr(m_C3d.GetData(i));
            BlockUpdate(false);
        }

        private void chkUserControl_CheckedChanged(object sender, EventArgs e)
        {
            m_C3d.Prop_Set_Main_MouseControlMode(Ojw.CConvert.BoolToInt(chkUserControl.Checked)); // 0: 화면이동,   1: 제어타입
            m_C3d.Prop_Update_VirtualObject(); // 변경 사항 Update
        }

        private static int m_nPos = -1;
        private static int m_nMask = 0x00;
        private void btnThumb_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.Thumb;
            m_bCapture = true;
            m_nMask |= 0x01;
        }

        private void btnFirstFinger_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.FirstFinger;
            m_bCapture = true;
            m_nMask |= 0x02;
        }

        private void btnMiddleFinger_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.MiddleFinger;
            m_bCapture = true;
            m_nMask |= 0x04;
        }

        private void btnLittleFinger_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.LittleFinger;
            m_bCapture = true;
            m_nMask |= 0x08;
        }

        private void btnFist_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.Fist;
            m_bCapture = true;
            m_nMask |= 0x10;
        }

        private void btnSpread_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.Spread;
            m_bCapture = true;
            m_nMask |= 0x20;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.Left;
            m_bCapture = true;
            m_nMask |= 0x40;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            m_nPos = (int)EMyoPos_t.Right;
            m_bCapture = true;
            m_nMask |= 0x80;
        }
    }
}
