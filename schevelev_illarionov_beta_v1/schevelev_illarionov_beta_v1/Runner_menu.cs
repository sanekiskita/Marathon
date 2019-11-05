using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schevelev_illarionov_beta_v1
{
    public partial class Runner_menu : Form
    {
        public Runner_menu()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            begun_login main = new begun_login();
            main.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void Runner_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
