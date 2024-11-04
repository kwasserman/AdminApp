using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AdminApp
{
    public partial class Form1 : Form
    {
        connection con = new connection();
        string username, password,rank;

        
        
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

        private void login_Btn_Click(object sender, EventArgs e)
        {
            string user = username_txt.ToString();
            string pass = password_txt.ToString();
            try
            {
                if (username_txt.Text != "" && password_txt.Text != "")
                {

                    con.Open();
                    string query = "select * from users Where username = '" + username_txt.Text + "'AND password = '" + password_txt.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                            rank = row["roles"].ToString();
                            
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No Data found", "Information");
                    }
                    MessageBox.Show(username + password);
                    /*if (user.ToString() == username && pass.ToString() == password)
                    {*/
                        
                         MenuForm menu = new();
                        this.Hide();
                        menu.ShowDialog();
                        
                   /* }
                    else
                    {
                        this.Show();
                    }*/
                       
                    

                }
                else
                {
                    MessageBox.Show("Username or Password is empty.", "Information");
                }

            }
            catch(Exception er)
            {
                MessageBox.Show("Connection Error." + er.Message + "Information");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}