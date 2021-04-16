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
    public partial class AdaugaParcela : Form
    {
        public AdaugaParcela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inserare

            String ins = "";
            ins = ins + "INSERT INTO PARCELA(SUPRAFATA,ARABIL,BLOC_FIZIC_ID) VALUES (";

            ins = ins + "'" + supr.Text + "','" + arab.Text + "','" + blocF.SelectedValue.ToString() + "');";


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

        private void AdaugaParcela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BLOC_FIZIC' table. You can move, or remove it, as needed.
            this.bLOC_FIZICTableAdapter.Fill(this.dataSet1.BLOC_FIZIC);

        }
    }
}
