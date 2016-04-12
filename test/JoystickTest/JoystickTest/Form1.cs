using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;

using OpenJigWare;
using Microsoft.Xna.Framework.Input;

namespace JoystickTest
{
    public enum PadKey : byte
    {
        None,
        Button1,
        Button2,
        Button3,
        Button4,
        Button5,
        Button6,
        Button7,
        Button8,
        Button9,
        Button10,
        Button11,
        Button12,
        Button13,
        Button14,
        Button15,
        Button16,
        Button17,
        Button18,
        Button19,
        Button20,
        Button21,
        Button22,
        Button23,
        Button24,
        Button25,
        Button26,
        Button27,
        Button28,
        Button29,
        Button30,
        StickUp,
        StickDown,
        StickLeft,
        StickRight,
        POVUp,
        POVDown,
        POVLeft,
        POVRight,
        SpinUp,
        SpinDown,
        SpinLeft,
        SpinRight,
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("WinMM.dll"), System.Security.SuppressUnmanagedCodeSecurity]
        public static extern int joyGetNumDevs();

        [DllImport("winmm.dll")]
        private static extern int joyGetPosEx(int joystickNumber, ref JOYINFOEX info);

        [StructLayout(LayoutKind.Sequential)]
        private struct JOYINFOEX
        {
            public int dwSize;
            public int dwFlags;
            public int dwXpos;
            public int dwYpos;
            public int dwZpos;
            public int dwRpos;
            public int dwUpos;
            public int dwVpos;
            public int dwButtons;
            public int dwButtonNumber;
            public int dwPOV;
            public int dwReserved1;
            public int dwReserved2;
        }
        private const int MMSYSERR_BASE = 0;
        private const int MMSYSERR_NODRIVER = (MMSYSERR_BASE + 6);
        private const int MMSYSERR_INVALPARAM = (MMSYSERR_BASE + 11);
        private const int JOYERR_BASE = 160;
        private const int JOYERR_UNPLUGGED = (JOYERR_BASE + 7);
        private const int MAXPNAMELEN = 32;
        private const int JOYERR_NOERROR = (0);
        private const int JOYSTICKID1 = 0;
        private const int JOYSTICKID2 = 1;
        private const int JOYERR_PARMS = (JOYERR_BASE + 5);
        private const int JOYERR_NOCANDO = (JOYERR_BASE + 6);

        private CJoystick m_CJoy = new CJoystick(JOYSTICKID1);
        private Ojw.C3d m_C3d = new Ojw.C3d();
        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);

            m_C3d.Init(picDisp);
            //m_C3d.SetScale(0.1f);
            //m_C3d.SetPos_Display(0, 50, 0);
            if (m_C3d.FileOpen("Joystick.ojw") == true)
            {
                timer1.Enabled = true;
            }
            else Application.Exit();

            //timer1.Enabled = true;
        }

        private float[] m_afAngle = new float[20];

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Joystick
            m_CJoy.Update();
            //lbX0.Text = m_CJoy.X.ToString();
            //lbY0.Text = m_CJoy.Y.ToString();

            //lbX1.Text = m_CJoy.SpinX.ToString();
            //lbY1.Text = m_CJoy.SpinY.ToString();
            //lbUp.Text = ((m_CJoy.IsDown(PadKey.Button1) == true) ? "true" : "false");
            //lbDown.Text = ((m_CJoy.IsDown(PadKey.Button2) == true) ? "true" : "false");

            // 스틱좌상단, 0+ - 좌, 1+ - 하
            // 패드 2+ - 좌, 3+ - 하
            // 스틱우하단, 4+ - 좌, 5+ - 하
            // 버튼
            // Top 6 - -3 : 클릭
            // Left 7 - -3 : 클릭
            // Right 8 - -3 : 클릭
            // Bottom 9 - -3 : 클릭
            // 전면우측 10 - -3 : 클릭
            // 전면좌측 11 - -3 : 클릭
            // 전면우측아래 12- : 클릭
            // 전면좌측아래 13- : 클릭
            float fDown = -3.0f;
            float fUp = 0.0f;
            int nNum = 0;
            // Up
            nNum = 6;
            if (m_CJoy.IsDown(PadKey.Button4) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Left
            nNum = 7;
            if (m_CJoy.IsDown(PadKey.Button3) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Right
            nNum = 8;
            if (m_CJoy.IsDown(PadKey.Button2) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Down
            nNum = 9;
            if (m_CJoy.IsDown(PadKey.Button1) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Front Left
            nNum = 10;
            if (m_CJoy.IsDown(PadKey.Button6) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            // Front Right
            nNum = 11;
            if (m_CJoy.IsDown(PadKey.Button5) == true) m_afAngle[nNum] = fDown;
            else m_afAngle[nNum] = fUp;
            
            // 좌상단 조이스틱
            m_afAngle[0] = (float)(20.0 * (m_CJoy.X0 - 0.5));
            m_afAngle[1] = (float)(20.0 * (m_CJoy.Y0 - 0.5));
            //Ojw.CMessage.Write2("{0}, \t{1}\n", m_CJoy.X0, m_CJoy.Y0);
            Ojw.CMessage.Write2("{0}, \t{1}\n", m_afAngle[0], m_afAngle[1]);

            // 우하단 조이스틱
            m_afAngle[4] = (float)(20.0 * (m_CJoy.X1 - 0.5));
            m_afAngle[5] = (float)(20.0 * (m_CJoy.Y1 - 0.5));

            // 슬라이드
            m_afAngle[13] = ((m_CJoy.Slide >= 0.5) ? (float)(20.0 * (0.5 - m_CJoy.Slide)) : 0.0f);
            m_afAngle[12] = ((m_CJoy.Slide <= 0.5) ? (float)(20.0 * (m_CJoy.Slide - 0.5)) : 0.0f);

            // 패드 2+ - 좌, 3+ - 하
            nNum = 2;
            m_afAngle[nNum] = 0.0f;
            if (m_CJoy.IsDown(PadKey.POVLeft) == true) m_afAngle[nNum] = -10.0f;
            //else m_afAngle[nNum] = fUp;
            if (m_CJoy.IsDown(PadKey.POVRight) == true) m_afAngle[nNum] = 10.0f;
            //else m_afAngle[nNum] = fUp;
            nNum = 3;
            m_afAngle[nNum] = 0.0f;
            if (m_CJoy.IsDown(PadKey.POVUp) == true) m_afAngle[nNum] = -10.0f;
            //else m_afAngle[nNum] = fUp;
            if (m_CJoy.IsDown(PadKey.POVDown) == true) m_afAngle[nNum] = 10.0f;
            //else m_afAngle[nNum] = fUp;

            for (int i = 0; i < 20; i++)
            {
                if (m_CJoy.IsDown((PadKey)((int)PadKey.Button7 + i)) == true)
                    Ojw.CMessage.Write((7 + i).ToString());
            }
            #endregion Joystick

            // 3D 모델링을 그리자
            m_C3d.OjwDraw(m_afAngle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fVal0 = Ojw.CConvert.StrToFloat(txtVibrate0.Text);
            float fVal1 = Ojw.CConvert.StrToFloat(txtVibrate1.Text);
            Microsoft.Xna.Framework.Input.GamePad.SetVibration(0, fVal0, fVal1);
            Ojw.CTimer.Wait(1000);
            Microsoft.Xna.Framework.Input.GamePad.SetVibration(0, (float)0.0, (float)0.0);

        }
    }


    #region CJoystick
    public class CJoystick
    {
        #region P/Invoke
        [SuppressUnmanagedCodeSecurity, DllImport("winmm")]
        static extern int joyGetNumDevs();
        [SuppressUnmanagedCodeSecurity, DllImport("winmm")]
        static extern int joyGetPosEx(int uJoyID, ref JOYINFOEX pji);
        [SuppressUnmanagedCodeSecurity, DllImport("winmm")]
        static extern int joyGetDevCaps(int uJoyID, ref JOYCAPS pjc, int cbjc);
        //GetJoyProperty
        [Flags]
        enum ReturnType : uint
        {
            None = 0,
            X = 1 << 0,
            Y = 1 << 1,
            Z = 1 << 2,
            R = 1 << 3,
            U = 1 << 4,
            V = 1 << 5,
            POV = 1 << 6,
            Buttons = 1 << 7,
            RawData = 1 << 8,
            POVContinuous = 1 << 9,
            Centered = 1 << 10,
            UseDeadZone = 1 << 11,
            All = X | Y | Z | R | U | V | POV | Buttons,
        }

        enum POV : uint
        {
            None = 65535,
            Up = 0,
            UpRight = 4500,
            Right = 9000,
            DownRight = 13500,
            Down = 18000,
            DownLeft = 22500,
            Left = 27000,
            UpLeft = 31500,
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct JOYINFOEX
        {
            public uint dwSize;
            public ReturnType dwFlags;
            public uint dwXpos;
            public uint dwYpos;
            public uint dwZpos;
            public uint dwRpos;
            public uint dwUpos;
            public uint dwVpos;
            public uint dwButtons;
            public uint dwButtonNumber;
            public POV dwPOV;
            public uint dwReserved1;
            public uint dwReserved2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct JOYCAPS
        {
            public ushort wMid;
            public ushort wPid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szPname;
            public uint wXmin;
            public uint wXmax;
            public uint wYmin;
            public uint wYmax;
            public uint wZmin;
            public uint wZmax;
            public uint wNumButtons;
            public uint wPeriodMin;
            public uint wPeriodMax;
            public uint wRmin;
            public uint wRmax;
            public uint wUmin;
            public uint wUmax;
            public uint wVmin;
            public uint wVmax;
            public uint wCaps;
            public uint wMaxAxes;
            public uint wNumAxes;
            public uint wMaxButtons;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szRegKey;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szOEMVxD;
        }
        #endregion

        JOYINFOEX info;
        JOYCAPS caps;
        readonly Dictionary<PadKey, bool> isDown = new Dictionary<PadKey, bool>();
        public int ID
        {
            get;
            private set;
        }

        // 좌상단
        public double X0
        {
            get
            {
                return Math.Round((double)(info.dwXpos - caps.wXmin) / (caps.wXmax - caps.wXmin), 3);
            }
        }

        public double Y0
        {
            get
            {
                return Math.Round((double)(info.dwYpos - caps.wYmin) / (caps.wYmax - caps.wYmin), 3);
            }
        }

        // Pad
        public double X1
        {
            get
            {
                return Math.Round((double)(info.dwUpos - caps.wUmin) / (caps.wUmax - caps.wUmin), 3);
                //return Math.Round((double)(info.dwVpos - caps.wVmin) / (caps.wVmax - caps.wVmin), 3);
            }
        }

        public double Y1
        {
            get
            {
                return Math.Round((double)(info.dwRpos - caps.wRmin) / (caps.wRmax - caps.wRmin), 3);
            }
        }

        public double Slide
        {
            get
            {
                return Math.Round((double)(info.dwZpos - caps.wZmin) / (caps.wZmax - caps.wZmin), 3);
            }
        }
        
        public bool Available
        {
            get;
            private set;
        }

        public CJoystick(int id)
        {
            caps = new JOYCAPS();
            info = new JOYINFOEX
            {
                dwSize = (uint)Marshal.SizeOf(typeof(JOYINFOEX)),
                dwFlags = ReturnType.All,
            };

            this.ID = id;
            this.Available = Update();

            if (id != -1)
                joyGetDevCaps(id, ref caps, Marshal.SizeOf(typeof(JOYCAPS)));
        }

        public bool Update()
        {
            if (this.ID == -1)
                return false;
            else
                if (joyGetPosEx(this.ID, ref info) == 0)
                {
                    foreach (PadKey i in Enum.GetValues(typeof(PadKey)))
                        isDown[i] = CheckIsDown(i);
                    return true;
                }
                else
                    return false;
        }

        bool CheckIsDown(PadKey key)
        {
            const double stickThreshold = 0.2;
            const double stickReverseThreshold = 1 - stickThreshold;

            switch (key)
            {
                case PadKey.None:
                    return false;
                case PadKey.StickUp:
                    return this.Y0 < stickThreshold;
                case PadKey.StickDown:
                    return this.Y0 > stickReverseThreshold;
                case PadKey.StickLeft:
                    return this.X0 < stickThreshold;
                case PadKey.StickRight:
                    return this.X0 > stickReverseThreshold;
                case PadKey.POVUp:
                    return info.dwPOV == POV.Up
                        || info.dwPOV == POV.UpLeft
                        || info.dwPOV == POV.UpRight;
                case PadKey.POVDown:
                    return info.dwPOV == POV.Down
                        || info.dwPOV == POV.DownLeft
                        || info.dwPOV == POV.DownRight;
                case PadKey.POVLeft:
                    return info.dwPOV == POV.Left
                        || info.dwPOV == POV.UpLeft
                        || info.dwPOV == POV.DownLeft;
                case PadKey.POVRight:
                    return info.dwPOV == POV.Right
                        || info.dwPOV == POV.UpRight
                        || info.dwPOV == POV.DownRight;
                //case PadKey.SpinUp:
                //    return this.SpinY < stickThreshold;
                //case PadKey.SpinDown:
                //    return this.SpinY > stickReverseThreshold;
                //case PadKey.SpinLeft:
                //    return this.SpinX < stickThreshold;
                //case PadKey.SpinRight:
                //    return this.SpinX > stickReverseThreshold;
                default:
                    return (info.dwButtons & (uint)Math.Pow(2, (int)key - 1)) != 0;
            }
        }

        public bool IsDown(IEnumerable<PadKey> all)
        {
            return all.All(IsDown);
        }

        public bool IsDown(params PadKey[] all)
        {
            return all.All(IsDown);
        }

        public bool IsDown(PadKey key)
        {
            if (isDown.Count > 0)
                return isDown[key];
            return false;
        }

        public bool IsUp(IEnumerable<PadKey> all)
        {
            return all.All(IsUp);
        }

        public bool IsUp(params PadKey[] all)
        {
            return all.All(IsUp);
        }

        public bool IsUp(PadKey key)
        {
            return !isDown[key];
        }

        public static IEnumerable<CJoystick> GetAvailableGamePads()
        {
            var max = joyGetNumDevs();

            for (int i = 0; i < max; i++)
            {
                var rt = new CJoystick(i);
                if (rt.Available)
                    yield return rt;
            }
        }

        
    }
    #endregion CJoystick
}
