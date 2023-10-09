using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer=new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.PerformStep();
            else
                timer.Stop();
            //throw new NotImplementedException();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // timer
            //while(progressBar1.Value < progressBar1.Maximum)
            //{
            //    progressBar1.PerformStep();
            //    await Task.Delay(1000);
            //}
                
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer.Interval=1000 - trackBar1.Value*100;
        }

        async void ProgressBarSpeed(int speed)
        {
            await Task.Delay(1000);
            
        }
    }
}
