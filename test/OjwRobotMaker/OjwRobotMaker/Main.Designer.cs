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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnProperty_Selected = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnKinematics = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnMotors = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.lbPick = new System.Windows.Forms.Label();
            this.rtxtDraw = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDisp
            // 
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(6, 9);
            this.pnProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(290, 774);
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
            this.dgAngle.Visible = false;
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
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(885, 391);
            this.txtMessage.TabIndex = 425;
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(12, 653);
            this.txtDraw.Multiline = true;
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(485, 194);
            this.txtDraw.TabIndex = 425;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(516, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 817);
            this.tabControl1.TabIndex = 426;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnProperty);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pnProperty_Selected);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 788);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Draw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(598, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 774);
            this.panel1.TabIndex = 421;
            // 
            // pnProperty_Selected
            // 
            this.pnProperty_Selected.Location = new System.Drawing.Point(302, 9);
            this.pnProperty_Selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty_Selected.Name = "pnProperty_Selected";
            this.pnProperty_Selected.Size = new System.Drawing.Size(290, 774);
            this.pnProperty_Selected.TabIndex = 421;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnKinematics);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(897, 788);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kinematics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnKinematics
            // 
            this.pnKinematics.Location = new System.Drawing.Point(6, 5);
            this.pnKinematics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnKinematics.Name = "pnKinematics";
            this.pnKinematics.Size = new System.Drawing.Size(885, 778);
            this.pnKinematics.TabIndex = 422;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnMotors);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(897, 788);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Motor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnMotors
            // 
            this.pnMotors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMotors.Location = new System.Drawing.Point(6, 5);
            this.pnMotors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMotors.Name = "pnMotors";
            this.pnMotors.Size = new System.Drawing.Size(290, 615);
            this.pnMotors.TabIndex = 422;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtMessage);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(897, 788);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Message";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(897, 788);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "test";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pnStatus
            // 
            this.pnStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatus.Location = new System.Drawing.Point(12, 455);
            this.pnStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(485, 178);
            this.pnStatus.TabIndex = 422;
            // 
            // pnBackground
            // 
            this.pnBackground.Location = new System.Drawing.Point(27, 692);
            this.pnBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(596, 156);
            this.pnBackground.TabIndex = 421;
            this.pnBackground.Visible = false;
            // 
            // lbPick
            // 
            this.lbPick.AutoSize = true;
            this.lbPick.Location = new System.Drawing.Point(12, 635);
            this.lbPick.Name = "lbPick";
            this.lbPick.Size = new System.Drawing.Size(45, 15);
            this.lbPick.TabIndex = 427;
            this.lbPick.Text = "label1";
            // 
            // rtxtDraw
            // 
            this.rtxtDraw.Location = new System.Drawing.Point(12, 653);
            this.rtxtDraw.Name = "rtxtDraw";
            this.rtxtDraw.Size = new System.Drawing.Size(485, 192);
            this.rtxtDraw.TabIndex = 428;
            this.rtxtDraw.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 859);
            this.Controls.Add(this.rtxtDraw);
            this.Controls.Add(this.lbPick);
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtDraw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picDisp);
            this.Controls.Add(this.dgAngle);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.DataGridView dgAngle;
        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnKinematics;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnMotors;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Label lbPick;
        private System.Windows.Forms.Panel pnProperty_Selected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtDraw;
    }
}

