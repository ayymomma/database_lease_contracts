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

//main

namespace tema_bd
{
    public partial class MainWindow : Form
    {
        private static string conectiune = "dsn=Baza_Date_Contracte_Arenda;UID=tema_bd;PWD=temabd;";

        public static OdbcConnection con = new OdbcConnection(conectiune);

        public MainWindow()
        {
            InitializeComponent();
            con.Open();
            //con.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Persoana participanti = new Persoana();
            this.Hide();
            participanti.ShowDialog();
            this.Show();

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            BlocFizic blocfizic = new BlocFizic();
            this.Hide();
            blocfizic.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contract contracte = new Contract();
            this.Hide();
            contracte.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parcela parcele = new Parcela();
            this.Hide();
            parcele.ShowDialog();
            this.Show();
        }

        

        private void onClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            con.Close();
        }
    }
}
