namespace testTimer
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
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnKillWait = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbWait = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(29, 26);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(287, 60);
            this.btnWait.TabIndex = 0;
            this.btnWait.Text = "wait(5000 ms)";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(29, 151);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(131, 60);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(185, 151);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(131, 60);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(29, 273);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(131, 60);
            this.btnNow.TabIndex = 0;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnKillWait
            // 
            this.btnKillWait.Location = new System.Drawing.Point(580, 26);
            this.btnKillWait.Name = "btnKillWait";
            this.btnKillWait.Size = new System.Drawing.Size(131, 60);
            this.btnKillWait.TabIndex = 0;
            this.btnKillWait.Text = "KillWait";
            this.btnKillWait.UseVisualStyleBackColor = true;
            this.btnKillWait.Click += new System.EventHandler(this.btnKillWait_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(580, 103);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 60);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(580, 191);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 60);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.Location = new System.Drawing.Point(350, 49);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(45, 15);
            this.lbWait.TabIndex = 1;
            this.lbWait.Text = "label1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(350, 174);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(179, 15);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Value(From \'Set\' to \'Get\')";
            // 
            // lbNow
            // 
            this.lbNow.AutoSize = true;
            this.lbNow.Location = new System.Drawing.Point(360, 306);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(45, 15);
            this.lbNow.TabIndex = 1;
            this.lbNow.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 503);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbNow);
            this.Controls.Add(this.lbWait);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnKillWait);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnWait);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnKillWait;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbWait;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNow;
    }
}

