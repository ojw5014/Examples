namespace testMyo
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tmrPulse = new System.Windows.Forms.Timer(this.components);
            this.lbGraph = new System.Windows.Forms.Label();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.chkAnother = new System.Windows.Forms.CheckBox();
            this.chkStep2 = new System.Windows.Forms.CheckBox();
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.pnProperty = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkDh = new System.Windows.Forms.CheckBox();
            this.lbTestDh = new System.Windows.Forms.Label();
            this.btnCheckDH = new System.Windows.Forms.Button();
            this.label294 = new System.Windows.Forms.Label();
            this.txtKinematicsString = new System.Windows.Forms.TextBox();
            this.txtForwardKinematics = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtInverseKinematics = new System.Windows.Forms.TextBox();
            this.btnChangePos = new System.Windows.Forms.Button();
            this.label329 = new System.Windows.Forms.Label();
            this.txtPos_Z = new System.Windows.Forms.TextBox();
            this.txtPos_X = new System.Windows.Forms.TextBox();
            this.txtPos_Y = new System.Windows.Forms.TextBox();
            this.GetPosition = new System.Windows.Forms.Button();
            this.txtT8 = new System.Windows.Forms.TextBox();
            this.txtT7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtT6 = new System.Windows.Forms.TextBox();
            this.txtT5 = new System.Windows.Forms.TextBox();
            this.txtT4 = new System.Windows.Forms.TextBox();
            this.txtT3 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.btnKinematicsCompile = new System.Windows.Forms.Button();
            this.btnDraw_240 = new System.Windows.Forms.Button();
            this.btnDraw_90 = new System.Windows.Forms.Button();
            this.btnDraw_120 = new System.Windows.Forms.Button();
            this.btnDraw_90_inverse = new System.Windows.Forms.Button();
            this.btnDraw_Normal = new System.Windows.Forms.Button();
            this.btnDraw_Bottom = new System.Windows.Forms.Button();
            this.btnDraw_Top = new System.Windows.Forms.Button();
            this.btnDraw_Front = new System.Windows.Forms.Button();
            this.txtT9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtT10 = new System.Windows.Forms.TextBox();
            this.txtT11 = new System.Windows.Forms.TextBox();
            this.txtT12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtT13 = new System.Windows.Forms.TextBox();
            this.txtT14 = new System.Windows.Forms.TextBox();
            this.chkUserControl = new System.Windows.Forms.CheckBox();
            this.lbPos = new System.Windows.Forms.Label();
            this.btnThumb = new System.Windows.Forms.Button();
            this.btnFirstFinger = new System.Windows.Forms.Button();
            this.btnMiddleFinger = new System.Windows.Forms.Button();
            this.btnLittleFinger = new System.Windows.Forms.Button();
            this.btnFist = new System.Windows.Forms.Button();
            this.btnSpread = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(143, 888);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(1249, 157);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.WordWrap = false;
            // 
            // tmrPulse
            // 
            this.tmrPulse.Tick += new System.EventHandler(this.tmrPulse_Tick);
            // 
            // lbGraph
            // 
            this.lbGraph.Location = new System.Drawing.Point(12, 9);
            this.lbGraph.Name = "lbGraph";
            this.lbGraph.Size = new System.Drawing.Size(755, 876);
            this.lbGraph.TabIndex = 23;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Checked = true;
            this.chkFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilter.Location = new System.Drawing.Point(15, 890);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(59, 19);
            this.chkFilter.TabIndex = 24;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(15, 915);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(100, 25);
            this.txtAlpha.TabIndex = 25;
            this.txtAlpha.Text = "0.1";
            this.txtAlpha.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            // 
            // chkAnother
            // 
            this.chkAnother.AutoSize = true;
            this.chkAnother.Checked = true;
            this.chkAnother.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnother.Location = new System.Drawing.Point(15, 946);
            this.chkAnother.Name = "chkAnother";
            this.chkAnother.Size = new System.Drawing.Size(67, 19);
            this.chkAnother.TabIndex = 24;
            this.chkAnother.Text = "Step1";
            this.chkAnother.UseVisualStyleBackColor = true;
            this.chkAnother.CheckedChanged += new System.EventHandler(this.chkAnother_CheckedChanged);
            // 
            // chkStep2
            // 
            this.chkStep2.AutoSize = true;
            this.chkStep2.Checked = true;
            this.chkStep2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStep2.Location = new System.Drawing.Point(15, 971);
            this.chkStep2.Name = "chkStep2";
            this.chkStep2.Size = new System.Drawing.Size(67, 19);
            this.chkStep2.TabIndex = 24;
            this.chkStep2.Text = "Step2";
            this.chkStep2.UseVisualStyleBackColor = true;
            this.chkStep2.CheckedChanged += new System.EventHandler(this.chkStep2_CheckedChanged);
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(773, 9);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(359, 275);
            this.picDisp.TabIndex = 26;
            this.picDisp.TabStop = false;
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(1138, 9);
            this.pnProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(254, 275);
            this.pnProperty.TabIndex = 422;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(773, 369);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 364);
            this.tabControl1.TabIndex = 465;
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
            this.chkDh.Checked = true;
            this.chkDh.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // label329
            // 
            this.label329.AutoSize = true;
            this.label329.Location = new System.Drawing.Point(261, 300);
            this.label329.Name = "label329";
            this.label329.Size = new System.Drawing.Size(43, 15);
            this.label329.TabIndex = 456;
            this.label329.Text = "X,Y,Z";
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
            // txtPos_X
            // 
            this.txtPos_X.Location = new System.Drawing.Point(310, 295);
            this.txtPos_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_X.Name = "txtPos_X";
            this.txtPos_X.Size = new System.Drawing.Size(46, 25);
            this.txtPos_X.TabIndex = 459;
            this.txtPos_X.Text = "0";
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
            // GetPosition
            // 
            this.GetPosition.Location = new System.Drawing.Point(1110, 744);
            this.GetPosition.Name = "GetPosition";
            this.GetPosition.Size = new System.Drawing.Size(181, 87);
            this.GetPosition.TabIndex = 486;
            this.GetPosition.Text = "Get";
            this.GetPosition.UseVisualStyleBackColor = true;
            this.GetPosition.Click += new System.EventHandler(this.GetPosition_Click);
            // 
            // txtT8
            // 
            this.txtT8.Location = new System.Drawing.Point(965, 802);
            this.txtT8.Name = "txtT8";
            this.txtT8.Size = new System.Drawing.Size(57, 25);
            this.txtT8.TabIndex = 482;
            this.txtT8.Text = "0";
            this.txtT8.TextChanged += new System.EventHandler(this.txtT8_TextChanged);
            // 
            // txtT7
            // 
            this.txtT7.Location = new System.Drawing.Point(881, 802);
            this.txtT7.Name = "txtT7";
            this.txtT7.Size = new System.Drawing.Size(57, 25);
            this.txtT7.TabIndex = 483;
            this.txtT7.Text = "0";
            this.txtT7.TextChanged += new System.EventHandler(this.txtT7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(942, 807);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 474;
            this.label9.Text = "t8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 807);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 471;
            this.label8.Text = "t7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(942, 778);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 468;
            this.label6.Text = "t5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(858, 778);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 467;
            this.label5.Text = "t4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 807);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 470;
            this.label7.Text = "t6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(942, 749);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 469;
            this.label3.Text = "t2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 778);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 473;
            this.label4.Text = "t3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 475;
            this.label2.Text = "t1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 749);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 472;
            this.label1.Text = "t0";
            // 
            // txtT6
            // 
            this.txtT6.Location = new System.Drawing.Point(797, 802);
            this.txtT6.Name = "txtT6";
            this.txtT6.Size = new System.Drawing.Size(57, 25);
            this.txtT6.TabIndex = 485;
            this.txtT6.Text = "0";
            this.txtT6.TextChanged += new System.EventHandler(this.txtT6_TextChanged);
            // 
            // txtT5
            // 
            this.txtT5.Location = new System.Drawing.Point(965, 773);
            this.txtT5.Name = "txtT5";
            this.txtT5.Size = new System.Drawing.Size(57, 25);
            this.txtT5.TabIndex = 484;
            this.txtT5.Text = "0";
            this.txtT5.TextChanged += new System.EventHandler(this.txtT5_TextChanged);
            // 
            // txtT4
            // 
            this.txtT4.Location = new System.Drawing.Point(881, 773);
            this.txtT4.Name = "txtT4";
            this.txtT4.Size = new System.Drawing.Size(57, 25);
            this.txtT4.TabIndex = 481;
            this.txtT4.Text = "0";
            this.txtT4.TextChanged += new System.EventHandler(this.txtT4_TextChanged);
            // 
            // txtT3
            // 
            this.txtT3.Location = new System.Drawing.Point(797, 773);
            this.txtT3.Name = "txtT3";
            this.txtT3.Size = new System.Drawing.Size(57, 25);
            this.txtT3.TabIndex = 478;
            this.txtT3.Text = "0";
            this.txtT3.TextChanged += new System.EventHandler(this.txtT3_TextChanged);
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(965, 744);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(57, 25);
            this.txtT2.TabIndex = 477;
            this.txtT2.Text = "0";
            this.txtT2.TextChanged += new System.EventHandler(this.txtT2_TextChanged);
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(881, 744);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(57, 25);
            this.txtT1.TabIndex = 480;
            this.txtT1.Text = "0";
            this.txtT1.TextChanged += new System.EventHandler(this.txtT1_TextChanged);
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(797, 744);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(57, 25);
            this.txtT0.TabIndex = 479;
            this.txtT0.Text = "0";
            this.txtT0.TextChanged += new System.EventHandler(this.txtT0_TextChanged);
            // 
            // btnKinematicsCompile
            // 
            this.btnKinematicsCompile.Location = new System.Drawing.Point(1297, 392);
            this.btnKinematicsCompile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKinematicsCompile.Name = "btnKinematicsCompile";
            this.btnKinematicsCompile.Size = new System.Drawing.Size(95, 128);
            this.btnKinematicsCompile.TabIndex = 476;
            this.btnKinematicsCompile.Text = "Compile";
            this.btnKinematicsCompile.UseVisualStyleBackColor = true;
            this.btnKinematicsCompile.Click += new System.EventHandler(this.btnKinematicsCompile_Click);
            // 
            // btnDraw_240
            // 
            this.btnDraw_240.Location = new System.Drawing.Point(773, 327);
            this.btnDraw_240.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_240.Name = "btnDraw_240";
            this.btnDraw_240.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_240.TabIndex = 492;
            this.btnDraw_240.Text = "240";
            this.btnDraw_240.UseVisualStyleBackColor = true;
            this.btnDraw_240.Click += new System.EventHandler(this.btnDraw_240_Click);
            // 
            // btnDraw_90
            // 
            this.btnDraw_90.Location = new System.Drawing.Point(901, 291);
            this.btnDraw_90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_90.Name = "btnDraw_90";
            this.btnDraw_90.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_90.TabIndex = 491;
            this.btnDraw_90.Text = "90";
            this.btnDraw_90.UseVisualStyleBackColor = true;
            this.btnDraw_90.Click += new System.EventHandler(this.btnDraw_90_Click);
            // 
            // btnDraw_120
            // 
            this.btnDraw_120.Location = new System.Drawing.Point(965, 291);
            this.btnDraw_120.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_120.Name = "btnDraw_120";
            this.btnDraw_120.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_120.TabIndex = 494;
            this.btnDraw_120.Text = "120";
            this.btnDraw_120.UseVisualStyleBackColor = true;
            this.btnDraw_120.Click += new System.EventHandler(this.btnDraw_120_Click);
            // 
            // btnDraw_90_inverse
            // 
            this.btnDraw_90_inverse.Location = new System.Drawing.Point(837, 291);
            this.btnDraw_90_inverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_90_inverse.Name = "btnDraw_90_inverse";
            this.btnDraw_90_inverse.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_90_inverse.TabIndex = 493;
            this.btnDraw_90_inverse.Text = "-90";
            this.btnDraw_90_inverse.UseVisualStyleBackColor = true;
            this.btnDraw_90_inverse.Click += new System.EventHandler(this.btnDraw_90_inverse_Click);
            // 
            // btnDraw_Normal
            // 
            this.btnDraw_Normal.Location = new System.Drawing.Point(965, 327);
            this.btnDraw_Normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Normal.Name = "btnDraw_Normal";
            this.btnDraw_Normal.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Normal.TabIndex = 488;
            this.btnDraw_Normal.Text = "Normal";
            this.btnDraw_Normal.UseVisualStyleBackColor = true;
            this.btnDraw_Normal.Click += new System.EventHandler(this.btnDraw_Normal_Click);
            // 
            // btnDraw_Bottom
            // 
            this.btnDraw_Bottom.Location = new System.Drawing.Point(901, 327);
            this.btnDraw_Bottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Bottom.Name = "btnDraw_Bottom";
            this.btnDraw_Bottom.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Bottom.TabIndex = 487;
            this.btnDraw_Bottom.Text = "Bottom";
            this.btnDraw_Bottom.UseVisualStyleBackColor = true;
            this.btnDraw_Bottom.Click += new System.EventHandler(this.btnDraw_Bottom_Click);
            // 
            // btnDraw_Top
            // 
            this.btnDraw_Top.Location = new System.Drawing.Point(837, 327);
            this.btnDraw_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Top.Name = "btnDraw_Top";
            this.btnDraw_Top.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Top.TabIndex = 490;
            this.btnDraw_Top.Text = "Top";
            this.btnDraw_Top.UseVisualStyleBackColor = true;
            this.btnDraw_Top.Click += new System.EventHandler(this.btnDraw_Top_Click);
            // 
            // btnDraw_Front
            // 
            this.btnDraw_Front.Location = new System.Drawing.Point(773, 291);
            this.btnDraw_Front.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Front.Name = "btnDraw_Front";
            this.btnDraw_Front.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Front.TabIndex = 489;
            this.btnDraw_Front.Text = "Front";
            this.btnDraw_Front.UseVisualStyleBackColor = true;
            this.btnDraw_Front.Click += new System.EventHandler(this.btnDraw_Front_Click);
            // 
            // txtT9
            // 
            this.txtT9.Location = new System.Drawing.Point(797, 831);
            this.txtT9.Name = "txtT9";
            this.txtT9.Size = new System.Drawing.Size(57, 25);
            this.txtT9.TabIndex = 485;
            this.txtT9.Text = "0";
            this.txtT9.TextChanged += new System.EventHandler(this.txtT9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(774, 836);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 470;
            this.label10.Text = "t9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(858, 836);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 471;
            this.label11.Text = "t10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(942, 836);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 474;
            this.label12.Text = "t11";
            // 
            // txtT10
            // 
            this.txtT10.Location = new System.Drawing.Point(881, 831);
            this.txtT10.Name = "txtT10";
            this.txtT10.Size = new System.Drawing.Size(57, 25);
            this.txtT10.TabIndex = 483;
            this.txtT10.Text = "0";
            this.txtT10.TextChanged += new System.EventHandler(this.txtT10_TextChanged);
            // 
            // txtT11
            // 
            this.txtT11.Location = new System.Drawing.Point(965, 831);
            this.txtT11.Name = "txtT11";
            this.txtT11.Size = new System.Drawing.Size(57, 25);
            this.txtT11.TabIndex = 482;
            this.txtT11.Text = "0";
            this.txtT11.TextChanged += new System.EventHandler(this.txtT11_TextChanged);
            // 
            // txtT12
            // 
            this.txtT12.Location = new System.Drawing.Point(797, 860);
            this.txtT12.Name = "txtT12";
            this.txtT12.Size = new System.Drawing.Size(57, 25);
            this.txtT12.TabIndex = 485;
            this.txtT12.Text = "0";
            this.txtT12.TextChanged += new System.EventHandler(this.txtT12_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(774, 865);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 470;
            this.label13.Text = "t12";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(858, 865);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 471;
            this.label14.Text = "t13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(942, 865);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 15);
            this.label15.TabIndex = 474;
            this.label15.Text = "t14";
            // 
            // txtT13
            // 
            this.txtT13.Location = new System.Drawing.Point(881, 860);
            this.txtT13.Name = "txtT13";
            this.txtT13.Size = new System.Drawing.Size(57, 25);
            this.txtT13.TabIndex = 483;
            this.txtT13.Text = "0";
            this.txtT13.TextChanged += new System.EventHandler(this.txtT13_TextChanged);
            // 
            // txtT14
            // 
            this.txtT14.Location = new System.Drawing.Point(965, 860);
            this.txtT14.Name = "txtT14";
            this.txtT14.Size = new System.Drawing.Size(57, 25);
            this.txtT14.TabIndex = 482;
            this.txtT14.Text = "0";
            this.txtT14.TextChanged += new System.EventHandler(this.txtT14_TextChanged);
            // 
            // chkUserControl
            // 
            this.chkUserControl.AutoSize = true;
            this.chkUserControl.Location = new System.Drawing.Point(1233, 291);
            this.chkUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkUserControl.Name = "chkUserControl";
            this.chkUserControl.Size = new System.Drawing.Size(111, 19);
            this.chkUserControl.TabIndex = 495;
            this.chkUserControl.Text = "User Control";
            this.chkUserControl.UseVisualStyleBackColor = true;
            this.chkUserControl.CheckedChanged += new System.EventHandler(this.chkUserControl_CheckedChanged);
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(1043, 291);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(53, 15);
            this.lbPos.TabIndex = 496;
            this.lbPos.Text = "label16";
            // 
            // btnThumb
            // 
            this.btnThumb.Location = new System.Drawing.Point(1297, 588);
            this.btnThumb.Name = "btnThumb";
            this.btnThumb.Size = new System.Drawing.Size(106, 30);
            this.btnThumb.TabIndex = 497;
            this.btnThumb.Text = "Thumb";
            this.btnThumb.UseVisualStyleBackColor = true;
            this.btnThumb.Click += new System.EventHandler(this.btnThumb_Click);
            // 
            // btnFirstFinger
            // 
            this.btnFirstFinger.Location = new System.Drawing.Point(1297, 624);
            this.btnFirstFinger.Name = "btnFirstFinger";
            this.btnFirstFinger.Size = new System.Drawing.Size(106, 30);
            this.btnFirstFinger.TabIndex = 497;
            this.btnFirstFinger.Text = "FirstFinger";
            this.btnFirstFinger.UseVisualStyleBackColor = true;
            this.btnFirstFinger.Click += new System.EventHandler(this.btnFirstFinger_Click);
            // 
            // btnMiddleFinger
            // 
            this.btnMiddleFinger.Location = new System.Drawing.Point(1297, 660);
            this.btnMiddleFinger.Name = "btnMiddleFinger";
            this.btnMiddleFinger.Size = new System.Drawing.Size(106, 30);
            this.btnMiddleFinger.TabIndex = 497;
            this.btnMiddleFinger.Text = "MiddleFinger";
            this.btnMiddleFinger.UseVisualStyleBackColor = true;
            this.btnMiddleFinger.Click += new System.EventHandler(this.btnMiddleFinger_Click);
            // 
            // btnLittleFinger
            // 
            this.btnLittleFinger.Location = new System.Drawing.Point(1297, 696);
            this.btnLittleFinger.Name = "btnLittleFinger";
            this.btnLittleFinger.Size = new System.Drawing.Size(106, 30);
            this.btnLittleFinger.TabIndex = 497;
            this.btnLittleFinger.Text = "LittltFinger";
            this.btnLittleFinger.UseVisualStyleBackColor = true;
            this.btnLittleFinger.Click += new System.EventHandler(this.btnLittleFinger_Click);
            // 
            // btnFist
            // 
            this.btnFist.Location = new System.Drawing.Point(1297, 732);
            this.btnFist.Name = "btnFist";
            this.btnFist.Size = new System.Drawing.Size(106, 30);
            this.btnFist.TabIndex = 497;
            this.btnFist.Text = "Fist";
            this.btnFist.UseVisualStyleBackColor = true;
            this.btnFist.Click += new System.EventHandler(this.btnFist_Click);
            // 
            // btnSpread
            // 
            this.btnSpread.Location = new System.Drawing.Point(1297, 768);
            this.btnSpread.Name = "btnSpread";
            this.btnSpread.Size = new System.Drawing.Size(106, 30);
            this.btnSpread.TabIndex = 497;
            this.btnSpread.Text = "Spread";
            this.btnSpread.UseVisualStyleBackColor = true;
            this.btnSpread.Click += new System.EventHandler(this.btnSpread_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1297, 807);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(106, 30);
            this.btnLeft.TabIndex = 497;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1297, 843);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(106, 30);
            this.btnRight.TabIndex = 497;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 1057);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnSpread);
            this.Controls.Add(this.btnFist);
            this.Controls.Add(this.btnLittleFinger);
            this.Controls.Add(this.btnMiddleFinger);
            this.Controls.Add(this.btnFirstFinger);
            this.Controls.Add(this.btnThumb);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.chkUserControl);
            this.Controls.Add(this.btnDraw_240);
            this.Controls.Add(this.btnDraw_90);
            this.Controls.Add(this.btnDraw_120);
            this.Controls.Add(this.btnDraw_90_inverse);
            this.Controls.Add(this.btnDraw_Normal);
            this.Controls.Add(this.btnDraw_Bottom);
            this.Controls.Add(this.btnDraw_Top);
            this.Controls.Add(this.btnDraw_Front);
            this.Controls.Add(this.GetPosition);
            this.Controls.Add(this.txtT14);
            this.Controls.Add(this.txtT11);
            this.Controls.Add(this.txtT8);
            this.Controls.Add(this.txtT13);
            this.Controls.Add(this.txtT10);
            this.Controls.Add(this.txtT7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtT12);
            this.Controls.Add(this.txtT9);
            this.Controls.Add(this.txtT6);
            this.Controls.Add(this.txtT5);
            this.Controls.Add(this.txtT4);
            this.Controls.Add(this.txtT3);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.btnKinematicsCompile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnProperty);
            this.Controls.Add(this.picDisp);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.chkStep2);
            this.Controls.Add(this.chkAnother);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.lbGraph);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer tmrPulse;
        private System.Windows.Forms.Label lbGraph;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.CheckBox chkAnother;
        private System.Windows.Forms.CheckBox chkStep2;
        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkDh;
        private System.Windows.Forms.Label lbTestDh;
        private System.Windows.Forms.Button btnCheckDH;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.TextBox txtKinematicsString;
        private System.Windows.Forms.TextBox txtForwardKinematics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtInverseKinematics;
        private System.Windows.Forms.Button btnChangePos;
        private System.Windows.Forms.Label label329;
        private System.Windows.Forms.TextBox txtPos_Z;
        private System.Windows.Forms.TextBox txtPos_X;
        private System.Windows.Forms.TextBox txtPos_Y;
        private System.Windows.Forms.Button GetPosition;
        private System.Windows.Forms.TextBox txtT8;
        private System.Windows.Forms.TextBox txtT7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtT6;
        private System.Windows.Forms.TextBox txtT5;
        private System.Windows.Forms.TextBox txtT4;
        private System.Windows.Forms.TextBox txtT3;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.Button btnKinematicsCompile;
        private System.Windows.Forms.Button btnDraw_240;
        private System.Windows.Forms.Button btnDraw_90;
        private System.Windows.Forms.Button btnDraw_120;
        private System.Windows.Forms.Button btnDraw_90_inverse;
        private System.Windows.Forms.Button btnDraw_Normal;
        private System.Windows.Forms.Button btnDraw_Bottom;
        private System.Windows.Forms.Button btnDraw_Top;
        private System.Windows.Forms.Button btnDraw_Front;
        private System.Windows.Forms.TextBox txtT9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtT10;
        private System.Windows.Forms.TextBox txtT11;
        private System.Windows.Forms.TextBox txtT12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtT13;
        private System.Windows.Forms.TextBox txtT14;
        private System.Windows.Forms.CheckBox chkUserControl;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Button btnThumb;
        private System.Windows.Forms.Button btnFirstFinger;
        private System.Windows.Forms.Button btnMiddleFinger;
        private System.Windows.Forms.Button btnLittleFinger;
        private System.Windows.Forms.Button btnFist;
        private System.Windows.Forms.Button btnSpread;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}

