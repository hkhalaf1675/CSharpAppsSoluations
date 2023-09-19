using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigments_GUI
{
    public partial class Converter_Form : Form
    {
        public Converter_Form()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(double.TryParse(ValueText.Text, out double val))
            {
                if (radioMeterToKilo.Checked)
                {
                    ResultText.Text = (val / 1000).ToString();
                }
                else if (radioMeterToMile.Checked)
                {
                    ResultText.Text = $"{val / 1609.34 : 0.000}";
                }
                else if (radioMileToMeter.Checked)
                {
                    ResultText.Text = $"{val * 1609.34: 0.000}";
                }
                else
                {
                    MessageBox.Show("Plz check type of convert");
                }
            }
            else
            {
                MessageBox.Show("Plz Sure that you enter a number!");
            }
            
        }
    }
}
