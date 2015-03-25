namespace OjwKinematics
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
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkDh = new System.Windows.Forms.CheckBox();
            this.lbTestDh = new System.Windows.Forms.Label();
            this.btnCheckDH = new System.Windows.Forms.Button();
            this.label294 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtInverseKinematics = new System.Windows.Forms.TextBox();
            this.btnChangePos = new System.Windows.Forms.Button();
            this.label329 = new System.Windows.Forms.Label();
            this.txtPos_Z = new System.Windows.Forms.TextBox();
            this.txtPos_X = new System.Windows.Forms.TextBox();
            this.txtPos_Y = new System.Windows.Forms.TextBox();
            this.txtMessage_Error = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtKinematicsString = new System.Windows.Forms.TextBox();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.dgAngle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDisp.Location = new System.Drawing.Point(12, 13);
            this.picDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(485, 436);
            this.picDisp.TabIndex = 116;
            this.picDisp.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("굴림", 12F);
            this.tabControl1.Location = new System.Drawing.Point(503, 75);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 654);
            this.tabControl1.TabIndex = 467;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgAngle);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(626, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Forward";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkDh
            // 
            this.chkDh.AutoSize = true;
            this.chkDh.Location = new System.Drawing.Point(998, 33);
            this.chkDh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDh.Name = "chkDh";
            this.chkDh.Size = new System.Drawing.Size(139, 19);
            this.chkDh.TabIndex = 465;
            this.chkDh.Text = "Show DH Object";
            this.chkDh.UseVisualStyleBackColor = true;
            // 
            // lbTestDh
            // 
            this.lbTestDh.AutoSize = true;
            this.lbTestDh.Location = new System.Drawing.Point(569, 13);
            this.lbTestDh.Name = "lbTestDh";
            this.lbTestDh.Size = new System.Drawing.Size(66, 15);
            this.lbTestDh.TabIndex = 474;
            this.lbTestDh.Text = "[x, y, z]";
            this.lbTestDh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckDH
            // 
            this.btnCheckDH.Location = new System.Drawing.Point(797, 33);
            this.btnCheckDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckDH.Name = "btnCheckDH";
            this.btnCheckDH.Size = new System.Drawing.Size(138, 31);
            this.btnCheckDH.TabIndex = 473;
            this.btnCheckDH.Text = "Move to point";
            this.btnCheckDH.UseVisualStyleBackColor = true;
            // 
            // label294
            // 
            this.label294.AutoSize = true;
            this.label294.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label294.ForeColor = System.Drawing.Color.Red;
            this.label294.Location = new System.Drawing.Point(501, 13);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(50, 15);
            this.label294.TabIndex = 462;
            this.label294.Text = "D-H :";
            this.label294.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInverseKinematics);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(626, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inverse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInverseKinematics
            // 
            this.txtInverseKinematics.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInverseKinematics.Location = new System.Drawing.Point(7, 8);
            this.txtInverseKinematics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInverseKinematics.Multiline = true;
            this.txtInverseKinematics.Name = "txtInverseKinematics";
            this.txtInverseKinematics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInverseKinematics.Size = new System.Drawing.Size(613, 613);
            this.txtInverseKinematics.TabIndex = 462;
            this.txtInverseKinematics.WordWrap = false;
            // 
            // btnChangePos
            // 
            this.btnChangePos.Location = new System.Drawing.Point(704, 35);
            this.btnChangePos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePos.Name = "btnChangePos";
            this.btnChangePos.Size = new System.Drawing.Size(46, 29);
            this.btnChangePos.TabIndex = 460;
            this.btnChangePos.Text = "Go";
            this.btnChangePos.UseVisualStyleBackColor = true;
            // 
            // label329
            // 
            this.label329.AutoSize = true;
            this.label329.Location = new System.Drawing.Point(509, 41);
            this.label329.Name = "label329";
            this.label329.Size = new System.Drawing.Size(43, 15);
            this.label329.TabIndex = 456;
            this.label329.Text = "X,Y,Z";
            // 
            // txtPos_Z
            // 
            this.txtPos_Z.Location = new System.Drawing.Point(656, 36);
            this.txtPos_Z.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_Z.Name = "txtPos_Z";
            this.txtPos_Z.Size = new System.Drawing.Size(46, 25);
            this.txtPos_Z.TabIndex = 457;
            this.txtPos_Z.Text = "0";
            // 
            // txtPos_X
            // 
            this.txtPos_X.Location = new System.Drawing.Point(558, 36);
            this.txtPos_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_X.Name = "txtPos_X";
            this.txtPos_X.Size = new System.Drawing.Size(46, 25);
            this.txtPos_X.TabIndex = 459;
            this.txtPos_X.Text = "0";
            // 
            // txtPos_Y
            // 
            this.txtPos_Y.Location = new System.Drawing.Point(607, 36);
            this.txtPos_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPos_Y.Name = "txtPos_Y";
            this.txtPos_Y.Size = new System.Drawing.Size(46, 25);
            this.txtPos_Y.TabIndex = 458;
            this.txtPos_Y.Text = "15";
            // 
            // txtMessage_Error
            // 
            this.txtMessage_Error.Location = new System.Drawing.Point(12, 595);
            this.txtMessage_Error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage_Error.Multiline = true;
            this.txtMessage_Error.Name = "txtMessage_Error";
            this.txtMessage_Error.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage_Error.Size = new System.Drawing.Size(485, 134);
            this.txtMessage_Error.TabIndex = 466;
            this.txtMessage_Error.WordWrap = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 455);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(485, 134);
            this.txtMessage.TabIndex = 465;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtKinematicsString);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Result(DH matrix)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtKinematicsString
            // 
            this.txtKinematicsString.Location = new System.Drawing.Point(7, 8);
            this.txtKinematicsString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKinematicsString.Multiline = true;
            this.txtKinematicsString.Name = "txtKinematicsString";
            this.txtKinematicsString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKinematicsString.Size = new System.Drawing.Size(613, 613);
            this.txtKinematicsString.TabIndex = 462;
            this.txtKinematicsString.WordWrap = false;
            // 
            // tmrDraw
            // 
            this.tmrDraw.Interval = 20;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // dgAngle
            // 
            this.dgAngle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAngle.Location = new System.Drawing.Point(6, 7);
            this.dgAngle.Name = "dgAngle";
            this.dgAngle.RowHeadersWidth = 150;
            this.dgAngle.RowTemplate.Height = 27;
            this.dgAngle.Size = new System.Drawing.Size(614, 606);
            this.dgAngle.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 736);
            this.Controls.Add(this.chkDh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCheckDH);
            this.Controls.Add(this.btnChangePos);
            this.Controls.Add(this.label329);
            this.Controls.Add(this.lbTestDh);
            this.Controls.Add(this.txtPos_Z);
            this.Controls.Add(this.txtMessage_Error);
            this.Controls.Add(this.txtPos_X);
            this.Controls.Add(this.label294);
            this.Controls.Add(this.txtPos_Y);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.picDisp);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtInverseKinematics;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtKinematicsString;
        private System.Windows.Forms.CheckBox chkDh;
        private System.Windows.Forms.Label lbTestDh;
        private System.Windows.Forms.Button btnCheckDH;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.Button btnChangePos;
        private System.Windows.Forms.Label label329;
        private System.Windows.Forms.TextBox txtPos_Z;
        private System.Windows.Forms.TextBox txtPos_X;
        private System.Windows.Forms.TextBox txtPos_Y;
        private System.Windows.Forms.TextBox txtMessage_Error;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.DataGridView dgAngle;
    }
}

