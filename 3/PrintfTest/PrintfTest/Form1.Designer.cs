namespace PrintfTest
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
            this.txtPrintf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrintf
            // 
            this.txtPrintf.Location = new System.Drawing.Point(12, 189);
            this.txtPrintf.Multiline = true;
            this.txtPrintf.Name = "txtPrintf";
            this.txtPrintf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrintf.Size = new System.Drawing.Size(528, 99);
            this.txtPrintf.TabIndex = 0;
            this.txtPrintf.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 300);
            this.Controls.Add(this.txtPrintf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrintf;
    }
}

