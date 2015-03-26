namespace Ex4_Timer
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
            this.btnWait = new System.Windows.Forms.Button();
            this.lbWait = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lbGet = new System.Windows.Forms.Label();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.btnKill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(14, 15);
            this.btnWait.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(200, 29);
            this.btnWait.TabIndex = 0;
            this.btnWait.Text = "Wait(5000 milli-second)";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.Location = new System.Drawing.Point(241, 21);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(15, 15);
            this.lbWait.TabIndex = 1;
            this.lbWait.Text = "0";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(14, 71);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(86, 29);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(128, 71);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(86, 29);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lbGet
            // 
            this.lbGet.AutoSize = true;
            this.lbGet.Location = new System.Drawing.Point(241, 78);
            this.lbGet.Name = "lbGet";
            this.lbGet.Size = new System.Drawing.Size(317, 15);
            this.lbGet.TabIndex = 1;
            this.lbGet.Text = "Set 을 누른 후 Get 을 누르기 까지의 시간체크";
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(14, 121);
            this.btnCurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(86, 29);
            this.btnCurrent.TabIndex = 2;
            this.btnCurrent.Text = "오늘은?";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Location = new System.Drawing.Point(241, 128);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(15, 15);
            this.lbCurrent.TabIndex = 1;
            this.lbCurrent.Text = "0";
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(309, 174);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(141, 53);
            this.btnKill.TabIndex = 3;
            this.btnKill.Text = "KillWait";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 328);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lbGet);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.lbWait);
            this.Controls.Add(this.btnWait);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Label lbWait;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lbGet;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Button btnKill;
    }
}

