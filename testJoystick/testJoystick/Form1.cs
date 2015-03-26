using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.DirectX.DirectInput;
//using OpenJigWare;

namespace testJoystick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Joystick jst;
        private void Form1_Load(object sender, EventArgs e)
        {
            // grab the joystick
            jst = new Joystick(this.Handle);
            string[] sticks = jst.FindJoysticks();
            jst.AcquireJoystick(sticks[0]);

            String strMsg = "AxisControls -> " + jst.AxisCount.ToString();
            MessageBox.Show(strMsg);
            //Ojw.CMessage.Write(strMsg);
            // add the axis controls to the axis container
            //for (int i = 0; i < jst.AxisCount; i++)
            //{
            //    Axis ax = new Axis();
            //    ax.AxisId = i + 1;
            //    flpAxes.Controls.Add(ax);
            //}
            strMsg = "Buttons -> " + jst.Buttons.Length.ToString();
            MessageBox.Show(strMsg);
            //Ojw.CMessage.Write(strMsg);
            // add the button controls to the button container
            //for (int i = 0; i < jst.Buttons.Length; i++)
            //{
            //    JoystickSample.Button btn = new Button();
            //    btn.ButtonId = i + 1;
            //    btn.ButtonStatus = jst.Buttons[i];
            //    flpButtons.Controls.Add(btn);
            //}
        }

        
    }

    public class Joystick
    {
        private Device joystickDevice;
        private JoystickState state;

        private int axisCount;
        /// <summary>
        /// Number of axes on the joystick.
        /// </summary>
        public int AxisCount
        {
            get { return axisCount; }
        }

        private int axisA;
        /// <summary>
        /// The first axis on the joystick.
        /// </summary>
        public int AxisA
        {
            get { return axisA; }
        }

        private int axisB;
        /// <summary>
        /// The second axis on the joystick.
        /// </summary>
        public int AxisB
        {
            get { return axisB; }
        }

        private int axisC;
        /// <summary>
        /// The third axis on the joystick.
        /// </summary>
        public int AxisC
        {
            get { return axisC; }
        }

        private int axisD;
        /// <summary>
        /// The fourth axis on the joystick.
        /// </summary>
        public int AxisD
        {
            get { return axisD; }
        }

        private int axisE;
        /// <summary>
        /// The fifth axis on the joystick.
        /// </summary>
        public int AxisE
        {
            get { return axisE; }
        }

        private int axisF;
        /// <summary>
        /// The sixth axis on the joystick.
        /// </summary>
        public int AxisF
        {
            get { return axisF; }
        }
        private IntPtr hWnd;

        private bool[] buttons;
        /// <summary>
        /// Array of buttons availiable on the joystick. This also includes PoV hats.
        /// </summary>
        public bool[] Buttons
        {
            get { return buttons; }
        }

        private string[] systemJoysticks;

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="window_handle">Handle of the window which the joystick will be "attached" to.</param>
        public Joystick(IntPtr window_handle)
        {
            hWnd = window_handle;
            axisA = -1;
            axisB = -1;
            axisC = -1;
            axisD = -1;
            axisE = -1;
            axisF = -1;
            axisCount = 0;
        }

        private void Poll()
        {
            try
            {
                // poll the joystick
                joystickDevice.Poll();
                // update the joystick state field
                state = joystickDevice.CurrentJoystickState;
            }
            catch (Exception err)
            {
                // we probably lost connection to the joystick
                // was it unplugged or locked by another application?
                //Ojw.CMessage.Write_Error("Poll()");
                //Ojw.CMessage.Write_Error(err.Message);
                //Ojw.CMessage.Write_Error(err.StackTrace);
            }
        }

        /// <summary>
        /// Retrieves a list of joysticks attached to the computer.
        /// </summary>
        /// <example>
        /// [C#]
        /// <code>
        /// Joystick jst = new Joystick(this.Handle);
        /// string[] sticks = jst.FindJoysticks();
        /// </code>
        /// </example>
        /// <returns>A list of joysticks as an array of strings.</returns>
        public string[] FindJoysticks()
        {
            systemJoysticks = null;

            try
            {
                // Find all the GameControl devices that are attached.
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);

                // check that we have at least one device.
                if (gameControllerList.Count > 0)
                {
                    systemJoysticks = new string[gameControllerList.Count];
                    int i = 0;
                    // loop through the devices.
                    foreach (DeviceInstance deviceInstance in gameControllerList)
                    {
                        // create a device from this controller so we can retrieve info.
                        joystickDevice = new Device(deviceInstance.InstanceGuid);
                        joystickDevice.SetCooperativeLevel(hWnd,
                            CooperativeLevelFlags.Background |
                            CooperativeLevelFlags.NonExclusive);

                        systemJoysticks[i] = joystickDevice.DeviceInformation.InstanceName;

                        i++;
                    }
                }
            }
            catch (Exception err)
            {
                //Ojw.CMessage.Write_Error("FindJoysticks()");
                //Ojw.CMessage.Write_Error(err.Message);
                //Ojw.CMessage.Write_Error(err.StackTrace);
            }

            return systemJoysticks;
        }

        /// <summary>
        /// Acquire the named joystick. You can find this joystick through the <see cref="FindJoysticks"/> method.
        /// </summary>
        /// <param name="name">Name of the joystick.</param>
        /// <returns>The success of the connection.</returns>
        public bool AcquireJoystick(string name)
        {
            try
            {
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);
                int i = 0;
                bool found = false;
                // loop through the devices.
                foreach (DeviceInstance deviceInstance in gameControllerList)
                {
                    if (deviceInstance.InstanceName == name)
                    {
                        found = true;
                        // create a device from this controller so we can retrieve info.
                        joystickDevice = new Device(deviceInstance.InstanceGuid);
                        joystickDevice.SetCooperativeLevel(hWnd,
                            CooperativeLevelFlags.Background |
                            CooperativeLevelFlags.NonExclusive);
                        break;
                    }

                    i++;
                }

                if (!found)
                    return false;

                // Tell DirectX that this is a Joystick.
                joystickDevice.SetDataFormat(DeviceDataFormat.Joystick);

                // Finally, acquire the device.
                joystickDevice.Acquire();

                // How many axes?
                // Find the capabilities of the joystick
                DeviceCaps cps = joystickDevice.Caps;
                string strMsg = "Joystick Axis: " + cps.NumberAxes;
                MessageBox.Show(strMsg);
                strMsg = "Joystick Buttons: " + cps.NumberButtons;
                MessageBox.Show(strMsg);
                //Ojw.CMessage.Write("Joystick Axis: " + cps.NumberAxes);
                //Ojw.CMessage.Write("Joystick Buttons: " + cps.NumberButtons);

                axisCount = cps.NumberAxes;

                UpdateStatus();
            }
            catch (Exception err)
            {
                //Ojw.CMessage.Write_Error("FindJoysticks()");
                //Ojw.CMessage.Write_Error(err.Message);
                //Ojw.CMessage.Write_Error(err.StackTrace);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Unaquire a joystick releasing it back to the system.
        /// </summary>
        public void ReleaseJoystick()
        {
            joystickDevice.Unacquire();
        }

        /// <summary>
        /// Update the properties of button and axis positions.
        /// </summary>
        public void UpdateStatus()
        {
            Poll();

            int[] extraAxis = state.GetSlider();
            //Rz Rx X Y Axis1 Axis2
            axisA = state.Rz;
            axisB = state.Rx;
            axisC = state.X;
            axisD = state.Y;
            axisE = extraAxis[0];
            axisF = extraAxis[1];

            // not using buttons, so don't take the tiny amount of time it takes to get/parse
            byte[] jsButtons = state.GetButtons();
            buttons = new bool[jsButtons.Length];

            int i = 0;
            foreach (byte button in jsButtons)
            {
                buttons[i] = button >= 128;
                i++;
            }
        }
    }
}
