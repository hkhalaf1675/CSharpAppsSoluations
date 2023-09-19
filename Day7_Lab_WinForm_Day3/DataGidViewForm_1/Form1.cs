using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGidViewForm_1
{
    public partial class Form1 : Form
    {
        List<Employee> emps;
        public Form1()
        {
            InitializeComponent();
            emps = new List<Employee>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ofd.OpenFile();
            fbd.ShowDialog();
            if(fbd.SelectedPath != null)
            {
                txtPath.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show("Plz select folder");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emps;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string empName = "";
            string empAddress = "";
            DateTime empBirthday = default;
            double empSalary = default;


            #region check validation of name
            if (txtName.Text.Length < 5 || Regex.IsMatch(txtName.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Plz the name must be more than 5 chars and do not conatin any number or special chars");
                txtName.Focus();
            }
            else
            {
                empName = txtName.Text;
            }
            #endregion

            #region Check Validtion Of Address
            if (txtAddress.Text.Length < 5)
            {
                MessageBox.Show("Address must be more than 5 chars");
                txtAddress.Focus();
            }
            else
            {
                empAddress = txtAddress.Text;
            }
            #endregion

            #region Check Vaildation of salary
            if (double.TryParse(txtSalary.Text, out empSalary) && empSalary > 2000) ;
            else
            {
                MessageBox.Show("The Salary must be numeric and more than 2000");
                txtSalary.Focus();
            }
            #endregion

            #region check validation of Age
            if (dtpBirthday.Value.Year > 2005)
            {
                MessageBox.Show("The Employee must be bigger than 18 years old");
                dtpBirthday.Focus();
            }
            else
            {
                empBirthday = dtpBirthday.Value;
            } 
            #endregion

            if(empName != "" && empAddress != "" && empBirthday != default && empSalary != default)
            {
                emps.Add(new Employee()
                {
                    Name = empName,
                    Address = empAddress,
                    Birthday = empBirthday,
                    Salary = empSalary
                });

                dataGridView1.DataSource = "";
                dataGridView1.DataSource = emps;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
