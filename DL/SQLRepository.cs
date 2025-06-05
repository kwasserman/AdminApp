using AdminModels;
using AdminSetting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp.DL
{
    public class SQLRepository
    {
        private readonly string _connectionString;
        public SQLRepository(string p_connectionString)
        {
            _connectionString = p_connectionString;
        }

        public List<UserModels> GetAllUsers()
        {
            List<UserModels> listOfUsers = new List<UserModels>();
            string SQLQuery = @"select * from users ";

       
                //con.Open();
                MySqlCommand cmd = new MySqlCommand(SQLQuery);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listOfUsers.Add(new UserModels()
                    {
                        username = reader.GetString(0),
                        password = reader.GetString(1),
                        rank = reader.GetString(2)
                    });
                }
            
            return listOfUsers;
        }
    }
}
