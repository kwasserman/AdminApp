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
using System.Drawing.Text;
namespace AdminApp
{
    public partial class login : Form
    {
        ConnectionSettings con = new();
        MenuForm menu = new();
        UserModels Models = new();
        public bool IsValid = false;






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
            /*The Below method logs in admin users. The fuction allows admins of a virtual airlines to be able to update news to the respeacted airlines website.
             Do not mess with the function below unless you know what you are doing! it will break the program*/
            string connectionString = "Server=localhost;Uid=root;Pwd=Hawaii12!;Database=test;";



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
                            //Gets the current list of users allowed to access the sites administration side and stores it in a model for the program to use later
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
                }

                UserModels users = new UserModels();
                string password = password_txt.Text;
                string username = username_txt.Text;

                if (users != null)
                {


                    if (password == users.password)
                    {
                        if (users.username.ToString() == username)
                        {
                            if (users.rank.ToString() == "Admin")
                            {
                                this.Hide();
                                menu.ShowDialog();
                                IsValid = true;
                            }
                            else
                            {
                                Log.Information("Non-autherized user attempted to access page", "Information");
                                MessageBox.Show("Only Admins can access this page", "Warning");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username, Please try again");
                            Log.Information("An incorrect username was entered, No such username was found");
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
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    