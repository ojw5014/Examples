namespace MyoSample
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
            this.lbGraph = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tmrMyo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbGraph
            // 
            this.lbGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGraph.Location = new System.Drawing.Point(12, 9);
            this.lbGraph.Name = "lbGraph";
            this.lbGraph.Size = new System.Drawing.Size(341, 304);
            this.lbGraph.TabIndex = 24;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 316);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(1115, 157);
            this.txtMessage.TabIndex = 25;
            this.txtMessage.WordWrap = false;
            // 
            // tmrMyo
            // 
            this.tmrMyo.Interval = 1000;
            this.tmrMyo.Tick += new System.EventHandler(this.tmrMyo_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 485);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lbGraph);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGraph;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer tmrMyo;
    }
}

