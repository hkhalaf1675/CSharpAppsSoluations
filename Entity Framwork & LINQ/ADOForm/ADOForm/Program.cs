using System.Data.SqlClient;
namespace ADOForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            // ADO : 
            // ------>> SQL Connection
            // ------------>> SQL Command : { connected mode , disconnected mode }
            // ------------------>> Connected Mode : read only , only select , SQL Data Reader
            // ------------------>> Disconnected Mode : read & write , SQL Data  Adapter
            // ---------------------->>> SQLDataAdapter : 4 SQL Commands : Select , Insert ,Delete ,Update
            // --------------------------->> recive data from server { Data set , Date Table }
            // 

            // sql connection
            // --> 1- install system.data.sqlclient from nuget packages manager
            // --> 2- using System.Data.SqlClient
            // --> 3- create the connection to database server : 
            // --------------->>> SqlConnection SqlCN = new SqlConnection();
            // --------------->>> SqlCN.ConnectionString = "Data Source=serever name; Initial Catalog = inital database name; Integrated Security = true & false; if false -> User Id = sql user name; Passsword = pass";
            // --------------->>> SqlCN.Open(); to open connection
            // --------------->>> SqlCN.Close(); to close connection
            // --------------->>> SqlCN.Dispose(); to close the connection before close the app { you don't know if the connnection is open or no}
            // --------------->>> SqlCN.State = System.Data.ConnectionState.Closed; to use it in if condition to check the state of connection
            // --------------->>> SqlCN.State = System.Data.ConnectionState.Open; to use it in if condition to check the state of connection
            // --> 2- the type of sql command 
            // ----------------->>> 1- CommandType.Text : {if it is a query like select}
            // ------------------------>> sqlCmd.CommandText = "select COUNT(*) from Country";
            // ----------------->>> 2- CommandType.StoredProcedure : {if it procedure}

            // Data Adapter : it is to execute the sqlcmd and recive all data { it will return column s and rows }
            // in disconnected { can save the data on data table or data set }
            // the Adapter manage the connection { openning and closing }
            
        }
    }
}