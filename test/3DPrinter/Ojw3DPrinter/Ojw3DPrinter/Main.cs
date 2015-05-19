using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;
using System.Threading;
using System.IO;

namespace Ojw3DPrinter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private float[] m_afPos_Prev = new float[3];
        private float[] m_afPos = new float[3];
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (m_bOrg == false)
            {
                Ojw.CMessage.Write_Error("No Org");
                return;
            }

            int i = 0;
            //m_afPos[i] = m_afPos_Prev[i] = 0.0f;
            //i++;
            //m_afPos[i] = m_afPos_Prev[i] = 0.0f;
            //i++;
            //m_afPos[i] = m_afPos_Prev[i] = 100.0f;
            //PosUpdate();
            //PosUpdate_Prev();
            m_afPos[i++] = Ojw.CConvert.StrToFloat(txtX1.Text);
            m_afPos[i++] = Ojw.CConvert.StrToFloat(txtY1.Text);
            m_afPos[i++] = Ojw.CConvert.StrToFloat(txtZ1.Text);
            
            //MoveRaw(m_afPos[0], m_afPos[1], m_afPos[2], Ojw.CConvert.StrToInt(txtSpeed.Text), true);
            
            float[] afD = new float[3];
            i = 0;
            for (i = 0; i < 3; i++) afD[i] = (m_afPos[i] - m_afPos_Prev[i]);

            float fDistance = (float)Math.Sqrt(afD[0] * afD[0] + afD[1] * afD[1] + afD[2] * afD[2]);
            //int nRps = Ojw.CConvert.StrToInt(txtSpeed.Text);
            //float fTime = Ojw.CMath.CalcTime(fDistance, (float)nRps);
            float fMax = 103.0f; //104.0f; //22000.0f;
            int nSpeed = Ojw.CConvert.StrToInt(txtSpeed.Text);
            float fTime = fMax * fDistance * 1000.0f / (float)nSpeed;
            Ojw.CMessage.Write("Time = {0}", fTime);
            MoveRaw(m_afPos[0], m_afPos[1], m_afPos[2], nSpeed, true);
            Ojw.CTimer.Wait((int)fTime);
            Ojw.CMessage.Write("Move End");
            PosUpdate();
        }
        private bool m_bMoving = false;
        private void MoveLin(float fX0, float fY0, float fZ0, float fX1, float fY1, float fZ1, float fDelta, float fSpeed)
        {
            m_bMoving = true;
            if (fDelta <= 0)
            {
                Ojw.CMessage.Write_Error("fDelta = {0}", fDelta);
                return;
            }
            if (fSpeed <= 0)
            {
                Ojw.CMessage.Write_Error("fSpeed = {0}", fSpeed);
                return;
            }
            int i = 0;
            m_afPos[i++] = fX1;
            m_afPos[i++] = fY1;
            m_afPos[i++] = fZ1;
            i = 0;
            m_afPos_Prev[i++] = fX0;
            m_afPos_Prev[i++] = fY0;
            m_afPos_Prev[i++] = fZ0;
                        
            float[] afD = new float[3];
            i = 0;
            for (i = 0; i < 3; i++) afD[i] = (m_afPos[i] - m_afPos_Prev[i]);

            float fDistance = (float)Math.Sqrt(afD[0] * afD[0] + afD[1] * afD[1] + afD[2] * afD[2]);
            int nCnt = (int)Math.Round(fDistance / fDelta, 0);
            i = 0;
            //float fDx = (float)Math.Abs(afD[i++]);
            //float fDy = (float)Math.Abs(afD[i++]);
            //float fDz = (float)Math.Abs(afD[i++]);

            float fMax = 103.0f;// 103.0f; //104.0f; //22000.0f;
            float fTime = fMax * fDistance * 1000.0f / fSpeed;
            Ojw.CMessage.Write("Time = {0}", fTime);
            Ojw.CTimer CTmr = new Ojw.CTimer();
            CTmr.Set();
            float fX, fY, fZ;
            float fPos = 0;
            for (i = 0; i < nCnt; i++)
            {
                fPos = (float)(i + 1) / (float)nCnt;
                fX = fX0 + afD[0] * fPos;
                fY = fY0 + afD[1] * fPos;
                fZ = fZ0 + afD[2] * fPos;
                if (i == nCnt - 1)
                {
                    fX = m_afPos[0];
                    fY = m_afPos[1];
                    fZ = m_afPos[2];
                }
                //MoveRaw(m_afPos[0], m_afPos[1], m_afPos[2], (int)Math.Round(fSpeed * fPos), false);
                MoveRaw(fX, fY, fZ, (int)fSpeed, false);
                //Ojw.CTimer.Wait((int)fTime);
                if (nCnt <= 0) nCnt = 1;
                float fTimeValue = fTime * (float)(i + 1) / (float)nCnt;
                if (fTimeValue <= 0) fTimeValue = 10;
                while ((m_bProgEnd == false) && (m_bStop == false))
                {
                    if (CTmr.Get() >= fTimeValue)
                    {
                        break;
                    }
                    Application.DoEvents();
                }
            }
            //Ojw.CMessage.Write("Move End");
            m_bMoving = false;
        }

        private void MoveRaw_Rapid(float fX, float fY, float fZ)
        {
            String strCmd = "G00";
            strCmd += " X" + ((fX >= 0) ? "+" : "-") + Ojw.CConvert.FloatToStr(fX);
            strCmd += " Y" + ((fY >= 0) ? "+" : "-") + Ojw.CConvert.FloatToStr(fY);
            strCmd += " Z" + ((fZ >= 0) ? "+" : "-") + Ojw.CConvert.FloatToStr(fZ);
            //strCmd += " F" + Ojw.CConvert.IntToStr(nSpeed);
                        
            Send(strCmd);
        }

        private void MoveRaw(float fX, float fY, float fZ, int nSpeed, bool bUpdate)
        {
            String strCmd = "G01"; //"G00";
            strCmd += " X" + ((fX >= 0) ? "+" : "-") + Ojw.CConvert.FloatToStr(fX);
            strCmd += " Y" + ((fY >= 0) ? "+" : "-") + Ojw.CConvert.FloatToStr(fY);
            strCmd += " Z" + ((fZ >= 0) ? "+" : "-") + Ojw.CConvert.FloatToStr(fZ);
            strCmd += " F" + Ojw.CConvert.IntToStr(nSpeed);

            int i = 0;
            m_afPos_Prev[i++] = fX;
            m_afPos_Prev[i++] = fY;
            m_afPos_Prev[i++] = fZ;

            if (bUpdate == true)
            {
                ///////////////////////////////
                PosUpdate_Prev();
            }

            Send(strCmd);
        }

        private void PosUpdate()
        {
            int i = 0;
            txtX1.Text = Ojw.CConvert.FloatToStr(m_afPos[i++]);
            txtY1.Text = Ojw.CConvert.FloatToStr(m_afPos[i++]);
            txtZ1.Text = Ojw.CConvert.FloatToStr(m_afPos[i++]);
        }
        private void PosUpdate_Prev()
        {
            int i = 0;
            txtX0.Text = Ojw.CConvert.FloatToStr(m_afPos_Prev[i++]);
            txtY0.Text = Ojw.CConvert.FloatToStr(m_afPos_Prev[i++]);
            txtZ0.Text = Ojw.CConvert.FloatToStr(m_afPos_Prev[i++]);
        }
        private Thread m_thRun;
        private Thread m_thMain;// = new Thread();
        private void Main_Load(object sender, EventArgs e)
        {
            m_strWorkDirectory = Application.StartupPath;
            Ojw.CMessage.Init(txtMessage);
            Array.Clear(m_afPos_Prev, 0, m_afPos_Prev.Length);

            CheckForIllegalCrossThreadCalls = false;
            m_thMain = new Thread(new ThreadStart(Thread_Main));
            m_thMain.Start();
        }
        private bool m_bProgEnd = false;
        private string m_strReceived = String.Empty;
        private void Thread_Main()
        {
            while (m_bProgEnd == false)
            {
                if (m_CSerial.IsConnect() == true)
                {
                    if (m_CSerial.GetBuffer_Length() > 0)
                    {
                        if (m_bMoving == true)
                        {
                            Byte[] m_abBuffer = m_CSerial.GetBytes();
                        }
                        else
                        {
                            String strData = Ojw.CConvert.BytesToStr(m_CSerial.GetBytes());
                            m_strReceived += strData;

                            if (m_strReceived.IndexOf("\n") >= 0)
                            {
                                String strTmp = m_strReceived.Substring(0, m_strReceived.IndexOf("\n"));
                                Ojw.CMessage.Write(strTmp);

                                if (m_bOrg_Running == true)
                                {
                                    if (strTmp.ToUpper() == "OK")
                                    {
                                        m_bOrg_Running = false;
                                        m_bOrg = true;

                                        Ojw.CMessage.Write("Org Ok");
                                        int i = 0;
                                        m_afPos_Prev[i] = 0.0f;
                                        m_afPos[i++] = 0.0f;
                                        m_afPos_Prev[i] = 0.0f;
                                        m_afPos[i++] = 0.0f;
                                        m_afPos_Prev[i] = 292.0f;
                                        m_afPos[i++] = 292.0f;

                                        PosUpdate();
                                        PosUpdate_Prev();
                                    }
                                }

                                // 연산 후 스트링 데이터 초기화
                                m_strReceived = String.Empty;
                            }
                        }
                    }
                }
                Thread.Sleep(1);
            }

        }
        private Ojw.CSerial m_CSerial = new Ojw.CSerial();
        private byte[] MakeCommand(String strCommand)
        {
            strCommand += "\n";
            return Ojw.CConvert.StrToBytes(strCommand);
        }
        private void Send(String strCommand)
        {
            m_CSerial.SendPacket(MakeCommand(strCommand));
        }
        private bool m_bOrg = false;
        private bool m_bOrg_Running = false;
        private void btnHome_Click(object sender, EventArgs e)
        {
            //m_CSerial.SendPacket(MakeCommand("G28"));
            m_bOrg = false;
            m_bOrg_Running = true;
            Ojw.CMessage.Write("Org running...");
            Send("G28");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (m_CSerial.IsConnect() == false)
            {
                m_CSerial.Connect(Ojw.CConvert.StrToInt(txtPort.Text), Ojw.CConvert.StrToInt(txtBaudRate.Text));
                if (m_CSerial.IsConnect() == true)
                {
                    btnConnect.Text = "DisConnect";
                    Send("M202 X10000 Y10000 Z10000 E10000"); // Max FeedRate
                    Send("M201 X10000 Y10000 Z10000 E10000"); // Max Acceleration
                    Send("M204 S7000 T7000"); // Default Acceleration
                    //Send("G90"); // Default Acceleration
                }
                else
                {
                    btnConnect.Text = "Connect";
                }
            }
            else
            {
                m_CSerial.DisConnect();
                btnConnect.Text = "Connect";
            }
        }

        private void btnInitPos_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //m_afPos[i] = m_afPos_Prev[i] = 0.0f;
            //i++;
            //m_afPos[i] = m_afPos_Prev[i] = 0.0f;
            //i++;
            //m_afPos[i] = m_afPos_Prev[i] = 100.0f;
            //PosUpdate();
            //PosUpdate_Prev();

            MoveRaw(0.0f, 0.0f, 100.0f, 1000, true);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Send(txtTest.Text);
        }

        private bool m_bStart = false;
        private bool m_bStop = false;
        private Thread m_thMotion;
        private void btnPrint_Click(object sender, EventArgs e)
        {
        //    m_thRun = new Thread(new ThreadStart(Thread_Motion));
        //    m_thRun.Start();
        //}
        //private void Thread_Motion()
        //{
            m_bStart = true;
            m_bStop = false;
            // ojw5014
            //m_nDispenseCount = 0;
            //m_bRun_Dispense = false;

            //tmrFeeding.Enabled = true; private void EventArgs 
            //tmrDispense.Enabled = true;
            Motion();
            //Run_2d();

            //tmrFeeding.Enabled = false;
            //tmrDispense.Enabled = false;

            MoveRaw(0.0f, 0.0f, 200.0f, 1000, true);

            m_bStart = false;
            //m_nCnt_Turning = 0;
        }
        private String m_strWorkDirectory = String.Empty;
        private void Motion()
        {
            OpenFileDialog ofdDesign = new OpenFileDialog();

            ofdDesign.FileName = "*.gcode";
            ofdDesign.Filter = "3D 프린팅용 파일(*.gcode)|*.gcode";

            ofdDesign.DefaultExt = "gcode";
            //ofdDesign.InitialDirectory = m_strWorkDirectory;
            if (ofdDesign.ShowDialog() == DialogResult.OK)
            {
                String fileName = ofdDesign.FileName;
                //m_strWorkDirectory = Directory.GetCurrentDirectory();
                //txtFileName.Text = fileName;
                if (LoadFile_GCode(fileName, out m_SMotion) == true)
                {
                    
                }
                else
                {

                }
            }
        }
        public struct SMotion_t
        {
            public int nCnt_Frame;
            public SMotionFrame_t[] pSFrame;
        }
        public struct SMotionFrame_t
        {
            public bool bEn;

            public bool bDispense;

            public int nGCode;

            public bool bEValue;
            public double dEValue;

            public bool bFValue;
            public double dFValue;

            public bool bX;
            public double dX;

            public bool bY;
            public double dY;

            public bool bZ;
            public double dZ;
        }
        private bool InterPreter_Gcode_to_Frame(String strLine, out SMotionFrame_t SMotion)
        {
            SMotion.nGCode = -1;
            SMotion.bEn = false;
            SMotion.bDispense = false;

            SMotion.bEValue = false;
            SMotion.dEValue = 0.0;

            SMotion.bFValue = false;
            SMotion.dFValue = 0.0;

            SMotion.bX = SMotion.bY = SMotion.bZ = false;
            SMotion.dX = SMotion.dY = SMotion.dZ = 0.0;

            // 주석 제거
            int nEnd = strLine.IndexOf(';');
            if (nEnd >= 0)
            {
                if (nEnd == 0) return false;

                strLine = strLine.Substring(0, nEnd + 1);
            }

            if (strLine == null) return false;
            if (strLine.Length < 1) return false;

            //strLine = Ojw.CConvert.ChangeString(strLine, " ", ":");
            //strLine = Ojw.CConvert.RemoveString(strLine, " ");
            String[] pstrValue = strLine.Split(' ');
            foreach (String strItem in pstrValue)
            {
                String strData = Ojw.CConvert.RemoveString(strItem, " ").ToUpper();
                if (strData.Length > 0)
                {
                    if (strData[0] == 'G')
                    {
                        SMotion.nGCode = Ojw.CConvert.StrToInt(strData.Substring(1, strData.Length - 1));
                        SMotion.bEn = true;
                        //switch (SMotion.nGCode)
                        //{
                        //    case 1:
                        //        {
                        //            SMotion.bEn = true;
                        //        }
                        //        break;
                        //}
                    }
                    if (SMotion.bEn == true)
                    {
                        if (strData[0] == 'E')
                        {
                            SMotion.bEValue = true;
                            SMotion.dEValue = Ojw.CConvert.StrToDouble(strData.Substring(1, strData.Length - 1));
                            //if (SMotion.dEValue < 0) // Wipe 인 경우는 현재 I/O 가 없으므로 구현 안한다.
                            //{
                            //    SMotion.bEn = false;
                            //}
                        }
                        else if (strData[0] == 'F')
                        {
                            SMotion.bFValue = true;
                            SMotion.dFValue = Ojw.CConvert.StrToDouble(strData.Substring(1, strData.Length - 1));
                        }
                        //else if (strData[0] == 'X')
                        else if (strData[0] == 'Z')
                        {
                            SMotion.bZ = true;
                            SMotion.dZ = Ojw.CConvert.StrToDouble(strData.Substring(1, strData.Length - 1));
                        }
                        //else if (strData[0] == 'Y')
                        else if (strData[0] == 'X')
                        {
                            SMotion.bX = true;
                            SMotion.dX = Ojw.CConvert.StrToDouble(strData.Substring(1, strData.Length - 1));
                        }
                        //else if (strData[0] == 'Z')
                        else if (strData[0] == 'Y')
                        {
                            SMotion.bY = true;
                            SMotion.dY = Ojw.CConvert.StrToDouble(strData.Substring(1, strData.Length - 1));
                        }
                    }
                }
            }
            return SMotion.bEn;
        }
        public SMotion_t m_SMotion;
        private bool LoadFile_GCode(String strFileName, out SMotion_t SMotion)
        {
            bool bRet = true;
            // Init
            SMotion.nCnt_Frame = 0;
            SMotion.pSFrame = null;

            FileInfo f = null;
            FileStream fs = null;
            float fSpeedBack = 0;
            try
            {

                f = new FileInfo(strFileName);
                fs = f.OpenRead();

                byte byteData;
                byte[] pbyteData = new byte[4096];
                //fs.Read(pbyteData, 0, pbyteData.Length);
                //fs.Close();
                ///////////////////////////////////////

                SMotion.nCnt_Frame = 0;
                SMotion.pSFrame = new SMotionFrame_t[1];

                double dRatio = 1.0;// 0.2;

                //String strLine = "";
                //int nStartIndex = 0;
                int nLength = 0;
                pbyteData.Initialize();
                //double dX0 = 0, dY0 = m_dWaitPos_Y, dZ0 = 0;
                double dStep = 0;
                //m_bNeedWaitTime = true;

                //OjwMotor.SetLed_Red(3, false);

                //Dispense_Insert();

                //Move_Init();

                // 이때부터 디스펜싱이 시작된다.
                //m_bStart = true;

                Ojw.CTimer.Wait(10000);

                //COjwTimer.TimerSet(0);
                Ojw.CTimer CTmr = new Ojw.CTimer();
                CTmr.Set();
                double dEvalue = 0.0f;
                double dFvalue = 0.0f;
                bool bFirstMove = true;

                float fDelta = Ojw.CConvert.StrToFloat(txtDelta.Text);
                float fSpeed;
                float fMulti = Ojw.CConvert.StrToFloat(txtMulti.Text);
                //int nPos = 0;
                for (int i = 0; i < fs.Length; i++) // 너무 기니까 테스트로 1/10만...
                {
                    lbProgress.Text = Ojw.CConvert.IntToStr(i + 1) + "/" + Ojw.CConvert.IntToStr(fs.Length + 1) + "[" + ((float)(i + 1) / (float)fs.Length * 100.0f).ToString() + "%]"; ;
                    if (m_bStop == true) break;
                    byteData = (byte)(fs.ReadByte() & 0xff);
                    pbyteData[nLength++] = byteData;
                    if (byteData == 0x0a)
                    {
                        //strLine = BitConverter.ToString(pbyteData, i, nLength);

                        SMotionFrame_t SFrame = new SMotionFrame_t();
                        //if (InterPreter_Gcode_to_Frame(Encoding.Default.GetString(pbyteData, nStartIndex, nLength), out SFrame) == true)
                        if (InterPreter_Gcode_to_Frame(Encoding.Default.GetString(pbyteData, 0, nLength), out SFrame) == true)
                        {
#if false
                            Array.Resize<SMotionFrame_t>(ref SMotion.pSFrame, SMotion.nCnt_Frame + 1);
                            //SMotion.pSFrame[i] = SFrame;
                            SMotion.pSFrame[SMotion.nCnt_Frame].bEn = SFrame.bEn;
                            SMotion.pSFrame[SMotion.nCnt_Frame].bDispense = SFrame.bDispense;
                            SMotion.pSFrame[SMotion.nCnt_Frame].bX = SFrame.bX;
                            SMotion.pSFrame[SMotion.nCnt_Frame].dX = SFrame.dX * dRatio;// +m_fOffset_X;
                            SMotion.pSFrame[SMotion.nCnt_Frame].bY = SFrame.bY;
                            SMotion.pSFrame[SMotion.nCnt_Frame].dY = SFrame.dY;// *dRatio; // 높이는 제외
                            SMotion.pSFrame[SMotion.nCnt_Frame].bZ = SFrame.bZ;
                            SMotion.pSFrame[SMotion.nCnt_Frame].dZ = SFrame.dZ * dRatio;// +m_fOffset_Y;

                            SMotion.pSFrame[SMotion.nCnt_Frame].bEValue = SFrame.bEValue;
                            SMotion.pSFrame[SMotion.nCnt_Frame].dEValue = SFrame.dEValue;
                            SMotion.pSFrame[SMotion.nCnt_Frame].bFValue = SFrame.bFValue;
                            SMotion.pSFrame[SMotion.nCnt_Frame].dFValue = SFrame.dFValue;

                            double dX, dY, dZ;
                            dX = ((SMotion.pSFrame[SMotion.nCnt_Frame].bX) ? SFrame.dX : dX0);// +m_fOffset_X;
                            dY = (SMotion.pSFrame[SMotion.nCnt_Frame].bY) ? m_dWorkPos_Y + SFrame.dY : dY0;
                            dZ = ((SMotion.pSFrame[SMotion.nCnt_Frame].bZ) ? SFrame.dZ : dZ0);// +m_fOffset_Y;
                            //dStep = m_dStep;// = ((SFrame.bEValue == true) && (SFrame.dEValue > 0)) ? m_dStep : 1.0;
                            
                            double dMulti = 1.0;

                            dMulti = m_dParam_Multi;//1.0;// 1.0f;// 1.0;// 2.0;
                            //if (SFrame.dFValue > 0) 
                            //                                dStep = SFrame.dFValue / 10000.0 * dMulti; // 3배속
                            //else if (SFrame.dFValue == 0) dStep = m_dStep;
                            // else 기존값 유지

                            if (SFrame.bFValue == true)
                            {
                                dFvalue = SFrame.dFValue;
                            }


                            //const int _SPD2 = 5;
                            const int _SPD3 = 1;
                            dStep = m_dStep;
                            if (dFvalue > 0)
                            {
                                m_nSpeed = (int)Math.Round((100000.0 / dMulti) / (dFvalue), 0);
                                //if (m_nSpeed < _SPD2) m_nSpeed = _SPD2;
                                if (m_nSpeed < (int)m_dParam_Limit) m_nSpeed = (int)m_dParam_Limit;
                            }
                            else m_nSpeed = _SPD3; // 
                            //                            dStep = dFvalue / 10000.0 * dMulti; // 3배속

                            String str0 = "E[" + Ojw.CConvert.DoubleToStr(SFrame.dEValue) + "]";
                            //String str1 = "dStep[" + Ojw.CConvert.DoubleToStr(dStep) + "]" + "F[" + Ojw.CConvert.DoubleToStr(SFrame.dFValue) + "]";
                            String str1 = "Spd[" + Ojw.CConvert.IntToStr(m_nSpeed) + "]" + "F[" + Ojw.CConvert.DoubleToStr(SFrame.dFValue) + "]";
                            lbDisp.Text = str1 + ((SFrame.bEValue == true) ? str0 : "");
                            bool bLimit = false;
                            double dLimit = 1;// 0.5;// 1.0;
                            //if (dStep > dLimit)
                            if (dFvalue / 10000.0 > dLimit)
                            {
                                //dStep = dLimit;
                                bLimit = true;
                                m_nSpeed = (int)m_dParam_Jump_Speed;
                            }
                            else if (dStep <= 0) dStep = 0.0001;
                            
                            if (
                                (bLimit == true) &&
                                (
                                  (dX0 != dX) ||
                                  (dY0 != dY) ||
                                  (dZ0 != dZ)
                                )
                            )
                            {
                                double dAlpha = m_dParam_Jump;
                                Move(dX0, dY0, dZ0,
                                    dX0,
                                    dY0 + dAlpha,
                                    dZ0,
                                    dStep, !bFirstMove); //k++;
                                Move(dX0, dY0 + dAlpha, dZ0, dX, dY + dAlpha, dZ, dStep, true);
                                Move(dX, dY + dAlpha, dZ, dX, dY, dZ, dStep, true);
                            }
                            else
                            {
                                Move(dX0, dY0, dZ0, dX, dY, dZ, dStep, !bFirstMove);
                            }

                            bFirstMove = false;
                            
                            dX0 = dX;
                            dY0 = dY;
                            dZ0 = dZ;
#else
                            //SFrame.bEn
                            float fX = (SFrame.bX  == true) ? (float)SFrame.dX : m_afPos_Prev[0];
                            float fY = (SFrame.bY  == true) ? (float)SFrame.dY : m_afPos_Prev[1];
                            float fZ = (SFrame.bZ  == true) ? (float)SFrame.dZ : m_afPos_Prev[2];
                            bool bMove = (
                                (SFrame.bX == true) ||
                                (SFrame.bY == true) ||
                                (SFrame.bZ == true)
                                ) ? true : false;
                            if (bMove == true)
                            {
                                fSpeed = (SFrame.bFValue == true) ? (float)SFrame.dFValue : fSpeedBack;
                                fSpeedBack = fSpeed;
                                //fSpeed = (SMotion.nCnt_Frame == 0) ? 7000.0f : (float)SFrame.dFValue / 100.0f;
                                //if (fSpeed <= 0) fSpeed = 100.0f;
                                MoveLin(
                                    m_afPos_Prev[0], m_afPos_Prev[1], m_afPos_Prev[2],
                                    fX, fY, fZ, fDelta, fSpeed * fMulti);
                                //Send(Ojw.CConvert.RemoveCaption(Encoding.Default.GetString(pbyteData, 0, nLength), false, false));
                                //Ojw.CTimer.Wait(10);
#endif
                            }
                            else
                            {
                                Send(Ojw.CConvert.RemoveCaption(Encoding.Default.GetString(pbyteData, 0, nLength), false, false));
                            }

                            // Dispense
                            if (SFrame.bDispense == true)
                            {
                            }
                            SMotion.nCnt_Frame++;
                        }
                        Application.DoEvents();
                        pbyteData.Initialize();
                        nLength = 0;
                    }


                }

                if (fs != null) fs.Close();

                if (m_bStop == true)
                {
                    bRet = false;
                }

                //Dispense_Stop();

                //OjwMotor.SetLed_Red(3, true);
                return bRet;
            }
            catch
            {
                if (fs != null) fs.Close();

                //Dispense_Stop();

                return false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_bProgEnd = true;
        }

        private void btnMoveLin_Click(object sender, EventArgs e)
        {
            float fX0 = Ojw.CConvert.StrToFloat(txtX0.Text);
            float fY0 = Ojw.CConvert.StrToFloat(txtY0.Text);
            float fZ0 = Ojw.CConvert.StrToFloat(txtZ0.Text);
            float fX1 = Ojw.CConvert.StrToFloat(txtX1.Text);
            float fY1 = Ojw.CConvert.StrToFloat(txtY1.Text);
            float fZ1 = Ojw.CConvert.StrToFloat(txtZ1.Text);
            float fSpeed = Ojw.CConvert.StrToFloat(txtSpeed.Text);
            float fDelta = Ojw.CConvert.StrToFloat(txtDelta.Text);
            MoveLin(fX0, fY0, fZ0, fX1, fY1, fZ1, fDelta, fSpeed);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_bStop = true;
        }
    }
}
