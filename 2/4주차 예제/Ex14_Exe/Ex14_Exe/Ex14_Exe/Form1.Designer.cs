namespace Ex14_Exe
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
            this.btnVirtualKeyboard = new System.Windows.Forms.Button();
            this.pnKeyboard = new System.Windows.Forms.Panel();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtWidth2 = new System.Windows.Forms.TextBox();
            this.txtHeight2 = new System.Windows.Forms.TextBox();
            this.btnMove2 = new System.Windows.Forms.Button();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 304);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(838, 98);
            this.txtMessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "화상키보드 실행";
            // 
            // btnVirtualKeyboard
            // 
            this.btnVirtualKeyboard.Location = new System.Drawing.Point(120, 4);
            this.btnVirtualKeyboard.Name = "btnVirtualKeyboard";
            this.btnVirtualKeyboard.Size = new System.Drawing.Size(75, 23);
            this.btnVirtualKeyboard.TabIndex = 2;
            this.btnVirtualKeyboard.Text = "Run";
            this.btnVirtualKeyboard.UseVisualStyleBackColor = true;
            this.btnVirtualKeyboard.Click += new System.EventHandler(this.btnVirtualKeyboard_Click);
            // 
            // pnKeyboard
            // 
            this.pnKeyboard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnKeyboard.Location = new System.Drawing.Point(12, 77);
            this.pnKeyboard.Name = "pnKeyboard";
            this.pnKeyboard.Size = new System.Drawing.Size(838, 221);
            this.pnKeyboard.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(400, 9);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 21);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(506, 9);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 21);
            this.txtY.TabIndex = 4;
            this.txtY.Text = "0";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(658, 9);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtWidth2
            // 
            this.txtWidth2.Location = new System.Drawing.Point(400, 38);
            this.txtWidth2.Name = "txtWidth2";
            this.txtWidth2.Size = new System.Drawing.Size(100, 21);
            this.txtWidth2.TabIndex = 4;
            this.txtWidth2.Text = "500";
            // 
            // txtHeight2
            // 
            this.txtHeight2.Location = new System.Drawing.Point(506, 38);
            this.txtHeight2.Name = "txtHeight2";
            this.txtHeight2.Size = new System.Drawing.Size(100, 21);
            this.txtHeight2.TabIndex = 4;
            this.txtHeight2.Text = "200";
            // 
            // btnMove2
            // 
            this.btnMove2.Location = new System.Drawing.Point(658, 38);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(75, 23);
            this.btnMove2.TabIndex = 5;
            this.btnMove2.Text = "Move";
            this.btnMove2.UseVisualStyleBackColor = true;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(189, 38);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 21);
            this.txtX2.TabIndex = 4;
            this.txtX2.Text = "0";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(295, 38);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 21);
            this.txtY2.TabIndex = 4;
            this.txtY2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 414);
            this.Controls.Add(this.btnMove2);
            this.Controls.Add(this.txtHeight2);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtWidth2);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.pnKeyboard);
            this.Controls.Add(this.btnVirtualKeyboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVirtualKeyboard;
        private System.Windows.Forms.Panel pnKeyboard;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtWidth2;
        private System.Windows.Forms.TextBox txtHeight2;
        private System.Windows.Forms.Button btnMove2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
    }
}

