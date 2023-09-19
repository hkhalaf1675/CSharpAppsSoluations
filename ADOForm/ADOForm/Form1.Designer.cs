namespace ADOForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 10);
            button1.Name = "button1";
            button1.Size = new Size(147, 38);
            button1.TabIndex = 0;
            button1.Text = "Open Connection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 10);
            button2.Name = "button2";
            button2.Size = new Size(147, 38);
            button2.TabIndex = 1;
            button2.Text = "Close Connection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 87);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 23);
            comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(12, 54);
            button3.Name = "button3";
            button3.Size = new Size(127, 23);
            button3.TabIndex = 5;
            button3.Text = "update proc";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 83);
            button4.Name = "button4";
            button4.Size = new Size(127, 23);
            button4.TabIndex = 6;
            button4.Text = "Fill Combo Box";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(14, 162);
            button5.Name = "button5";
            button5.Size = new Size(111, 38);
            button5.TabIndex = 7;
            button5.Text = "Fill List";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(343, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 199);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(167, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(410, 179);
            dataGridView1.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(14, 206);
            button6.Name = "button6";
            button6.Size = new Size(111, 38);
            button6.TabIndex = 10;
            button6.Text = "Fill Grid View";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 433);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button6;
    }
}