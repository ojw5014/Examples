namespace Test0
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
            this.txtData0 = new System.Windows.Forms.TextBox();
            this.btnDataSet0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbData0 = new System.Windows.Forms.Label();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.btnDataSet1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbData1 = new System.Windows.Forms.Label();
            this.tmrTest = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtData0
            // 
            this.txtData0.Location = new System.Drawing.Point(125, 99);
            this.txtData0.Name = "txtData0";
            this.txtData0.Size = new System.Drawing.Size(100, 21);
            this.txtData0.TabIndex = 0;
            this.txtData0.Text = "0";
            // 
            // btnDataSet0
            // 
            this.btnDataSet0.Location = new System.Drawing.Point(242, 99);
            this.btnDataSet0.Name = "btnDataSet0";
            this.btnDataSet0.Size = new System.Drawing.Size(75, 23);
            this.btnDataSet0.TabIndex = 1;
            this.btnDataSet0.Text = "Set";
            this.btnDataSet0.UseVisualStyleBackColor = true;
            this.btnDataSet0.Click += new System.EventHandler(this.btnDataSet0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Var";
            // 
            // lbData0
            // 
            this.lbData0.AutoSize = true;
            this.lbData0.Location = new System.Drawing.Point(48, 185);
            this.lbData0.Name = "lbData0";
            this.lbData0.Size = new System.Drawing.Size(24, 12);
            this.lbData0.TabIndex = 2;
            this.lbData0.Text = "Var";
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(125, 128);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(100, 21);
            this.txtData1.TabIndex = 0;
            this.txtData1.Text = "0";
            // 
            // btnDataSet1
            // 
            this.btnDataSet1.Location = new System.Drawing.Point(242, 128);
            this.btnDataSet1.Name = "btnDataSet1";
            this.btnDataSet1.Size = new System.Drawing.Size(75, 23);
            this.btnDataSet1.TabIndex = 1;
            this.btnDataSet1.Text = "Set";
            this.btnDataSet1.UseVisualStyleBackColor = true;
            this.btnDataSet1.Click += new System.EventHandler(this.btnDataSet1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Var";
            // 
            // lbData1
            // 
            this.lbData1.AutoSize = true;
            this.lbData1.Location = new System.Drawing.Point(48, 207);
            this.lbData1.Name = "lbData1";
            this.lbData1.Size = new System.Drawing.Size(24, 12);
            this.lbData1.TabIndex = 2;
            this.lbData1.Text = "Var";
            // 
            // tmrTest
            // 
            this.tmrTest.Tick += new System.EventHandler(this.tmrTest_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.lbData1);
            this.Controls.Add(this.lbData0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDataSet1);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.btnDataSet0);
            this.Controls.Add(this.txtData0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData0;
        private System.Windows.Forms.Button btnDataSet0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbData0;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.Button btnDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbData1;
        private System.Windows.Forms.Timer tmrTest;
    }
}

