using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkedListTrainees.SelectedItem != null)
            {
                checkedListLab.Items.Add(checkedListTrainees.SelectedItem);
                checkedListTrainees.Items.Remove(checkedListTrainees.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var items = checkedListTrainees.CheckedIndices;
            for(int i=items.Count-1; i>=0; i--)
            {
                checkedListLab.Items.Add(checkedListTrainees.Items[items[i]]);
                checkedListTrainees.Items.Remove(checkedListTrainees.Items[items[i]]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListLab.SelectedItem != null)
            {
                checkedListTrainees.Items.Add(checkedListLab.SelectedItem);
                checkedListLab.Items.Remove(checkedListLab.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var items = checkedListLab.CheckedIndices;
            for (int i = items.Count - 1; i >= 0; i--)
            {
                checkedListTrainees.Items.Add(checkedListLab.Items[items[i]]);
                checkedListLab.Items.Remove(checkedListLab.Items[items[i]]);
            }
        }
    }
}
