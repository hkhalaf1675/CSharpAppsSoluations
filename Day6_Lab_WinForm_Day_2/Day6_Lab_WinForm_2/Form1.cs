namespace Day6_Lab_WinForm_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FrmDialog frm;

        public Font txtfontPto { get { return txtText.Font; } set  { txtText.Font=value; } }
        public Color txColortPto { get { return txtText.ForeColor; } set  { txtText.ForeColor=value; } }
        
        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Length == 0)
            {
                MessageBox.Show("Plz Enter Text !");

            }
            else
            {
                frm = new FrmDialog(this);
                frm.ShowDialog();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}