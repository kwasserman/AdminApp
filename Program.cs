using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;



namespace AdminApp
{
    class connection
    {
        MySql.Data.MySqlClient.MySqlConnection con;
        string myConnString;
        static string host = "localhost";
        static string database = "test";
        static string userDB = "root";
        static string passwordDB = "Hawaii12!";
        public static string Provider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + passwordDB;

        public bool Open()
        {
            try
            {
                Provider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + passwordDB;
                con = new MySqlConnection(Provider);
                con.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error! " + er.Message + "Information");
            }
            return false;
        }
        public void Close()
        {
            con.Close();
            con.Dispose();
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand command = new MySqlCommand(sql, con);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction myTransaction = con.BeginTransaction();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                myTransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
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
                
               
          
            
            
        }
        
    }
}