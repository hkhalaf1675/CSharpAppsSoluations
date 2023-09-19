using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_Lab_WinForm_2
{
    public partial class FrmDialog : Form
    {
        int fontSize;
        string fontFamily;
        bool fontBold;
        bool fontItalic;
        bool fontUnderline;


        Form1 formObj;


        public FrmDialog(Form1 obj)
        {
            InitializeComponent();
            formObj = obj;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupFormat_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDialog_Load(object sender, EventArgs e)
        {
            string[] fontFamilies = new string[]
            {
                "Arial",
                "Calibri",
                "Batang",
                "Chiller"
            };

            comboFontFamily.Items.AddRange(fontFamilies);
            comboFontFamily.SelectedIndex = 0;
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if(txtFontSize.Text.Length == 0 && !radioBlue.Checked && !radioGreen.Checked && !radioRed.Checked)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                if (int.TryParse(txtFontSize.Text ,out fontSize)){
                    
                }
                else
                {
                    MessageBox.Show("Plz Enter a valid Number");
                }

                if (comboFontFamily.SelectedIndex == 0)
                    fontFamily = "Arial";
                else if (comboFontFamily.SelectedIndex == 1)
                    fontFamily = "Calibri";
                else if (comboFontFamily.SelectedIndex == 2)
                    fontFamily = "Batang";
                else if (comboFontFamily.SelectedIndex == 3)
                    fontFamily = "Chiller";
                else
                    MessageBox.Show("Plz Select  valid font family");

                if (radioBlue.Checked)
                    formObj.txColortPto = Color.Blue;
                else if (radioGreen.Checked)
                    formObj.txColortPto = Color.Green;
                else if (radioRed.Checked)
                    formObj.txColortPto = Color.Red;


                if (checkBold.Checked)
                    fontBold = true;
                if (checkItalic.Checked)
                    fontItalic = true;
                if (checkUnderline.Checked)
                    fontUnderline = true;

                
                formObj.txtfontPto = new Font(fontFamily, fontSize,style:fontBold == true ? FontStyle.Bold:fontItalic==true?FontStyle.Italic:fontUnderline==true?FontStyle.Underline:FontStyle.Regular);
                
                

                this.Close();
            }
        }
    }
}
