namespace testStream
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
            this.btnStart_Cam = new System.Windows.Forms.Button();
            this.btnStart_Screen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart_Cam
            // 
            this.btnStart_Cam.Location = new System.Drawing.Point(12, 90);
            this.btnStart_Cam.Name = "btnStart_Cam";
            this.btnStart_Cam.Size = new System.Drawing.Size(137, 79);
            this.btnStart_Cam.TabIndex = 0;
            this.btnStart_Cam.Text = "Start(Cam)";
            this.btnStart_Cam.UseVisualStyleBackColor = true;
            this.btnStart_Cam.Click += new System.EventHandler(this.btnStart_Cam_Click);
            // 
            // btnStart_Screen
            // 
            this.btnStart_Screen.Location = new System.Drawing.Point(169, 90);
            this.btnStart_Screen.Name = "btnStart_Screen";
            this.btnStart_Screen.Size = new System.Drawing.Size(137, 79);
            this.btnStart_Screen.TabIndex = 0;
            this.btnStart_Screen.Text = "Start(Screen)";
            this.btnStart_Screen.UseVisualStyleBackColor = true;
            this.btnStart_Screen.Click += new System.EventHandler(this.btnStart_Screen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 182);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 79);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(206, 8);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8081";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(206, 35);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 21);
            this.txtW.TabIndex = 2;
            this.txtW.Text = "640";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(206, 62);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 21);
            this.txtH.TabIndex = 2;
            this.txtH.Text = "480";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Camera Index";
            // 
            // txtCam
            // 
            this.txtCam.Location = new System.Drawing.Point(12, 62);
            this.txtCam.Name = "txtCam";
            this.txtCam.Size = new System.Drawing.Size(137, 21);
            this.txtCam.TabIndex = 2;
            this.txtCam.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart_Screen);
            this.Controls.Add(this.btnStart_Cam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart_Cam;
        private System.Windows.Forms.Button btnStart_Screen;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCam;
    }
}

