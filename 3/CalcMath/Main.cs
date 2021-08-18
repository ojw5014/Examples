using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenJigWare;

namespace CalcMath
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            Ojw.SOjwCode_t SCode = new Ojw.SOjwCode_t();
            String strMessage = string.Empty;
            String[] pstrCompile = new String[5];
            int nError = Ojw.CKinematics.CInverse.Compile(txtOrg.Text,
                                                        out SCode,
                                                        true,
                                                        ref pstrCompile[0],
                                                        ref pstrCompile[1],
                                                        ref pstrCompile[2],
                                                        true,
                                                        ref pstrCompile[3],
                                                        ref pstrCompile[4],
                                                        true,
                                                        ref strMessage);
            txtOrg2.Text = pstrCompile[0];
            txtCompile.Text = pstrCompile[1];
            txtAsemTest.Text = pstrCompile[2];
            txtAsem.Text = pstrCompile[3];
            txtCode.Text = pstrCompile[4];

            if (nError > 0) // 에러발생
            {
                strMessage += "\r\n" + Ojw.CKinematics.CInverse.GetErrorString_CompilePath();
                MessageBox.Show(strMessage);
                return;
            }
            //Ojw.CKinematics.CInverse.Compile(txtOrg.Text, )

            int i;
            lbMotor_Cnt.Text = Ojw.CConvert.IntToStr(SCode.nMotor_Max);
            lbMotor.Text = "Motor";
            for (i = 0; i < SCode.nMotor_Max; i++)
            {
                lbMotor.Text = lbMotor.Text + "-" + Ojw.CConvert.IntToStr(SCode.pnMotor_Number[i]);
            }
            lbVar_Cnt.Text = Ojw.CConvert.IntToStr(SCode.nVar_Max);
            lbVar.Text = "변수(V)";
            for (i = 0; i < SCode.nVar_Max; i++)
            {
                lbVar.Text = lbVar.Text + "-" + Ojw.CConvert.IntToStr(SCode.pnVar_Number[i]);
            }
        }

        public Ojw.SOjwCode_t m_SOjwCode = new Ojw.SOjwCode_t();
        private void btnTest_Click(object sender, EventArgs e)
        {


            // Test
            double dX = Ojw.CConvert.StrToFloat(txtX.Text);
            double dY = Ojw.CConvert.StrToFloat(txtY.Text);
            double dZ = Ojw.CConvert.StrToFloat(txtZ.Text);
            double dV0 = Ojw.CConvert.StrToFloat(txtV0.Text);
            double dV1 = Ojw.CConvert.StrToFloat(txtV1.Text);
            double dV2 = Ojw.CConvert.StrToFloat(txtV2.Text);
            double dV3 = Ojw.CConvert.StrToFloat(txtV3.Text);
            double dV4 = Ojw.CConvert.StrToFloat(txtV4.Text);
            double[] adVar = new double[Ojw.CKinematics.CInverse._CNT_VAR_V];
            double[] adMot = new double[Ojw.CKinematics.CInverse._CNT_MOTOR];
            //adMot.Initialize();
            Array.Clear(adMot, 0, adMot.Length);
            Array.Clear(adVar, 0, adVar.Length);

            //adMot[Ojw.CConvert.StrToInt(txtMot_Index.Text)] = Ojw.CConvert.StrToFloat(txtMot_Value.Text);

            Ojw.CKinematics.CInverse.SetValue_Motor(Ojw.CConvert.StrToInt(txtMot_Index.Text), Ojw.CConvert.StrToFloat(txtMot_Value.Text));

            Ojw.CKinematics.CInverse.CalcCode(ref m_SOjwCode, ref dX, ref dY, ref dZ, ref adVar, ref adMot);

            String strValue = "dX[" + Ojw.CConvert.DoubleToStr(dX) + "]" + ",dY[" + Ojw.CConvert.DoubleToStr(dY) + "]" + ",dZ[" + Ojw.CConvert.DoubleToStr(dZ) + "]" +
                       "adMot0[" + Ojw.CConvert.DoubleToStr(adMot[0]) + "]" + "adMot1[" + Ojw.CConvert.DoubleToStr(adMot[1]) + "]" + "adMot2[" + Ojw.CConvert.DoubleToStr(adMot[2]) + "]" +
                       "adVar0[" + Ojw.CConvert.DoubleToStr(adVar[0]) + "]" + "adVar1[" + Ojw.CConvert.DoubleToStr(adVar[1]) + "]" + "adVar2[" + Ojw.CConvert.DoubleToStr(adVar[2]) + "]";
            int i = 0;
            lbMot0.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot1.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot2.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot3.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot4.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot5.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot6.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot7.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot8.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot9.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot10.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot11.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot12.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot13.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot14.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot15.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot16.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot17.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot18.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot19.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot20.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot21.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot22.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot23.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot24.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            MessageBox.Show(strValue);
            adMot = null;
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            // Test
            Ojw.CKinematics.CInverse.SetValue_ClearAll(ref m_SOjwCode);
            // 모터의 값을 복사
            //Ojw.CKinematics.CInverse.SetValue_Motor();
            // 시작
            float fX = Ojw.CConvert.StrToFloat(txtX.Text);
            float fY = Ojw.CConvert.StrToFloat(txtY.Text);
            float fZ = Ojw.CConvert.StrToFloat(txtZ.Text);

            Ojw.CKinematics.CInverse.SetValue_X(fX);
            Ojw.CKinematics.CInverse.SetValue_Y(fY);
            Ojw.CKinematics.CInverse.SetValue_Z(fZ);

            Ojw.CKinematics.CInverse.SetValue_V(0, Ojw.CConvert.StrToFloat(txtV0.Text));
            Ojw.CKinematics.CInverse.SetValue_V(1, Ojw.CConvert.StrToFloat(txtV1.Text));
            Ojw.CKinematics.CInverse.SetValue_V(2, Ojw.CConvert.StrToFloat(txtV2.Text));
            Ojw.CKinematics.CInverse.SetValue_V(3, Ojw.CConvert.StrToFloat(txtV3.Text));
            Ojw.CKinematics.CInverse.SetValue_V(4, Ojw.CConvert.StrToFloat(txtV4.Text));
            Ojw.CKinematics.CInverse.SetValue_V(5, Ojw.CConvert.StrToFloat(txtV5.Text));
            Ojw.CKinematics.CInverse.SetValue_V(6, Ojw.CConvert.StrToFloat(txtV6.Text));
            Ojw.CKinematics.CInverse.SetValue_V(7, Ojw.CConvert.StrToFloat(txtV7.Text));
            Ojw.CKinematics.CInverse.SetValue_V(8, Ojw.CConvert.StrToFloat(txtV8.Text));
            Ojw.CKinematics.CInverse.SetValue_V(9, Ojw.CConvert.StrToFloat(txtV9.Text));
            Ojw.CKinematics.CInverse.SetValue_V(10, Ojw.CConvert.StrToFloat(txtV10.Text));
            Ojw.CKinematics.CInverse.SetValue_V(11, Ojw.CConvert.StrToFloat(txtV11.Text));
            Ojw.CKinematics.CInverse.SetValue_V(12, Ojw.CConvert.StrToFloat(txtV12.Text));
            Ojw.CKinematics.CInverse.SetValue_V(13, Ojw.CConvert.StrToFloat(txtV13.Text));
            Ojw.CKinematics.CInverse.SetValue_V(14, Ojw.CConvert.StrToFloat(txtV14.Text));
            Ojw.CKinematics.CInverse.SetValue_V(15, Ojw.CConvert.StrToFloat(txtV15.Text));
            Ojw.CKinematics.CInverse.SetValue_V(16, Ojw.CConvert.StrToFloat(txtV16.Text));
            Ojw.CKinematics.CInverse.SetValue_V(17, Ojw.CConvert.StrToFloat(txtV17.Text));

            Ojw.CKinematics.CInverse.SetValue_Motor(Ojw.CConvert.StrToInt(txtMot_Index.Text), Ojw.CConvert.StrToFloat(txtMot_Value.Text));

            //Ojw.CKinematics.CInverse.SetValue_Motor(0, fV0);
            Ojw.CKinematics.CInverse.CalcCode(ref m_SOjwCode);

            String strValue = "fX[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_X()) + "]" + ",fY[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Y()) + "]" + ",fZ[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Z()) + "]" +
                       "adMot0[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(0)) + "]" + "adMot1[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(1)) + "]" + "adMot2[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(2)) + "]" +
                       "afVar0[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(0)) + "]" + "afVar1[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(1)) + "]" + "afVar2[" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(2)) + "]";
            int i = 0;
            double[] adMot = Ojw.CKinematics.CInverse.GetValue_Motor();
            lbMot0.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot1.Text = Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(i++));
            lbMot2.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot3.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot4.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot5.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot6.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot7.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot8.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot9.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot10.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot11.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot12.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot13.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot14.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot15.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot16.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot17.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot18.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot19.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot20.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot21.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot22.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot23.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            lbMot24.Text = Ojw.CConvert.DoubleToStr(adMot[i++]);
            MessageBox.Show(strValue);



            String strValue2 = "x=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_X()) + "\r\n" +
                                "y=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Y()) + "\r\n" +
                                "z=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Z()) + "\r\n" +
                                "Mot0=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(0)) + "\r\n" +
                                "Mot1=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(1)) + "\r\n" +
                                "Mot2=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_Motor(2)) + "\r\n";
            /* +
            "V0=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(0)) + "\r\n" +
            "V1=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(1)) + "\r\n" +
            "V2=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(2));
*/
            for (i = 0; i < 20; i++)
            {
                strValue2 += "V" + Ojw.CConvert.IntToStr(i) + "=" + Ojw.CConvert.DoubleToStr(Ojw.CKinematics.CInverse.GetValue_V(i)) + "\r\n";
            }

            txtResult.Text = strValue2;
            adMot = null;
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            //m_strEncryption = Ojw.CKinematics.CInverse.Encryption(true, txtEncryption1.Text); // 암호화는 굳이 EncryptionSet 안해도 된다.
            //byte[] byteData = Encoding.Default.GetBytes(m_strEncryption);
            //txtEncryption3.Text = "";
            //for (int i = 0; i < byteData.Length; i++)
            //{
            //    txtEncryption3.Text += "0x" + Ojw.CConvert.IntToHex((int)byteData[i]) + ((((i + 1) % 5) == 0) ? "\r\n" : ",");
            //}
            //txtEncryption2.Text = m_strEncryption;//Ojw.CKinematics.CInverse.Encryption(true, txtEncryption1.Text);   
        }

        private void btnEncryption2_Click(object sender, EventArgs e)
        {
            //Ojw.CKinematics.CInverse.EncryptionSet("OJW5014"); // 암호화 해제는 보안이 필요
            //txtEncryption1.Text = Ojw.CKinematics.CInverse.Encryption(false, m_strEncryption);
        }
    }
}
