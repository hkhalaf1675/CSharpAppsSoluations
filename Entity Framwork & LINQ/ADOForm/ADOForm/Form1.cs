using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADOForm
{
    public partial class Form1 : Form
    {
        SqlConnection SqlCN;
        SqlCommand SqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sqlConnection(Data Source = servername; intial catalog = database;Integrated Security = true;")
            // Integrated Security = true --> mean Windows Auth
            // ................... = false --> sql auth

            SqlCN = new SqlConnection();
            //SqlCN.ConnectionString = "Data Source=.;Initial Catalog=World; Integrated Security=true";

            SqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["WorldConnection"].ConnectionString;

            SqlCN.StateChange += (sender, e) => label1.Text = $"Orginal State : {e.OriginalState} , to Current State : {e.CurrentState}";

            SqlCN.InfoMessage += (sender, e) => label2.Text = $"{e.Message}";

            SqlCmd = new SqlCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SqlCN.State == System.Data.ConnectionState.Closed)
            {
                SqlCN.Open();

            }
            SqlCmd.Connection = SqlCN;
            SqlCmd.CommandType = System.Data.CommandType.Text;
            SqlCmd.CommandText = "select COUNT(*) from Country";
            if (int.TryParse(SqlCmd.ExecuteScalar()?.ToString() ?? "0", out int num))
                label2.Text = $"Number of Countries is : {num}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SqlCN.State == System.Data.ConnectionState.Open)
            {
                SqlCN.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SqlCN.State == System.Data.ConnectionState.Closed)
                SqlCN.Open();


            SqlCmd.Connection = SqlCN;
            SqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

            #region Excute Update Procedure
            //SqlCmd.CommandText = "UpdateCountryNameByCode";
            //SqlCmd.Parameters.Add("@code", System.Data.SqlDbType.VarChar, 5);
            //SqlCmd.Parameters.Add("@newName", System.Data.SqlDbType.VarChar, 50);

            //SqlCmd.Parameters["@code"].Value = "ABW";
            //SqlCmd.Parameters["@newName"].Value = "ARRBAB";

            //int rowAffected = SqlCmd.ExecuteNonQuery();

            //label2.Text = $"Rows Affected : {rowAffected}"; 
            #endregion

            //SqlCmd.CommandText = ""

            SqlCN.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand SqlGetCountriesNamesCmd = new SqlCommand("select Name from Country", SqlCN);

            SqlCN.Open();

            SqlDataReader DR = SqlGetCountriesNamesCmd.ExecuteReader();


            while (DR.Read())
            {
                comboBox1.Items.Add(DR.GetString(0));
            }
            SqlCN.Close();
        }

        SqlDataAdapter DA;
        DataTable DT;
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand SqlCmdAdpater = new SqlCommand("select * from Country", SqlCN);

            DA = new SqlDataAdapter(SqlCmdAdpater);

            DT = new DataTable();

            DA.Fill(DT);

            label2.Text = DT.Rows.Count.ToString();

            listBox1.DataSource = DT;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Code";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedValue.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand SqlCmdAdpater = new SqlCommand("select * from Country", SqlCN);

            DA = new SqlDataAdapter(SqlCmdAdpater);

            DT = new DataTable();

            DA.Fill(DT);

            label2.Text = DT.Rows.Count.ToString();

            dataGridView1.DataSource = DT;
        }
    }
}