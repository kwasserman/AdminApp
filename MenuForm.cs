using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSetting;

namespace AdminApp
{
    public partial class MenuForm : Form
    {
        ConnectionSettings con = new();
        System.DateTime date = System.DateTime.Now;




        public MenuForm()
        {

            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            login login = new();
            login.ShowDialog();


            con.Close();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginForm = new login();

            try
            {

                Log.Information("User has tried to get,set,or retrevie news from site. Date : " + date);

                Panel newsPanel = new();

                newsPanel.Location = new System.Drawing.Point(0, 27);
                newsPanel.Name = "News";
                newsPanel.Size = new System.Drawing.Size(800, 411);
                newsPanel.TabIndex = 0;
                newsPanel.Show();
                this.Focus();

                Controls.Add(newsPanel);

            }
            catch (Exception er)
            {
                MessageBox.Show("Information", "An Error has occured. Date: " + date + "Error: " + er.Message);
                Log.Information("An Error has occured. Date: " + date + "Error: " + er.Message);
                
            }

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
