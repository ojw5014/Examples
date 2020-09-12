using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Step 1 - 사용하기위한 선언
using OpenJigWare;
// 쓰레드를 사용하기 위해 선언
using System.Threading;

namespace SerialTest
{
    public partial class Form1 : Form
    {
        // Step 2 - 변수 선언
        private Ojw.CSerial m_CSerial = new Ojw.CSerial();
        // 데이타를 받아올 쓰레드 선언
        Thread m_thReceive = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);
            Ojw.CMessage.Write("메세지 출력 준비 완료");

            /////
        }
        #region 연결 하기 위한...
        private void btnConnect_Click(object sender, EventArgs e)
        {
            int nPort = Ojw.CConvert.StrToInt(txtPort.Text); // 문자를 숫자로...
            int nBaudrate = Ojw.CConvert.StrToInt(txtBaudrate.Text);

            if (m_CSerial.IsConnect() == true) 
            {
                Ojw.CMessage.Write("이미 연결되어 있습니다. 굳이 다시 연결할 필요 없습니다.");
                return;
            }

            if (m_CSerial.Connect(nPort, nBaudrate) == true)
            {
                Ojw.CMessage.Write("연결 성공!!!, Port={0}, BaudRate={1}", nPort, nBaudrate);

                // Thread 를 돌려 데이타를 받을 함수를 지정하자.
                m_thReceive = new Thread(new ThreadStart(Thread_Receive));
                m_thReceive.Start();
            }
            else Ojw.CMessage.Write("연결 실패");
        }

        #region Thread
        private void Thread_Receive()
        {
            Ojw.CMessage.Write("[Thread] is Started");
            while (m_CSerial.IsConnect() == true)
            {
                try
                {
                    if (m_CSerial.GetBuffer_Length() > 0)
                    {
                        byte data = m_CSerial.GetByte();
                        Ojw.CMessage.Write2("{0}", (char)data);
                    }
                }
                catch
                {
                    Ojw.CMessage.Write("[Thread] Port Closed");
                }
            }
            Ojw.CMessage.Write("[Thread] Closed Thread");
        }
        #endregion Thread

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (m_CSerial.IsConnect() == true)
            {
                m_CSerial.DisConnect();
                Ojw.CMessage.Write("통신 종료");
            }
            else Ojw.CMessage.Write("통신이 오픈되어 있지 않습니다.");
        }
        #endregion 연결 하기 위한...

        // 보너스 기능 - 내 컴에 연결 가능한 컴포트가 무엇이 있는지 알아보자.
        private void btnCheckComport_Click(object sender, EventArgs e)
        {
            string [] pstrComport = null;
            Ojw.CRegistry.GetSerialPort(out pstrComport, true, true);

            if (pstrComport != null)
            {
                Ojw.CMessage.Write("발견된 Comport =>");
                for (int i = 0; i < pstrComport.Length; i++)
                {
                    Ojw.CMessage.Write2(pstrComport[i]);
                    Ojw.CMessage.Write2("\r\n"); // 줄바꿈을 하자
                }
            }
            else Ojw.CMessage.Write("발견된 통신 포트가 없습니다.");
        }

        #region Send
        private void btnSend_Click(object sender, EventArgs e)
        {
            string[] pstrData = txtData.Text.Split(',');
            int[] pnData = new int[pstrData.Length];
            int i = 0;
            Ojw.CMessage.Write("Data Send=>");
            foreach (string strData in pstrData)
            {
                pnData[i] = Ojw.CConvert.StrToInt(strData);
                Ojw.CMessage.Write2("0x{0},", Ojw.CConvert.IntToHex(pnData[i], 2));
                i++;
            }
            Ojw.CMessage.Write2("\r\n");
            if (m_CSerial.IsConnect() == true)
            {
                SendValue(pnData);
            }
            else
                Ojw.CMessage.Write("통신이 연결되지 않아 보내지 못했습니다.");
        }
        private void SendValue(params int[] pnData)
        {
            if (pnData.Length % 2 != 0)
            {
                Ojw.CMessage.Write_Error("Data Size error");
                return;
            }
            int nSize_Header = 5;
            int nSize_Data = pnData.Length / 2 * 3;
            byte[] pBuffer = new byte[nSize_Header + nSize_Data];
            byte[] pbyteTmp;
            int i = 0;
            int nCmd = 0x01;

            // Header
            pBuffer[i++] = (byte)0x02;
            // Command
            pBuffer[i++] = (byte)(nCmd & 0xff);
            byte byCheckSum = pBuffer[i - 1];
            // Size
            pBuffer[i++] = (byte)(nSize_Data & 0xff);
            byCheckSum ^= pBuffer[i - 1];

            for (int nPos = 0; nPos < pnData.Length / 2; nPos++)
            {
                pBuffer[i++] = (byte)(pnData[nPos * 2] & 0xff);
                byCheckSum ^= pBuffer[i - 1];
                pbyteTmp = Ojw.CConvert.ShortToBytes((short)pnData[nPos * 2 + 1]);
                pBuffer[i++] = pbyteTmp[0];
                byCheckSum ^= pBuffer[i - 1];
                pBuffer[i++] = pbyteTmp[1];
                byCheckSum ^= pBuffer[i - 1];
            }

            // CheckSum
            pBuffer[i++] = byCheckSum; // Checksum

            // Tail
            pBuffer[i++] = (byte)0x03;

            m_CSerial.SendPacket(pBuffer);
        }
        #endregion Send

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_CSerial.IsConnect() == true) m_CSerial.DisConnect();
        }


    }
}
