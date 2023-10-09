namespace RegisterationForm
{
    partial class Registeration
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.checkFootball = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblHoppiesError = new System.Windows.Forms.Label();
            this.lblVaildRegister = new System.Windows.Forms.Label();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.checkTennis = new System.Windows.Forms.CheckBox();
            this.checkSwimming = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 30);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(141, 191);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(70, 27);
            this.radioMale.TabIndex = 2;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // checkFootball
            // 
            this.checkFootball.AutoSize = true;
            this.checkFootball.Location = new System.Drawing.Point(141, 246);
            this.checkFootball.Name = "checkFootball";
            this.checkFootball.Size = new System.Drawing.Size(100, 27);
            this.checkFootball.TabIndex = 3;
            this.checkFootball.Text = "Football";
            this.checkFootball.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(291, 298);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(148, 43);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hoppies :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(332, 125);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(25, 23);
            this.lblEmailError.TabIndex = 10;
            this.lblEmailError.Text = "   ";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(332, 69);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(24, 19);
            this.lblNameError.TabIndex = 9;
            this.lblNameError.Text = "   ";
            // 
            // lblHoppiesError
            // 
            this.lblHoppiesError.AutoSize = true;
            this.lblHoppiesError.ForeColor = System.Drawing.Color.Red;
            this.lblHoppiesError.Location = new System.Drawing.Point(479, 249);
            this.lblHoppiesError.Name = "lblHoppiesError";
            this.lblHoppiesError.Size = new System.Drawing.Size(25, 23);
            this.lblHoppiesError.TabIndex = 11;
            this.lblHoppiesError.Text = "   ";
            // 
            // lblVaildRegister
            // 
            this.lblVaildRegister.AutoSize = true;
            this.lblVaildRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVaildRegister.Location = new System.Drawing.Point(200, 362);
            this.lblVaildRegister.Name = "lblVaildRegister";
            this.lblVaildRegister.Size = new System.Drawing.Size(25, 23);
            this.lblVaildRegister.TabIndex = 12;
            this.lblVaildRegister.Text = "   ";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(244, 189);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(92, 27);
            this.radioFemale.TabIndex = 13;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // checkTennis
            // 
            this.checkTennis.AutoSize = true;
            this.checkTennis.Location = new System.Drawing.Point(247, 245);
            this.checkTennis.Name = "checkTennis";
            this.checkTennis.Size = new System.Drawing.Size(88, 27);
            this.checkTennis.TabIndex = 14;
            this.checkTennis.Text = "Tennis";
            this.checkTennis.UseVisualStyleBackColor = true;
            // 
            // checkSwimming
            // 
            this.checkSwimming.AutoSize = true;
            this.checkSwimming.Location = new System.Drawing.Point(353, 246);
            this.checkSwimming.Name = "checkSwimming";
            this.checkSwimming.Size = new System.Drawing.Size(120, 27);
            this.checkSwimming.TabIndex = 15;
            this.checkSwimming.Text = "Swimming";
            this.checkSwimming.UseVisualStyleBackColor = true;
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 406);
            this.Controls.Add(this.checkSwimming);
            this.Controls.Add(this.checkTennis);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.lblVaildRegister);
            this.Controls.Add(this.lblHoppiesError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.checkFootball);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Registeration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.CheckBox checkFootball;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblHoppiesError;
        private System.Windows.Forms.Label lblVaildRegister;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.CheckBox checkTennis;
        private System.Windows.Forms.CheckBox checkSwimming;
    }
}

