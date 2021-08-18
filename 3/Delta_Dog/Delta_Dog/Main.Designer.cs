namespace Delta_Dog
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lbDisp = new System.Windows.Forms.Label();
            this.tmrDisp = new System.Windows.Forms.Timer(this.components);
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.cmbComport = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tmrControl = new System.Windows.Forms.Timer(this.components);
            this.lbPos = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnTorqOn = new System.Windows.Forms.Button();
            this.btnTorqOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(409, 388);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(522, 102);
            this.txtMessage.TabIndex = 0;
            // 
            // lbDisp
            // 
            this.lbDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisp.Location = new System.Drawing.Point(9, 13);
            this.lbDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDisp.Name = "lbDisp";
            this.lbDisp.Size = new System.Drawing.Size(393, 477);
            this.lbDisp.TabIndex = 1;
            this.lbDisp.Text = "label1";
            this.lbDisp.Click += new System.EventHandler(this.lbDisp_Click);
            // 
            // tmrDisp
            // 
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(1159, 23);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(38, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(1200, 23);
            this.txtY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(38, 20);
            this.txtY.TabIndex = 2;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(1242, 23);
            this.txtZ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(38, 20);
            this.txtZ.TabIndex = 2;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(1284, 23);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(94, 49);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // cmbComport
            // 
            this.cmbComport.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComport.FormattingEnabled = true;
            this.cmbComport.Location = new System.Drawing.Point(412, 13);
            this.cmbComport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbComport.Name = "cmbComport";
            this.cmbComport.Size = new System.Drawing.Size(317, 47);
            this.cmbComport.TabIndex = 5;
            this.cmbComport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbComport_MouseDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(766, 13);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(165, 49);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(1200, 50);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(80, 20);
            this.txtTime.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1319, 326);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(71, 47);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Up(위)";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1319, 423);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(71, 47);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down(아래)";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1137, 375);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(56, 47);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "◀";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1249, 375);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(56, 47);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(1193, 326);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(56, 47);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = "▲";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseUp);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(1193, 423);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(56, 47);
            this.btnBackward.TabIndex = 6;
            this.btnBackward.Text = "▼";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseDown);
            this.btnBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseUp);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1099, 23);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(56, 20);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tmrControl
            // 
            this.tmrControl.Tick += new System.EventHandler(this.tmrControl_Tick);
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(1156, 474);
            this.lbPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(35, 13);
            this.lbPos.TabIndex = 8;
            this.lbPos.Text = "label1";
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(409, 80);
            this.btnReboot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(118, 58);
            this.btnReboot.TabIndex = 9;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnTorqOn
            // 
            this.btnTorqOn.Location = new System.Drawing.Point(611, 80);
            this.btnTorqOn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTorqOn.Name = "btnTorqOn";
            this.btnTorqOn.Size = new System.Drawing.Size(118, 58);
            this.btnTorqOn.TabIndex = 9;
            this.btnTorqOn.Text = "Torq On";
            this.btnTorqOn.UseVisualStyleBackColor = true;
            this.btnTorqOn.Click += new System.EventHandler(this.btnTorqOn_Click);
            // 
            // btnTorqOff
            // 
            this.btnTorqOff.Location = new System.Drawing.Point(813, 80);
            this.btnTorqOff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTorqOff.Name = "btnTorqOff";
            this.btnTorqOff.Size = new System.Drawing.Size(118, 58);
            this.btnTorqOff.TabIndex = 9;
            this.btnTorqOff.Text = "Torq Off";
            this.btnTorqOff.UseVisualStyleBackColor = true;
            this.btnTorqOff.Click += new System.EventHandler(this.btnTorqOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(406, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "로봇의 센서위로 손을 올려 보세요";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTorqOff);
            this.Controls.Add(this.btnTorqOn);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.cmbComport);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lbDisp);
            this.Controls.Add(this.txtMessage);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lbDisp;
        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ComboBox cmbComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer tmrControl;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnTorqOn;
        private System.Windows.Forms.Button btnTorqOff;
        private System.Windows.Forms.Label label1;
    }
}

