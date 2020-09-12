namespace Ex3_Convert
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtIsDigit = new System.Windows.Forms.TextBox();
            this.txtFloat = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRemoveString = new System.Windows.Forms.Button();
            this.txtRemoveString = new System.Windows.Forms.TextBox();
            this.txtResult_RemoveString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Is this a Digit?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIsDigit
            // 
            this.txtIsDigit.Location = new System.Drawing.Point(12, 12);
            this.txtIsDigit.Name = "txtIsDigit";
            this.txtIsDigit.Size = new System.Drawing.Size(100, 25);
            this.txtIsDigit.TabIndex = 1;
            this.txtIsDigit.Text = "Input digit";
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(12, 53);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(41, 25);
            this.txtFloat.TabIndex = 1;
            this.txtFloat.Text = "3.5";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(98, 53);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(41, 25);
            this.txtHex.TabIndex = 1;
            this.txtHex.Text = "cd";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(166, 53);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(41, 25);
            this.txtInt.TabIndex = 1;
            this.txtInt.Text = "5";
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(245, 53);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.Size = new System.Drawing.Size(41, 25);
            this.txtDouble.TabIndex = 1;
            this.txtDouble.Text = "90";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "+  0x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "=";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(405, 53);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(97, 25);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Calc";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(319, 53);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(80, 25);
            this.txtResult.TabIndex = 1;
            // 
            // btnRemoveString
            // 
            this.btnRemoveString.Location = new System.Drawing.Point(166, 84);
            this.btnRemoveString.Name = "btnRemoveString";
            this.btnRemoveString.Size = new System.Drawing.Size(120, 27);
            this.btnRemoveString.TabIndex = 4;
            this.btnRemoveString.Text = "Remove \"kk\"";
            this.btnRemoveString.UseVisualStyleBackColor = true;
            this.btnRemoveString.Click += new System.EventHandler(this.btnRemoveString_Click);
            // 
            // txtRemoveString
            // 
            this.txtRemoveString.Location = new System.Drawing.Point(12, 87);
            this.txtRemoveString.Name = "txtRemoveString";
            this.txtRemoveString.Size = new System.Drawing.Size(148, 25);
            this.txtRemoveString.TabIndex = 1;
            this.txtRemoveString.Text = "kkkkk rk udkkk";
            // 
            // txtResult_RemoveString
            // 
            this.txtResult_RemoveString.Location = new System.Drawing.Point(319, 84);
            this.txtResult_RemoveString.Name = "txtResult_RemoveString";
            this.txtResult_RemoveString.Size = new System.Drawing.Size(183, 25);
            this.txtResult_RemoveString.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "=";
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(12, 118);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(63, 25);
            this.txtTest2.TabIndex = 1;
            this.txtTest2.Text = "33";
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(81, 117);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(205, 23);
            this.btnTest2.TabIndex = 5;
            this.btnTest2.Text = "FillString \"0\" to Left(4 digit)";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(319, 115);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(183, 25);
            this.txtResult2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 153);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnRemoveString);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtRemoveString);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult_RemoveString);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDouble);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.txtIsDigit);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIsDigit;
        private System.Windows.Forms.TextBox txtFloat;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtDouble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnRemoveString;
        private System.Windows.Forms.TextBox txtRemoveString;
        private System.Windows.Forms.TextBox txtResult_RemoveString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.Label label6;
    }
}

