namespace WindowsFormsApplication1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMotion = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtMotionNumber = new System.Windows.Forms.TextBox();
            this.btnMoveMpsu = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 21);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMotion
            // 
            this.txtMotion.Location = new System.Drawing.Point(14, 39);
            this.txtMotion.Name = "txtMotion";
            this.txtMotion.Size = new System.Drawing.Size(100, 21);
            this.txtMotion.TabIndex = 3;
            this.txtMotion.Text = "870";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(120, 39);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(117, 21);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtMotionNumber
            // 
            this.txtMotionNumber.Location = new System.Drawing.Point(59, 134);
            this.txtMotionNumber.Name = "txtMotionNumber";
            this.txtMotionNumber.Size = new System.Drawing.Size(55, 21);
            this.txtMotionNumber.TabIndex = 3;
            this.txtMotionNumber.Text = "0";
            // 
            // btnMoveMpsu
            // 
            this.btnMoveMpsu.Location = new System.Drawing.Point(120, 134);
            this.btnMoveMpsu.Name = "btnMoveMpsu";
            this.btnMoveMpsu.Size = new System.Drawing.Size(117, 21);
            this.btnMoveMpsu.TabIndex = 4;
            this.btnMoveMpsu.Text = "Move";
            this.btnMoveMpsu.UseVisualStyleBackColor = true;
            this.btnMoveMpsu.Click += new System.EventHandler(this.btnMoveMpsu_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 134);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 21);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "253";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 348);
            this.Controls.Add(this.btnMoveMpsu);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMotionNumber);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtMotion);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMotion;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtMotionNumber;
        private System.Windows.Forms.Button btnMoveMpsu;
        private System.Windows.Forms.TextBox txtId;
    }
}

