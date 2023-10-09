namespace Day6_Lab_WinForm_Day_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.domainFontColor = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size :";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(97, 125);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(131, 24);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Sample Text";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(101, 60);
            this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.ReadOnly = true;
            this.fontSize.Size = new System.Drawing.Size(220, 31);
            this.fontSize.TabIndex = 3;
            this.fontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // domainFontColor
            // 
            this.domainFontColor.Location = new System.Drawing.Point(101, 22);
            this.domainFontColor.Name = "domainFontColor";
            this.domainFontColor.Size = new System.Drawing.Size(220, 31);
            this.domainFontColor.TabIndex = 4;
            this.domainFontColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainFontColor.SelectedItemChanged += new System.EventHandler(this.domainFontColor_SelectedItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 175);
            this.Controls.Add(this.domainFontColor);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.DomainUpDown domainFontColor;
    }
}

