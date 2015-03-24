namespace LaserDisplay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.txtComport = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnEmergencySwitch = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnMoveInit = new System.Windows.Forms.Button();
            this.btnLaserOn = new System.Windows.Forms.Button();
            this.btnLaserOff = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnLaserConnect = new System.Windows.Forms.Button();
            this.txtLaserPort = new System.Windows.Forms.TextBox();
            this.txtLaserBaudrate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.pic2D = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic2D)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comport";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(82, 45);
            this.txtBaudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(63, 25);
            this.txtBaudrate.TabIndex = 18;
            this.txtBaudrate.Text = "115200";
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(82, 14);
            this.txtComport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(63, 25);
            this.txtComport.TabIndex = 17;
            this.txtComport.Text = "4";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(151, 14);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 58);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnEmergencySwitch
            // 
            this.btnEmergencySwitch.ForeColor = System.Drawing.Color.Red;
            this.btnEmergencySwitch.Location = new System.Drawing.Point(17, 122);
            this.btnEmergencySwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmergencySwitch.Name = "btnEmergencySwitch";
            this.btnEmergencySwitch.Size = new System.Drawing.Size(251, 38);
            this.btnEmergencySwitch.TabIndex = 23;
            this.btnEmergencySwitch.Text = "Emergency Switch";
            this.btnEmergencySwitch.UseVisualStyleBackColor = true;
            this.btnEmergencySwitch.Click += new System.EventHandler(this.btnEmergencySwitch_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(147, 84);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 38);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(17, 84);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 38);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(17, 334);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(614, 154);
            this.txtMessage.TabIndex = 25;
            this.txtMessage.WordWrap = false;
            // 
            // btnMoveInit
            // 
            this.btnMoveInit.Location = new System.Drawing.Point(17, 161);
            this.btnMoveInit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveInit.Name = "btnMoveInit";
            this.btnMoveInit.Size = new System.Drawing.Size(251, 55);
            this.btnMoveInit.TabIndex = 26;
            this.btnMoveInit.Text = "Move Init";
            this.btnMoveInit.UseVisualStyleBackColor = true;
            this.btnMoveInit.Click += new System.EventHandler(this.btnMoveInit_Click);
            // 
            // btnLaserOn
            // 
            this.btnLaserOn.Location = new System.Drawing.Point(314, 84);
            this.btnLaserOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLaserOn.Name = "btnLaserOn";
            this.btnLaserOn.Size = new System.Drawing.Size(251, 55);
            this.btnLaserOn.TabIndex = 26;
            this.btnLaserOn.Text = "Laser On";
            this.btnLaserOn.UseVisualStyleBackColor = true;
            this.btnLaserOn.Click += new System.EventHandler(this.btnLaserOn_Click);
            // 
            // btnLaserOff
            // 
            this.btnLaserOff.Location = new System.Drawing.Point(311, 161);
            this.btnLaserOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLaserOff.Name = "btnLaserOff";
            this.btnLaserOff.Size = new System.Drawing.Size(251, 55);
            this.btnLaserOff.TabIndex = 26;
            this.btnLaserOff.Text = "Laser Off";
            this.btnLaserOff.UseVisualStyleBackColor = true;
            this.btnLaserOff.Click += new System.EventHandler(this.btnLaserOff_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(62, 224);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 25);
            this.txtX.TabIndex = 17;
            this.txtX.Text = "0";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(126, 224);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 25);
            this.txtY.TabIndex = 17;
            this.txtY.Text = "0";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(183, 224);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(86, 29);
            this.btnMove.TabIndex = 27;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnLaserConnect
            // 
            this.btnLaserConnect.Location = new System.Drawing.Point(448, 14);
            this.btnLaserConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaserConnect.Name = "btnLaserConnect";
            this.btnLaserConnect.Size = new System.Drawing.Size(118, 58);
            this.btnLaserConnect.TabIndex = 16;
            this.btnLaserConnect.Text = "Connect";
            this.btnLaserConnect.UseVisualStyleBackColor = true;
            this.btnLaserConnect.Click += new System.EventHandler(this.btnLaserConnect_Click);
            // 
            // txtLaserPort
            // 
            this.txtLaserPort.Location = new System.Drawing.Point(379, 14);
            this.txtLaserPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaserPort.Name = "txtLaserPort";
            this.txtLaserPort.Size = new System.Drawing.Size(63, 25);
            this.txtLaserPort.TabIndex = 17;
            this.txtLaserPort.Text = "7";
            // 
            // txtLaserBaudrate
            // 
            this.txtLaserBaudrate.Location = new System.Drawing.Point(379, 45);
            this.txtLaserBaudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaserBaudrate.Name = "txtLaserBaudrate";
            this.txtLaserBaudrate.Size = new System.Drawing.Size(63, 25);
            this.txtLaserBaudrate.TabIndex = 18;
            this.txtLaserBaudrate.Text = "115200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Comport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Baudrate";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(659, 109);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(91, 95);
            this.btnTest.TabIndex = 28;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pic2D
            // 
            this.pic2D.Location = new System.Drawing.Point(650, 266);
            this.pic2D.Name = "pic2D";
            this.pic2D.Size = new System.Drawing.Size(100, 100);
            this.pic2D.TabIndex = 29;
            this.pic2D.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.pic2D);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnLaserOff);
            this.Controls.Add(this.btnLaserOn);
            this.Controls.Add(this.btnMoveInit);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnEmergencySwitch);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLaserBaudrate);
            this.Controls.Add(this.txtBaudrate);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtLaserPort);
            this.Controls.Add(this.txtComport);
            this.Controls.Add(this.btnLaserConnect);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic2D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.TextBox txtComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnEmergencySwitch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnMoveInit;
        private System.Windows.Forms.Button btnLaserOn;
        private System.Windows.Forms.Button btnLaserOff;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnLaserConnect;
        private System.Windows.Forms.TextBox txtLaserPort;
        private System.Windows.Forms.TextBox txtLaserBaudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox pic2D;
    }
}

