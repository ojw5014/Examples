namespace test3d_Simple
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
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.pnProperty = new System.Windows.Forms.Panel();
            this.dgAngle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(12, 12);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(457, 404);
            this.picDisp.TabIndex = 0;
            this.picDisp.TabStop = false;
            // 
            // tmrDraw
            // 
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(477, 12);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(289, 403);
            this.pnProperty.TabIndex = 1;
            // 
            // dgAngle
            // 
            this.dgAngle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAngle.Location = new System.Drawing.Point(12, 422);
            this.dgAngle.Name = "dgAngle";
            this.dgAngle.RowTemplate.Height = 27;
            this.dgAngle.Size = new System.Drawing.Size(1083, 278);
            this.dgAngle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 712);
            this.Controls.Add(this.dgAngle);
            this.Controls.Add(this.pnProperty);
            this.Controls.Add(this.picDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.DataGridView dgAngle;
    }
}

