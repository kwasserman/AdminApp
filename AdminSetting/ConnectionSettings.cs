using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminApp;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using AdminModels;

namespace AdminSetting
{
    public class ConnectionSettings
    {
        MySqlConnection con = new();

        string host = "localhost";
        string database = "test", userDB = "root", passwordDB = "Hawaii12!";
        string? Provider;
        System.DateTime date = System.DateTime.Now;
        //string username = users.username;

        //Opens the connection to the database for it to get the users information
        //will be logged for security and training and development purposes
        public bool Open()
        {

            try
            {
                
                Provider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + passwordDB;
                con = new MySqlConnection(Provider);
                con.Open();
                Log.Information("A connection was successfully made. Date: " + date);
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error! " + er.Message + "Information");
                Log.Information(er.Message + "/br Error was made on " + date);
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
}
