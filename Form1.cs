using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminApp
{
    public partial class Form1 : Form
    {
        Connection con = new Connection();
        string username, password,PilotId;
        

        

        public Form1()
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

        public void login_Btn_Click(object sender, EventArgs e)
        {
            string passtext = password_txt.ToString();
            string passhash = password.GetHashCode().ToString();
            //MessageBox.Show(passhash,"Warning")
            
                try
                {
                    if (username_txt.Text != "" && password_txt.Text != "")
                    {

                        con.Open();
                        string query = "select * from users Where pilot_id = '" + username_txt.Text + "'AND password = '" + password_txt.Text + "'";
                        MySqlDataReader data;
                        data = con.ExecuteReader(query);
                        MenuForm menu = new MenuForm();
                         while (data.Read())
                            {
                                Name = data["Name"].ToString();
                                username = data["username"].ToString();
                                password = data["password"].ToString();
                                PilotId = data["pilot_id"].ToString();
                            }
                            
                            if (data.HasRows)
                            {
                           
                            Program.ValidLogin = true;
                            }
                            else
                            {
                                MessageBox.Show("No Account found. Please register on our website." , "Information");
                                ShowDialog();
                            

                            if(Program.ValidLogin == true && password == passhash)
                            {
                            this.Hide();
                            menu.ShowDialog();  
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login. Please try again", "Warning");
                                this.Show();
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is empty.", "Information");
                    }

                }
                catch
                {
                    MessageBox.Show("Connection Error.", "Information");
                }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}