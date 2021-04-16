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
    public partial class Parcela : Form
    {
        public Parcela()
        {
            InitializeComponent();
            Afisare();
        }

        private void Parcela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PARCELA' table. You can move, or remove it, as needed.
            this.pARCELATableAdapter.Fill(this.dataSet1.PARCELA);

        }

        public void Afisare()
        {
            OdbcDataAdapter data = new OdbcDataAdapter("SELECT * FROM PARCELA", MainWindow.con);
            DataTable D = new DataTable();
            data.Fill(D);
            dataGridView1.DataSource = D;
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugaParcela ap = new AdaugaParcela();
            ap.ShowDialog();
            this.Show();
            Afisare();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int rowId = Convert.ToInt32(item.Cells[0].Value);

                OdbcCommand com = new OdbcCommand();
                com.CommandText = "DELETE FROM PARCELA WHERE PARCELA_ID = " + rowId + ";";
                com.Connection = MainWindow.con;
                com.ExecuteNonQuery();

                dataGridView1.Rows.Remove(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EDITARE
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("SELECT * FROM PARCELA WHERE PARCELA_ID = " + dataGridView1.SelectedRows[0].Cells[0].Value, MainWindow.con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                Editare editare = new Editare(dt, "PARCELA");
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
