namespace Ex2_MessageBox
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
            this.txtMessage_Error = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckError = new System.Windows.Forms.Button();
            this.btnMessage1 = new System.Windows.Forms.Button();
            this.btnMessage2 = new System.Windows.Forms.Button();
            this.btnErrorMessage1 = new System.Windows.Forms.Button();
            this.btnErrorMessage2 = new System.Windows.Forms.Button();
            this.btnResetMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 167);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(767, 228);
            this.txtMessage.TabIndex = 119;
            this.txtMessage.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 120;
            this.label1.Text = "Message";
            // 
            // txtMessage_Error
            // 
            this.txtMessage_Error.Location = new System.Drawing.Point(15, 429);
            this.txtMessage_Error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage_Error.Multiline = true;
            this.txtMessage_Error.Name = "txtMessage_Error";
            this.txtMessage_Error.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage_Error.Size = new System.Drawing.Size(767, 228);
            this.txtMessage_Error.TabIndex = 119;
            this.txtMessage_Error.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 120;
            this.label2.Text = "Error";
            // 
            // btnCheckError
            // 
            this.btnCheckError.Location = new System.Drawing.Point(599, 12);
            this.btnCheckError.Name = "btnCheckError";
            this.btnCheckError.Size = new System.Drawing.Size(180, 63);
            this.btnCheckError.TabIndex = 121;
            this.btnCheckError.Text = "Are there any Errors?";
            this.btnCheckError.UseVisualStyleBackColor = true;
            this.btnCheckError.Click += new System.EventHandler(this.btnCheckError_Click);
            // 
            // btnMessage1
            // 
            this.btnMessage1.Location = new System.Drawing.Point(12, 12);
            this.btnMessage1.Name = "btnMessage1";
            this.btnMessage1.Size = new System.Drawing.Size(180, 63);
            this.btnMessage1.TabIndex = 122;
            this.btnMessage1.Text = "Message1";
            this.btnMessage1.UseVisualStyleBackColor = true;
            this.btnMessage1.Click += new System.EventHandler(this.btnMessage1_Click);
            // 
            // btnMessage2
            // 
            this.btnMessage2.Location = new System.Drawing.Point(12, 81);
            this.btnMessage2.Name = "btnMessage2";
            this.btnMessage2.Size = new System.Drawing.Size(180, 63);
            this.btnMessage2.TabIndex = 122;
            this.btnMessage2.Text = "Message2";
            this.btnMessage2.UseVisualStyleBackColor = true;
            this.btnMessage2.Click += new System.EventHandler(this.btnMessage2_Click);
            // 
            // btnErrorMessage1
            // 
            this.btnErrorMessage1.Location = new System.Drawing.Point(224, 12);
            this.btnErrorMessage1.Name = "btnErrorMessage1";
            this.btnErrorMessage1.Size = new System.Drawing.Size(180, 63);
            this.btnErrorMessage1.TabIndex = 122;
            this.btnErrorMessage1.Text = "Error Message1";
            this.btnErrorMessage1.UseVisualStyleBackColor = true;
            this.btnErrorMessage1.Click += new System.EventHandler(this.btnErrorMessage1_Click);
            // 
            // btnErrorMessage2
            // 
            this.btnErrorMessage2.Location = new System.Drawing.Point(224, 81);
            this.btnErrorMessage2.Name = "btnErrorMessage2";
            this.btnErrorMessage2.Size = new System.Drawing.Size(180, 63);
            this.btnErrorMessage2.TabIndex = 122;
            this.btnErrorMessage2.Text = "Error Message2";
            this.btnErrorMessage2.UseVisualStyleBackColor = true;
            this.btnErrorMessage2.Click += new System.EventHandler(this.btnErrorMessage2_Click);
            // 
            // btnResetMessage
            // 
            this.btnResetMessage.Location = new System.Drawing.Point(599, 81);
            this.btnResetMessage.Name = "btnResetMessage";
            this.btnResetMessage.Size = new System.Drawing.Size(180, 63);
            this.btnResetMessage.TabIndex = 121;
            this.btnResetMessage.Text = "Reset Message";
            this.btnResetMessage.UseVisualStyleBackColor = true;
            this.btnResetMessage.Click += new System.EventHandler(this.btnResetMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 674);
            this.Controls.Add(this.btnErrorMessage2);
            this.Controls.Add(this.btnMessage2);
            this.Controls.Add(this.btnErrorMessage1);
            this.Controls.Add(this.btnMessage1);
            this.Controls.Add(this.btnResetMessage);
            this.Controls.Add(this.btnCheckError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage_Error);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage_Error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckError;
        private System.Windows.Forms.Button btnMessage1;
        private System.Windows.Forms.Button btnMessage2;
        private System.Windows.Forms.Button btnErrorMessage1;
        private System.Windows.Forms.Button btnErrorMessage2;
        private System.Windows.Forms.Button btnResetMessage;
    }
}

