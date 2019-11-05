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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g284_l09_Grigoreva_VinogradovaDataSet.Planet' table. You can move, or remove it, as needed.
            this.planetTableAdapter.Fill(this.g284_l09_Grigoreva_VinogradovaDataSet.Planet);
            this.Width = 450;
            this.Height = 400;
            this.Text = "Односторонее связывание:" + "базы данных и элементы Gird";
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }         
        private void button1_Click_1(object sender, EventArgs e)

        {
            string str = "Data Source=127.0.0.1;Initial Catalog=g284_l09_Grigoreva_Vinogradova;User ID=student;Password=student";

            SqlConnection con = new SqlConnection(str);
            con.Open();

    

            string sql = "SELECT PlanetName, DistanceFromSun FROM planet;";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())

            {
        string name = rdr.GetString(0);
        double dist = rdr.GetDouble(1);

        MessageBox.Show(name + ";" + dist.ToString());

            }

            rdr.Close();
            con.Close();
        }
     
    }
}
