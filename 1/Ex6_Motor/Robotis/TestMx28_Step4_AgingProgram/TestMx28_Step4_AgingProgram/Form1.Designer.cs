namespace TestMx28_Step4_AgingProgram
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTorqOff = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTorqOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartMotion = new System.Windows.Forms.Button();
            this.txtPos3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPos2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPos1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMovingTime = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPos0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.txtComport = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(526, 111);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 37);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTorqOff
            // 
            this.btnTorqOff.Location = new System.Drawing.Point(133, 111);
            this.btnTorqOff.Name = "btnTorqOff";
            this.btnTorqOff.Size = new System.Drawing.Size(105, 37);
            this.btnTorqOff.TabIndex = 25;
            this.btnTorqOff.Text = "Torq Off";
            this.btnTorqOff.UseVisualStyleBackColor = true;
            this.btnTorqOff.Click += new System.EventHandler(this.btnTorqOff_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(413, 111);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 37);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTorqOn
            // 
            this.btnTorqOn.Location = new System.Drawing.Point(20, 111);
            this.btnTorqOn.Name = "btnTorqOn";
            this.btnTorqOn.Size = new System.Drawing.Size(105, 37);
            this.btnTorqOn.TabIndex = 27;
            this.btnTorqOn.Text = "Torq On";
            this.btnTorqOn.UseVisualStyleBackColor = true;
            this.btnTorqOn.Click += new System.EventHandler(this.btnTorqOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartMotion);
            this.groupBox2.Controls.Add(this.txtPos3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPos2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPos1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMovingTime);
            this.groupBox2.Controls.Add(this.txtDelay);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPos0);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtLoop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(20, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 154);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aging";
            // 
            // btnStartMotion
            // 
            this.btnStartMotion.Location = new System.Drawing.Point(483, 67);
            this.btnStartMotion.Name = "btnStartMotion";
            this.btnStartMotion.Size = new System.Drawing.Size(114, 81);
            this.btnStartMotion.TabIndex = 10;
            this.btnStartMotion.Text = "Start";
            this.btnStartMotion.UseVisualStyleBackColor = true;
            this.btnStartMotion.Click += new System.EventHandler(this.btnStartMotion_Click);
            // 
            // txtPos3
            // 
            this.txtPos3.Location = new System.Drawing.Point(405, 123);
            this.txtPos3.Name = "txtPos3";
            this.txtPos3.Size = new System.Drawing.Size(49, 25);
            this.txtPos3.TabIndex = 6;
            this.txtPos3.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "4\'st";
            // 
            // txtPos2
            // 
            this.txtPos2.Location = new System.Drawing.Point(309, 123);
            this.txtPos2.Name = "txtPos2";
            this.txtPos2.Size = new System.Drawing.Size(49, 25);
            this.txtPos2.TabIndex = 6;
            this.txtPos2.Text = "90";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "3\'st";
            // 
            // txtPos1
            // 
            this.txtPos1.Location = new System.Drawing.Point(210, 123);
            this.txtPos1.Name = "txtPos1";
            this.txtPos1.Size = new System.Drawing.Size(49, 25);
            this.txtPos1.TabIndex = 6;
            this.txtPos1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "2\'st";
            // 
            // txtMovingTime
            // 
            this.txtMovingTime.Location = new System.Drawing.Point(210, 67);
            this.txtMovingTime.Name = "txtMovingTime";
            this.txtMovingTime.Size = new System.Drawing.Size(49, 25);
            this.txtMovingTime.TabIndex = 6;
            this.txtMovingTime.Text = "1000";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(405, 67);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(49, 25);
            this.txtDelay.TabIndex = 6;
            this.txtDelay.Text = "1000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Moving Time(ms)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Delay Time(ms)";
            // 
            // txtPos0
            // 
            this.txtPos0.Location = new System.Drawing.Point(113, 123);
            this.txtPos0.Name = "txtPos0";
            this.txtPos0.Size = new System.Drawing.Size(49, 25);
            this.txtPos0.TabIndex = 6;
            this.txtPos0.Text = "-90";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "1\'st";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position";
            // 
            // txtLoop
            // 
            this.txtLoop.Location = new System.Drawing.Point(98, 27);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.Size = new System.Drawing.Size(49, 25);
            this.txtLoop.TabIndex = 6;
            this.txtLoop.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loop Count";
            // 
            // txtMotorID
            // 
            this.txtMotorID.Location = new System.Drawing.Point(86, 78);
            this.txtMotorID.Name = "txtMotorID";
            this.txtMotorID.Size = new System.Drawing.Size(49, 25);
            this.txtMotorID.TabIndex = 17;
            this.txtMotorID.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Motor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Comport";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(282, 37);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(100, 25);
            this.txtBaudrate.TabIndex = 19;
            this.txtBaudrate.Text = "115200";
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(84, 37);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(100, 25);
            this.txtComport.TabIndex = 18;
            this.txtComport.Text = "1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(17, 314);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(614, 162);
            this.txtMessage.TabIndex = 16;
            this.txtMessage.WordWrap = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(470, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 71);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 495);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTorqOff);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTorqOn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMotorID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaudrate);
            this.Controls.Add(this.txtComport);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTorqOff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTorqOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartMotion;
        private System.Windows.Forms.TextBox txtPos3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPos2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPos1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMovingTime;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPos0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.TextBox txtComport;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConnect;
    }
}

