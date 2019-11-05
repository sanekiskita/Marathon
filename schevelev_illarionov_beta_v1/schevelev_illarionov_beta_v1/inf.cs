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
    public partial class inf : Form
    {
        public inf()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label14.Text = t.Days.ToString() + Program.GetDeclension(Convert.ToInt32(t.Days.ToString()), " день ", " дня ", " дней ") + t.Hours.ToString() + Program.GetDeclension(Convert.ToInt32(t.Hours.ToString()), " час ", " часа ", " часов ") + t.Minutes.ToString() + Program.GetDeclension(Convert.ToInt32(t.Minutes.ToString()), " минута ", " минуты ", " минут ") + " до старта марафона!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            list_of_ch charity = new list_of_ch();
            charity.Show();
        }

        private void inf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
