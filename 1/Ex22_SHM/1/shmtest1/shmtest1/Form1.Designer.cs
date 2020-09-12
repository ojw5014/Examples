namespace shmtest1
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
            this.btnCmd = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShmName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStruct_Char = new System.Windows.Forms.TextBox();
            this.txtStruct_Float = new System.Windows.Forms.TextBox();
            this.txtStruct_Int = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtProgName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(11, 179);
            this.btnCmd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(178, 45);
            this.btnCmd.TabIndex = 0;
            this.btnCmd.Text = "Send";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(365, 15);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(329, 384);
            this.txtMessage.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(213, 81);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(120, 142);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(11, 25);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 45);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Enabled = false;
            this.btnDestroy.Location = new System.Drawing.Point(104, 25);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(86, 45);
            this.btnDestroy.TabIndex = 3;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtShmName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStruct_Char);
            this.groupBox1.Controls.Add(this.txtStruct_Float);
            this.groupBox1.Controls.Add(this.txtStruct_Int);
            this.groupBox1.Controls.Add(this.btnDestroy);
            this.groupBox1.Controls.Add(this.btnCmd);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(344, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shared Memory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Shm Name";
            // 
            // txtShmName
            // 
            this.txtShmName.Location = new System.Drawing.Point(213, 44);
            this.txtShmName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShmName.Name = "txtShmName";
            this.txtShmName.Size = new System.Drawing.Size(119, 25);
            this.txtShmName.TabIndex = 15;
            this.txtShmName.Text = "OpenJigWare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "char";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "float";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "int";
            // 
            // txtStruct_Char
            // 
            this.txtStruct_Char.Location = new System.Drawing.Point(75, 145);
            this.txtStruct_Char.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStruct_Char.Name = "txtStruct_Char";
            this.txtStruct_Char.Size = new System.Drawing.Size(114, 25);
            this.txtStruct_Char.TabIndex = 10;
            // 
            // txtStruct_Float
            // 
            this.txtStruct_Float.Location = new System.Drawing.Point(75, 111);
            this.txtStruct_Float.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStruct_Float.Name = "txtStruct_Float";
            this.txtStruct_Float.Size = new System.Drawing.Size(114, 25);
            this.txtStruct_Float.TabIndex = 9;
            // 
            // txtStruct_Int
            // 
            this.txtStruct_Int.Location = new System.Drawing.Point(75, 78);
            this.txtStruct_Int.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStruct_Int.Name = "txtStruct_Int";
            this.txtStruct_Int.Size = new System.Drawing.Size(114, 25);
            this.txtStruct_Int.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendMessage);
            this.groupBox2.Controls.Add(this.txtProgName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSendMessage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(344, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Message";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(11, 90);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(321, 44);
            this.btnSendMessage.TabIndex = 9;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtProgName
            // 
            this.txtProgName.Location = new System.Drawing.Point(120, 25);
            this.txtProgName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProgName.Name = "txtProgName";
            this.txtProgName.Size = new System.Drawing.Size(212, 25);
            this.txtProgName.TabIndex = 4;
            this.txtProgName.Text = "shmtest0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Program Name";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(75, 56);
            this.txtSendMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(257, 25);
            this.txtSendMessage.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStruct_Char;
        private System.Windows.Forms.TextBox txtStruct_Float;
        private System.Windows.Forms.TextBox txtStruct_Int;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShmName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtProgName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Label label4;
    }
}

