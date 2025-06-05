using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AdminSetting;
using AdminModels;
using AdminApp.DL;
using AdminApp.AdminBL;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto.Tls;
using MyApp.Namespace;
using Mysqlx;
using System.CodeDom;
namespace AdminApp
{
    public partial class login : Form
    {
        ConnectionSettings con = new();
        MenuForm menu = new();
        UserModels Models = new();






        //do not mess with 

        private readonly IAdminBL _repo;

        public login(IAdminBL p_name)
        {
            _repo = p_name;

        }
        /*string? username, password,rank;*/



        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Close();
            Environment.Exit(0);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            Environment.Exit(0);
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            // MySqlConnection con = new();
            string connectionString = "Server=localhost;Uid=root;Pwd=Hawaii12!;Database=test;";
            string saltpass = ComputePassHash(password_txt.Text);
            
            if (username_txt.Text != "" && password_txt.Text != "")
            {
                List<UserModels> listOfUsers = new List<UserModels>();
                string SQLQuery = @"select * from users ";
                
                using (MySql.Data.MySqlClient.MySqlConnection con = new(connectionString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        MySqlCommand cmd = new MySqlCommand(SQLQuery, con);
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
                    }
                    else
                    {
                        MessageBox.Show("Error, No Connection Established", "Error");
                    }
                }/*
                MySqlCommand cmd = new MySqlCommand(SQLQuery, con);
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
                */               
                
                UserModels users = new UserModels();
                MessageBox.Show(users.ToString());
                string password = password_txt.ToString();

                if (users != null)
                {
                   
                    
                    if (password_txt.ToString() == users.password.ToString())
                    {
                        if (users.username.ToString() == username_txt.ToString())
                        {
                            if (users.rank.ToString() == "Admin")
                            {
                                this.Hide();
                                menu.ShowDialog();
                                IsValid = true;
                            }
                            else
                            {
                                Log.Information("Not autherized user attempted to access page", "Information");
                                MessageBox.Show("Only Admins can access this page", "Warning");
                            }
                        }
                                      
                     }
                    else
                        {
                            MessageBox.Show("Invalid Password!", "Warning");
                            Log.Information("User entered the wrong password, They had to try again", "Information");
                        }   
                       
                }
                else
                {
                    MessageBox.Show("No Account found.", "Information");
                    this.Show();
                }
            }

            else
            {
                MessageBox.Show("Username or Password is empty.", "Information");
            }

            /*catch(Exception er)
 {
     MessageBox.Show("Connection Error." + er.Message + "Information");
 }*/


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        static string ComputePassHash(string rawData)
        {
            using (SHA256 pashash = SHA256.Create())
            {
                byte[] passbyte = pashash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new();
                for (int i = 0; i < passbyte.Length; i++)
                {
                    builder.Append(passbyte[i].ToString("x2"));
                }
                MessageBox.Show(builder.ToString());
                return builder.ToString();
            }
        }
    }
}
    