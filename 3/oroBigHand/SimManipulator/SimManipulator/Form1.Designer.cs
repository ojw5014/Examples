namespace SimManipulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnDisp = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSkeleton = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.tmrDisp = new System.Windows.Forms.Timer(this.components);
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtInverse = new System.Windows.Forms.TextBox();
            this.txtPos_X = new System.Windows.Forms.TextBox();
            this.txtPos_Y = new System.Windows.Forms.TextBox();
            this.txtPos_Z = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSkeleton_2 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtZ0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtZ1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGo0 = new System.Windows.Forms.Button();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.rdMode0 = new System.Windows.Forms.RadioButton();
            this.rdMode1 = new System.Windows.Forms.RadioButton();
            this.tbTilt = new System.Windows.Forms.TrackBar();
            this.tbTurn = new System.Windows.Forms.TrackBar();
            this.btnGrab = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDisp
            // 
            this.pnDisp.Controls.Add(this.rdMode1);
            this.pnDisp.Controls.Add(this.rdMode0);
            this.pnDisp.Location = new System.Drawing.Point(10, 10);
            this.pnDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDisp.Name = "pnDisp";
            this.pnDisp.Size = new System.Drawing.Size(400, 374);
            this.pnDisp.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(10, 388);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(400, 227);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.WordWrap = false;
            // 
            // txtSkeleton
            // 
            this.txtSkeleton.Location = new System.Drawing.Point(416, 48);
            this.txtSkeleton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSkeleton.Multiline = true;
            this.txtSkeleton.Name = "txtSkeleton";
            this.txtSkeleton.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSkeleton.Size = new System.Drawing.Size(266, 120);
            this.txtSkeleton.TabIndex = 1;
            this.txtSkeleton.WordWrap = false;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(536, 10);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(146, 21);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tmrDisp
            // 
            this.tmrDisp.Tick += new System.EventHandler(this.tmrDisp_Tick);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(416, 406);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(634, 106);
            this.txtResult.TabIndex = 1;
            this.txtResult.WordWrap = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(531, 516);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(59, 65);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "=> Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtInverse
            // 
            this.txtInverse.Location = new System.Drawing.Point(689, 48);
            this.txtInverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInverse.Multiline = true;
            this.txtInverse.Name = "txtInverse";
            this.txtInverse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInverse.Size = new System.Drawing.Size(361, 336);
            this.txtInverse.TabIndex = 1;
            this.txtInverse.WordWrap = false;
            // 
            // txtPos_X
            // 
            this.txtPos_X.Location = new System.Drawing.Point(474, 516);
            this.txtPos_X.Name = "txtPos_X";
            this.txtPos_X.Size = new System.Drawing.Size(57, 21);
            this.txtPos_X.TabIndex = 4;
            // 
            // txtPos_Y
            // 
            this.txtPos_Y.Location = new System.Drawing.Point(474, 538);
            this.txtPos_Y.Name = "txtPos_Y";
            this.txtPos_Y.Size = new System.Drawing.Size(57, 21);
            this.txtPos_Y.TabIndex = 4;
            // 
            // txtPos_Z
            // 
            this.txtPos_Z.Location = new System.Drawing.Point(474, 560);
            this.txtPos_Z.Name = "txtPos_Z";
            this.txtPos_Z.Size = new System.Drawing.Size(57, 21);
            this.txtPos_Z.TabIndex = 4;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(741, 516);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(48, 104);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(416, 516);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(58, 65);
            this.btnGet.TabIndex = 6;
            this.btnGet.Text = "Get =>";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "scale";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(459, 10);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(71, 21);
            this.txtScale.TabIndex = 8;
            this.txtScale.Text = "0.3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Forward 결과 수식";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inverse 수식";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forward 수식(DH Param)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Forward 수식2 (위 수식에 이어지지만 실제 수식";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "에는 반영되지 않고 그림만 그린다.)";
            // 
            // txtSkeleton_2
            // 
            this.txtSkeleton_2.Location = new System.Drawing.Point(416, 196);
            this.txtSkeleton_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSkeleton_2.Multiline = true;
            this.txtSkeleton_2.Name = "txtSkeleton_2";
            this.txtSkeleton_2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSkeleton_2.Size = new System.Drawing.Size(266, 188);
            this.txtSkeleton_2.TabIndex = 1;
            this.txtSkeleton_2.WordWrap = false;
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(620, 530);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(57, 21);
            this.txtX0.TabIndex = 4;
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(620, 552);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(57, 21);
            this.txtY0.TabIndex = 4;
            // 
            // txtZ0
            // 
            this.txtZ0.Location = new System.Drawing.Point(620, 574);
            this.txtZ0.Name = "txtZ0";
            this.txtZ0.Size = new System.Drawing.Size(57, 21);
            this.txtZ0.TabIndex = 4;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(678, 530);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(57, 21);
            this.txtX1.TabIndex = 4;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(678, 552);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(57, 21);
            this.txtY1.TabIndex = 4;
            // 
            // txtZ1
            // 
            this.txtZ1.Location = new System.Drawing.Point(678, 574);
            this.txtZ1.Name = "txtZ1";
            this.txtZ1.Size = new System.Drawing.Size(57, 21);
            this.txtZ1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(678, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "End";
            // 
            // btnGo0
            // 
            this.btnGo0.Location = new System.Drawing.Point(619, 595);
            this.btnGo0.Name = "btnGo0";
            this.btnGo0.Size = new System.Drawing.Size(58, 25);
            this.btnGo0.TabIndex = 10;
            this.btnGo0.Text = "Go";
            this.btnGo0.UseVisualStyleBackColor = true;
            this.btnGo0.Click += new System.EventHandler(this.btnGo0_Click);
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(677, 596);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(58, 25);
            this.btnGo1.TabIndex = 10;
            this.btnGo1.Text = "Go";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // rdMode0
            // 
            this.rdMode0.AutoSize = true;
            this.rdMode0.BackColor = System.Drawing.Color.Transparent;
            this.rdMode0.Location = new System.Drawing.Point(3, 3);
            this.rdMode0.Name = "rdMode0";
            this.rdMode0.Size = new System.Drawing.Size(71, 16);
            this.rdMode0.TabIndex = 0;
            this.rdMode0.TabStop = true;
            this.rdMode0.Text = "화면이동";
            this.rdMode0.UseVisualStyleBackColor = false;
            this.rdMode0.CheckedChanged += new System.EventHandler(this.rdMode0_CheckedChanged);
            // 
            // rdMode1
            // 
            this.rdMode1.AutoSize = true;
            this.rdMode1.BackColor = System.Drawing.Color.Transparent;
            this.rdMode1.Location = new System.Drawing.Point(3, 25);
            this.rdMode1.Name = "rdMode1";
            this.rdMode1.Size = new System.Drawing.Size(71, 16);
            this.rdMode1.TabIndex = 0;
            this.rdMode1.TabStop = true;
            this.rdMode1.Text = "로봇이동";
            this.rdMode1.UseVisualStyleBackColor = false;
            this.rdMode1.CheckedChanged += new System.EventHandler(this.rdMode1_CheckedChanged);
            // 
            // tbTilt
            // 
            this.tbTilt.Location = new System.Drawing.Point(832, 519);
            this.tbTilt.Maximum = 100;
            this.tbTilt.Minimum = -100;
            this.tbTilt.Name = "tbTilt";
            this.tbTilt.Size = new System.Drawing.Size(104, 45);
            this.tbTilt.TabIndex = 11;
            this.tbTilt.Scroll += new System.EventHandler(this.tbTilt_Scroll);
            // 
            // tbTurn
            // 
            this.tbTurn.Location = new System.Drawing.Point(832, 572);
            this.tbTurn.Maximum = 100;
            this.tbTurn.Minimum = -100;
            this.tbTurn.Name = "tbTurn";
            this.tbTurn.Size = new System.Drawing.Size(104, 45);
            this.tbTurn.TabIndex = 11;
            this.tbTurn.Scroll += new System.EventHandler(this.tbTurn_Scroll);
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(951, 516);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(99, 51);
            this.btnGrab.TabIndex = 12;
            this.btnGrab.Text = "Hand [Grab]";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(951, 569);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(99, 51);
            this.btnRelease.TabIndex = 12;
            this.btnRelease.Text = "Hand [Release]";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(804, 535);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tilt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(804, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 626);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.tbTurn);
            this.Controls.Add(this.tbTilt);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.btnGo0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtZ1);
            this.Controls.Add(this.txtZ0);
            this.Controls.Add(this.txtPos_Z);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtPos_Y);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.txtPos_X);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtInverse);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSkeleton_2);
            this.Controls.Add(this.txtSkeleton);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pnDisp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnDisp.ResumeLayout(false);
            this.pnDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDisp;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSkeleton;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Timer tmrDisp;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtInverse;
        private System.Windows.Forms.TextBox txtPos_X;
        private System.Windows.Forms.TextBox txtPos_Y;
        private System.Windows.Forms.TextBox txtPos_Z;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSkeleton_2;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtZ0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtZ1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGo0;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.RadioButton rdMode1;
        private System.Windows.Forms.RadioButton rdMode0;
        private System.Windows.Forms.TrackBar tbTilt;
        private System.Windows.Forms.TrackBar tbTurn;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

