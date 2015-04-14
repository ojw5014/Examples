namespace OjwRobotMaker
{
    partial class Main
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
            this.tmrDisp = new System.Windows.Forms.Timer(this.components);
            this.pnProperty = new System.Windows.Forms.Panel();
            this.dgAngle = new System.Windows.Forms.DataGridView();
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnProperty_Selected = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrDisp
            // 
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(503, 13);
            this.pnProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(290, 619);
            this.pnProperty.TabIndex = 421;
            // 
            // dgAngle
            // 
            this.dgAngle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAngle.Location = new System.Drawing.Point(12, 456);
            this.dgAngle.Name = "dgAngle";
            this.dgAngle.RowTemplate.Height = 27;
            this.dgAngle.Size = new System.Drawing.Size(485, 176);
            this.dgAngle.TabIndex = 422;
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(12, 13);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(485, 437);
            this.picDisp.TabIndex = 423;
            this.picDisp.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 424;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // pnProperty_Selected
            // 
            this.pnProperty_Selected.Location = new System.Drawing.Point(799, 13);
            this.pnProperty_Selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty_Selected.Name = "pnProperty_Selected";
            this.pnProperty_Selected.Size = new System.Drawing.Size(290, 619);
            this.pnProperty_Selected.TabIndex = 421;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 638);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(485, 209);
            this.txtMessage.TabIndex = 425;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 859);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picDisp);
            this.Controls.Add(this.dgAngle);
            this.Controls.Add(this.pnProperty_Selected);
            this.Controls.Add(this.pnProperty);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.DataGridView dgAngle;
        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnProperty_Selected;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

