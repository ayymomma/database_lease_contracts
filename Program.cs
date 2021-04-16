using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace tema_bd
{
    static class Program
    {

        public static MainWindow mw;

        [STAThread]
        static void Main()
        { 
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mw = new MainWindow();
            Application.Run(mw);
        }
    }
}
