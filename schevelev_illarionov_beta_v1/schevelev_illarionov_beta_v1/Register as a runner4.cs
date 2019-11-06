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
            if ((tb_email.Text != null) && (tb_Pass.Text == tb_povtpass.Text) && (tb_Pass.Text != null) && (tb_name.Text != null) && (tb_lastname.Text != null))
            {
                this.Hide();
                Runner_menu mn_r = new Runner_menu();
                mn_r.Show();
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

       
    }
}
