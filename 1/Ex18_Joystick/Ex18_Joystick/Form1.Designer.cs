namespace Ex18_Joystick
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
            this.lbJoystick = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbJoystick_0 = new System.Windows.Forms.Label();
            this.lbJoystick_1 = new System.Windows.Forms.Label();
            this.lbJoystick_2 = new System.Windows.Forms.Label();
            this.lbJoystick_3 = new System.Windows.Forms.Label();
            this.lbJoystick_4 = new System.Windows.Forms.Label();
            this.lbJoystick_5 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.BackColor = System.Drawing.Color.Transparent;
            this.lbJoystick.Font = new System.Drawing.Font("Georgia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbJoystick.ForeColor = System.Drawing.Color.White;
            this.lbJoystick.Location = new System.Drawing.Point(12, 9);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(197, 18);
            this.lbJoystick.TabIndex = 436;
            this.lbJoystick.Text = "Joystick (No Connected)";
            this.lbJoystick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 29);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(517, 251);
            this.txtMessage.TabIndex = 437;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(535, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(149, 42);
            this.btnConnect.TabIndex = 438;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 439;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(628, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 21);
            this.txtId.TabIndex = 440;
            this.txtId.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 439;
            this.label2.Text = "Joystick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 439;
            this.label3.Text = "Joystick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 439;
            this.label4.Text = "Joystick";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 439;
            this.label5.Text = "Joystick";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 439;
            this.label6.Text = "Joystick";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 439;
            this.label7.Text = "Joystick";
            // 
            // lbJoystick_0
            // 
            this.lbJoystick_0.AutoSize = true;
            this.lbJoystick_0.Location = new System.Drawing.Point(617, 133);
            this.lbJoystick_0.Name = "lbJoystick_0";
            this.lbJoystick_0.Size = new System.Drawing.Size(51, 12);
            this.lbJoystick_0.TabIndex = 439;
            this.lbJoystick_0.Text = "Joystick";
            // 
            // lbJoystick_1
            // 
            this.lbJoystick_1.AutoSize = true;
            this.lbJoystick_1.Location = new System.Drawing.Point(617, 160);
            this.lbJoystick_1.Name = "lbJoystick_1";
            this.lbJoystick_1.Size = new System.Drawing.Size(51, 12);
            this.lbJoystick_1.TabIndex = 439;
            this.lbJoystick_1.Text = "Joystick";
            // 
            // lbJoystick_2
            // 
            this.lbJoystick_2.AutoSize = true;
            this.lbJoystick_2.Location = new System.Drawing.Point(617, 187);
            this.lbJoystick_2.Name = "lbJoystick_2";
            this.lbJoystick_2.Size = new System.Drawing.Size(51, 12);
            this.lbJoystick_2.TabIndex = 439;
            this.lbJoystick_2.Text = "Joystick";
            // 
            // lbJoystick_3
            // 
            this.lbJoystick_3.AutoSize = true;
            this.lbJoystick_3.Location = new System.Drawing.Point(617, 214);
            this.lbJoystick_3.Name = "lbJoystick_3";
            this.lbJoystick_3.Size = new System.Drawing.Size(51, 12);
            this.lbJoystick_3.TabIndex = 439;
            this.lbJoystick_3.Text = "Joystick";
            // 
            // lbJoystick_4
            // 
            this.lbJoystick_4.AutoSize = true;
            this.lbJoystick_4.Location = new System.Drawing.Point(617, 241);
            this.lbJoystick_4.Name = "lbJoystick_4";
            this.lbJoystick_4.Size = new System.Drawing.Size(51, 12);
            this.lbJoystick_4.TabIndex = 439;
            this.lbJoystick_4.Text = "Joystick";
            // 
            // lbJoystick_5
            // 
            this.lbJoystick_5.AutoSize = true;
            this.lbJoystick_5.Location = new System.Drawing.Point(617, 268);
            this.lbJoystick_5.Name = "lbJoystick_5";
            this.lbJoystick_5.Size = new System.Drawing.Size(51, 12);
            this.lbJoystick_5.TabIndex = 439;
            this.lbJoystick_5.Text = "Joystick";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(240, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 23);
            this.btnCheck.TabIndex = 441;
            this.btnCheck.Text = "Check Joystick";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 291);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbJoystick_5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbJoystick_4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbJoystick_3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbJoystick_2);
            this.Controls.Add(this.lbJoystick_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbJoystick_0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lbJoystick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbJoystick_0;
        private System.Windows.Forms.Label lbJoystick_1;
        private System.Windows.Forms.Label lbJoystick_2;
        private System.Windows.Forms.Label lbJoystick_3;
        private System.Windows.Forms.Label lbJoystick_4;
        private System.Windows.Forms.Label lbJoystick_5;
        private System.Windows.Forms.Button btnCheck;
    }
}

