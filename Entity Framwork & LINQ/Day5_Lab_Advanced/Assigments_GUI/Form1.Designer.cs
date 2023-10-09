namespace Assigments_GUI
{
    partial class Converter_Form
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
            this.ValueText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioMeterToKilo = new System.Windows.Forms.RadioButton();
            this.radioMeterToMile = new System.Windows.Forms.RadioButton();
            this.radioMileToMeter = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result :";
            // 
            // ValueText
            // 
            this.ValueText.Location = new System.Drawing.Point(96, 65);
            this.ValueText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(131, 30);
            this.ValueText.TabIndex = 2;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(96, 128);
            this.ResultText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(131, 30);
            this.ResultText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(313, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose Unit";
            // 
            // radioMeterToKilo
            // 
            this.radioMeterToKilo.AutoSize = true;
            this.radioMeterToKilo.Location = new System.Drawing.Point(266, 65);
            this.radioMeterToKilo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioMeterToKilo.Name = "radioMeterToKilo";
            this.radioMeterToKilo.Size = new System.Drawing.Size(196, 27);
            this.radioMeterToKilo.TabIndex = 5;
            this.radioMeterToKilo.TabStop = true;
            this.radioMeterToKilo.Text = " Meter to kilometer";
            this.radioMeterToKilo.UseVisualStyleBackColor = true;
            // 
            // radioMeterToMile
            // 
            this.radioMeterToMile.AutoSize = true;
            this.radioMeterToMile.Location = new System.Drawing.Point(266, 97);
            this.radioMeterToMile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioMeterToMile.Name = "radioMeterToMile";
            this.radioMeterToMile.Size = new System.Drawing.Size(149, 27);
            this.radioMeterToMile.TabIndex = 6;
            this.radioMeterToMile.TabStop = true;
            this.radioMeterToMile.Text = " Meter to mile";
            this.radioMeterToMile.UseVisualStyleBackColor = true;
            // 
            // radioMileToMeter
            // 
            this.radioMileToMeter.AutoSize = true;
            this.radioMileToMeter.Location = new System.Drawing.Point(266, 128);
            this.radioMileToMeter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioMileToMeter.Name = "radioMileToMeter";
            this.radioMileToMeter.Size = new System.Drawing.Size(144, 27);
            this.radioMileToMeter.TabIndex = 7;
            this.radioMileToMeter.TabStop = true;
            this.radioMileToMeter.Text = "Mile to meter";
            this.radioMileToMeter.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(137, 179);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(145, 41);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Converter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(481, 252);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radioMileToMeter);
            this.Controls.Add(this.radioMeterToMile);
            this.Controls.Add(this.radioMeterToKilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Converter_Form";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValueText;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioMeterToKilo;
        private System.Windows.Forms.RadioButton radioMeterToMile;
        private System.Windows.Forms.RadioButton radioMileToMeter;
        private System.Windows.Forms.Button btnConvert;
    }
}

