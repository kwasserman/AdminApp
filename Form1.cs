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

        private void login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_txt.Text != "" && password_txt.Text != "")
                {

                    con.Open();
                    string query = "select * from users Where pilot_id = '" + username_txt.Text + "'AND password = '" + password_txt.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            Name = row["Name"].ToString();
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                            PilotId = row["pilot_id"].ToString();
                        }
                        Program.ValidLogin = true;
                        MenuForm menu = new MenuForm();
                        this.Hide();
                         menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No Account found. Please register on our website." + "<a href='http://www.springsairairlines.com'>SpringsAir</a>" , "Information");
                        ShowDialog();
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