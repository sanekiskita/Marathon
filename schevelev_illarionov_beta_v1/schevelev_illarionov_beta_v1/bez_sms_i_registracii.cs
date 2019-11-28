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
    public partial class bez_sms_i_registracii : Form
    {
        public bez_sms_i_registracii()
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
    }
}
