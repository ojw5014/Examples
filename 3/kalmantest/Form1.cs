using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// for OpenJigWare
using OpenJigWare;

namespace kalmantest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Sonar Data - 예제 파일을 읽어오기 위해 필요
        private List<double> listSonarData = new List<double>();

        public bool ReadSonarCSV
        {
            get;
            set;
        }
        private double GetSonar(int k)
        {
            if (ReadSonarCSV == false)
            {
                var reader = new StreamReader(File.OpenRead(@"SonarAlt.csv"));
                listSonarData = new List<double>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

#if true
                    int iCount = 0;
                    foreach (string str in values) iCount++;
#else
                    //int iCount = values.ToList<string>().Count;
#endif

                    for (int i = 0; i < iCount; i++)
                    {
                        if (values[i] != null && values[i] != "") listSonarData.Add(Convert.ToDouble(values[i]));
                    }
                }
            }
            return listSonarData[k];
        }
        #endregion Sonar Data

        private void button1_Click(object sender, EventArgs e)
        {
            // 칼만필터, 로패스 필터를 테스트
            double dt = 0.02;

            int Nsamples = 500;

            List<double> t = new List<double>();
            t.Add(0);
#if true
            while (t.Count < Nsamples) t.Add(t[t.Count - 1] + dt);
#else
            while (t.Count < Nsamples) t.Add(t.Last() + dt);
#endif
            double[] Xsaved = new double[Nsamples];
            double[] Xmsaved = new double[Nsamples];

            Ojw.CKalman.LPF filterLpf = new Ojw.CKalman.LPF();

            const int nDim = 1;
            Ojw.CKalman.SimpleKalman filterKalman = new Ojw.CKalman.SimpleKalman(1);

            //최종 결과를 그래프로 보기위해 OpenJigWare 의 그래프 함수를 이용한다.
            //PopupChart popChart = new PopupChart();
            // 500 샘플을 출력하고, 배경 검은색으로(배경이미지 없음=null), 

            // 원본 Wheat,
            // Lowpass = Yello
            // Simple Kalman = Red
            Ojw.CGraph CGrp = new Ojw.CGraph(lbDraw, Nsamples, Color.Black, null, Color.Wheat, Color.Yellow, Color.Red);


            double[] adVal = new double[nDim];

            double[] adLpf = new double[nDim];
            double[] adKalman = new double[nDim];
            for (int k = 0; k < Nsamples; k++)
            {
                adVal[0] = GetSonar(k); // 입력 받은 데이타를
                //Thread.Sleep(1);

                // 각각 필터링한다.
                filterLpf.Do(adVal[0], ref adLpf[0]);
                filterKalman.Do(adVal, ref adKalman);

                Xsaved[k] = adLpf[0];
                Xmsaved[k] = adKalman[0];
                CGrp.Push((int)adVal[0], (int)Xsaved[k], (int)Xmsaved[k]);
            }
            //결과값 출력
            CGrp.OjwDraw();
        }
    }
}
