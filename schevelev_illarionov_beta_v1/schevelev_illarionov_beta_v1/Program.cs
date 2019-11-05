using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schevelev_illarionov_beta_v1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         public static DateTime start = new DateTime(2020, 10, 30, 12, 00, 00);
         public static int x=1, y=10; 

         public static string GetDeclension(int number, string nominativ, string genetiv, string plural)
         {

             number = number % 100;

             if (number >= 11 && number <= 19)
             {
                 return plural;
             }

             var i = number % 10;
             switch (i)
             {
                 case 1:
                     return nominativ;
                 case 2:
                 case 3:
                 case 4:
                     return genetiv;
                 default:
                     return plural;
             }
         }

         public static string don ;
         public static string name_uch;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        


        //[STAThread]
     
    }
}
