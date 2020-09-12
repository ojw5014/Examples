namespace CHerkulex2_Test
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComport = new System.Windows.Forms.TextBox();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbMotorType = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnTorqOn = new System.Windows.Forms.Button();
            this.btnTorqOff = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAngle0 = new System.Windows.Forms.TextBox();
            this.txtTime0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAngle1 = new System.Windows.Forms.TextBox();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAngle2 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtID_Second = new System.Windows.Forms.TextBox();
            this.btnGo_Second = new System.Windows.Forms.Button();
            this.txtAngle_Second = new System.Windows.Forms.TextBox();
            this.txtTime_Second = new System.Windows.Forms.TextBox();
            this.cmbMotorType_Second = new System.Windows.Forms.ComboBox();
            this.txtAngle0_Second = new System.Windows.Forms.TextBox();
            this.txtAngle1_Second = new System.Windows.Forms.TextBox();
            this.txtAngle2_Second = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 262);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(720, 137);
            this.txtMessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Motor Type";
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(645, 8);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(54, 21);
            this.txtComport.TabIndex = 2;
            this.txtComport.Text = "1";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(645, 35);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(89, 21);
            this.txtBaudrate.TabIndex = 2;
            this.txtBaudrate.Text = "115200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Baudrate";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(54, 21);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "219";
            // 
            // cmbMotorType
            // 
            this.cmbMotorType.FormattingEnabled = true;
            this.cmbMotorType.Items.AddRange(new object[] {
            "DRS-0101",
            "DRS-0102",
            "DRS-0201",
            "DRS-0202",
            "DRS-0401",
            "DRS-0402",
            "DRS-0601",
            "DRS-0602"});
            this.cmbMotorType.Location = new System.Drawing.Point(82, 40);
            this.cmbMotorType.Name = "cmbMotorType";
            this.cmbMotorType.Size = new System.Drawing.Size(121, 20);
            this.cmbMotorType.TabIndex = 3;
            this.cmbMotorType.SelectedIndexChanged += new System.EventHandler(this.cmbMotorType_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(510, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 71);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(627, 61);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(111, 71);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(51, 67);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(54, 21);
            this.txtAngle.TabIndex = 2;
            this.txtAngle.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(51, 91);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(54, 21);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "1000";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(112, 65);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 47);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnTorqOn
            // 
            this.btnTorqOn.Location = new System.Drawing.Point(12, 0);
            this.btnTorqOn.Name = "btnTorqOn";
            this.btnTorqOn.Size = new System.Drawing.Size(66, 47);
            this.btnTorqOn.TabIndex = 5;
            this.btnTorqOn.Text = "Torq On";
            this.btnTorqOn.UseVisualStyleBackColor = true;
            this.btnTorqOn.Click += new System.EventHandler(this.btnTorqOn_Click);
            // 
            // btnTorqOff
            // 
            this.btnTorqOff.Location = new System.Drawing.Point(86, 0);
            this.btnTorqOff.Name = "btnTorqOff";
            this.btnTorqOff.Size = new System.Drawing.Size(66, 47);
            this.btnTorqOff.TabIndex = 5;
            this.btnTorqOff.Text = "Torq Off";
            this.btnTorqOff.UseVisualStyleBackColor = true;
            this.btnTorqOff.Click += new System.EventHandler(this.btnTorqOff_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(232, 0);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(79, 47);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(160, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 47);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(615, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(81, 45);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Angle0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Time";
            // 
            // txtAngle0
            // 
            this.txtAngle0.Location = new System.Drawing.Point(63, 22);
            this.txtAngle0.Name = "txtAngle0";
            this.txtAngle0.Size = new System.Drawing.Size(40, 21);
            this.txtAngle0.TabIndex = 2;
            this.txtAngle0.Text = "-45";
            // 
            // txtTime0
            // 
            this.txtTime0.Location = new System.Drawing.Point(63, 46);
            this.txtTime0.Name = "txtTime0";
            this.txtTime0.Size = new System.Drawing.Size(40, 21);
            this.txtTime0.TabIndex = 2;
            this.txtTime0.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Angle1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Time";
            // 
            // txtAngle1
            // 
            this.txtAngle1.Location = new System.Drawing.Point(273, 22);
            this.txtAngle1.Name = "txtAngle1";
            this.txtAngle1.Size = new System.Drawing.Size(40, 21);
            this.txtAngle1.TabIndex = 2;
            this.txtAngle1.Text = "90";
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(273, 46);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(40, 21);
            this.txtTime1.TabIndex = 2;
            this.txtTime1.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Angle2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(435, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "Time";
            // 
            // txtAngle2
            // 
            this.txtAngle2.Location = new System.Drawing.Point(470, 22);
            this.txtAngle2.Name = "txtAngle2";
            this.txtAngle2.Size = new System.Drawing.Size(40, 21);
            this.txtAngle2.TabIndex = 2;
            this.txtAngle2.Text = "45";
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(470, 46);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(40, 21);
            this.txtTime2.TabIndex = 2;
            this.txtTime2.Text = "1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtAngle0_Second);
            this.groupBox1.Controls.Add(this.txtAngle0);
            this.groupBox1.Controls.Add(this.txtAngle1_Second);
            this.groupBox1.Controls.Add(this.txtAngle1);
            this.groupBox1.Controls.Add(this.txtAngle2_Second);
            this.groupBox1.Controls.Add(this.txtAngle2);
            this.groupBox1.Controls.Add(this.txtTime0);
            this.groupBox1.Controls.Add(this.txtTime2);
            this.groupBox1.Controls.Add(this.txtTime1);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.btnGo);
            this.groupBox2.Controls.Add(this.txtAngle);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.cmbMotorType);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 120);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor(First)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtID_Second);
            this.groupBox3.Controls.Add(this.btnGo_Second);
            this.groupBox3.Controls.Add(this.txtAngle_Second);
            this.groupBox3.Controls.Add(this.txtTime_Second);
            this.groupBox3.Controls.Add(this.cmbMotorType_Second);
            this.groupBox3.Location = new System.Drawing.Point(246, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 120);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor(Second)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "Motor ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "Motor Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "Angle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "Time";
            // 
            // txtID_Second
            // 
            this.txtID_Second.Location = new System.Drawing.Point(82, 14);
            this.txtID_Second.Name = "txtID_Second";
            this.txtID_Second.Size = new System.Drawing.Size(54, 21);
            this.txtID_Second.TabIndex = 2;
            this.txtID_Second.Text = "0";
            // 
            // btnGo_Second
            // 
            this.btnGo_Second.Location = new System.Drawing.Point(112, 65);
            this.btnGo_Second.Name = "btnGo_Second";
            this.btnGo_Second.Size = new System.Drawing.Size(91, 47);
            this.btnGo_Second.TabIndex = 5;
            this.btnGo_Second.Text = "Go";
            this.btnGo_Second.UseVisualStyleBackColor = true;
            this.btnGo_Second.Click += new System.EventHandler(this.btnGo_Second_Click);
            // 
            // txtAngle_Second
            // 
            this.txtAngle_Second.Location = new System.Drawing.Point(51, 67);
            this.txtAngle_Second.Name = "txtAngle_Second";
            this.txtAngle_Second.Size = new System.Drawing.Size(54, 21);
            this.txtAngle_Second.TabIndex = 2;
            this.txtAngle_Second.Text = "0";
            // 
            // txtTime_Second
            // 
            this.txtTime_Second.Location = new System.Drawing.Point(51, 91);
            this.txtTime_Second.Name = "txtTime_Second";
            this.txtTime_Second.Size = new System.Drawing.Size(54, 21);
            this.txtTime_Second.TabIndex = 2;
            this.txtTime_Second.Text = "1000";
            // 
            // cmbMotorType_Second
            // 
            this.cmbMotorType_Second.FormattingEnabled = true;
            this.cmbMotorType_Second.Items.AddRange(new object[] {
            "DRS-0101",
            "DRS-0102",
            "DRS-0201",
            "DRS-0202",
            "DRS-0401",
            "DRS-0402",
            "DRS-0601",
            "DRS-0602"});
            this.cmbMotorType_Second.Location = new System.Drawing.Point(82, 40);
            this.cmbMotorType_Second.Name = "cmbMotorType_Second";
            this.cmbMotorType_Second.Size = new System.Drawing.Size(121, 20);
            this.cmbMotorType_Second.TabIndex = 3;
            this.cmbMotorType_Second.SelectedIndexChanged += new System.EventHandler(this.cmbMotorType_SelectedIndexChanged);
            // 
            // txtAngle0_Second
            // 
            this.txtAngle0_Second.Location = new System.Drawing.Point(109, 22);
            this.txtAngle0_Second.Name = "txtAngle0_Second";
            this.txtAngle0_Second.Size = new System.Drawing.Size(40, 21);
            this.txtAngle0_Second.TabIndex = 2;
            this.txtAngle0_Second.Text = "-45";
            // 
            // txtAngle1_Second
            // 
            this.txtAngle1_Second.Location = new System.Drawing.Point(319, 22);
            this.txtAngle1_Second.Name = "txtAngle1_Second";
            this.txtAngle1_Second.Size = new System.Drawing.Size(40, 21);
            this.txtAngle1_Second.TabIndex = 2;
            this.txtAngle1_Second.Text = "90";
            // 
            // txtAngle2_Second
            // 
            this.txtAngle2_Second.Location = new System.Drawing.Point(516, 22);
            this.txtAngle2_Second.Name = "txtAngle2_Second";
            this.txtAngle2_Second.Size = new System.Drawing.Size(40, 21);
            this.txtAngle2_Second.TabIndex = 2;
            this.txtAngle2_Second.Text = "45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTorqOff);
            this.Controls.Add(this.btnTorqOn);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtBaudrate);
            this.Controls.Add(this.txtComport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComport;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbMotorType;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnTorqOn;
        private System.Windows.Forms.Button btnTorqOff;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAngle0;
        private System.Windows.Forms.TextBox txtTime0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAngle1;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAngle2;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID_Second;
        private System.Windows.Forms.Button btnGo_Second;
        private System.Windows.Forms.TextBox txtAngle_Second;
        private System.Windows.Forms.TextBox txtTime_Second;
        private System.Windows.Forms.ComboBox cmbMotorType_Second;
        private System.Windows.Forms.TextBox txtAngle0_Second;
        private System.Windows.Forms.TextBox txtAngle1_Second;
        private System.Windows.Forms.TextBox txtAngle2_Second;
    }
}

