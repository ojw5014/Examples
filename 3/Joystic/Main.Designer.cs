namespace Joystic
{
    partial class frmMain
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
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.tmrDisp = new System.Windows.Forms.Timer(this.components);
            this.lbDisp = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(12, 12);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(403, 366);
            this.picDisp.TabIndex = 1;
            this.picDisp.TabStop = false;
            // 
            // tmrDisp
            // 
            this.tmrDisp.Interval = 40;
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // lbDisp
            // 
            this.lbDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisp.Location = new System.Drawing.Point(421, 12);
            this.lbDisp.Name = "lbDisp";
            this.lbDisp.Size = new System.Drawing.Size(403, 366);
            this.lbDisp.TabIndex = 2;
            this.lbDisp.Text = "label1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 384);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(1042, 308);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.WordWrap = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 893);
            this.Controls.Add(this.lbDisp);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.picDisp);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.Label lbDisp;
        public System.Windows.Forms.TextBox txtMessage;
    }
}

