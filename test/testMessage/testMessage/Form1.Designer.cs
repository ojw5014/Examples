namespace testMessage
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
            this.txtMessage_Error = new System.Windows.Forms.TextBox();
            this.txtTest0 = new System.Windows.Forms.TextBox();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.btnCmd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnErrorCheck = new System.Windows.Forms.Button();
            this.btnResetErrors = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(70, 191);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(316, 120);
            this.txtMessage.TabIndex = 0;
            // 
            // txtMessage_Error
            // 
            this.txtMessage_Error.Location = new System.Drawing.Point(70, 328);
            this.txtMessage_Error.Multiline = true;
            this.txtMessage_Error.Name = "txtMessage_Error";
            this.txtMessage_Error.Size = new System.Drawing.Size(316, 120);
            this.txtMessage_Error.TabIndex = 0;
            // 
            // txtTest0
            // 
            this.txtTest0.Location = new System.Drawing.Point(409, 191);
            this.txtTest0.Multiline = true;
            this.txtTest0.Name = "txtTest0";
            this.txtTest0.Size = new System.Drawing.Size(316, 120);
            this.txtTest0.TabIndex = 0;
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(409, 328);
            this.txtTest1.Multiline = true;
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(316, 120);
            this.txtTest1.TabIndex = 0;
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(107, 70);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(100, 25);
            this.txtCmd.TabIndex = 1;
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(244, 69);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(161, 35);
            this.btnCmd.TabIndex = 2;
            this.btnCmd.Text = "Command";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "txtMessage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "txtMessage_Error";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "txtTest0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "txtTest1";
            // 
            // btnErrorCheck
            // 
            this.btnErrorCheck.Location = new System.Drawing.Point(586, 30);
            this.btnErrorCheck.Name = "btnErrorCheck";
            this.btnErrorCheck.Size = new System.Drawing.Size(139, 65);
            this.btnErrorCheck.TabIndex = 4;
            this.btnErrorCheck.Text = "Error Check";
            this.btnErrorCheck.UseVisualStyleBackColor = true;
            this.btnErrorCheck.Click += new System.EventHandler(this.btnErrorCheck_Click);
            // 
            // btnResetErrors
            // 
            this.btnResetErrors.Location = new System.Drawing.Point(586, 101);
            this.btnResetErrors.Name = "btnResetErrors";
            this.btnResetErrors.Size = new System.Drawing.Size(139, 65);
            this.btnResetErrors.TabIndex = 4;
            this.btnResetErrors.Text = "Reset Error";
            this.btnResetErrors.UseVisualStyleBackColor = true;
            this.btnResetErrors.Click += new System.EventHandler(this.btnResetErrors_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(244, 122);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(161, 44);
            this.btnError.TabIndex = 5;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 460);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnResetErrors);
            this.Controls.Add(this.btnErrorCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.txtTest0);
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
        private System.Windows.Forms.TextBox txtMessage_Error;
        private System.Windows.Forms.TextBox txtTest0;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnErrorCheck;
        private System.Windows.Forms.Button btnResetErrors;
        private System.Windows.Forms.Button btnError;
    }
}

