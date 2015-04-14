//#define _DEF_THREAD

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

namespace OjwRobotMaker
{    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Ojw.C3d m_C3d = new Ojw.C3d();
        private Ojw.CGridView m_CGrid = new Ojw.CGridView();
        private void Main_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);

            m_C3d.Init(picDisp);
            m_C3d.CreateProb_VirtualObject(pnProperty);
            m_C3d.CreateProp_Selected(pnProperty_Selected, null);
            
            // 
            m_C3d.Prop_Set_Main_ShowStandardAxis(true);
            m_C3d.Prop_Set_Main_ShowVirtualAxis(true);
            m_C3d.Prop_Update_VirtualObject();


            //m_CGrid.Create(dgAngle, 3, new Ojw.SGridTable_t("Comment", 250, 1, 0, Color.LightGray, ""));
            m_C3d.GridDraw_Init(dgAngle, 30);
            
#if _DEF_THREAD
            thRun = new Thread(new ThreadStart(ThreadRun));
            thRun.Start();
            m_C3d.OjwDraw();
#else
            tmrDisp.Enabled = true;
#endif            
        }
        float fPan = 0.0f;
        private void tmrDisp_Tick(object sender, EventArgs e)
        {
#if !_DEF_THREAD
            //fPan += 10.0f;
            //m_C3d.SetAngle_Display(fPan, 0, 0);
            //fPan %= 360.0f;
            m_C3d.OjwDraw();
#endif
        }
#if _DEF_THREAD
        private Thread thRun;
        private void ThreadRun()
        {
            while (m_bProgEnd == false)
            {
                fPan += 1.0f;
                m_C3d.SetAngle_Display(fPan, 0, 0);
                fPan %= 360.0f;
                m_C3d.OjwDraw();
                Thread.Sleep(10);
            }
        }
#endif
        private bool m_bProgEnd = false;
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_bProgEnd = true;
        }
    }
}
