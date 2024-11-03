using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;

namespace AdminApp
{
    public partial class MenuForm : Form
    {
        Connections con = new();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ValidLogin == true)
            {
                this.Hide();
                Form1 login = new();
                login.ShowDialog();


                con.Close();
            }
        }
    }
}
