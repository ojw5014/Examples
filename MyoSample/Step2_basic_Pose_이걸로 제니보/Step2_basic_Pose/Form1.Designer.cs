namespace Step2_basic_Pose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnTurnRight = new System.Windows.Forms.Button();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.btnGrapStop = new System.Windows.Forms.Button();
            this.btnGrapConti = new System.Windows.Forms.Button();
            this.chkQwm_SpeedUp = new System.Windows.Forms.CheckBox();
            this.btnQwm3_Stop = new System.Windows.Forms.Button();
            this.btnQwm3_Right = new System.Windows.Forms.Button();
            this.btnQwm3_Left = new System.Windows.Forms.Button();
            this.btnQwm3_Forward = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnPos8 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkConnect_Vision = new System.Windows.Forms.CheckBox();
            this.chkConnect_Robot = new System.Windows.Forms.CheckBox();
            this.chkConnect_Action = new System.Windows.Forms.CheckBox();
            this.chkConnect_Test = new System.Windows.Forms.CheckBox();
            this.mtxtPasswd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tmrHeartBeat = new System.Windows.Forms.Timer(this.components);
            this.btnPos7 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(7, 219);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(166, 745);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.WordWrap = false;
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTurnRight.Location = new System.Drawing.Point(111, 252);
            this.btnTurnRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(49, 44);
            this.btnTurnRight.TabIndex = 397;
            this.btnTurnRight.Text = "우";
            this.btnTurnRight.UseVisualStyleBackColor = true;
            this.btnTurnRight.Click += new System.EventHandler(this.btnTurnRight_Click);
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTurnLeft.Location = new System.Drawing.Point(7, 252);
            this.btnTurnLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(49, 44);
            this.btnTurnLeft.TabIndex = 398;
            this.btnTurnLeft.Text = "좌";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            this.btnTurnLeft.Click += new System.EventHandler(this.btnTurnLeft_Click);
            // 
            // btnGrapStop
            // 
            this.btnGrapStop.Location = new System.Drawing.Point(12, 415);
            this.btnGrapStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrapStop.Name = "btnGrapStop";
            this.btnGrapStop.Size = new System.Drawing.Size(150, 46);
            this.btnGrapStop.TabIndex = 395;
            this.btnGrapStop.Text = "촬영정지";
            this.btnGrapStop.UseVisualStyleBackColor = true;
            this.btnGrapStop.Click += new System.EventHandler(this.btnGrapStop_Click);
            // 
            // btnGrapConti
            // 
            this.btnGrapConti.Location = new System.Drawing.Point(11, 361);
            this.btnGrapConti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrapConti.Name = "btnGrapConti";
            this.btnGrapConti.Size = new System.Drawing.Size(150, 46);
            this.btnGrapConti.TabIndex = 396;
            this.btnGrapConti.Text = "촬영시작";
            this.btnGrapConti.UseVisualStyleBackColor = true;
            this.btnGrapConti.Click += new System.EventHandler(this.btnGrapConti_Click);
            // 
            // chkQwm_SpeedUp
            // 
            this.chkQwm_SpeedUp.AutoSize = true;
            this.chkQwm_SpeedUp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkQwm_SpeedUp.Location = new System.Drawing.Point(9, 228);
            this.chkQwm_SpeedUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkQwm_SpeedUp.Name = "chkQwm_SpeedUp";
            this.chkQwm_SpeedUp.Size = new System.Drawing.Size(126, 24);
            this.chkQwm_SpeedUp.TabIndex = 394;
            this.chkQwm_SpeedUp.Text = "Speed Up";
            this.chkQwm_SpeedUp.UseVisualStyleBackColor = true;
            // 
            // btnQwm3_Stop
            // 
            this.btnQwm3_Stop.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQwm3_Stop.Location = new System.Drawing.Point(59, 294);
            this.btnQwm3_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQwm3_Stop.Name = "btnQwm3_Stop";
            this.btnQwm3_Stop.Size = new System.Drawing.Size(49, 44);
            this.btnQwm3_Stop.TabIndex = 393;
            this.btnQwm3_Stop.Text = "■";
            this.btnQwm3_Stop.UseVisualStyleBackColor = true;
            this.btnQwm3_Stop.Click += new System.EventHandler(this.btnQwm3_Stop_Click);
            // 
            // btnQwm3_Right
            // 
            this.btnQwm3_Right.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQwm3_Right.Location = new System.Drawing.Point(111, 294);
            this.btnQwm3_Right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQwm3_Right.Name = "btnQwm3_Right";
            this.btnQwm3_Right.Size = new System.Drawing.Size(49, 44);
            this.btnQwm3_Right.TabIndex = 392;
            this.btnQwm3_Right.Text = "▶";
            this.btnQwm3_Right.UseVisualStyleBackColor = true;
            this.btnQwm3_Right.Click += new System.EventHandler(this.btnQwm3_Right_Click);
            // 
            // btnQwm3_Left
            // 
            this.btnQwm3_Left.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQwm3_Left.Location = new System.Drawing.Point(7, 294);
            this.btnQwm3_Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQwm3_Left.Name = "btnQwm3_Left";
            this.btnQwm3_Left.Size = new System.Drawing.Size(49, 44);
            this.btnQwm3_Left.TabIndex = 391;
            this.btnQwm3_Left.Text = "◀";
            this.btnQwm3_Left.UseVisualStyleBackColor = true;
            this.btnQwm3_Left.Click += new System.EventHandler(this.btnQwm3_Left_Click);
            // 
            // btnQwm3_Forward
            // 
            this.btnQwm3_Forward.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQwm3_Forward.Location = new System.Drawing.Point(59, 252);
            this.btnQwm3_Forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQwm3_Forward.Name = "btnQwm3_Forward";
            this.btnQwm3_Forward.Size = new System.Drawing.Size(49, 44);
            this.btnQwm3_Forward.TabIndex = 390;
            this.btnQwm3_Forward.Text = "▲";
            this.btnQwm3_Forward.UseVisualStyleBackColor = true;
            this.btnQwm3_Forward.Click += new System.EventHandler(this.btnQwm3_Forward_Click);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImage.Location = new System.Drawing.Point(179, 4);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(1280, 960);
            this.picImage.TabIndex = 389;
            this.picImage.TabStop = false;
            // 
            // btnPos8
            // 
            this.btnPos8.AutoSize = true;
            this.btnPos8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPos8.BackgroundImage")));
            this.btnPos8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPos8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPos8.ForeColor = System.Drawing.Color.Red;
            this.btnPos8.Location = new System.Drawing.Point(12, 621);
            this.btnPos8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPos8.Name = "btnPos8";
            this.btnPos8.Size = new System.Drawing.Size(150, 129);
            this.btnPos8.TabIndex = 388;
            this.btnPos8.Text = "일어서";
            this.btnPos8.UseVisualStyleBackColor = true;
            this.btnPos8.Click += new System.EventHandler(this.btnPos8_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(8, 9);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(431, 1);
            this.panel6.TabIndex = 386;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkConnect_Vision);
            this.groupBox1.Controls.Add(this.chkConnect_Robot);
            this.groupBox1.Controls.Add(this.chkConnect_Action);
            this.groupBox1.Controls.Add(this.chkConnect_Test);
            this.groupBox1.Controls.Add(this.mtxtPasswd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(1, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(172, 211);
            this.groupBox1.TabIndex = 385;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // chkConnect_Vision
            // 
            this.chkConnect_Vision.AutoSize = true;
            this.chkConnect_Vision.Checked = true;
            this.chkConnect_Vision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConnect_Vision.Location = new System.Drawing.Point(6, 149);
            this.chkConnect_Vision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConnect_Vision.Name = "chkConnect_Vision";
            this.chkConnect_Vision.Size = new System.Drawing.Size(104, 19);
            this.chkConnect_Vision.TabIndex = 187;
            this.chkConnect_Vision.Text = "Vision Task";
            this.chkConnect_Vision.UseVisualStyleBackColor = true;
            // 
            // chkConnect_Robot
            // 
            this.chkConnect_Robot.AutoSize = true;
            this.chkConnect_Robot.Checked = true;
            this.chkConnect_Robot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConnect_Robot.Location = new System.Drawing.Point(6, 132);
            this.chkConnect_Robot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConnect_Robot.Name = "chkConnect_Robot";
            this.chkConnect_Robot.Size = new System.Drawing.Size(105, 19);
            this.chkConnect_Robot.TabIndex = 187;
            this.chkConnect_Robot.Text = "Robot Task";
            this.chkConnect_Robot.UseVisualStyleBackColor = true;
            // 
            // chkConnect_Action
            // 
            this.chkConnect_Action.AutoSize = true;
            this.chkConnect_Action.Checked = true;
            this.chkConnect_Action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConnect_Action.Location = new System.Drawing.Point(6, 114);
            this.chkConnect_Action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConnect_Action.Name = "chkConnect_Action";
            this.chkConnect_Action.Size = new System.Drawing.Size(106, 19);
            this.chkConnect_Action.TabIndex = 187;
            this.chkConnect_Action.Text = "Action Task";
            this.chkConnect_Action.UseVisualStyleBackColor = true;
            // 
            // chkConnect_Test
            // 
            this.chkConnect_Test.AutoSize = true;
            this.chkConnect_Test.Enabled = false;
            this.chkConnect_Test.Location = new System.Drawing.Point(6, 96);
            this.chkConnect_Test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConnect_Test.Name = "chkConnect_Test";
            this.chkConnect_Test.Size = new System.Drawing.Size(93, 19);
            this.chkConnect_Test.TabIndex = 187;
            this.chkConnect_Test.Text = "Test Task";
            this.chkConnect_Test.UseVisualStyleBackColor = true;
            // 
            // mtxtPasswd
            // 
            this.mtxtPasswd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtxtPasswd.Location = new System.Drawing.Point(41, 66);
            this.mtxtPasswd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtPasswd.Name = "mtxtPasswd";
            this.mtxtPasswd.PasswordChar = '*';
            this.mtxtPasswd.Size = new System.Drawing.Size(63, 23);
            this.mtxtPasswd.TabIndex = 186;
            this.mtxtPasswd.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 72);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 15);
            this.label28.TabIndex = 6;
            this.label28.Text = "Pass";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 171);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(155, 32);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(41, 16);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(120, 25);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "192.168.20.51";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 15);
            this.label27.TabIndex = 6;
            this.label27.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtId.Location = new System.Drawing.Point(41, 42);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 23);
            this.txtId.TabIndex = 185;
            this.txtId.Text = "genibo";
            // 
            // tmrHeartBeat
            // 
            this.tmrHeartBeat.Interval = 5000;
            this.tmrHeartBeat.Tick += new System.EventHandler(this.tmrHeartBeat_Tick);
            // 
            // btnPos7
            // 
            this.btnPos7.AutoSize = true;
            this.btnPos7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPos7.BackgroundImage")));
            this.btnPos7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPos7.Font = new System.Drawing.Font("굴림", 24F);
            this.btnPos7.ForeColor = System.Drawing.Color.Red;
            this.btnPos7.Location = new System.Drawing.Point(12, 484);
            this.btnPos7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPos7.Name = "btnPos7";
            this.btnPos7.Size = new System.Drawing.Size(150, 129);
            this.btnPos7.TabIndex = 388;
            this.btnPos7.Text = "앉아";
            this.btnPos7.UseVisualStyleBackColor = true;
            this.btnPos7.Click += new System.EventHandler(this.btnPos7_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(30, 922);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 399;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 969);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTurnRight);
            this.Controls.Add(this.btnTurnLeft);
            this.Controls.Add(this.btnGrapStop);
            this.Controls.Add(this.btnGrapConti);
            this.Controls.Add(this.chkQwm_SpeedUp);
            this.Controls.Add(this.btnQwm3_Stop);
            this.Controls.Add(this.btnQwm3_Right);
            this.Controls.Add(this.btnQwm3_Left);
            this.Controls.Add(this.btnQwm3_Forward);
            this.Controls.Add(this.btnPos7);
            this.Controls.Add(this.btnPos8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnTurnRight;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Button btnGrapStop;
        private System.Windows.Forms.Button btnGrapConti;
        private System.Windows.Forms.CheckBox chkQwm_SpeedUp;
        private System.Windows.Forms.Button btnQwm3_Stop;
        private System.Windows.Forms.Button btnQwm3_Right;
        private System.Windows.Forms.Button btnQwm3_Left;
        private System.Windows.Forms.Button btnQwm3_Forward;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnPos8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkConnect_Vision;
        private System.Windows.Forms.CheckBox chkConnect_Robot;
        private System.Windows.Forms.CheckBox chkConnect_Action;
        private System.Windows.Forms.CheckBox chkConnect_Test;
        private System.Windows.Forms.MaskedTextBox mtxtPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Timer tmrHeartBeat;
        private System.Windows.Forms.Button btnPos7;
        private System.Windows.Forms.Button btnTest;
    }
}

