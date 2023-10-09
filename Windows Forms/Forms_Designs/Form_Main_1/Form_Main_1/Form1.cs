using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Form_Main_1
{
    public partial class formMain : Form
    {
        private Button currentButton;

        public formMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                rect.Location = new Point(0, 0);
                this.MaximizedBounds = rect;
                this.WindowState = FormWindowState.Maximized;
                //this.btnClose.BackColor = Color.Red;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formMain_Load(object sender, EventArgs e)
        {}

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            FormOnPanel(new Form2());
        }

        // method to create the sub Forms on the main form
        private void FormOnPanel(object formObj)
        {
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls.RemoveAt(0);
            }
            Form frm = formObj as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(frm);
            this.panelContent.Tag = formObj;
            frm.Show();
        }

        // method to change the back color of active button
        private void ActiveBtn(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableBtn();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(55, 85, 109);
                }
            }
        }

        // disable button that change the back color of button to main color
        private void DisableBtn()
        {
            foreach(Control prevControl in this.panelSideMenu.Controls)
            {
                if(prevControl.GetType() == typeof(Button))
                {
                    prevControl.BackColor = Color.FromArgb(80, 126, 162);

                }
            }
        }
    }
}
