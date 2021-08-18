namespace Kinematics
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnDisp = new System.Windows.Forms.Panel();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnDesigner = new System.Windows.Forms.Button();
            this.tmrDisp = new System.Windows.Forms.Timer(this.components);
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtInverse = new System.Windows.Forms.TextBox();
            this.txtForward = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetForward = new System.Windows.Forms.Button();
            this.rdMode1 = new System.Windows.Forms.RadioButton();
            this.rdMode0 = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.txtAxis = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDir = new System.Windows.Forms.ComboBox();
            this.chkInit = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFunctionNumber = new System.Windows.Forms.TextBox();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnReset_Angle = new System.Windows.Forms.Button();
            this.cmbCalcInv_Mode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExample2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDisp
            // 
            this.pnDisp.Location = new System.Drawing.Point(14, 48);
            this.pnDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDisp.Name = "pnDisp";
            this.pnDisp.Size = new System.Drawing.Size(419, 475);
            this.pnDisp.TabIndex = 0;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(14, 12);
            this.btnFileOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(115, 29);
            this.btnFileOpen.TabIndex = 1;
            this.btnFileOpen.Text = "FileOpen(3d)";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // btnDesigner
            // 
            this.btnDesigner.Location = new System.Drawing.Point(1160, 20);
            this.btnDesigner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesigner.Name = "btnDesigner";
            this.btnDesigner.Size = new System.Drawing.Size(239, 78);
            this.btnDesigner.TabIndex = 1;
            this.btnDesigner.Text = "Open(3d Designer program)";
            this.btnDesigner.UseVisualStyleBackColor = true;
            this.btnDesigner.Click += new System.EventHandler(this.btnDesigner_Click);
            // 
            // tmrDisp
            // 
            this.tmrDisp.Enabled = true;
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(905, 104);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(493, 715);
            this.txtInfo.TabIndex = 8;
            this.txtInfo.WordWrap = false;
            // 
            // txtInverse
            // 
            this.txtInverse.Location = new System.Drawing.Point(682, 259);
            this.txtInverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInverse.Multiline = true;
            this.txtInverse.Name = "txtInverse";
            this.txtInverse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInverse.Size = new System.Drawing.Size(215, 190);
            this.txtInverse.TabIndex = 10;
            this.txtInverse.WordWrap = false;
            // 
            // txtForward
            // 
            this.txtForward.Location = new System.Drawing.Point(437, 259);
            this.txtForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForward.Multiline = true;
            this.txtForward.Name = "txtForward";
            this.txtForward.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForward.Size = new System.Drawing.Size(239, 190);
            this.txtForward.TabIndex = 9;
            this.txtForward.WordWrap = false;
            this.txtForward.TextChanged += new System.EventHandler(this.txtForward_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(14, 634);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(662, 185);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Forward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inverse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(905, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "정보";
            // 
            // btnSetForward
            // 
            this.btnSetForward.Location = new System.Drawing.Point(437, 456);
            this.btnSetForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetForward.Name = "btnSetForward";
            this.btnSetForward.Size = new System.Drawing.Size(240, 65);
            this.btnSetForward.TabIndex = 13;
            this.btnSetForward.Text = "Set Forward (파라미터 변경-테스트)";
            this.btnSetForward.UseVisualStyleBackColor = true;
            this.btnSetForward.Click += new System.EventHandler(this.btnSetForward_Click);
            // 
            // rdMode1
            // 
            this.rdMode1.AutoSize = true;
            this.rdMode1.Location = new System.Drawing.Point(373, 12);
            this.rdMode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdMode1.Name = "rdMode1";
            this.rdMode1.Size = new System.Drawing.Size(88, 19);
            this.rdMode1.TabIndex = 14;
            this.rdMode1.TabStop = true;
            this.rdMode1.Text = "관절조종";
            this.rdMode1.UseVisualStyleBackColor = true;
            this.rdMode1.CheckedChanged += new System.EventHandler(this.rdMode1_CheckedChanged);
            // 
            // rdMode0
            // 
            this.rdMode0.AutoSize = true;
            this.rdMode0.Location = new System.Drawing.Point(285, 12);
            this.rdMode0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdMode0.Name = "rdMode0";
            this.rdMode0.Size = new System.Drawing.Size(88, 19);
            this.rdMode0.TabIndex = 14;
            this.rdMode0.TabStop = true;
            this.rdMode0.Text = "화면이동";
            this.rdMode0.UseVisualStyleBackColor = true;
            this.rdMode0.CheckedChanged += new System.EventHandler(this.rdMode0_CheckedChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(742, 46);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(63, 25);
            this.txtA.TabIndex = 15;
            this.txtA.Text = "0";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.txtA.Leave += new System.EventHandler(this.ModelingChanged);
            this.txtA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.txtA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.txtA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(742, 71);
            this.txtD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(63, 25);
            this.txtD.TabIndex = 15;
            this.txtD.Text = "0";
            this.txtD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.txtD.Leave += new System.EventHandler(this.ModelingChanged);
            this.txtD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.txtD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.txtD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(742, 121);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(63, 25);
            this.txtAlpha.TabIndex = 15;
            this.txtAlpha.Text = "0";
            this.txtAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.txtAlpha.Leave += new System.EventHandler(this.ModelingChanged);
            this.txtAlpha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.txtAlpha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.txtAlpha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(742, 96);
            this.txtTheta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(63, 25);
            this.txtTheta.TabIndex = 15;
            this.txtTheta.Text = "0";
            this.txtTheta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.txtTheta.Leave += new System.EventHandler(this.ModelingChanged);
            this.txtTheta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.txtTheta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.txtTheta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // txtAxis
            // 
            this.txtAxis.Location = new System.Drawing.Point(742, 146);
            this.txtAxis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAxis.Name = "txtAxis";
            this.txtAxis.Size = new System.Drawing.Size(63, 25);
            this.txtAxis.TabIndex = 15;
            this.txtAxis.Text = "-1";
            this.txtAxis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.txtAxis.Leave += new System.EventHandler(this.ModelingChanged);
            this.txtAxis.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(742, 171);
            this.txtFunction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(63, 25);
            this.txtFunction.TabIndex = 15;
            this.txtFunction.Text = "255";
            this.txtFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.txtFunction.Leave += new System.EventHandler(this.ModelingChanged);
            this.txtFunction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(813, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 151);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "A(빨간공 쪽으로 이동하는 거리[drag 가능])";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "D(파란공 쪽으로 이동하는 거리[drag 가능])";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Alpha(빨간공 기준 회전[drag 가능])";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Theta(파란공 기준 회전[drag 가능])";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "모터삽입(-1 이 아닌값을 넣어주고...)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "수식번호 삽입(255 가 아닌값을 넣어주고...)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "모터방향";
            // 
            // cmbDir
            // 
            this.cmbDir.FormattingEnabled = true;
            this.cmbDir.Items.AddRange(new object[] {
            "그대로(CW)",
            "거꾸로(CCW)"});
            this.cmbDir.Location = new System.Drawing.Point(514, 202);
            this.cmbDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDir.Name = "cmbDir";
            this.cmbDir.Size = new System.Drawing.Size(138, 23);
            this.cmbDir.TabIndex = 20;
            this.cmbDir.SelectedIndexChanged += new System.EventHandler(this.ModelingChanged);
            // 
            // chkInit
            // 
            this.chkInit.AutoSize = true;
            this.chkInit.Location = new System.Drawing.Point(739, 206);
            this.chkInit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkInit.Name = "chkInit";
            this.chkInit.Size = new System.Drawing.Size(159, 19);
            this.chkInit.TabIndex = 21;
            this.chkInit.Text = "여기부터 다시 계산";
            this.chkInit.UseVisualStyleBackColor = true;
            this.chkInit.CheckedChanged += new System.EventHandler(this.ModelingChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(42, 568);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 25);
            this.txtX.TabIndex = 23;
            this.txtX.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(187, 568);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 25);
            this.txtY.TabIndex = 23;
            this.txtY.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Z";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(331, 568);
            this.txtZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 25);
            this.txtZ.TabIndex = 23;
            this.txtZ.Text = "0";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(440, 568);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(238, 25);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(440, 598);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(238, 25);
            this.btnGet.TabIndex = 24;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 531);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "수식번호";
            // 
            // txtFunctionNumber
            // 
            this.txtFunctionNumber.Location = new System.Drawing.Point(93, 528);
            this.txtFunctionNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunctionNumber.Name = "txtFunctionNumber";
            this.txtFunctionNumber.Size = new System.Drawing.Size(100, 25);
            this.txtFunctionNumber.TabIndex = 23;
            this.txtFunctionNumber.Text = "0";
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(514, 232);
            this.btnExample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(79, 28);
            this.btnExample.TabIndex = 25;
            this.btnExample.Text = "example1";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // btnReset_Angle
            // 
            this.btnReset_Angle.Location = new System.Drawing.Point(23, 599);
            this.btnReset_Angle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset_Angle.Name = "btnReset_Angle";
            this.btnReset_Angle.Size = new System.Drawing.Size(410, 30);
            this.btnReset_Angle.TabIndex = 24;
            this.btnReset_Angle.Text = "관절각도 전부 0으로...";
            this.btnReset_Angle.UseVisualStyleBackColor = true;
            this.btnReset_Angle.Click += new System.EventHandler(this.btnReset_Angle_Click);
            // 
            // cmbCalcInv_Mode
            // 
            this.cmbCalcInv_Mode.FormattingEnabled = true;
            this.cmbCalcInv_Mode.Items.AddRange(new object[] {
            "0: Auto",
            "1: Inverse",
            "2: Inverse2",
            "3: Inverse + Motors"});
            this.cmbCalcInv_Mode.Location = new System.Drawing.Point(295, 528);
            this.cmbCalcInv_Mode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCalcInv_Mode.Name = "cmbCalcInv_Mode";
            this.cmbCalcInv_Mode.Size = new System.Drawing.Size(138, 23);
            this.cmbCalcInv_Mode.TabIndex = 26;
            this.cmbCalcInv_Mode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 462);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(599, 232);
            this.btnExample2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(79, 28);
            this.btnExample2.TabIndex = 25;
            this.btnExample2.Text = "example2";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 836);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbCalcInv_Mode);
            this.Controls.Add(this.btnExample2);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.btnReset_Angle);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFunctionNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkInit);
            this.Controls.Add(this.cmbDir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.txtAxis);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rdMode0);
            this.Controls.Add(this.rdMode1);
            this.Controls.Add(this.btnSetForward);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtInverse);
            this.Controls.Add(this.txtForward);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnDesigner);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.pnDisp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Design 3d";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDisp;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnDesigner;
        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtInverse;
        private System.Windows.Forms.TextBox txtForward;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetForward;
        private System.Windows.Forms.RadioButton rdMode1;
        private System.Windows.Forms.RadioButton rdMode0;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.TextBox txtAxis;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDir;
        private System.Windows.Forms.CheckBox chkInit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFunctionNumber;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnReset_Angle;
        private System.Windows.Forms.ComboBox cmbCalcInv_Mode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExample2;
    }
}

