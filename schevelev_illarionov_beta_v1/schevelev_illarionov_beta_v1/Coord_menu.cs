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
    public partial class Coord_menu : Form
    {
        public Coord_menu()
        {
            InitializeComponent();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label14.Text = t.Days.ToString() + Program.GetDeclension(Convert.ToInt32(t.Days.ToString()), " день ", " дня ", " дней ") + t.Hours.ToString() + Program.GetDeclension(Convert.ToInt32(t.Hours.ToString()), " час ", " часа ", " часов ") + t.Minutes.ToString() + Program.GetDeclension(Convert.ToInt32(t.Minutes.ToString()), " минута ", " минуты ", " минут ") + " до старта марафона!";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            begun_login main = new begun_login();
            main.Show();
        }
    }
}
