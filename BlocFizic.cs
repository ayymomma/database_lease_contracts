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
    public partial class BlocFizic : Form
    {
        public BlocFizic()
        {
            InitializeComponent();
            Afisare();
        }

        private void BlocFizic_Load(object sender, EventArgs e)
        {

        }
        public void Afisare()
        {
            OdbcDataAdapter data = new OdbcDataAdapter("SELECT * FROM BLOC_FIZIC", MainWindow.con);
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
            AdaugaBlocFizic ab = new AdaugaBlocFizic();
            ab.ShowDialog();
            this.Show();
            Afisare();
        }

        private void Sterge_Bloc_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int rowId = Convert.ToInt32(item.Cells[0].Value);

                OdbcCommand com = new OdbcCommand();
                com.CommandText = "DELETE FROM BLOC_FIZIC WHERE BLOC_FIZIC_ID = " + rowId + ";";
                com.Connection = MainWindow.con;
                com.ExecuteNonQuery();

                dataGridView1.Rows.Remove(item);
            }
        }

        private void Editeaza_Bloc_Click(object sender, EventArgs e)
        {
            //EDITARE
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("SELECT * FROM BLOC_FIZIC WHERE BLOC_FIZIC_ID = " + dataGridView1.SelectedRows[0].Cells[0].Value, MainWindow.con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                Editare editare = new Editare(dt, "BLOC_FIZIC");
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
