namespace ColorfulParagraphControl

{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorfulParagraph1 = new ColorfulParagraphControl.ColorfulParagraph();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // colorfulParagraph1
            // 
            this.colorfulParagraph1.BackColor = System.Drawing.SystemColors.Control;
            this.colorfulParagraph1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorfulParagraph1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colorfulParagraph1.Location = new System.Drawing.Point(12, 12);
            this.colorfulParagraph1.Name = "colorfulParagraph1";
            this.colorfulParagraph1.ReadOnly = true;
            this.colorfulParagraph1.Size = new System.Drawing.Size(375, 137);
            this.colorfulParagraph1.TabIndex = 0;
            this.colorfulParagraph1.TabStop = false;
            this.colorfulParagraph1.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorfulParagraph1);
            this.Name = "frmMain";
            this.Text = "Colorful Paragraph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorfulParagraph colorfulParagraph1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

