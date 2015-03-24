namespace TestMx28_Step3_ReadPosition
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
            this.txtMotorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.txtComport = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMotorID
            // 
            this.txtMotorID.Location = new System.Drawing.Point(93, 84);
            this.txtMotorID.Name = "txtMotorID";
            this.txtMotorID.Size = new System.Drawing.Size(49, 25);
            this.txtMotorID.TabIndex = 16;
            this.txtMotorID.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Motor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comport";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(279, 37);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(100, 25);
            this.txtBaudrate.TabIndex = 18;
            this.txtBaudrate.Text = "115200";
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(81, 37);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(100, 25);
            this.txtComport.TabIndex = 17;
            this.txtComport.Text = "1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(467, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 71);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(14, 146);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(614, 97);
            this.txtMessage.TabIndex = 22;
            this.txtMessage.WordWrap = false;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(148, 84);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(231, 25);
            this.btnRead.TabIndex = 15;
            this.btnRead.Text = "Read Position(1\'st way)";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Location = new System.Drawing.Point(148, 115);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(231, 25);
            this.btnRead2.TabIndex = 15;
            this.btnRead2.Text = "Read Position(2\'st way)";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 255);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtMotorID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaudrate);
            this.Controls.Add(this.txtComport);
            this.Controls.Add(this.btnRead2);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.TextBox txtComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnRead2;
    }
}

