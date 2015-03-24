namespace JdjDelta
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.pnProperty = new System.Windows.Forms.Panel();
            this.tmrDisp = new System.Windows.Forms.Timer(this.components);
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnDraw_Front = new System.Windows.Forms.Button();
            this.btnDraw_90_inverse = new System.Windows.Forms.Button();
            this.btnDraw_90 = new System.Windows.Forms.Button();
            this.btnDraw_120 = new System.Windows.Forms.Button();
            this.btnDraw_240 = new System.Windows.Forms.Button();
            this.btnDraw_Top = new System.Windows.Forms.Button();
            this.btnDraw_Bottom = new System.Windows.Forms.Button();
            this.btnDraw_Normal = new System.Windows.Forms.Button();
            this.chkUserControl = new System.Windows.Forms.CheckBox();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd15 = new System.Windows.Forms.RadioButton();
            this.btnChangePos = new System.Windows.Forms.Button();
            this.txtPos_Z = new System.Windows.Forms.TextBox();
            this.txtPos_Y = new System.Windows.Forms.TextBox();
            this.txtPos_X = new System.Windows.Forms.TextBox();
            this.label329 = new System.Windows.Forms.Label();
            this.chkMouseControl = new System.Windows.Forms.CheckBox();
            this.btnKinematicsCompile = new System.Windows.Forms.Button();
            this.txtInverseKinematics = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkDh = new System.Windows.Forms.CheckBox();
            this.lbTestDh = new System.Windows.Forms.Label();
            this.btnCheckDH = new System.Windows.Forms.Button();
            this.label294 = new System.Windows.Forms.Label();
            this.txtKinematicsString = new System.Windows.Forms.TextBox();
            this.txtForwardKinematics = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.txtT3 = new System.Windows.Forms.TextBox();
            this.txtT6 = new System.Windows.Forms.TextBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.txtT4 = new System.Windows.Forms.TextBox();
            this.txtT7 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.txtT5 = new System.Windows.Forms.TextBox();
            this.txtT8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GetPosition = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDisp.Location = new System.Drawing.Point(14, 44);
            this.picDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(747, 436);
            this.picDisp.TabIndex = 116;
            this.picDisp.TabStop = false;
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(767, 38);
            this.pnProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(254, 275);
            this.pnProperty.TabIndex = 421;
            // 
            // tmrDisp
            // 
            this.tmrDisp.Interval = 30;
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(15, 631);
            this.txtFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile.Size = new System.Drawing.Size(746, 134);
            this.txtFile.TabIndex = 423;
            this.txtFile.WordWrap = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 491);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(746, 134);
            this.txtMessage.TabIndex = 422;
            // 
            // btnDraw_Front
            // 
            this.btnDraw_Front.Location = new System.Drawing.Point(768, 320);
            this.btnDraw_Front.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Front.Name = "btnDraw_Front";
            this.btnDraw_Front.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Front.TabIndex = 424;
            this.btnDraw_Front.Text = "Front";
            this.btnDraw_Front.UseVisualStyleBackColor = true;
            this.btnDraw_Front.Click += new System.EventHandler(this.btnDraw_Front_Click);
            // 
            // btnDraw_90_inverse
            // 
            this.btnDraw_90_inverse.Location = new System.Drawing.Point(832, 320);
            this.btnDraw_90_inverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_90_inverse.Name = "btnDraw_90_inverse";
            this.btnDraw_90_inverse.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_90_inverse.TabIndex = 424;
            this.btnDraw_90_inverse.Text = "-90";
            this.btnDraw_90_inverse.UseVisualStyleBackColor = true;
            this.btnDraw_90_inverse.Click += new System.EventHandler(this.btnDraw_90_inverse_Click);
            // 
            // btnDraw_90
            // 
            this.btnDraw_90.Location = new System.Drawing.Point(896, 320);
            this.btnDraw_90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_90.Name = "btnDraw_90";
            this.btnDraw_90.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_90.TabIndex = 424;
            this.btnDraw_90.Text = "90";
            this.btnDraw_90.UseVisualStyleBackColor = true;
            this.btnDraw_90.Click += new System.EventHandler(this.btnDraw_90_Click);
            // 
            // btnDraw_120
            // 
            this.btnDraw_120.Location = new System.Drawing.Point(960, 320);
            this.btnDraw_120.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_120.Name = "btnDraw_120";
            this.btnDraw_120.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_120.TabIndex = 424;
            this.btnDraw_120.Text = "120";
            this.btnDraw_120.UseVisualStyleBackColor = true;
            this.btnDraw_120.Click += new System.EventHandler(this.btnDraw_120_Click);
            // 
            // btnDraw_240
            // 
            this.btnDraw_240.Location = new System.Drawing.Point(768, 356);
            this.btnDraw_240.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_240.Name = "btnDraw_240";
            this.btnDraw_240.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_240.TabIndex = 424;
            this.btnDraw_240.Text = "240";
            this.btnDraw_240.UseVisualStyleBackColor = true;
            this.btnDraw_240.Click += new System.EventHandler(this.btnDraw_240_Click);
            // 
            // btnDraw_Top
            // 
            this.btnDraw_Top.Location = new System.Drawing.Point(832, 356);
            this.btnDraw_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Top.Name = "btnDraw_Top";
            this.btnDraw_Top.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Top.TabIndex = 424;
            this.btnDraw_Top.Text = "Top";
            this.btnDraw_Top.UseVisualStyleBackColor = true;
            this.btnDraw_Top.Click += new System.EventHandler(this.btnDraw_Top_Click);
            // 
            // btnDraw_Bottom
            // 
            this.btnDraw_Bottom.Location = new System.Drawing.Point(896, 356);
            this.btnDraw_Bottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Bottom.Name = "btnDraw_Bottom";
            this.btnDraw_Bottom.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Bottom.TabIndex = 424;
            this.btnDraw_Bottom.Text = "Bottom";
            this.btnDraw_Bottom.UseVisualStyleBackColor = true;
            this.btnDraw_Bottom.Click += new System.EventHandler(this.btnDraw_Bottom_Click);
            // 
            // btnDraw_Normal
            // 
            this.btnDraw_Normal.Location = new System.Drawing.Point(960, 356);
            this.btnDraw_Normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Normal.Name = "btnDraw_Normal";
            this.btnDraw_Normal.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Normal.TabIndex = 424;
            this.btnDraw_Normal.Text = "Normal";
            this.btnDraw_Normal.UseVisualStyleBackColor = true;
            this.btnDraw_Normal.Click += new System.EventHandler(this.btnDraw_Normal_Click);
            // 
            // chkUserControl
            // 
            this.chkUserControl.AutoSize = true;
            this.chkUserControl.Location = new System.Drawing.Point(602, 13);
            this.chkUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkUserControl.Name = "chkUserControl";
            this.chkUserControl.Size = new System.Drawing.Size(159, 19);
            this.chkUserControl.TabIndex = 425;
            this.chkUserControl.Text = "사용자 컨트롤 사용";
            this.chkUserControl.UseVisualStyleBackColor = true;
            this.chkUserControl.CheckedChanged += new System.EventHandler(this.chkUserControl_CheckedChanged);
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Checked = true;
            this.rd5.Location = new System.Drawing.Point(13, 12);
            this.rd5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(103, 19);
            this.rd5.TabIndex = 426;
            this.rd5.TabStop = true;
            this.rd5.Text = "Model 5mm";
            this.rd5.UseVisualStyleBackColor = true;
            this.rd5.CheckedChanged += new System.EventHandler(this.rd5_CheckedChanged);
            // 
            // rd15
            // 
            this.rd15.AutoSize = true;
            this.rd15.Location = new System.Drawing.Point(147, 12);
            this.rd15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd15.Name = "rd15";
            this.rd15.Size = new System.Drawing.Size(111, 19);
            this.rd15.TabIndex = 426;
            this.rd15.TabStop = true;
            this.rd15.Text = "Model 15mm";
            this.rd15.UseVisualStyleBackColor = true;
            this.rd15.CheckedChanged += new System.EventHandler(this.rd15_CheckedChanged);
            // 
            // btnChangePos
            // 
            this.btnChangePos.Location = new System.Drawing.Point(456, 294);
            this.btnChangePos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePos.Name = "btnChangePos";
            this.btnChangePos.Size = new System.Drawing.Size(46, 29);
            this.btnChangePos.TabIndex = 460;
            this.btnChangePos.Text = "Go";
            this.btnChangePos.UseVisualStyleBackColor = true;
            this.btnChangePos.Click += new System.EventHandler(this.btnChangePos_Click);
            // 
            // txtPos_Z
            // 
            this.txtPos_Z.Location = new System.Drawing.Point(408, 295);
            this.txtPos_Z.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_Z.Name = "txtPos_Z";
            this.txtPos_Z.Size = new System.Drawing.Size(46, 25);
            this.txtPos_Z.TabIndex = 457;
            this.txtPos_Z.Text = "0";
            // 
            // txtPos_Y
            // 
            this.txtPos_Y.Location = new System.Drawing.Point(359, 295);
            this.txtPos_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_Y.Name = "txtPos_Y";
            this.txtPos_Y.Size = new System.Drawing.Size(46, 25);
            this.txtPos_Y.TabIndex = 458;
            this.txtPos_Y.Text = "15";
            // 
            // txtPos_X
            // 
            this.txtPos_X.Location = new System.Drawing.Point(310, 295);
            this.txtPos_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_X.Name = "txtPos_X";
            this.txtPos_X.Size = new System.Drawing.Size(46, 25);
            this.txtPos_X.TabIndex = 459;
            this.txtPos_X.Text = "0";
            // 
            // label329
            // 
            this.label329.AutoSize = true;
            this.label329.Location = new System.Drawing.Point(261, 300);
            this.label329.Name = "label329";
            this.label329.Size = new System.Drawing.Size(43, 15);
            this.label329.TabIndex = 456;
            this.label329.Text = "X,Y,Z";
            // 
            // chkMouseControl
            // 
            this.chkMouseControl.AutoSize = true;
            this.chkMouseControl.Location = new System.Drawing.Point(460, 13);
            this.chkMouseControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMouseControl.Name = "chkMouseControl";
            this.chkMouseControl.Size = new System.Drawing.Size(129, 19);
            this.chkMouseControl.TabIndex = 425;
            this.chkMouseControl.Text = "화면 직접 이동";
            this.chkMouseControl.UseVisualStyleBackColor = true;
            this.chkMouseControl.CheckedChanged += new System.EventHandler(this.chkMouseControl_CheckedChanged);
            // 
            // btnKinematicsCompile
            // 
            this.btnKinematicsCompile.Location = new System.Drawing.Point(1137, 350);
            this.btnKinematicsCompile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKinematicsCompile.Name = "btnKinematicsCompile";
            this.btnKinematicsCompile.Size = new System.Drawing.Size(149, 45);
            this.btnKinematicsCompile.TabIndex = 463;
            this.btnKinematicsCompile.Text = "Compile";
            this.btnKinematicsCompile.UseVisualStyleBackColor = true;
            this.btnKinematicsCompile.Click += new System.EventHandler(this.btnKinematicsCompile_Click);
            // 
            // txtInverseKinematics
            // 
            this.txtInverseKinematics.Location = new System.Drawing.Point(7, 8);
            this.txtInverseKinematics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInverseKinematics.Multiline = true;
            this.txtInverseKinematics.Name = "txtInverseKinematics";
            this.txtInverseKinematics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInverseKinematics.Size = new System.Drawing.Size(494, 280);
            this.txtInverseKinematics.TabIndex = 462;
            this.txtInverseKinematics.WordWrap = false;
            this.txtInverseKinematics.TextChanged += new System.EventHandler(this.txtInverseKinematics_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(767, 401);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 364);
            this.tabControl1.TabIndex = 464;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkDh);
            this.tabPage1.Controls.Add(this.lbTestDh);
            this.tabPage1.Controls.Add(this.btnCheckDH);
            this.tabPage1.Controls.Add(this.label294);
            this.tabPage1.Controls.Add(this.txtKinematicsString);
            this.tabPage1.Controls.Add(this.txtForwardKinematics);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(510, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Forward";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkDh
            // 
            this.chkDh.AutoSize = true;
            this.chkDh.Location = new System.Drawing.Point(7, 10);
            this.chkDh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDh.Name = "chkDh";
            this.chkDh.Size = new System.Drawing.Size(139, 19);
            this.chkDh.TabIndex = 465;
            this.chkDh.Text = "Show DH Object";
            this.chkDh.UseVisualStyleBackColor = true;
            this.chkDh.CheckedChanged += new System.EventHandler(this.chkDh_CheckedChanged);
            // 
            // lbTestDh
            // 
            this.lbTestDh.AutoSize = true;
            this.lbTestDh.Location = new System.Drawing.Point(75, 298);
            this.lbTestDh.Name = "lbTestDh";
            this.lbTestDh.Size = new System.Drawing.Size(66, 15);
            this.lbTestDh.TabIndex = 474;
            this.lbTestDh.Text = "[x, y, z]";
            this.lbTestDh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckDH
            // 
            this.btnCheckDH.Location = new System.Drawing.Point(363, 292);
            this.btnCheckDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckDH.Name = "btnCheckDH";
            this.btnCheckDH.Size = new System.Drawing.Size(138, 31);
            this.btnCheckDH.TabIndex = 473;
            this.btnCheckDH.Text = "Move to point";
            this.btnCheckDH.UseVisualStyleBackColor = true;
            this.btnCheckDH.Click += new System.EventHandler(this.btnCheckDH_Click);
            // 
            // label294
            // 
            this.label294.AutoSize = true;
            this.label294.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label294.ForeColor = System.Drawing.Color.Red;
            this.label294.Location = new System.Drawing.Point(7, 298);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(50, 15);
            this.label294.TabIndex = 462;
            this.label294.Text = "D-H :";
            this.label294.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKinematicsString
            // 
            this.txtKinematicsString.Location = new System.Drawing.Point(255, 36);
            this.txtKinematicsString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKinematicsString.Multiline = true;
            this.txtKinematicsString.Name = "txtKinematicsString";
            this.txtKinematicsString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKinematicsString.Size = new System.Drawing.Size(246, 253);
            this.txtKinematicsString.TabIndex = 461;
            this.txtKinematicsString.WordWrap = false;
            // 
            // txtForwardKinematics
            // 
            this.txtForwardKinematics.Location = new System.Drawing.Point(7, 36);
            this.txtForwardKinematics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtForwardKinematics.Multiline = true;
            this.txtForwardKinematics.Name = "txtForwardKinematics";
            this.txtForwardKinematics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForwardKinematics.Size = new System.Drawing.Size(242, 253);
            this.txtForwardKinematics.TabIndex = 461;
            this.txtForwardKinematics.WordWrap = false;
            this.txtForwardKinematics.TextChanged += new System.EventHandler(this.txtForwardKinematics_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInverseKinematics);
            this.tabPage2.Controls.Add(this.btnChangePos);
            this.tabPage2.Controls.Add(this.label329);
            this.tabPage2.Controls.Add(this.txtPos_Z);
            this.tabPage2.Controls.Add(this.txtPos_X);
            this.tabPage2.Controls.Add(this.txtPos_Y);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(510, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inverse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(1057, 38);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(57, 25);
            this.txtT0.TabIndex = 465;
            this.txtT0.Text = "0";
            this.txtT0.TextChanged += new System.EventHandler(this.txtT0_TextChanged);
            // 
            // txtT3
            // 
            this.txtT3.Location = new System.Drawing.Point(1057, 69);
            this.txtT3.Name = "txtT3";
            this.txtT3.Size = new System.Drawing.Size(57, 25);
            this.txtT3.TabIndex = 465;
            this.txtT3.Text = "0";
            this.txtT3.TextChanged += new System.EventHandler(this.txtT3_TextChanged);
            // 
            // txtT6
            // 
            this.txtT6.Location = new System.Drawing.Point(1057, 100);
            this.txtT6.Name = "txtT6";
            this.txtT6.Size = new System.Drawing.Size(57, 25);
            this.txtT6.TabIndex = 465;
            this.txtT6.Text = "0";
            this.txtT6.TextChanged += new System.EventHandler(this.txtT6_TextChanged);
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(1141, 38);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(57, 25);
            this.txtT1.TabIndex = 465;
            this.txtT1.Text = "0";
            this.txtT1.TextChanged += new System.EventHandler(this.txtT1_TextChanged);
            // 
            // txtT4
            // 
            this.txtT4.Location = new System.Drawing.Point(1141, 69);
            this.txtT4.Name = "txtT4";
            this.txtT4.Size = new System.Drawing.Size(57, 25);
            this.txtT4.TabIndex = 465;
            this.txtT4.Text = "0";
            this.txtT4.TextChanged += new System.EventHandler(this.txtT4_TextChanged);
            // 
            // txtT7
            // 
            this.txtT7.Location = new System.Drawing.Point(1141, 100);
            this.txtT7.Name = "txtT7";
            this.txtT7.Size = new System.Drawing.Size(57, 25);
            this.txtT7.TabIndex = 465;
            this.txtT7.Text = "0";
            this.txtT7.TextChanged += new System.EventHandler(this.txtT7_TextChanged);
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(1225, 38);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(57, 25);
            this.txtT2.TabIndex = 465;
            this.txtT2.Text = "0";
            this.txtT2.TextChanged += new System.EventHandler(this.txtT2_TextChanged);
            // 
            // txtT5
            // 
            this.txtT5.Location = new System.Drawing.Point(1225, 69);
            this.txtT5.Name = "txtT5";
            this.txtT5.Size = new System.Drawing.Size(57, 25);
            this.txtT5.TabIndex = 465;
            this.txtT5.Text = "0";
            this.txtT5.TextChanged += new System.EventHandler(this.txtT5_TextChanged);
            // 
            // txtT8
            // 
            this.txtT8.Location = new System.Drawing.Point(1225, 100);
            this.txtT8.Name = "txtT8";
            this.txtT8.Size = new System.Drawing.Size(57, 25);
            this.txtT8.TabIndex = 465;
            this.txtT8.Text = "0";
            this.txtT8.TextChanged += new System.EventHandler(this.txtT8_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1034, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 456;
            this.label1.Text = "t0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1118, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 456;
            this.label2.Text = "t1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1202, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 456;
            this.label3.Text = "t2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1034, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 456;
            this.label4.Text = "t3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1118, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 456;
            this.label5.Text = "t4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1202, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 456;
            this.label6.Text = "t5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1034, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 456;
            this.label7.Text = "t6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1118, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 456;
            this.label8.Text = "t7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1202, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 456;
            this.label9.Text = "t8";
            // 
            // GetPosition
            // 
            this.GetPosition.Location = new System.Drawing.Point(1035, 131);
            this.GetPosition.Name = "GetPosition";
            this.GetPosition.Size = new System.Drawing.Size(246, 33);
            this.GetPosition.TabIndex = 466;
            this.GetPosition.Text = "Get";
            this.GetPosition.UseVisualStyleBackColor = true;
            this.GetPosition.Click += new System.EventHandler(this.GetPosition_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Lime;
            this.btnTest.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTest.Location = new System.Drawing.Point(1037, 223);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(139, 58);
            this.btnTest.TabIndex = 467;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 782);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.GetPosition);
            this.Controls.Add(this.txtT8);
            this.Controls.Add(this.txtT7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtT6);
            this.Controls.Add(this.txtT5);
            this.Controls.Add(this.txtT4);
            this.Controls.Add(this.txtT3);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnKinematicsCompile);
            this.Controls.Add(this.rd15);
            this.Controls.Add(this.rd5);
            this.Controls.Add(this.chkMouseControl);
            this.Controls.Add(this.chkUserControl);
            this.Controls.Add(this.btnDraw_240);
            this.Controls.Add(this.btnDraw_90);
            this.Controls.Add(this.btnDraw_120);
            this.Controls.Add(this.btnDraw_90_inverse);
            this.Controls.Add(this.btnDraw_Normal);
            this.Controls.Add(this.btnDraw_Bottom);
            this.Controls.Add(this.btnDraw_Top);
            this.Controls.Add(this.btnDraw_Front);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pnProperty);
            this.Controls.Add(this.picDisp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnDraw_Front;
        private System.Windows.Forms.Button btnDraw_90_inverse;
        private System.Windows.Forms.Button btnDraw_90;
        private System.Windows.Forms.Button btnDraw_120;
        private System.Windows.Forms.Button btnDraw_240;
        private System.Windows.Forms.Button btnDraw_Top;
        private System.Windows.Forms.Button btnDraw_Bottom;
        private System.Windows.Forms.Button btnDraw_Normal;
        private System.Windows.Forms.CheckBox chkUserControl;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd15;
        private System.Windows.Forms.Button btnChangePos;
        private System.Windows.Forms.TextBox txtPos_Z;
        private System.Windows.Forms.TextBox txtPos_Y;
        private System.Windows.Forms.TextBox txtPos_X;
        private System.Windows.Forms.Label label329;
        private System.Windows.Forms.CheckBox chkMouseControl;
        private System.Windows.Forms.Button btnKinematicsCompile;
        private System.Windows.Forms.TextBox txtInverseKinematics;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbTestDh;
        private System.Windows.Forms.Button btnCheckDH;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtKinematicsString;
        private System.Windows.Forms.TextBox txtForwardKinematics;
        private System.Windows.Forms.CheckBox chkDh;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.TextBox txtT3;
        private System.Windows.Forms.TextBox txtT6;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.TextBox txtT4;
        private System.Windows.Forms.TextBox txtT7;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.TextBox txtT5;
        private System.Windows.Forms.TextBox txtT8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GetPosition;
        private System.Windows.Forms.Button btnTest;
    }
}

