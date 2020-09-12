namespace TestMx28_Step2_Moving
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
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMove_Speed = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMove_Time = new System.Windows.Forms.Button();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtMotorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTorqOn = new System.Windows.Forms.Button();
            this.btnTorqOff = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartMotion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPos0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPos1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPos2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPos3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMovingTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comport";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(277, 37);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(100, 25);
            this.txtBaudrate.TabIndex = 7;
            this.txtBaudrate.Text = "115200";
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(79, 37);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(100, 25);
            this.txtComport.TabIndex = 6;
            this.txtComport.Text = "1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 362);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(614, 114);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.WordWrap = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(465, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 71);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(59, 26);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(47, 25);
            this.txtAngle.TabIndex = 6;
            this.txtAngle.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(232, 23);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(51, 25);
            this.txtSpeed.TabIndex = 6;
            this.txtSpeed.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Speed";
            // 
            // btnMove_Speed
            // 
            this.btnMove_Speed.Location = new System.Drawing.Point(293, 25);
            this.btnMove_Speed.Name = "btnMove_Speed";
            this.btnMove_Speed.Size = new System.Drawing.Size(62, 23);
            this.btnMove_Speed.TabIndex = 10;
            this.btnMove_Speed.Text = "Move";
            this.btnMove_Speed.UseVisualStyleBackColor = true;
            this.btnMove_Speed.Click += new System.EventHandler(this.btnMove_Speed_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 104;
            this.lineShape1.X2 = 139;
            this.lineShape1.Y1 = 16;
            this.lineShape1.Y2 = 16;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(232, 56);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(51, 25);
            this.txtTime.TabIndex = 6;
            this.txtTime.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moving Time";
            // 
            // btnMove_Time
            // 
            this.btnMove_Time.Location = new System.Drawing.Point(293, 58);
            this.btnMove_Time.Name = "btnMove_Time";
            this.btnMove_Time.Size = new System.Drawing.Size(62, 23);
            this.btnMove_Time.TabIndex = 10;
            this.btnMove_Time.Text = "Move";
            this.btnMove_Time.UseVisualStyleBackColor = true;
            this.btnMove_Time.Click += new System.EventHandler(this.btnMove_Time_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 116;
            this.lineShape2.X2 = 138;
            this.lineShape2.Y1 = 48;
            this.lineShape2.Y2 = 48;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 116;
            this.lineShape3.X2 = 116;
            this.lineShape3.Y1 = 17;
            this.lineShape3.Y2 = 48;
            // 
            // txtMotorID
            // 
            this.txtMotorID.Location = new System.Drawing.Point(91, 84);
            this.txtMotorID.Name = "txtMotorID";
            this.txtMotorID.Size = new System.Drawing.Size(49, 25);
            this.txtMotorID.TabIndex = 6;
            this.txtMotorID.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Motor ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSpeed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnMove_Speed);
            this.groupBox1.Controls.Add(this.btnMove_Time);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtAngle);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(257, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 97);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test1";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 21);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(363, 73);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
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
            this.groupBox2.Location = new System.Drawing.Point(15, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 154);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test2";
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
            // btnTorqOn
            // 
            this.btnTorqOn.Location = new System.Drawing.Point(25, 111);
            this.btnTorqOn.Name = "btnTorqOn";
            this.btnTorqOn.Size = new System.Drawing.Size(105, 37);
            this.btnTorqOn.TabIndex = 14;
            this.btnTorqOn.Text = "Torq On";
            this.btnTorqOn.UseVisualStyleBackColor = true;
            this.btnTorqOn.Click += new System.EventHandler(this.btnTorqOn_Click);
            // 
            // btnTorqOff
            // 
            this.btnTorqOff.Location = new System.Drawing.Point(138, 111);
            this.btnTorqOff.Name = "btnTorqOff";
            this.btnTorqOff.Size = new System.Drawing.Size(105, 37);
            this.btnTorqOff.TabIndex = 14;
            this.btnTorqOff.Text = "Torq Off";
            this.btnTorqOff.UseVisualStyleBackColor = true;
            this.btnTorqOff.Click += new System.EventHandler(this.btnTorqOff_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 37);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(138, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 37);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "2\'st";
            // 
            // txtPos1
            // 
            this.txtPos1.Location = new System.Drawing.Point(210, 123);
            this.txtPos1.Name = "txtPos1";
            this.txtPos1.Size = new System.Drawing.Size(49, 25);
            this.txtPos1.TabIndex = 6;
            this.txtPos1.Text = "0";
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
            // txtPos2
            // 
            this.txtPos2.Location = new System.Drawing.Point(309, 123);
            this.txtPos2.Name = "txtPos2";
            this.txtPos2.Size = new System.Drawing.Size(49, 25);
            this.txtPos2.TabIndex = 6;
            this.txtPos2.Text = "90";
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
            // txtPos3
            // 
            this.txtPos3.Location = new System.Drawing.Point(405, 123);
            this.txtPos3.Name = "txtPos3";
            this.txtPos3.Size = new System.Drawing.Size(49, 25);
            this.txtPos3.TabIndex = 6;
            this.txtPos3.Text = "0";
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
            // txtMovingTime
            // 
            this.txtMovingTime.Location = new System.Drawing.Point(210, 67);
            this.txtMovingTime.Name = "txtMovingTime";
            this.txtMovingTime.Size = new System.Drawing.Size(49, 25);
            this.txtMovingTime.TabIndex = 6;
            this.txtMovingTime.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 488);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTorqOff);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTorqOn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMotorID);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMove_Speed;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMove_Time;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox txtMotorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTorqOn;
        private System.Windows.Forms.Button btnTorqOff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartMotion;
        private System.Windows.Forms.TextBox txtPos3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPos2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPos1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPos0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMovingTime;
        private System.Windows.Forms.Label label14;
    }
}

