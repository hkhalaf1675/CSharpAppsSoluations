using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_Lab_WinForm_Day_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = 
            {
                "Black",
                "Red",
                "White",
                "Green",
                "Blue"
            };

            domainFontColor.Items.AddRange(colors);

            domainFontColor.SelectedIndex = 0;
        }

        private void domainFontColor_SelectedItemChanged(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.FromName(domainFontColor.SelectedItem.ToString());
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            lblText.Font = new Font("Arial", float.Parse(fontSize.Value.ToString()));
        }
    }
}
