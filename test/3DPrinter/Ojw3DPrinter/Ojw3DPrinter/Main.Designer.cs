namespace Ojw3DPrinter
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
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtZ0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtZ1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnInitPos = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbProgress = new System.Windows.Forms.Label();
            this.btnMoveLin = new System.Windows.Forms.Button();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtMulti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(41, 26);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(56, 25);
            this.txtX0.TabIndex = 0;
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(41, 57);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(56, 25);
            this.txtY0.TabIndex = 0;
            // 
            // txtZ0
            // 
            this.txtZ0.Location = new System.Drawing.Point(41, 88);
            this.txtZ0.Name = "txtZ0";
            this.txtZ0.Size = new System.Drawing.Size(56, 25);
            this.txtZ0.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(139, 26);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(56, 25);
            this.txtX1.TabIndex = 0;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(139, 57);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(56, 25);
            this.txtY1.TabIndex = 0;
            // 
            // txtZ1
            // 
            this.txtZ1.Location = new System.Drawing.Point(139, 88);
            this.txtZ1.Name = "txtZ1";
            this.txtZ1.Size = new System.Drawing.Size(56, 25);
            this.txtZ1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Z";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(226, 26);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(117, 86);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(483, 38);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 68);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(70, 227);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(80, 25);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "1";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(70, 263);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(80, 25);
            this.txtBaudRate.TabIndex = 0;
            this.txtBaudRate.Text = "115200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Baud";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(167, 227);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 61);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 299);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(744, 194);
            this.txtMessage.TabIndex = 0;
            // 
            // btnInitPos
            // 
            this.btnInitPos.Location = new System.Drawing.Point(387, 128);
            this.btnInitPos.Name = "btnInitPos";
            this.btnInitPos.Size = new System.Drawing.Size(114, 68);
            this.btnInitPos.TabIndex = 5;
            this.btnInitPos.Text = "InitPos";
            this.btnInitPos.UseVisualStyleBackColor = true;
            this.btnInitPos.Click += new System.EventHandler(this.btnInitPos_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(139, 135);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(56, 25);
            this.txtSpeed.TabIndex = 0;
            this.txtSpeed.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Speed";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(426, 228);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(144, 25);
            this.txtTest.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Test";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(594, 228);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(131, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Command";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(640, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 61);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(384, 270);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(35, 15);
            this.lbProgress.TabIndex = 1;
            this.lbProgress.Text = "Test";
            // 
            // btnMoveLin
            // 
            this.btnMoveLin.Location = new System.Drawing.Point(15, 164);
            this.btnMoveLin.Name = "btnMoveLin";
            this.btnMoveLin.Size = new System.Drawing.Size(180, 42);
            this.btnMoveLin.TabIndex = 8;
            this.btnMoveLin.Text = "MoveLin";
            this.btnMoveLin.UseVisualStyleBackColor = true;
            this.btnMoveLin.Click += new System.EventHandler(this.btnMoveLin_Click);
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(41, 135);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(56, 25);
            this.txtDelta.TabIndex = 0;
            this.txtDelta.Text = "0.2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Delta";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(640, 83);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 49);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtMulti
            // 
            this.txtMulti.Location = new System.Drawing.Point(653, 159);
            this.txtMulti.Name = "txtMulti";
            this.txtMulti.Size = new System.Drawing.Size(71, 25);
            this.txtMulti.TabIndex = 0;
            this.txtMulti.Text = "0.1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(650, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Multi(속도배율)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 505);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMoveLin);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnInitPos);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelta);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtMulti);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtZ1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtZ0);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtZ0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtZ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnInitPos;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Button btnMoveLin;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtMulti;
        private System.Windows.Forms.Label label12;
    }
}

