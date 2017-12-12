namespace OpenJigWare_example
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lbCam = new System.Windows.Forms.Label();
            this.btnCamStart = new System.Windows.Forms.Button();
            this.btnCamStop = new System.Windows.Forms.Button();
            this.btnCamServerStop = new System.Windows.Forms.Button();
            this.btnCamServerStart = new System.Windows.Forms.Button();
            this.lbCam2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb3d = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lb3d_property = new System.Windows.Forms.Label();
            this.btnCamServerStart2 = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lbNotepad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(948, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(948, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(939, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "textBox1";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(939, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "textBox2";
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(939, 192);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 92);
            this.textBox3.TabIndex = 4;
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseDown);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(941, 301);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(934, 326);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "test0",
            "test1",
            "test2"});
            this.comboBox1.Location = new System.Drawing.Point(934, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "comboBox1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(292, 432);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(495, 124);
            this.txtMessage.TabIndex = 9;
            this.txtMessage.WordWrap = false;
            // 
            // lbCam
            // 
            this.lbCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCam.Location = new System.Drawing.Point(12, 67);
            this.lbCam.Name = "lbCam";
            this.lbCam.Size = new System.Drawing.Size(290, 228);
            this.lbCam.TabIndex = 10;
            this.lbCam.Text = "label1";
            // 
            // btnCamStart
            // 
            this.btnCamStart.Location = new System.Drawing.Point(12, 9);
            this.btnCamStart.Name = "btnCamStart";
            this.btnCamStart.Size = new System.Drawing.Size(133, 52);
            this.btnCamStart.TabIndex = 11;
            this.btnCamStart.Text = "Camera Start";
            this.btnCamStart.UseVisualStyleBackColor = true;
            this.btnCamStart.Click += new System.EventHandler(this.btnCamStart_Click);
            // 
            // btnCamStop
            // 
            this.btnCamStop.Location = new System.Drawing.Point(169, 9);
            this.btnCamStop.Name = "btnCamStop";
            this.btnCamStop.Size = new System.Drawing.Size(133, 52);
            this.btnCamStop.TabIndex = 11;
            this.btnCamStop.Text = "Camera Stop";
            this.btnCamStop.UseVisualStyleBackColor = true;
            this.btnCamStop.Click += new System.EventHandler(this.btnCamStop_Click);
            // 
            // btnCamServerStop
            // 
            this.btnCamServerStop.Location = new System.Drawing.Point(292, 315);
            this.btnCamServerStop.Name = "btnCamServerStop";
            this.btnCamServerStop.Size = new System.Drawing.Size(133, 52);
            this.btnCamServerStop.TabIndex = 13;
            this.btnCamServerStop.Text = "CameraServer Stop";
            this.btnCamServerStop.UseVisualStyleBackColor = true;
            this.btnCamServerStop.Click += new System.EventHandler(this.btnCamServerStop_Click);
            // 
            // btnCamServerStart
            // 
            this.btnCamServerStart.Location = new System.Drawing.Point(14, 315);
            this.btnCamServerStart.Name = "btnCamServerStart";
            this.btnCamServerStart.Size = new System.Drawing.Size(133, 52);
            this.btnCamServerStart.TabIndex = 14;
            this.btnCamServerStart.Text = "바탕화면 영상 인터넷 전송";
            this.btnCamServerStart.UseVisualStyleBackColor = true;
            this.btnCamServerStart.Click += new System.EventHandler(this.btnCamServerStart_Click);
            // 
            // lbCam2
            // 
            this.lbCam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCam2.Location = new System.Drawing.Point(14, 370);
            this.lbCam2.Name = "lbCam2";
            this.lbCam2.Size = new System.Drawing.Size(272, 186);
            this.lbCam2.TabIndex = 12;
            this.lbCam2.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb3d
            // 
            this.lb3d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb3d.Location = new System.Drawing.Point(308, 67);
            this.lb3d.Name = "lb3d";
            this.lb3d.Size = new System.Drawing.Size(290, 228);
            this.lb3d.TabIndex = 15;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(308, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(133, 52);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open 3D";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lb3d_property
            // 
            this.lb3d_property.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb3d_property.Location = new System.Drawing.Point(604, 67);
            this.lb3d_property.Name = "lb3d_property";
            this.lb3d_property.Size = new System.Drawing.Size(290, 228);
            this.lb3d_property.TabIndex = 16;
            // 
            // btnCamServerStart2
            // 
            this.btnCamServerStart2.Location = new System.Drawing.Point(153, 315);
            this.btnCamServerStart2.Name = "btnCamServerStart2";
            this.btnCamServerStart2.Size = new System.Drawing.Size(133, 52);
            this.btnCamServerStart2.TabIndex = 14;
            this.btnCamServerStart2.Text = "CameraServer Start";
            this.btnCamServerStart2.UseVisualStyleBackColor = true;
            this.btnCamServerStart2.Click += new System.EventHandler(this.btnCamServerStart2_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(793, 498);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(141, 58);
            this.btnOpenFolder.TabIndex = 17;
            this.btnOpenFolder.Text = "현 작업 폴더 열기";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(965, 481);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(195, 68);
            this.btnShutdown.TabIndex = 17;
            this.btnShutdown.Text = "컴퓨터 끄기";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // lbNotepad
            // 
            this.lbNotepad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNotepad.Location = new System.Drawing.Point(617, 301);
            this.lbNotepad.Name = "lbNotepad";
            this.lbNotepad.Size = new System.Drawing.Size(277, 128);
            this.lbNotepad.TabIndex = 12;
            this.lbNotepad.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "노트패드 가져오기";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lb3d_property);
            this.Controls.Add(this.lb3d);
            this.Controls.Add(this.btnCamServerStop);
            this.Controls.Add(this.btnCamServerStart2);
            this.Controls.Add(this.btnCamServerStart);
            this.Controls.Add(this.lbNotepad);
            this.Controls.Add(this.lbCam2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCamStop);
            this.Controls.Add(this.btnCamStart);
            this.Controls.Add(this.lbCam);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lbCam;
        private System.Windows.Forms.Button btnCamStart;
        private System.Windows.Forms.Button btnCamStop;
        private System.Windows.Forms.Button btnCamServerStop;
        private System.Windows.Forms.Button btnCamServerStart;
        private System.Windows.Forms.Label lbCam2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb3d;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lb3d_property;
        private System.Windows.Forms.Button btnCamServerStart2;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label lbNotepad;
        private System.Windows.Forms.Label label1;
    }
}

