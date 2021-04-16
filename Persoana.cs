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

//persoane

namespace tema_bd
{
    public partial class Persoana : Form
    {
        public Persoana()
        {
            InitializeComponent();
            Afisare();
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugaPersoana ap = new AdaugaPersoana();
            ap.ShowDialog();
            this.Show();
            Afisare();
        }

        private void Sterge_Persoana_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int rowId = Convert.ToInt32(item.Cells[0].Value);
               
                OdbcCommand com = new OdbcCommand();
                com.CommandText = "DELETE FROM PERSOANA WHERE PERSOANA_ID = " + rowId + ";";
                com.Connection = MainWindow.con;
                try
                {
                    com.ExecuteNonQuery();
                }catch(Exception eee)
                {
                    Console.WriteLine(eee.Message);
                }

                dataGridView1.Rows.Remove(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PERSOANA' table. You can move, or remove it, as needed.
            this.pERSOANATableAdapter.Fill(this.dataSet1.PERSOANA);

        }
        public void Afisare()
        {
            OdbcDataAdapter data = new OdbcDataAdapter("SELECT * FROM PERSOANA", MainWindow.con);
            DataTable D = new DataTable();
            data.Fill(D);
            dataGridView1.DataSource = D;
        }


        private void onClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Editeaza_Persoana_Click(object sender, EventArgs e)
        {
            
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("SELECT * FROM PERSOANA WHERE PERSOANA_ID = " + dataGridView1.SelectedRows[0].Cells[0].Value,MainWindow.con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                Editare editare = new Editare(dt, "PERSOANA");
                editare.ShowDialog();
                Afisare();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }
    }
}
