namespace Ex1_InputBox
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnInputBox_Show = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnInputBox_Show2 = new System.Windows.Forms.Button();
            this.btnInputBox_Show_Pswd = new System.Windows.Forms.Button();
            this.btnInputBox_Show2_Pswd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(95, 13);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(48, 25);
            this.txtX.TabIndex = 0;
            this.txtX.Text = "100";
            // 
            // btnInputBox_Show
            // 
            this.btnInputBox_Show.Location = new System.Drawing.Point(225, 13);
            this.btnInputBox_Show.Name = "btnInputBox_Show";
            this.btnInputBox_Show.Size = new System.Drawing.Size(394, 45);
            this.btnInputBox_Show.TabIndex = 1;
            this.btnInputBox_Show.Text = "Show(X, Y, Title, Prompt Text, Value)";
            this.btnInputBox_Show.UseVisualStyleBackColor = true;
            this.btnInputBox_Show.Click += new System.EventHandler(this.btnInputBox_Show_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(95, 43);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(48, 25);
            this.txtY.TabIndex = 0;
            this.txtY.Text = "100";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(95, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(102, 25);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "title";
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(95, 103);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(102, 25);
            this.txtPrompt.TabIndex = 0;
            this.txtPrompt.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "PromptText";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(95, 133);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(102, 25);
            this.txtValue.TabIndex = 0;
            this.txtValue.Text = "value";
            // 
            // btnInputBox_Show2
            // 
            this.btnInputBox_Show2.Location = new System.Drawing.Point(225, 64);
            this.btnInputBox_Show2.Name = "btnInputBox_Show2";
            this.btnInputBox_Show2.Size = new System.Drawing.Size(394, 45);
            this.btnInputBox_Show2.TabIndex = 1;
            this.btnInputBox_Show2.Text = "Show(Title, Prompt Text, Value)";
            this.btnInputBox_Show2.UseVisualStyleBackColor = true;
            this.btnInputBox_Show2.Click += new System.EventHandler(this.btnInputBox_Show2_Click);
            // 
            // btnInputBox_Show_Pswd
            // 
            this.btnInputBox_Show_Pswd.Location = new System.Drawing.Point(225, 115);
            this.btnInputBox_Show_Pswd.Name = "btnInputBox_Show_Pswd";
            this.btnInputBox_Show_Pswd.Size = new System.Drawing.Size(394, 45);
            this.btnInputBox_Show_Pswd.TabIndex = 1;
            this.btnInputBox_Show_Pswd.Text = "Show_PasswordType(X, Y, Title, Prompt Text, Value)";
            this.btnInputBox_Show_Pswd.UseVisualStyleBackColor = true;
            this.btnInputBox_Show_Pswd.Click += new System.EventHandler(this.btnInputBox_Show_Pswd_Click);
            // 
            // btnInputBox_Show2_Pswd
            // 
            this.btnInputBox_Show2_Pswd.Location = new System.Drawing.Point(225, 166);
            this.btnInputBox_Show2_Pswd.Name = "btnInputBox_Show2_Pswd";
            this.btnInputBox_Show2_Pswd.Size = new System.Drawing.Size(394, 45);
            this.btnInputBox_Show2_Pswd.TabIndex = 1;
            this.btnInputBox_Show2_Pswd.Text = "Show_PasswordType(Title, Prompt Text, Value)";
            this.btnInputBox_Show2_Pswd.UseVisualStyleBackColor = true;
            this.btnInputBox_Show2_Pswd.Click += new System.EventHandler(this.btnInputBox_Show2_Pswd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 222);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInputBox_Show2_Pswd);
            this.Controls.Add(this.btnInputBox_Show_Pswd);
            this.Controls.Add(this.btnInputBox_Show2);
            this.Controls.Add(this.btnInputBox_Show);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnInputBox_Show;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnInputBox_Show2;
        private System.Windows.Forms.Button btnInputBox_Show_Pswd;
        private System.Windows.Forms.Button btnInputBox_Show2_Pswd;
    }
}

