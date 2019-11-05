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
    public partial class sponsor_a_runner6 : Form
    {
        public sponsor_a_runner6()
        {
            InitializeComponent();
        }

        int zap;



        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void sponsor_a_runner6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        string mou;
        string years;
        private void t_Tick(object sender, EventArgs e)
        {
             int  z= 1;
            TimeSpan t = Program.start - DateTime.Now;
            mou = DateTime.Now.Month.ToString();
            years = DateTime.Now.Year.ToString();

            label14.Text = t.Days.ToString() + Program.GetDeclension(Convert.ToInt32(t.Days.ToString()), " день ", " дня ", " дней ") + t.Hours.ToString() + Program.GetDeclension(Convert.ToInt32(t.Hours.ToString()), " час ", " часа ", " часов ") + t.Minutes.ToString() + Program.GetDeclension(Convert.ToInt32(t.Minutes.ToString()), " минута ", " минуты ", " минут ") + " до старта марафона!";

            if (tb_pay_am.Text != label13.Text)
            {
                label13.Text = tb_pay_am.Text ;
            }
            if (label13.Text == "")
            {
                
            }
            if (int.Parse(tb_pay_am.Text) < 1  )
            {
                label13.Text = z.ToString() ;
                tb_pay_am.Text = z.ToString();
            }

            zap = int.Parse(tb_pay_am.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int t = int.Parse(tb_pay_am.Text);
            tb_pay_am.Text = (t + 10).ToString();
            label13.Text = (int.Parse(label13.Text) + 10).ToString() ;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int t = int.Parse(tb_pay_am.Text);
            tb_pay_am.Text = (t - 10).ToString();
            label13.Text = (int.Parse(label13.Text) - 10).ToString();
            
        }

        private void tb_pay_am_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                int s = Convert.ToInt32(tb_pay_am.Text);
            }
            catch (System.FormatException)
            {
                label13.Text = zap.ToString();
                tb_pay_am.Text = zap.ToString();
            }
           
        }

        private void sponsor_a_runner6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_Shevelev__IllarionovDataSet.name_runner' table. You can move, or remove it, as needed.
            this.name_runnerTableAdapter.Fill(this.g464_Shevelev__IllarionovDataSet.name_runner);
            tb_name.Text = "Введите имя";
            tb_name.ForeColor = Color.Gray;
            tb_card.Text = "Введите фамилию и имя";
            tb_card.ForeColor = Color.Gray;
        }

        private void tb_card_Enter(object sender, EventArgs e)
        {
            if (tb_card.Text == "Введите фамилию и имя")
            {
                tb_card.Clear();
                tb_card.ForeColor = Color.Black;
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

            
            if ((maskedTextBox3.Text == "") && (maskedTextBox2.Text == "") && (tb_name.Text == "Введите имя") )MessageBox.Show("DANNIE NOT VVEDENI ");
            else
            {
                try
                {
                    int sum = Convert.ToInt32(maskedTextBox3.Text);
                    int sum2 = Convert.ToInt32(maskedTextBox2.Text);
                    if (Convert.ToDouble(label13.Text) > 0  && Convert.ToInt32(maskedTextBox2.Text) >= Convert.ToInt32(mou)  && Convert.ToInt32(maskedTextBox3.Text) >= Convert.ToInt32(years))
                    {

                       // MessageBox.Show("Jib,rf <!");
                        string connectionString = null;
                        SqlCommand cmd;
                        SqlConnection con;

                        connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Shevelev__Illarionov;User ID=student;Password=student");
                        con = new SqlConnection(connectionString);
                        con.Open();
                        cmd = new SqlCommand("Insert INTO Sponsorship(SponsorName, RegistrationId, Amount) values(@name,@id,@amount)", con);
                     
                        cmd.Parameters.AddWithValue("@name", tb_name.Text);
                        cmd.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@amount", label13.Text);
                        

                        cmd.ExecuteNonQuery();

                        Program.don = label13.Text;
                        Program.name_uch = comboBox1.Text;
                        
                        this.Hide();
                        sponsorship_confirm sponsorship_conf = new sponsorship_confirm();
                        sponsorship_conf.Show();
                    }
                    else { MessageBox.Show("Данные введены неверно!"); }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка данных!");
                }
            }



         
        }

        private void btn_cncl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                tb_name.Text = "Введите имя";
                tb_name.ForeColor = Color.Gray;
            }
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == "Введите имя")
            {
                tb_name.Clear();
                tb_name.ForeColor = Color.Black;
            }
        }

        private void tb_card_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_card.Text))
            {
                tb_card.Text = "Введите фамилию и имя";
                tb_card.ForeColor = Color.Gray;
            }
        }


    }
}
