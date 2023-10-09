namespace Day6_Lab_WinForm_2
{
    partial class FrmDialog
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
            label1 = new Label();
            label2 = new Label();
            comboFontFamily = new ComboBox();
            txtFontSize = new TextBox();
            groupFormat = new GroupBox();
            checkUnderline = new CheckBox();
            checkItalic = new CheckBox();
            checkBold = new CheckBox();
            groupColor = new GroupBox();
            radioBlue = new RadioButton();
            radioGreen = new RadioButton();
            radioRed = new RadioButton();
            btnOk = new Button();
            groupFormat.SuspendLayout();
            groupColor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // comboFontFamily
            // 
            comboFontFamily.FormattingEnabled = true;
            comboFontFamily.Location = new Point(83, 25);
            comboFontFamily.Name = "comboFontFamily";
            comboFontFamily.Size = new Size(145, 31);
            comboFontFamily.TabIndex = 2;
            // 
            // txtFontSize
            // 
            txtFontSize.Location = new Point(83, 86);
            txtFontSize.Name = "txtFontSize";
            txtFontSize.Size = new Size(145, 30);
            txtFontSize.TabIndex = 3;
            // 
            // groupFormat
            // 
            groupFormat.Controls.Add(checkUnderline);
            groupFormat.Controls.Add(checkItalic);
            groupFormat.Controls.Add(checkBold);
            groupFormat.Location = new Point(13, 124);
            groupFormat.Name = "groupFormat";
            groupFormat.Size = new Size(442, 63);
            groupFormat.TabIndex = 4;
            groupFormat.TabStop = false;
            groupFormat.Text = "Format";
            groupFormat.Enter += groupFormat_Enter;
            // 
            // checkUnderline
            // 
            checkUnderline.AutoSize = true;
            checkUnderline.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
            checkUnderline.Location = new Point(247, 29);
            checkUnderline.Name = "checkUnderline";
            checkUnderline.Size = new Size(96, 23);
            checkUnderline.TabIndex = 2;
            checkUnderline.Text = "Underline";
            checkUnderline.UseVisualStyleBackColor = true;
            // 
            // checkItalic
            // 
            checkItalic.AutoSize = true;
            checkItalic.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkItalic.Location = new Point(136, 29);
            checkItalic.Name = "checkItalic";
            checkItalic.Size = new Size(62, 23);
            checkItalic.TabIndex = 1;
            checkItalic.Text = "Italic";
            checkItalic.UseVisualStyleBackColor = true;
            // 
            // checkBold
            // 
            checkBold.AutoSize = true;
            checkBold.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBold.Location = new Point(30, 29);
            checkBold.Name = "checkBold";
            checkBold.Size = new Size(64, 23);
            checkBold.TabIndex = 0;
            checkBold.Text = "Bold";
            checkBold.UseVisualStyleBackColor = true;
            // 
            // groupColor
            // 
            groupColor.Controls.Add(radioBlue);
            groupColor.Controls.Add(radioGreen);
            groupColor.Controls.Add(radioRed);
            groupColor.Location = new Point(260, 12);
            groupColor.Name = "groupColor";
            groupColor.Size = new Size(195, 106);
            groupColor.TabIndex = 5;
            groupColor.TabStop = false;
            groupColor.Text = "Color";
            // 
            // radioBlue
            // 
            radioBlue.AutoSize = true;
            radioBlue.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioBlue.ForeColor = Color.MediumBlue;
            radioBlue.Location = new Point(28, 80);
            radioBlue.Name = "radioBlue";
            radioBlue.Size = new Size(55, 21);
            radioBlue.TabIndex = 2;
            radioBlue.TabStop = true;
            radioBlue.Text = "Blue";
            radioBlue.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            radioGreen.AutoSize = true;
            radioGreen.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioGreen.ForeColor = Color.Green;
            radioGreen.Location = new Point(28, 56);
            radioGreen.Name = "radioGreen";
            radioGreen.Size = new Size(65, 21);
            radioGreen.TabIndex = 1;
            radioGreen.TabStop = true;
            radioGreen.Text = "Green";
            radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioRed
            // 
            radioRed.AutoSize = true;
            radioRed.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioRed.ForeColor = Color.Red;
            radioRed.Location = new Point(28, 29);
            radioRed.Name = "radioRed";
            radioRed.Size = new Size(51, 21);
            radioRed.TabIndex = 0;
            radioRed.TabStop = true;
            radioRed.Text = "Red";
            radioRed.UseVisualStyleBackColor = true;
            radioRed.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(13, 205);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(442, 48);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // FrmDialog
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 265);
            Controls.Add(btnOk);
            Controls.Add(groupColor);
            Controls.Add(groupFormat);
            Controls.Add(txtFontSize);
            Controls.Add(comboFontFamily);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmDialog";
            Text = "Dialog";
            Load += FrmDialog_Load;
            groupFormat.ResumeLayout(false);
            groupFormat.PerformLayout();
            groupColor.ResumeLayout(false);
            groupColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboFontFamily;
        private TextBox txtFontSize;
        private GroupBox groupFormat;
        private GroupBox groupColor;
        private Button btnOk;
        private RadioButton radioRed;
        private CheckBox checkUnderline;
        private CheckBox checkItalic;
        private CheckBox checkBold;
        private RadioButton radioBlue;
        private RadioButton radioGreen;
    }
}