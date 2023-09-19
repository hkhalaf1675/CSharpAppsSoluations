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

namespace RegisterationForm
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 5 && Regex.IsMatch(txtName.Text, @"^\d+$"))
            {
                lblNameError.Text = "";
                if (txtEmail.Text.Contains('@'))
                {
                    lblEmailError.Text = "";
                    if (checkFootball.Checked || checkSwimming.Checked || checkTennis.Checked)
                    {
                        lblHoppiesError.Text = "";
                        lblVaildRegister.Text = "Thank You , You regiteration is valid";
                    }
                    else
                    {
                        lblHoppiesError.Text = "You should check at least one hobby";
                    }
                }
                else
                {
                    lblEmailError.Text = "Email must have @";
                }
            }
            else
            {
                lblNameError.Text = "Namee must contain at least 5 chars and do not contain numbers";
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Length < 5 || Regex.IsMatch(txtName.Text, @"[^a-zA-Z]"))
            {
                lblNameError.Text = "Event on change or text change";
            }
            else
            {
                lblNameError.Text = "";
            }
        }
    }
}
