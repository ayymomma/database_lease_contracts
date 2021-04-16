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
    public partial class Editare : Form
    {
        string tb;

        public Editare(DataTable dt,string tb)
        {
            
            InitializeComponent(); 
            this.tb = tb;
            dataGridView1.DataSource = dt;
        }

        private void onEnter(object sender, DataGridViewCellEventArgs e)
        {
            string stm = "UPDATE " + tb +
                " SET " + dataGridView1.Columns[e.ColumnIndex].Name + " = '" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value +
                "' WHERE " + dataGridView1.Columns[0].Name + " = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value + ";";
            Console.WriteLine(stm);
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandText = stm;
            cmd.Connection = MainWindow.con;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
