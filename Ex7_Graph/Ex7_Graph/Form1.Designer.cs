namespace Ex7_Graph
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
            this.lbDisp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTest0 = new System.Windows.Forms.Label();
            this.lbTest1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDisp
            // 
            this.lbDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisp.Location = new System.Drawing.Point(37, 46);
            this.lbDisp.Name = "lbDisp";
            this.lbDisp.Size = new System.Drawing.Size(359, 283);
            this.lbDisp.TabIndex = 6;
            this.lbDisp.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTest0
            // 
            this.lbTest0.AutoSize = true;
            this.lbTest0.Location = new System.Drawing.Point(470, 128);
            this.lbTest0.Name = "lbTest0";
            this.lbTest0.Size = new System.Drawing.Size(45, 15);
            this.lbTest0.TabIndex = 7;
            this.lbTest0.Text = "label1";
            // 
            // lbTest1
            // 
            this.lbTest1.AutoSize = true;
            this.lbTest1.Location = new System.Drawing.Point(470, 225);
            this.lbTest1.Name = "lbTest1";
            this.lbTest1.Size = new System.Drawing.Size(45, 15);
            this.lbTest1.TabIndex = 7;
            this.lbTest1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 409);
            this.Controls.Add(this.lbTest1);
            this.Controls.Add(this.lbTest0);
            this.Controls.Add(this.lbDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDisp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTest0;
        private System.Windows.Forms.Label lbTest1;
    }
}

