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
    public partial class Register_as_a_runner4 : Form
    {
        public Register_as_a_runner4()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void Register_as_a_runner4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label14.Text = t.Days.ToString() + Program.GetDeclension(Convert.ToInt32(t.Days.ToString()), " день ", " дня ", " дней ") + t.Hours.ToString() + Program.GetDeclension(Convert.ToInt32(t.Hours.ToString()), " час ", " часа ", " часов ") + t.Minutes.ToString() + Program.GetDeclension(Convert.ToInt32(t.Minutes.ToString()), " минута ", " минуты ", " минут ") + " до старта марафона!";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((tb_email.Text != "Введите email") && (tb_Pass.Text == tb_povtpass.Text) && (tb_Pass.Text != "******") && (tb_name.Text != null) && (tb_lastname.Text != null))
            {

                try
                {

                  

                        // MessageBox.Show("Jib,rf <!");
                        string connectionString = null;
                        SqlCommand cmd;
                        SqlConnection con;
                        string rol = "R";
                        connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Shevelev__Illarionov;User ID=student;Password=student");
                        con = new SqlConnection(connectionString);
                        con.Open();


                        string connectionString2 = null;
                        SqlCommand cmd2;
                        SqlConnection con2;
                       
                        connectionString2 = ("Data Source=127.0.0.1;Initial Catalog=g464_Shevelev__Illarionov;User ID=student;Password=student");
                        con2 = new SqlConnection(connectionString);
                        con2.Open();

                        cmd2 = new SqlCommand("Insert INTO [User](Email, Password, FirstName, LastName, RoleId) values(@email,@passw,@FN,@LN,@roll)", con);

                        cmd2.Parameters.AddWithValue("@email", tb_email.Text);
                        cmd2.Parameters.AddWithValue("@passw", tb_Pass.Text);
                        cmd2.Parameters.AddWithValue("@FN", tb_name.Text);
                        cmd2.Parameters.AddWithValue("@LN", tb_lastname.Text);
                        cmd2.Parameters.AddWithValue("@roll", rol);

                        cmd2.ExecuteNonQuery();
                    //

                        cmd = new SqlCommand("Insert INTO Runner(Email, Gender, DateOfBirth,CountryCode,Runner_img) values(@email,@gender,@Date,@cou,@img)", con);

                        cmd.Parameters.AddWithValue("@email", tb_email.Text);
                        cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@date", dtp_day.Value);
                        cmd.Parameters.AddWithValue("@cou", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@img", tb_file.Text);


                        cmd.ExecuteNonQuery();


                        this.Hide();
                        Runner_menu mn_r = new Runner_menu();
                        mn_r.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка данных!");
                }
                
            }
                
            else
                MessageBox.Show("Ошибка данных!");
        }

        private void Register_as_a_runner4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_Shevelev__IllarionovDataSet2.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.g464_Shevelev__IllarionovDataSet2.Country);
            // TODO: This line of code loads data into the 'g464_Shevelev__IllarionovDataSet1.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.g464_Shevelev__IllarionovDataSet1.Gender);


          int mou = Convert.ToInt32(DateTime.Now.Month);
          int years = Convert.ToInt32(DateTime.Now.Year);
          int days = Convert.ToInt32(DateTime.Now.Day);
          years = years - 15;
            DateTime date1 = new  DateTime(years,mou,days);
            dtp_day.MaxDate=date1;

            years = years - 100;
            DateTime date2 = new DateTime(years, mou, days);
            dtp_day.MinDate = date2;


            tb_email.Text = "Введите email";
            tb_email.ForeColor = Color.Gray;
            tb_Pass.Text = "******";
            tb_Pass.ForeColor = Color.Gray;
            tb_povtpass.Text = "******";
            tb_povtpass.ForeColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_file.ReadOnly=false;
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png , *jpeg)|*.bmp;*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            else
            {
                tb_file.ReadOnly = false;
                tb_file.Text = "";
                pictureBox1.ImageLocation = "";
                return;
            }

            tb_file.Text = filePath;
            pictureBox1.ImageLocation = filePath;
            tb_file.ReadOnly = true;
        }

 

        private void tb_email_Enter(object sender, EventArgs e)
        {
            if (tb_email.Text == "Введите email")
            {
                tb_email.Clear();
                tb_email.ForeColor = Color.Black;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_email.Text))
            {
                tb_email.Text = "Введите email";
                tb_email.ForeColor = Color.Gray;
            }
        }

        private void tb_Pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Pass.Text))
            {
                tb_Pass.Text = "******";
                tb_Pass.ForeColor = Color.Gray;
            }
        }

        private void tb_Pass_Enter(object sender, EventArgs e)
        {
            if (tb_Pass.Text == "******")
            {
                tb_Pass.Clear();
                tb_Pass.ForeColor = Color.Black;
            }
        }

        private void tb_povtpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_povtpass.Text))
            {
                tb_povtpass.Text = "******";
                tb_povtpass.ForeColor = Color.Gray;
            }
        }

        private void tb_povtpass_Enter(object sender, EventArgs e)
        {
            if (tb_povtpass.Text == "******")
            {
                tb_povtpass.Clear();
                tb_povtpass.ForeColor = Color.Black;
            }
        }

        private void dtp_day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_Pass_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
