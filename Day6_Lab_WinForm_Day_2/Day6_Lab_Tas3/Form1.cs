using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_Lab_Tas3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.Columns.Add("colName", "Name");
            dgv.Columns.Add("colPhone", "Phone");
            dgv.Columns.Add("colBirthday", "Birthday");

            dgv.Columns[0].Width = 120;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 150;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(txtName.Text, txtPhone.Text, dtpBirthday.Value);
        }
    }
}
