namespace Ex5_3d_2_PropertyWindow
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnProperty = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(91, 67);
            this.picDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(353, 293);
            this.picDisp.TabIndex = 2;
            this.picDisp.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(450, 67);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(314, 293);
            this.pnProperty.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 427);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnProperty);
            this.Controls.Add(this.picDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.Button btnAdd;
    }
}

