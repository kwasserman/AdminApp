using MySql.Data.MySqlClient;



namespace AdminApp
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
        }
        class connection
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString;
            static string host = "localhost";
            static string database = "testDB";
            static string userDB = "root";
            static string passwordDB = "root";
            public static string Provider = "server=" + host +";Database=" + database + ";User ID=" + userDB + ";Password=" + passwordDB;

            public bool Open()
            {
                try
                {
                    Provider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + passwordDB;
                    conn = new MySqlConnection(Provider);
                    conn.Open();
                    return true;
                }
                catch(Exception er)
                {
                    MessageBox.Show("Connection Error! " + er.Message + "Information");
                }
                return false;
            }
            public void Close()
            {
                conn.Close();
                conn.Dispose();
            }

            public MySqlDataReader ExecuteReader(string sql)
            {
                try
                {
                    MySqlDataReader reader;
                    MySqlCommand command = new MySqlCommand(sql, conn);
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
                    MySqlTransaction myTransaction = conn.BeginTransaction();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    affected = cmd.ExecuteNonQuery();
                    myTransaction.Commit();
                    return affected;
                }
                catch( Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
                return -1;
            }
        }
    }
}