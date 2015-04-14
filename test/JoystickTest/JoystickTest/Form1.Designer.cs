namespace JoystickTest
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVibrate0 = new System.Windows.Forms.TextBox();
            this.txtVibrate1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 393);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(537, 108);
            this.txtMessage.TabIndex = 426;
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(12, 12);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(537, 366);
            this.picDisp.TabIndex = 428;
            this.picDisp.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 61);
            this.button1.TabIndex = 429;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVibrate0
            // 
            this.txtVibrate0.Location = new System.Drawing.Point(570, 104);
            this.txtVibrate0.Name = "txtVibrate0";
            this.txtVibrate0.Size = new System.Drawing.Size(65, 25);
            this.txtVibrate0.TabIndex = 430;
            this.txtVibrate0.Text = "1.0";
            // 
            // txtVibrate1
            // 
            this.txtVibrate1.Location = new System.Drawing.Point(641, 104);
            this.txtVibrate1.Name = "txtVibrate1";
            this.txtVibrate1.Size = new System.Drawing.Size(65, 25);
            this.txtVibrate1.TabIndex = 430;
            this.txtVibrate1.Text = "1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 513);
            this.Controls.Add(this.txtVibrate1);
            this.Controls.Add(this.txtVibrate0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picDisp);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVibrate0;
        private System.Windows.Forms.TextBox txtVibrate1;
    }
}

