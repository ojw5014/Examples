namespace Ex13_Forms
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
            this.pn0 = new System.Windows.Forms.Panel();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn0
            // 
            this.pn0.Location = new System.Drawing.Point(40, 42);
            this.pn0.Name = "pn0";
            this.pn0.Size = new System.Drawing.Size(280, 244);
            this.pn0.TabIndex = 0;
            // 
            // pn1
            // 
            this.pn1.Location = new System.Drawing.Point(326, 42);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(275, 244);
            this.pn1.TabIndex = 0;
            // 
            // pn2
            // 
            this.pn2.Location = new System.Drawing.Point(40, 292);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(280, 217);
            this.pn2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 521);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn0;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
    }
}

