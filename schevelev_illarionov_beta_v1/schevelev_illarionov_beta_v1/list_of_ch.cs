using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schevelev_illarionov_beta_v1
{
    public partial class list_of_ch : Form
    {
        public list_of_ch()
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
            inf info = new inf();
            info.Show();
        }

        private void list_of_ch_Load(object sender, EventArgs e)
        {
            int n = 5;

            string connectionString = null;
            SqlCommand cmd;
            SqlConnection con;

            connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Shevelev__Illarionov;User ID=student;Password=student");
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("SELECT CharityName ,CharityDescription ,CharityLogo FROM Charity", con);
           // cmd.ExecuteNonQuery();



             List<string[]> data = new List<string[]>();
             SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString(); 
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            




           // Color[] bg = new Color[] { Color.Red, Color.Green, Color.Red, Color.Green, Color.Red };
           // string[] t1 = new string[] { data[0][0], "a", "a", "a", "b" };
          //  string[] t2 = new string[] { data[0][1], "2", "3", "4", "5" };
            int lg = data.Count;
            for( int i =0;i<lg;i++)
            {
                int j=0;
                    UserControl1 ctl = new UserControl1();
                    ctl.setup(data[i][j+2], data[i][j], data[i][j + 1]);
                    flowLayoutPanel1.Controls.Add(ctl);
                
            }
        }

        private void list_of_ch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
