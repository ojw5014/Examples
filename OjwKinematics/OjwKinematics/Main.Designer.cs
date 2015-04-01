namespace OjwKinematics
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStickSize = new System.Windows.Forms.TextBox();
            this.txtBallSize = new System.Windows.Forms.TextBox();
            this.btnCompile_Kinematics = new System.Windows.Forms.Button();
            this.chkDh = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGroupDel = new System.Windows.Forms.Button();
            this.btnGroup1 = new System.Windows.Forms.Button();
            this.btnGroup2 = new System.Windows.Forms.Button();
            this.btnGroup3 = new System.Windows.Forms.Button();
            this.dgAngle = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtInverseKinematics = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtKinematicsString = new System.Windows.Forms.TextBox();
            this.lbTestDh = new System.Windows.Forms.Label();
            this.btnCheckDH = new System.Windows.Forms.Button();
            this.label294 = new System.Windows.Forms.Label();
            this.btnChangePos = new System.Windows.Forms.Button();
            this.label329 = new System.Windows.Forms.Label();
            this.txtPos_Z = new System.Windows.Forms.TextBox();
            this.txtPos_X = new System.Windows.Forms.TextBox();
            this.txtPos_Y = new System.Windows.Forms.TextBox();
            this.txtMessage_Error = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.tabAngle = new System.Windows.Forms.TabControl();
            this.tabPg0 = new System.Windows.Forms.TabPage();
            this.tabPg1 = new System.Windows.Forms.TabPage();
            this.pnProperty = new System.Windows.Forms.Panel();
            this.btnDraw_240 = new System.Windows.Forms.Button();
            this.btnDraw_90 = new System.Windows.Forms.Button();
            this.btnDraw_120 = new System.Windows.Forms.Button();
            this.btnDraw_90_inverse = new System.Windows.Forms.Button();
            this.btnDraw_Normal = new System.Windows.Forms.Button();
            this.btnDraw_Bottom = new System.Windows.Forms.Button();
            this.btnDraw_Top = new System.Windows.Forms.Button();
            this.btnDraw_Front = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label324 = new System.Windows.Forms.Label();
            this.label309 = new System.Windows.Forms.Label();
            this.cmbDh = new System.Windows.Forms.ComboBox();
            this.label340 = new System.Windows.Forms.Label();
            this.cmbKinematicsType = new System.Windows.Forms.ComboBox();
            this.cmbSecret = new System.Windows.Forms.ComboBox();
            this.label339 = new System.Windows.Forms.Label();
            this.btnFileOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabAngle.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDisp.Location = new System.Drawing.Point(12, 13);
            this.picDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(587, 552);
            this.picDisp.TabIndex = 116;
            this.picDisp.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("굴림", 10F);
            this.tabControl1.Location = new System.Drawing.Point(865, 65);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 602);
            this.tabControl1.TabIndex = 467;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtStickSize);
            this.tabPage1.Controls.Add(this.txtBallSize);
            this.tabPage1.Controls.Add(this.btnCompile_Kinematics);
            this.tabPage1.Controls.Add(this.chkDh);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dgAngle);
            this.tabPage1.Font = new System.Drawing.Font("굴림", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(626, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Forward";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 611;
            this.label2.Text = "StickSize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 611;
            this.label1.Text = "BallSize";
            // 
            // txtStickSize
            // 
            this.txtStickSize.Location = new System.Drawing.Point(336, 530);
            this.txtStickSize.Name = "txtStickSize";
            this.txtStickSize.Size = new System.Drawing.Size(89, 27);
            this.txtStickSize.TabIndex = 610;
            this.txtStickSize.Text = "10.0";
            this.txtStickSize.TextChanged += new System.EventHandler(this.txtStickSize_TextChanged);
            // 
            // txtBallSize
            // 
            this.txtBallSize.Location = new System.Drawing.Point(336, 492);
            this.txtBallSize.Name = "txtBallSize";
            this.txtBallSize.Size = new System.Drawing.Size(89, 27);
            this.txtBallSize.TabIndex = 610;
            this.txtBallSize.Text = "10.0";
            this.txtBallSize.TextChanged += new System.EventHandler(this.txtBallSize_TextChanged);
            // 
            // btnCompile_Kinematics
            // 
            this.btnCompile_Kinematics.Location = new System.Drawing.Point(6, 513);
            this.btnCompile_Kinematics.Name = "btnCompile_Kinematics";
            this.btnCompile_Kinematics.Size = new System.Drawing.Size(242, 49);
            this.btnCompile_Kinematics.TabIndex = 609;
            this.btnCompile_Kinematics.Text = "Compile(Forward Kinematics)";
            this.btnCompile_Kinematics.UseVisualStyleBackColor = true;
            this.btnCompile_Kinematics.Click += new System.EventHandler(this.btnCompile_Kinematics_Click_1);
            // 
            // chkDh
            // 
            this.chkDh.AutoSize = true;
            this.chkDh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDh.Location = new System.Drawing.Point(6, 492);
            this.chkDh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDh.Name = "chkDh";
            this.chkDh.Size = new System.Drawing.Size(147, 21);
            this.chkDh.TabIndex = 465;
            this.chkDh.Text = "Show DH Object";
            this.chkDh.UseVisualStyleBackColor = true;
            this.chkDh.CheckedChanged += new System.EventHandler(this.chkDh_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnGroupDel);
            this.panel2.Controls.Add(this.btnGroup1);
            this.panel2.Controls.Add(this.btnGroup2);
            this.panel2.Controls.Add(this.btnGroup3);
            this.panel2.Location = new System.Drawing.Point(430, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 78);
            this.panel2.TabIndex = 608;
            // 
            // btnGroupDel
            // 
            this.btnGroupDel.BackColor = System.Drawing.Color.Transparent;
            this.btnGroupDel.Location = new System.Drawing.Point(79, 4);
            this.btnGroupDel.Name = "btnGroupDel";
            this.btnGroupDel.Size = new System.Drawing.Size(108, 70);
            this.btnGroupDel.TabIndex = 450;
            this.btnGroupDel.Text = "Remove Group";
            this.btnGroupDel.UseVisualStyleBackColor = false;
            this.btnGroupDel.Click += new System.EventHandler(this.btnGroupDel_Click);
            // 
            // btnGroup1
            // 
            this.btnGroup1.BackColor = System.Drawing.Color.Turquoise;
            this.btnGroup1.Location = new System.Drawing.Point(3, 4);
            this.btnGroup1.Name = "btnGroup1";
            this.btnGroup1.Size = new System.Drawing.Size(75, 24);
            this.btnGroup1.TabIndex = 448;
            this.btnGroup1.Text = "Group1";
            this.btnGroup1.UseVisualStyleBackColor = false;
            this.btnGroup1.Click += new System.EventHandler(this.btnGroup1_Click);
            // 
            // btnGroup2
            // 
            this.btnGroup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGroup2.Location = new System.Drawing.Point(3, 27);
            this.btnGroup2.Name = "btnGroup2";
            this.btnGroup2.Size = new System.Drawing.Size(75, 24);
            this.btnGroup2.TabIndex = 452;
            this.btnGroup2.Text = "Group2";
            this.btnGroup2.UseVisualStyleBackColor = false;
            this.btnGroup2.Click += new System.EventHandler(this.btnGroup2_Click);
            // 
            // btnGroup3
            // 
            this.btnGroup3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGroup3.Location = new System.Drawing.Point(3, 50);
            this.btnGroup3.Name = "btnGroup3";
            this.btnGroup3.Size = new System.Drawing.Size(75, 24);
            this.btnGroup3.TabIndex = 451;
            this.btnGroup3.Text = "Group3";
            this.btnGroup3.UseVisualStyleBackColor = false;
            this.btnGroup3.Click += new System.EventHandler(this.btnGroup3_Click);
            // 
            // dgAngle
            // 
            this.dgAngle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAngle.Location = new System.Drawing.Point(6, 7);
            this.dgAngle.Name = "dgAngle";
            this.dgAngle.RowHeadersWidth = 150;
            this.dgAngle.RowTemplate.Height = 27;
            this.dgAngle.Size = new System.Drawing.Size(614, 471);
            this.dgAngle.TabIndex = 16;
            this.dgAngle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAngle_CellContentClick);
            this.dgAngle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAngle_CellEnter);
            this.dgAngle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAngle_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInverseKinematics);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(626, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inverse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInverseKinematics
            // 
            this.txtInverseKinematics.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInverseKinematics.Location = new System.Drawing.Point(7, 8);
            this.txtInverseKinematics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInverseKinematics.Multiline = true;
            this.txtInverseKinematics.Name = "txtInverseKinematics";
            this.txtInverseKinematics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInverseKinematics.Size = new System.Drawing.Size(613, 552);
            this.txtInverseKinematics.TabIndex = 462;
            this.txtInverseKinematics.WordWrap = false;
            this.txtInverseKinematics.TextChanged += new System.EventHandler(this.txtInverseKinematics_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtKinematicsString);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Result(DH matrix)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtKinematicsString
            // 
            this.txtKinematicsString.Location = new System.Drawing.Point(7, 8);
            this.txtKinematicsString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKinematicsString.Multiline = true;
            this.txtKinematicsString.Name = "txtKinematicsString";
            this.txtKinematicsString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKinematicsString.Size = new System.Drawing.Size(613, 605);
            this.txtKinematicsString.TabIndex = 462;
            this.txtKinematicsString.WordWrap = false;
            // 
            // lbTestDh
            // 
            this.lbTestDh.AutoSize = true;
            this.lbTestDh.Location = new System.Drawing.Point(85, 795);
            this.lbTestDh.Name = "lbTestDh";
            this.lbTestDh.Size = new System.Drawing.Size(66, 15);
            this.lbTestDh.TabIndex = 474;
            this.lbTestDh.Text = "[x, y, z]";
            this.lbTestDh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckDH
            // 
            this.btnCheckDH.Location = new System.Drawing.Point(272, 816);
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
            this.label294.Location = new System.Drawing.Point(17, 795);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(50, 15);
            this.label294.TabIndex = 462;
            this.label294.Text = "D-H :";
            this.label294.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangePos
            // 
            this.btnChangePos.Location = new System.Drawing.Point(220, 817);
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
            this.label329.Location = new System.Drawing.Point(25, 823);
            this.label329.Name = "label329";
            this.label329.Size = new System.Drawing.Size(43, 15);
            this.label329.TabIndex = 456;
            this.label329.Text = "X,Y,Z";
            // 
            // txtPos_Z
            // 
            this.txtPos_Z.Location = new System.Drawing.Point(172, 818);
            this.txtPos_Z.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_Z.Name = "txtPos_Z";
            this.txtPos_Z.Size = new System.Drawing.Size(46, 25);
            this.txtPos_Z.TabIndex = 457;
            this.txtPos_Z.Text = "0";
            // 
            // txtPos_X
            // 
            this.txtPos_X.Location = new System.Drawing.Point(74, 818);
            this.txtPos_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_X.Name = "txtPos_X";
            this.txtPos_X.Size = new System.Drawing.Size(46, 25);
            this.txtPos_X.TabIndex = 459;
            this.txtPos_X.Text = "0";
            // 
            // txtPos_Y
            // 
            this.txtPos_Y.Location = new System.Drawing.Point(123, 818);
            this.txtPos_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_Y.Name = "txtPos_Y";
            this.txtPos_Y.Size = new System.Drawing.Size(46, 25);
            this.txtPos_Y.TabIndex = 458;
            this.txtPos_Y.Text = "15";
            // 
            // txtMessage_Error
            // 
            this.txtMessage_Error.Location = new System.Drawing.Point(498, 709);
            this.txtMessage_Error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage_Error.Multiline = true;
            this.txtMessage_Error.Name = "txtMessage_Error";
            this.txtMessage_Error.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage_Error.Size = new System.Drawing.Size(361, 134);
            this.txtMessage_Error.TabIndex = 466;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(498, 571);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(361, 134);
            this.txtMessage.TabIndex = 465;
            // 
            // tmrDraw
            // 
            this.tmrDraw.Interval = 20;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // tabAngle
            // 
            this.tabAngle.Controls.Add(this.tabPg0);
            this.tabAngle.Controls.Add(this.tabPg1);
            this.tabAngle.Font = new System.Drawing.Font("굴림", 8F);
            this.tabAngle.Location = new System.Drawing.Point(865, 670);
            this.tabAngle.Name = "tabAngle";
            this.tabAngle.SelectedIndex = 0;
            this.tabAngle.Size = new System.Drawing.Size(634, 173);
            this.tabAngle.TabIndex = 475;
            // 
            // tabPg0
            // 
            this.tabPg0.Location = new System.Drawing.Point(4, 23);
            this.tabPg0.Name = "tabPg0";
            this.tabPg0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg0.Size = new System.Drawing.Size(626, 146);
            this.tabPg0.TabIndex = 0;
            this.tabPg0.Text = "tabPage4";
            this.tabPg0.UseVisualStyleBackColor = true;
            // 
            // tabPg1
            // 
            this.tabPg1.Location = new System.Drawing.Point(4, 23);
            this.tabPg1.Name = "tabPg1";
            this.tabPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg1.Size = new System.Drawing.Size(626, 146);
            this.tabPg1.TabIndex = 1;
            this.tabPg1.Text = "tabPage5";
            this.tabPg1.UseVisualStyleBackColor = true;
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(605, 13);
            this.pnProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(254, 485);
            this.pnProperty.TabIndex = 476;
            // 
            // btnDraw_240
            // 
            this.btnDraw_240.Location = new System.Drawing.Point(605, 536);
            this.btnDraw_240.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_240.Name = "btnDraw_240";
            this.btnDraw_240.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_240.TabIndex = 482;
            this.btnDraw_240.Text = "240";
            this.btnDraw_240.UseVisualStyleBackColor = true;
            // 
            // btnDraw_90
            // 
            this.btnDraw_90.Location = new System.Drawing.Point(733, 504);
            this.btnDraw_90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_90.Name = "btnDraw_90";
            this.btnDraw_90.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_90.TabIndex = 481;
            this.btnDraw_90.Text = "90";
            this.btnDraw_90.UseVisualStyleBackColor = true;
            // 
            // btnDraw_120
            // 
            this.btnDraw_120.Location = new System.Drawing.Point(797, 504);
            this.btnDraw_120.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_120.Name = "btnDraw_120";
            this.btnDraw_120.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_120.TabIndex = 484;
            this.btnDraw_120.Text = "120";
            this.btnDraw_120.UseVisualStyleBackColor = true;
            // 
            // btnDraw_90_inverse
            // 
            this.btnDraw_90_inverse.Location = new System.Drawing.Point(669, 504);
            this.btnDraw_90_inverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_90_inverse.Name = "btnDraw_90_inverse";
            this.btnDraw_90_inverse.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_90_inverse.TabIndex = 483;
            this.btnDraw_90_inverse.Text = "-90";
            this.btnDraw_90_inverse.UseVisualStyleBackColor = true;
            // 
            // btnDraw_Normal
            // 
            this.btnDraw_Normal.Location = new System.Drawing.Point(797, 536);
            this.btnDraw_Normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Normal.Name = "btnDraw_Normal";
            this.btnDraw_Normal.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Normal.TabIndex = 478;
            this.btnDraw_Normal.Text = "Normal";
            this.btnDraw_Normal.UseVisualStyleBackColor = true;
            // 
            // btnDraw_Bottom
            // 
            this.btnDraw_Bottom.Location = new System.Drawing.Point(733, 536);
            this.btnDraw_Bottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Bottom.Name = "btnDraw_Bottom";
            this.btnDraw_Bottom.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Bottom.TabIndex = 477;
            this.btnDraw_Bottom.Text = "Bottom";
            this.btnDraw_Bottom.UseVisualStyleBackColor = true;
            // 
            // btnDraw_Top
            // 
            this.btnDraw_Top.Location = new System.Drawing.Point(669, 536);
            this.btnDraw_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Top.Name = "btnDraw_Top";
            this.btnDraw_Top.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Top.TabIndex = 480;
            this.btnDraw_Top.Text = "Top";
            this.btnDraw_Top.UseVisualStyleBackColor = true;
            // 
            // btnDraw_Front
            // 
            this.btnDraw_Front.Location = new System.Drawing.Point(605, 504);
            this.btnDraw_Front.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw_Front.Name = "btnDraw_Front";
            this.btnDraw_Front.Size = new System.Drawing.Size(62, 29);
            this.btnDraw_Front.TabIndex = 479;
            this.btnDraw_Front.Text = "Front";
            this.btnDraw_Front.UseVisualStyleBackColor = true;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(1035, 10);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(214, 25);
            this.txtGroupName.TabIndex = 488;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // label324
            // 
            this.label324.AutoSize = true;
            this.label324.Location = new System.Drawing.Point(865, 13);
            this.label324.Name = "label324";
            this.label324.Size = new System.Drawing.Size(166, 15);
            this.label324.TabIndex = 487;
            this.label324.Text = "Function Name(Caption)";
            // 
            // label309
            // 
            this.label309.AutoSize = true;
            this.label309.Location = new System.Drawing.Point(929, 40);
            this.label309.Name = "label309";
            this.label309.Size = new System.Drawing.Size(324, 15);
            this.label309.TabIndex = 486;
            this.label309.Text = "DH(0~255-Manual(For mapping), 256~511:Etc)";
            // 
            // cmbDh
            // 
            this.cmbDh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDh.FormattingEnabled = true;
            this.cmbDh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199"});
            this.cmbDh.Location = new System.Drawing.Point(865, 36);
            this.cmbDh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDh.Name = "cmbDh";
            this.cmbDh.Size = new System.Drawing.Size(63, 23);
            this.cmbDh.TabIndex = 485;
            this.cmbDh.SelectedIndexChanged += new System.EventHandler(this.cmbDh_SelectedIndexChanged);
            // 
            // label340
            // 
            this.label340.AutoSize = true;
            this.label340.Location = new System.Drawing.Point(1271, 42);
            this.label340.Name = "label340";
            this.label340.Size = new System.Drawing.Size(100, 15);
            this.label340.TabIndex = 491;
            this.label340.Text = "Function Type";
            // 
            // cmbKinematicsType
            // 
            this.cmbKinematicsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKinematicsType.FormattingEnabled = true;
            this.cmbKinematicsType.Items.AddRange(new object[] {
            "0 - Normal",
            "1 - Wheel"});
            this.cmbKinematicsType.Location = new System.Drawing.Point(1372, 36);
            this.cmbKinematicsType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKinematicsType.Name = "cmbKinematicsType";
            this.cmbKinematicsType.Size = new System.Drawing.Size(127, 23);
            this.cmbKinematicsType.TabIndex = 489;
            this.cmbKinematicsType.SelectedIndexChanged += new System.EventHandler(this.cmbKinematicsType_SelectedIndexChanged);
            // 
            // cmbSecret
            // 
            this.cmbSecret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecret.FormattingEnabled = true;
            this.cmbSecret.Items.AddRange(new object[] {
            "0 - 암호화 안함",
            "1 - 암호화 실행"});
            this.cmbSecret.Location = new System.Drawing.Point(1372, 12);
            this.cmbSecret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSecret.Name = "cmbSecret";
            this.cmbSecret.Size = new System.Drawing.Size(127, 23);
            this.cmbSecret.TabIndex = 490;
            this.cmbSecret.SelectedIndexChanged += new System.EventHandler(this.cmbSecret_SelectedIndexChanged);
            // 
            // label339
            // 
            this.label339.AutoSize = true;
            this.label339.Location = new System.Drawing.Point(1270, 15);
            this.label339.Name = "label339";
            this.label339.Size = new System.Drawing.Size(76, 15);
            this.label339.TabIndex = 492;
            this.label339.Text = "Encryption";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(12, 572);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 37);
            this.btnFileOpen.TabIndex = 493;
            this.btnFileOpen.Text = "Open";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 848);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.label340);
            this.Controls.Add(this.cmbKinematicsType);
            this.Controls.Add(this.cmbSecret);
            this.Controls.Add(this.label339);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label324);
            this.Controls.Add(this.label309);
            this.Controls.Add(this.cmbDh);
            this.Controls.Add(this.btnDraw_240);
            this.Controls.Add(this.btnDraw_90);
            this.Controls.Add(this.btnDraw_120);
            this.Controls.Add(this.btnDraw_90_inverse);
            this.Controls.Add(this.btnDraw_Normal);
            this.Controls.Add(this.btnDraw_Bottom);
            this.Controls.Add(this.btnDraw_Top);
            this.Controls.Add(this.btnDraw_Front);
            this.Controls.Add(this.pnProperty);
            this.Controls.Add(this.tabAngle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCheckDH);
            this.Controls.Add(this.btnChangePos);
            this.Controls.Add(this.label329);
            this.Controls.Add(this.lbTestDh);
            this.Controls.Add(this.txtPos_Z);
            this.Controls.Add(this.txtMessage_Error);
            this.Controls.Add(this.txtPos_X);
            this.Controls.Add(this.label294);
            this.Controls.Add(this.txtPos_Y);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.picDisp);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabAngle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtInverseKinematics;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtKinematicsString;
        private System.Windows.Forms.CheckBox chkDh;
        private System.Windows.Forms.Label lbTestDh;
        private System.Windows.Forms.Button btnCheckDH;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.Button btnChangePos;
        private System.Windows.Forms.Label label329;
        private System.Windows.Forms.TextBox txtPos_Z;
        private System.Windows.Forms.TextBox txtPos_X;
        private System.Windows.Forms.TextBox txtPos_Y;
        private System.Windows.Forms.TextBox txtMessage_Error;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.DataGridView dgAngle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGroupDel;
        private System.Windows.Forms.Button btnGroup1;
        private System.Windows.Forms.Button btnGroup2;
        private System.Windows.Forms.Button btnGroup3;
        private System.Windows.Forms.Button btnCompile_Kinematics;
        private System.Windows.Forms.TabControl tabAngle;
        private System.Windows.Forms.TabPage tabPg0;
        private System.Windows.Forms.TabPage tabPg1;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.Button btnDraw_240;
        private System.Windows.Forms.Button btnDraw_90;
        private System.Windows.Forms.Button btnDraw_120;
        private System.Windows.Forms.Button btnDraw_90_inverse;
        private System.Windows.Forms.Button btnDraw_Normal;
        private System.Windows.Forms.Button btnDraw_Bottom;
        private System.Windows.Forms.Button btnDraw_Top;
        private System.Windows.Forms.Button btnDraw_Front;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBallSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStickSize;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label324;
        private System.Windows.Forms.Label label309;
        private System.Windows.Forms.ComboBox cmbDh;
        private System.Windows.Forms.Label label340;
        private System.Windows.Forms.ComboBox cmbKinematicsType;
        private System.Windows.Forms.ComboBox cmbSecret;
        private System.Windows.Forms.Label label339;
        private System.Windows.Forms.Button btnFileOpen;
    }
}

