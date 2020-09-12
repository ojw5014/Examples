namespace TestMotor_Step2_Moving
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.txtComport = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnServoOff = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnServoOn = new System.Windows.Forms.Button();
            this.btnDriverOn = new System.Windows.Forms.Button();
            this.btnDriverOff = new System.Windows.Forms.Button();
            this.btnEmergencySwitch = new System.Windows.Forms.Button();
            this.cmbDir = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAxis = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.btnGreenOff = new System.Windows.Forms.Button();
            this.btnBlueOff = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRedOff = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Comport";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(242, 30);
            this.txtBaudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(88, 21);
            this.txtBaudrate.TabIndex = 13;
            this.txtBaudrate.Text = "115200";
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(69, 30);
            this.txtComport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(88, 21);
            this.txtComport.TabIndex = 12;
            this.txtComport.Text = "1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(11, 264);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(538, 124);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.WordWrap = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(407, 10);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 57);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(111, 194);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 30);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnServoOff
            // 
            this.btnServoOff.Location = new System.Drawing.Point(111, 125);
            this.btnServoOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServoOff.Name = "btnServoOff";
            this.btnServoOff.Size = new System.Drawing.Size(92, 30);
            this.btnServoOff.TabIndex = 20;
            this.btnServoOff.Text = "Servo Off";
            this.btnServoOff.UseVisualStyleBackColor = true;
            this.btnServoOff.Click += new System.EventHandler(this.btnServoOff_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 194);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 30);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnServoOn
            // 
            this.btnServoOn.Location = new System.Drawing.Point(12, 125);
            this.btnServoOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(92, 30);
            this.btnServoOn.TabIndex = 22;
            this.btnServoOn.Text = "Servo On";
            this.btnServoOn.UseVisualStyleBackColor = true;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // btnDriverOn
            // 
            this.btnDriverOn.Location = new System.Drawing.Point(12, 159);
            this.btnDriverOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDriverOn.Name = "btnDriverOn";
            this.btnDriverOn.Size = new System.Drawing.Size(92, 30);
            this.btnDriverOn.TabIndex = 22;
            this.btnDriverOn.Text = "Driver On";
            this.btnDriverOn.UseVisualStyleBackColor = true;
            this.btnDriverOn.Click += new System.EventHandler(this.btnDriverOn_Click);
            // 
            // btnDriverOff
            // 
            this.btnDriverOff.Location = new System.Drawing.Point(111, 159);
            this.btnDriverOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDriverOff.Name = "btnDriverOff";
            this.btnDriverOff.Size = new System.Drawing.Size(92, 30);
            this.btnDriverOff.TabIndex = 20;
            this.btnDriverOff.Text = "Driver Off";
            this.btnDriverOff.UseVisualStyleBackColor = true;
            this.btnDriverOff.Click += new System.EventHandler(this.btnDriverOff_Click);
            // 
            // btnEmergencySwitch
            // 
            this.btnEmergencySwitch.ForeColor = System.Drawing.Color.Red;
            this.btnEmergencySwitch.Location = new System.Drawing.Point(12, 226);
            this.btnEmergencySwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmergencySwitch.Name = "btnEmergencySwitch";
            this.btnEmergencySwitch.Size = new System.Drawing.Size(191, 30);
            this.btnEmergencySwitch.TabIndex = 19;
            this.btnEmergencySwitch.Text = "Emergency Switch";
            this.btnEmergencySwitch.UseVisualStyleBackColor = true;
            this.btnEmergencySwitch.Click += new System.EventHandler(this.btnEmergencySwitch_Click);
            // 
            // cmbDir
            // 
            this.cmbDir.FormattingEnabled = true;
            this.cmbDir.Items.AddRange(new object[] {
            "Forward",
            "Backward"});
            this.cmbDir.Location = new System.Drawing.Point(416, 105);
            this.cmbDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDir.Name = "cmbDir";
            this.cmbDir.Size = new System.Drawing.Size(106, 20);
            this.cmbDir.TabIndex = 32;
            this.cmbDir.SelectedIndexChanged += new System.EventHandler(this.cmbDir_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "DRS-0101",
            "DRS-0102",
            "DRS-0201"});
            this.cmbModel.Location = new System.Drawing.Point(416, 86);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(106, 20);
            this.cmbModel.TabIndex = 33;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Dir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "Axis";
            // 
            // txtAxis
            // 
            this.txtAxis.Location = new System.Drawing.Point(416, 128);
            this.txtAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAxis.Name = "txtAxis";
            this.txtAxis.Size = new System.Drawing.Size(69, 21);
            this.txtAxis.TabIndex = 24;
            this.txtAxis.Text = "0";
            this.txtAxis.TextChanged += new System.EventHandler(this.txtAxis_TextChanged);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(490, 151);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(60, 45);
            this.btnMove.TabIndex = 38;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "Pos";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(416, 176);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(69, 21);
            this.txtTime.TabIndex = 34;
            this.txtTime.Text = "100";
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(416, 151);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(69, 21);
            this.txtAngle.TabIndex = 35;
            this.txtAngle.Text = "0";
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // btnGreenOff
            // 
            this.btnGreenOff.Location = new System.Drawing.Point(501, 237);
            this.btnGreenOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGreenOff.Name = "btnGreenOff";
            this.btnGreenOff.Size = new System.Drawing.Size(47, 18);
            this.btnGreenOff.TabIndex = 42;
            this.btnGreenOff.Text = "Green";
            this.btnGreenOff.UseVisualStyleBackColor = true;
            this.btnGreenOff.Click += new System.EventHandler(this.btnGreenOff_Click);
            // 
            // btnBlueOff
            // 
            this.btnBlueOff.Location = new System.Drawing.Point(452, 237);
            this.btnBlueOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlueOff.Name = "btnBlueOff";
            this.btnBlueOff.Size = new System.Drawing.Size(47, 18);
            this.btnBlueOff.TabIndex = 44;
            this.btnBlueOff.Text = "Blue";
            this.btnBlueOff.UseVisualStyleBackColor = true;
            this.btnBlueOff.Click += new System.EventHandler(this.btnBlueOff_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(501, 217);
            this.btnGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(47, 18);
            this.btnGreen.TabIndex = 45;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRedOff
            // 
            this.btnRedOff.Location = new System.Drawing.Point(403, 237);
            this.btnRedOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRedOff.Name = "btnRedOff";
            this.btnRedOff.Size = new System.Drawing.Size(47, 18);
            this.btnRedOff.TabIndex = 46;
            this.btnRedOff.Text = "Red";
            this.btnRedOff.UseVisualStyleBackColor = true;
            this.btnRedOff.Click += new System.EventHandler(this.btnRedOff_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(452, 217);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(47, 18);
            this.btnBlue.TabIndex = 43;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(403, 217);
            this.btnRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(47, 18);
            this.btnRed.TabIndex = 41;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "Off";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "On";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(242, 159);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(98, 42);
            this.btnRead.TabIndex = 47;
            this.btnRead.Text = "ReadPosition";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(603, 84);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(105, 71);
            this.btnTest.TabIndex = 48;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 399);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnGreenOff);
            this.Controls.Add(this.btnBlueOff);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRedOff);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.cmbDir);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAxis);
            this.Controls.Add(this.btnEmergencySwitch);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDriverOff);
            this.Controls.Add(this.btnServoOff);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDriverOn);
            this.Controls.Add(this.btnServoOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaudrate);
            this.Controls.Add(this.txtComport);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.TextBox txtComport;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnServoOff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnServoOn;
        private System.Windows.Forms.Button btnDriverOn;
        private System.Windows.Forms.Button btnDriverOff;
        private System.Windows.Forms.Button btnEmergencySwitch;
        private System.Windows.Forms.ComboBox cmbDir;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAxis;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Button btnGreenOff;
        private System.Windows.Forms.Button btnBlueOff;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRedOff;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnTest;
    }
}

