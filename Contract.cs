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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
            Afisare();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CONTRACT' table. You can move, or remove it, as needed.
            this.cONTRACTTableAdapter.Fill(this.dataSet1.CONTRACT);

        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            //adaugare
            this.Hide();
            AdaugaContract ac = new AdaugaContract();
            ac.ShowDialog();
            Afisare();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //editare
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("SELECT * FROM CONTRACT WHERE CONTRACT_ID = " + dataGridView1.SelectedRows[0].Cells[0].Value, MainWindow.con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                Editare editare = new Editare(dt, "CONTRACT");
                editare.ShowDialog();
                Afisare();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stergere
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int rowId = Convert.ToInt32(item.Cells[0].Value);

                OdbcCommand com = new OdbcCommand();
                com.CommandText = "DELETE FROM CONTRACT WHERE CONTRACT_ID = " + rowId + ";";
                com.Connection = MainWindow.con;
                com.ExecuteNonQuery();

                dataGridView1.Rows.Remove(item);
            }
        }
        public void Afisare()
        {
            OdbcDataAdapter data = new OdbcDataAdapter("SELECT * FROM CONTRACT", MainWindow.con);
            DataTable D = new DataTable();
            data.Fill(D);
            dataGridView1.DataSource = D;
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
