using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace Ex18_Joystick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 메세지 박스를 사용한다고 지정
            Ojw.CMessage.Init(txtMessage);


        }

        private Ojw.CJoystick m_CJoy;// = new Ojw.CJoystick(Ojw.CJoystick._ID_0); // 조이스틱 선언
        private void btnConnect_Click(object sender, EventArgs e)
        {
            int nID = Ojw.CConvert.StrToInt(txtId.Text);
            m_CJoy = new Ojw.CJoystick(nID);
            
            CheckConnection();
        }

        private void CheckConnection()
        {
            if (m_CJoy != null)
            {
                if (m_CJoy.IsValid == false)
                {
                    Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                    lbJoystick.ForeColor = Color.White;
                    lbJoystick.Text = "Joystick (No Connected)";
                }
                else
                {
                    Ojw.CMessage.Write("Joystick is Connected");
                    lbJoystick.ForeColor = Color.Green;
                    lbJoystick.Text = "Joystick (Connected)";
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_CJoy != null)
            {
                // 조이스틱 정보 갱신
                m_CJoy.Update();
                
                // 조이스틱 데이타 확인
                if (m_CJoy.IsValid == true)
                {
                    // 버튼 체크
                    for (int i = 0; i < 30; i++)
                    {
                        if (m_CJoy.IsDown_Event(i) == true)
                        {
                            Ojw.CMessage.Write("button -> {0} Down event", i);
                        }
                        else if (m_CJoy.IsUp_Event(i) == true)
                        {
                            Ojw.CMessage.Write("button -> {0} Up event", i);
                        }
                    }

                    // 스틱 체크
                    for (int i = 0; i < 6; i++)
                    {
                        Label lb = (Label)Ojw.CSystem.FindControl(this, "lbJoystick_" + i.ToString());
                        lb.Text = Ojw.CConvert.DoubleToStr(m_CJoy.GetPos(i));

                        if (i == 0)
                        {
                            Ojw.CMouse.Mouse_Move_Inc((int)Math.Round((m_CJoy.GetPos(i)-0.5f) * 50), 0);
                        }
                    }
                }
                else
                {
                    // 연결이 끊어지면 바로 화면에 나타내자.
                    if (lbJoystick.ForeColor != Color.White)
                    {
                        lbJoystick.ForeColor = Color.White;
                        lbJoystick.Text = "Joystick (No Connected)";
                    }
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // 조이스틱이 살아 있는지 체크하는 함수
            CheckConnection();
        }
    }
}
