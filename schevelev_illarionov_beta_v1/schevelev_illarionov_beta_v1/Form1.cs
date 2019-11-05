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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        } 
        
         

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan t = Program.start - DateTime.Now;

            // _  _  _  _  _  _  _  _  _ 
           // │†││†││†││†││†││†││†││†││†│
           // ☺
         //  /|\
//           / \

            label4.Text = t.Days.ToString() + Program.GetDeclension(Convert.ToInt32(t.Days.ToString()), " день ", " дня ", " дней ") + t.Hours.ToString() + Program.GetDeclension(Convert.ToInt32(t.Hours.ToString()), " час ", " часа ", " часов ") + t.Minutes.ToString() + Program.GetDeclension(Convert.ToInt32(t.Minutes.ToString()), " минута ", " минуты ", " минут ") + " до старта марафона!";
        }

        private void btn_spn_beguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            sponsor_a_runner6 sponsor = new sponsor_a_runner6();
            sponsor.Show();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_begun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 register = new Form2();
            register.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_inf_Click(object sender, EventArgs e)
        {
            this.Hide();
            inf info = new inf();
            info.Show();
        }


    }
}
