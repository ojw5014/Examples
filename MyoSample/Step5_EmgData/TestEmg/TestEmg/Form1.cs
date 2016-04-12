using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// OpenJigWare
using OpenJigWare;

// Myo
using MyoSharp.Communication;
using MyoSharp.Device;
//using MyoSharp.ConsoleSample.Internal;
using MyoSharp.Exceptions;
using MyoSharp.Poses;

namespace TestEmg
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Variable
        #region For OpenJigWare
        // Graphic
        private Ojw.CGraph m_CGrap = null;

        // Timer
        private Ojw.CTimer m_CTId = new Ojw.CTimer();
        private Ojw.CTimer m_CTId_Graph = new Ojw.CTimer();
        #endregion For OpenJigWare

        #region For Myo
        IChannel m_myoChannel;
        IHub m_myoHub;
        IHeldPose m_myoPos;
        #endregion For Myo
        #endregion Variable

        private void frmMain_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);

            // Graph Init
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

            #region Myo
            m_myoChannel = Channel.Create(ChannelDriver.Create(ChannelBridge.Create(), MyoErrorHandlerDriver.Create(MyoErrorHandlerBridge.Create())));
            m_myoHub = Hub.Create(m_myoChannel);

            // 이벤트 등록            
            m_myoHub.MyoConnected += new EventHandler<MyoEventArgs>(myoHub_MyoConnected);
            m_myoHub.MyoDisconnected += new EventHandler<MyoEventArgs>(myoHub_MyoDisconnected);

            // start listening for Myo data
            m_myoChannel.StartListening();
            #endregion Myo

        }

        #region Myo
        private void myoHub_MyoConnected(object sender, MyoEventArgs e)
        {
            Ojw.CMessage.Write(String.Format("Myo {0} has connected!", e.Myo.Handle));
            e.Myo.Vibrate(VibrationType.Short);
            //e.Myo.Unlock(UnlockType.Hold);
            Ojw.CMessage.Write("Connected(Myo)");

            m_CTId.Set();
            e.Myo.EmgDataAcquired += Myo_EmgDataAcquired;
            e.Myo.SetEmgStreaming(true);
        }
        private void myoHub_MyoDisconnected(object sender, MyoEventArgs e)
        {
            e.Myo.SetEmgStreaming(false);
            e.Myo.EmgDataAcquired -= Myo_EmgDataAcquired;

            Ojw.CMessage.Write("Disconnected(Myo)");
        }
        private void Myo_EmgDataAcquired(object sender, EmgDataEventArgs e)
        {
            // Display Emg Text Data (1000 ms interval = 1 second)
            if (m_CTId.Get() >= 1000)
            {
                m_CTId.Set();
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

            // Display Emg Graphic Data (100 ms interval)
            if (m_CTId_Graph.Get() >= 100)
            {
                m_CTId_Graph.Set();
                m_CGrap.Push(
                            e.EmgData.GetDataForSensor(0),
                            e.EmgData.GetDataForSensor(1),
                            e.EmgData.GetDataForSensor(2),
                            e.EmgData.GetDataForSensor(3),
                            e.EmgData.GetDataForSensor(4),
                            e.EmgData.GetDataForSensor(5),
                            e.EmgData.GetDataForSensor(6),
                            e.EmgData.GetDataForSensor(7)
                        );
                m_CGrap.OjwDraw();
            }
        }
        #endregion Myo
    }
}
