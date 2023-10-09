namespace Day6_Lab_WinForm_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtText = new TextBox();
            btnFormat = new Button();
            SuspendLayout();
            // 
            // txtText
            // 
            txtText.Location = new Point(13, 13);
            txtText.Margin = new Padding(4);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(377, 76);
            txtText.TabIndex = 0;
            // 
            // btnFormat
            // 
            btnFormat.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormat.Location = new Point(425, 32);
            btnFormat.Margin = new Padding(4);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(123, 39);
            btnFormat.TabIndex = 1;
            btnFormat.Text = "Format";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 102);
            Controls.Add(btnFormat);
            Controls.Add(txtText);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Formation";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtText;
        private Button btnFormat;
    }
}