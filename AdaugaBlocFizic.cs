using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace tema_bd
{
    public partial class AdaugaBlocFizic : Form
    {
        public AdaugaBlocFizic()
        {
            InitializeComponent();
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ins = "";
            ins = ins + "INSERT INTO BLOC_FIZIC(DENUMIRE,SUPRAFATA) VALUES (";

            ins = ins + "'" + denumire.Text + "','" + suprafata.Text + "');";


            OdbcCommand com = new OdbcCommand();
            com.CommandText = ins;
            com.Connection = MainWindow.con;
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception eee)
            {
                Console.WriteLine("Date Eronate!");
                Console.WriteLine(eee.Message);
            }
            Console.WriteLine(ins);


            this.Close();
        }
    }
}
