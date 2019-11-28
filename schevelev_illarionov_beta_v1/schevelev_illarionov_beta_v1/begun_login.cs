using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schevelev_illarionov_beta_v1
{
    public partial class begun_login : Form
    {
        public begun_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string email = textBox1.Text;
                string connectionString = null;
                SqlCommand cmd;
                SqlConnection con;

                connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Shevelev__Illarionov;User ID=student;Password=student");
                con = new SqlConnection(connectionString);
                con.Open();
                string potkl;
                potkl = "select Email, Password ,RoleID  From [User] where Email='" + email+"'";
                cmd = new SqlCommand(potkl, con);


                string password="";
                string role="";
               
                SqlDataReader reader = cmd.ExecuteReader();

             
                    while (reader.Read())
                    {

                        //email = reader[0].ToString();
                         password = reader[1].ToString();
                         role = reader[2].ToString();
                    }
                    reader.Close();

                    if (textBox2.Text == password)
                    {
                        if (role == "R")
                        {
                            this.Hide();
                            Runner_menu mn_r = new Runner_menu();
                            mn_r.Show();
                        }
                        if (role == "C")
                        {
                            this.Hide();
                            Coord_menu mn_r2 = new Coord_menu();
                            mn_r2.Show();
                            //coordinatro
                        }
                        if (role == "A")
                        {
                            this.Hide();
                            adm_menu mn_r1 = new adm_menu();
                            mn_r1.Show();
                           //administrator
                        }
                    }
                
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void begun_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label4.Text = t.Days.ToString() + Program.GetDeclension(Convert.ToInt32(t.Days.ToString()), " день ", " дня ", " дней ") + t.Hours.ToString() + Program.GetDeclension(Convert.ToInt32(t.Hours.ToString()), " час ", " часа ", " часов ") + t.Minutes.ToString() + Program.GetDeclension(Convert.ToInt32(t.Minutes.ToString()), " минута ", " минуты ", " минут ") + " до старта марафона!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bez_sms_i_registracii free = new bez_sms_i_registracii();
            free.Show();
        }
    }
}
