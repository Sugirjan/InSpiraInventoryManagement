using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Inspira
{
    public partial class frmReturn1 : Form

    {
        public frmReturn1()
        {
            InitializeComponent();
        }

        private void frmReturn1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindataDataSet8.returnitems' table. You can move, or remove it, as needed.
            this.returnitemsTableAdapter1.Fill(this.logindataDataSet8.returnitems);
            // TODO: This line of code loads data into the 'logindataDataSet6.returnitems' table. You can move, or remove it, as needed.
         //   this.returnitemsTableAdapter.Fill(this.logindataDataSet6.returnitems);
//             // TODO: This line of code loads data into the 'stockDataSet.returnitems' table. You can move, or remove it, as needed.
//             this.returnitemsTableAdapter.Fill(this.stockDataSet.returnitems);

        }

      

        public void GetData()
        {

            //             try
            //             {
            //                 MySqlConnection myConnection1 = new MySqlConnection();
            //                 myConnection1.Open();
            //                 myConnection1.ConnectionString = Inspira.Properties.Settings.Default.connectionString;
            //                 String Query = "SELECT productID,batchID,DrugName,reason,quantity from returnitems";
            //                 MySqlCommand myCommand1 = new MySqlCommand(Query, myConnection1);
            //                 MySqlDataAdapter myAdapter1 = new MySqlDataAdapter();
            //                 myAdapter1.SelectCommand = myCommand1;
            //                 // myConnection1.Open();
            //                 DataTable table = new DataTable();
            //                 myAdapter1.Fill(table);
            // 
            //                 dataGridView1.DataSource = table;
            //             }
            //             catch (Exception ex)
            //             {
            //                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //             }

            try
            {
                MySqlConnection myConnection1 = new MySqlConnection();

                myConnection1.ConnectionString = Inspira.Properties.Settings.Default.connectionString;
                String Query = "SELECT productID,batchID,DrugName,reason,quantity from returnitems";
                MySqlCommand myCommand1 = new MySqlCommand(Query, myConnection1);
                MySqlDataAdapter myAdapter1 = new MySqlDataAdapter();
                myAdapter1.SelectCommand = myCommand1;
                // myConnection1.Open();
                DataTable table = new DataTable();
                myAdapter1.Fill(table);
                //adapter = new MySqlDataAdapter("SELECT ID,DrugName,ChemicalName from stock");
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReturn1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmReturn frm = new frmReturn();
            frm.Show();
        }
    }
}
