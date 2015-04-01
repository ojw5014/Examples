namespace Simple_3D_Robot
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
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.pnProperty = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAngle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValueIncrement = new System.Windows.Forms.Button();
            this.btnValueDecrement = new System.Windows.Forms.Button();
            this.btnValueStackIncrement = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChangeValue = new System.Windows.Forms.TextBox();
            this.btnValueStackDecrement = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnValueMul = new System.Windows.Forms.Button();
            this.btnValueDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnValueFlip = new System.Windows.Forms.Button();
            this.btnValueChange = new System.Windows.Forms.Button();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.btnInterpolation2 = new System.Windows.Forms.Button();
            this.btnGroupDel = new System.Windows.Forms.Button();
            this.btnGroup1 = new System.Windows.Forms.Button();
            this.btnGroup2 = new System.Windows.Forms.Button();
            this.btnGroup3 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDisp
            // 
            this.picDisp.Location = new System.Drawing.Point(12, 11);
            this.picDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(403, 366);
            this.picDisp.TabIndex = 5;
            this.picDisp.TabStop = false;
            // 
            // tmrDraw
            // 
            this.tmrDraw.Interval = 50;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // pnProperty
            // 
            this.pnProperty.Location = new System.Drawing.Point(421, 11);
            this.pnProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProperty.Name = "pnProperty";
            this.pnProperty.Size = new System.Drawing.Size(254, 366);
            this.pnProperty.TabIndex = 477;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(1063, 28);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(438, 149);
            this.txtMessage.TabIndex = 478;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(681, 28);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTest.Size = new System.Drawing.Size(376, 349);
            this.txtTest.TabIndex = 478;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 479;
            this.label1.Text = "< Information with clicking part >";
            // 
            // dgAngle
            // 
            this.dgAngle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAngle.Location = new System.Drawing.Point(12, 383);
            this.dgAngle.Name = "dgAngle";
            this.dgAngle.RowHeadersWidth = 150;
            this.dgAngle.RowTemplate.Height = 27;
            this.dgAngle.Size = new System.Drawing.Size(1489, 434);
            this.dgAngle.TabIndex = 480;
            this.dgAngle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAngle_CellContentClick);
            this.dgAngle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAngle_CellEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.btnValueIncrement);
            this.panel2.Controls.Add(this.btnValueDecrement);
            this.panel2.Controls.Add(this.btnValueStackIncrement);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtChangeValue);
            this.panel2.Controls.Add(this.btnValueStackDecrement);
            this.panel2.Controls.Add(this.btnFlip);
            this.panel2.Controls.Add(this.btnValueMul);
            this.panel2.Controls.Add(this.btnValueDiv);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnValueFlip);
            this.panel2.Controls.Add(this.btnValueChange);
            this.panel2.Controls.Add(this.btnInterpolation);
            this.panel2.Controls.Add(this.btnInterpolation2);
            this.panel2.Controls.Add(this.btnGroupDel);
            this.panel2.Controls.Add(this.btnGroup1);
            this.panel2.Controls.Add(this.btnGroup2);
            this.panel2.Controls.Add(this.btnGroup3);
            this.panel2.Location = new System.Drawing.Point(1063, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 132);
            this.panel2.TabIndex = 608;
            // 
            // btnValueIncrement
            // 
            this.btnValueIncrement.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueIncrement.Location = new System.Drawing.Point(2, 28);
            this.btnValueIncrement.Name = "btnValueIncrement";
            this.btnValueIncrement.Size = new System.Drawing.Size(38, 26);
            this.btnValueIncrement.TabIndex = 423;
            this.btnValueIncrement.Text = "+";
            this.btnValueIncrement.UseVisualStyleBackColor = true;
            this.btnValueIncrement.Click += new System.EventHandler(this.btnValueIncrement_Click);
            // 
            // btnValueDecrement
            // 
            this.btnValueDecrement.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueDecrement.Location = new System.Drawing.Point(39, 28);
            this.btnValueDecrement.Name = "btnValueDecrement";
            this.btnValueDecrement.Size = new System.Drawing.Size(38, 26);
            this.btnValueDecrement.TabIndex = 424;
            this.btnValueDecrement.Text = "-";
            this.btnValueDecrement.UseVisualStyleBackColor = true;
            this.btnValueDecrement.Click += new System.EventHandler(this.btnValueDecrement_Click);
            // 
            // btnValueStackIncrement
            // 
            this.btnValueStackIncrement.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueStackIncrement.Location = new System.Drawing.Point(2, 54);
            this.btnValueStackIncrement.Name = "btnValueStackIncrement";
            this.btnValueStackIncrement.Size = new System.Drawing.Size(75, 26);
            this.btnValueStackIncrement.TabIndex = 427;
            this.btnValueStackIncrement.Text = "Inc";
            this.btnValueStackIncrement.UseVisualStyleBackColor = true;
            this.btnValueStackIncrement.Click += new System.EventHandler(this.btnValueStackIncrement_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(18, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 421;
            this.label11.Text = "Value";
            // 
            // txtChangeValue
            // 
            this.txtChangeValue.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtChangeValue.Location = new System.Drawing.Point(77, 4);
            this.txtChangeValue.Name = "txtChangeValue";
            this.txtChangeValue.Size = new System.Drawing.Size(75, 23);
            this.txtChangeValue.TabIndex = 420;
            this.txtChangeValue.Text = "0";
            // 
            // btnValueStackDecrement
            // 
            this.btnValueStackDecrement.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueStackDecrement.Location = new System.Drawing.Point(77, 54);
            this.btnValueStackDecrement.Name = "btnValueStackDecrement";
            this.btnValueStackDecrement.Size = new System.Drawing.Size(75, 26);
            this.btnValueStackDecrement.TabIndex = 428;
            this.btnValueStackDecrement.Text = "Dec";
            this.btnValueStackDecrement.UseVisualStyleBackColor = true;
            this.btnValueStackDecrement.Click += new System.EventHandler(this.btnValueStackDecrement_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFlip.Location = new System.Drawing.Point(167, 4);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 26);
            this.btnFlip.TabIndex = 431;
            this.btnFlip.Text = "Switch";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnValueMul
            // 
            this.btnValueMul.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueMul.Location = new System.Drawing.Point(77, 28);
            this.btnValueMul.Name = "btnValueMul";
            this.btnValueMul.Size = new System.Drawing.Size(38, 26);
            this.btnValueMul.TabIndex = 432;
            this.btnValueMul.Text = "*";
            this.btnValueMul.UseVisualStyleBackColor = true;
            this.btnValueMul.Click += new System.EventHandler(this.btnValueMul_Click);
            // 
            // btnValueDiv
            // 
            this.btnValueDiv.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueDiv.Location = new System.Drawing.Point(114, 28);
            this.btnValueDiv.Name = "btnValueDiv";
            this.btnValueDiv.Size = new System.Drawing.Size(38, 26);
            this.btnValueDiv.TabIndex = 433;
            this.btnValueDiv.Text = "/";
            this.btnValueDiv.UseVisualStyleBackColor = true;
            this.btnValueDiv.Click += new System.EventHandler(this.btnValueDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 26);
            this.btnClear.TabIndex = 419;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnValueFlip
            // 
            this.btnValueFlip.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueFlip.Location = new System.Drawing.Point(77, 79);
            this.btnValueFlip.Name = "btnValueFlip";
            this.btnValueFlip.Size = new System.Drawing.Size(75, 26);
            this.btnValueFlip.TabIndex = 426;
            this.btnValueFlip.Text = "Flip";
            this.btnValueFlip.UseVisualStyleBackColor = true;
            this.btnValueFlip.Click += new System.EventHandler(this.btnValueFlip_Click);
            // 
            // btnValueChange
            // 
            this.btnValueChange.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValueChange.Location = new System.Drawing.Point(2, 79);
            this.btnValueChange.Name = "btnValueChange";
            this.btnValueChange.Size = new System.Drawing.Size(75, 26);
            this.btnValueChange.TabIndex = 422;
            this.btnValueChange.Text = "Change";
            this.btnValueChange.UseVisualStyleBackColor = true;
            this.btnValueChange.Click += new System.EventHandler(this.btnValueChange_Click);
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInterpolation.Location = new System.Drawing.Point(2, 104);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(75, 26);
            this.btnInterpolation.TabIndex = 429;
            this.btnInterpolation.Text = "Curve";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // btnInterpolation2
            // 
            this.btnInterpolation2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInterpolation2.Location = new System.Drawing.Point(77, 104);
            this.btnInterpolation2.Name = "btnInterpolation2";
            this.btnInterpolation2.Size = new System.Drawing.Size(75, 26);
            this.btnInterpolation2.TabIndex = 430;
            this.btnInterpolation2.Text = "S Curve";
            this.btnInterpolation2.UseVisualStyleBackColor = true;
            this.btnInterpolation2.Click += new System.EventHandler(this.btnInterpolation2_Click);
            // 
            // btnGroupDel
            // 
            this.btnGroupDel.BackColor = System.Drawing.Color.Transparent;
            this.btnGroupDel.Location = new System.Drawing.Point(241, 53);
            this.btnGroupDel.Name = "btnGroupDel";
            this.btnGroupDel.Size = new System.Drawing.Size(75, 76);
            this.btnGroupDel.TabIndex = 450;
            this.btnGroupDel.Text = "Remove Group";
            this.btnGroupDel.UseVisualStyleBackColor = false;
            this.btnGroupDel.Click += new System.EventHandler(this.btnGroupDel_Click);
            // 
            // btnGroup1
            // 
            this.btnGroup1.BackColor = System.Drawing.Color.Turquoise;
            this.btnGroup1.Location = new System.Drawing.Point(167, 53);
            this.btnGroup1.Name = "btnGroup1";
            this.btnGroup1.Size = new System.Drawing.Size(75, 26);
            this.btnGroup1.TabIndex = 448;
            this.btnGroup1.Text = "Group1";
            this.btnGroup1.UseVisualStyleBackColor = false;
            this.btnGroup1.Click += new System.EventHandler(this.btnGroup1_Click);
            // 
            // btnGroup2
            // 
            this.btnGroup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGroup2.Location = new System.Drawing.Point(167, 78);
            this.btnGroup2.Name = "btnGroup2";
            this.btnGroup2.Size = new System.Drawing.Size(75, 26);
            this.btnGroup2.TabIndex = 452;
            this.btnGroup2.Text = "Group2";
            this.btnGroup2.UseVisualStyleBackColor = false;
            this.btnGroup2.Click += new System.EventHandler(this.btnGroup2_Click);
            // 
            // btnGroup3
            // 
            this.btnGroup3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGroup3.Location = new System.Drawing.Point(167, 103);
            this.btnGroup3.Name = "btnGroup3";
            this.btnGroup3.Size = new System.Drawing.Size(75, 26);
            this.btnGroup3.TabIndex = 451;
            this.btnGroup3.Text = "Group3";
            this.btnGroup3.UseVisualStyleBackColor = false;
            this.btnGroup3.Click += new System.EventHandler(this.btnGroup3_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(330, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(105, 61);
            this.btnRun.TabIndex = 453;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(330, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 61);
            this.btnStop.TabIndex = 453;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 829);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgAngle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pnProperty);
            this.Controls.Add(this.picDisp);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAngle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.Panel pnProperty;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAngle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnValueIncrement;
        private System.Windows.Forms.Button btnValueDecrement;
        private System.Windows.Forms.Button btnValueStackIncrement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChangeValue;
        private System.Windows.Forms.Button btnValueStackDecrement;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnValueMul;
        private System.Windows.Forms.Button btnValueDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnValueFlip;
        private System.Windows.Forms.Button btnValueChange;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.Button btnInterpolation2;
        private System.Windows.Forms.Button btnGroupDel;
        private System.Windows.Forms.Button btnGroup1;
        private System.Windows.Forms.Button btnGroup2;
        private System.Windows.Forms.Button btnGroup3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
    }
}

