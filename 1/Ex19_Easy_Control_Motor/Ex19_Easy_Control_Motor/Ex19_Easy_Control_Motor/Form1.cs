using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Step 1
using OpenJigWare;

namespace Ex19_Easy_Control_Motor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Step 2 - 모터 제어 변수 선언
        private Ojw.CHerkulex2 m_CMotor = new Ojw.CHerkulex2();

        private void btnPosition_Click(object sender, EventArgs e)
        {
            // Position Control
            int nId0 = 0;
            int nId1 = 1;

            int nComport = 6; // 장치관리자에서 자신의 통신 포트 확인해서 넣을 것
            int nBaudrate = 115200;
            
            // 통신 포트를 연다.
            if (m_CMotor.Open(nComport, nBaudrate) == true)
            {

                m_CMotor.SetParam(nId0, Ojw.CHerkulex2._MODEL_DRS_0601); // 제어할 모델 설정
                m_CMotor.SetParam(nId1, Ojw.CHerkulex2._MODEL_DRS_0601); // 제어할 모델 설정

                m_CMotor.Reset(); // 혹시나 있을 에러를 클리어 한다.

                m_CMotor.SetTorque(true, true); // 토크 온 - 모터 동작 준비

                #region 90도 움직인다.
                // 제어할 위치 셋팅
                m_CMotor.Set_Angle(nId0, 90.0f);
                m_CMotor.Set_Angle(nId1, 90.0f);

                // 실제 움직이게 한다.(동시)
                m_CMotor.Send_Motor(1000); // 1초(1000 ms) 동안 동작

                // 동작 시간만큼 멈춘다. 이때 자동적으로 모터의 현 위치를 가져온다.
                m_CMotor.Wait_Delay(1000);
                #endregion 90도 움직인다.

                #region -90도 움직인다.
                // 제어할 위치 셋팅
                m_CMotor.Set_Angle(nId0, -90.0f);
                m_CMotor.Set_Angle(nId1, -90.0f);

                // 실제 움직이게 한다.(동시)
                m_CMotor.Send_Motor(1000); // 1초(1000 ms) 동안 동작

                // 동작 시간만큼 멈춘다. 이때 자동적으로 모터의 현 위치를 가져온다.
                m_CMotor.Wait_Delay(1000);
                #endregion -90도 움직인다.

                #region 무한턴
                // 한 방향으로 무한 턴
                m_CMotor.Set_Turn(nId0, 1000);
                m_CMotor.Set_Turn(nId1, 1000);

                // 실제 움직이게 한다.(동시)
                m_CMotor.Send_Motor(100); // 속도값은 별로 의미 없다.

                // 5초정도 대기한 다음
                m_CMotor.Wait_Delay(5000);

                // 멈춘다.
                m_CMotor.Stop(); // Stop 을 한 이후에는 반드시 Reset 을 해야 동작한다.
                #endregion 무한턴

                m_CMotor.Close();
                // 통신 포트를 닫는다.
            }
        }
    }
}
