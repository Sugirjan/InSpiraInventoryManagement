using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.OleDb;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

using Excel = Microsoft.Office.Interop.Excel;
namespace Inspira
{
    public partial class frmReturn2 : Form
    {
        /* OleDbDataReader rdr = null;
         OleDbConnection con = null;
         OleDbCommand cmd = null;
         String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\SIS_DB.accdb;";*/
        MySqlDataReader rdr = null;
        MySqlConnection con;
        string cs = "Inspira.Properties.Settings.Default.connectionString";
        MySqlCommand cmd;
        public frmReturn2()
        {
            InitializeComponent();
        }
        public void GetData()
        {
//             try
//             {
//                 con = new MySqlConnection(cs);
//                 con.Open();
//                 // String Query = "SELECT productID,DrugName,ChemicalName,batchNo,companyName,unitPrice,Quantity from stock WHERE DrugName like '" + txtProductName.Text + "%' ";
// 
//                 cmd = new MySqlCommand("SELECT productID,batchNo,DrugName from stock order by DrugName", con);
//                // 
//                 rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
//                 dataGridView1.Rows.Clear();
//                 while (rdr.Read() == true)
//                 {
//                     dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
//                 }
//                 con.Close();

                try
                {
                    MySqlConnection myConnection1 = new MySqlConnection();

                    myConnection1.ConnectionString = Inspira.Properties.Settings.Default.connectionString;
                    String Query = "SELECT productID,batchNo,DrugName from stock order by DrugName";
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
                MessageBox.Show(ex.Message, ",getDataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProductsRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindataDataSet7.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter1.Fill(this.logindataDataSet7.stock);
            // TODO: This line of code loads data into the 'logindataDataSet9.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.logindataDataSet9.stock);
            GetData();
        }

        private void txtProductname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);
                con.Open();
                cmd = new MySqlCommand("SELECT productID,batchNo,DrugName from stock WHERE DrugName like '" + txtProductname.Text + "%' order by DrugName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

      
       
        private void frmProductsRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //frmProduct frm = new frmProduct();
            frmReturn frm = new frmReturn(); 
            frm.Show();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmReturn frm = new frmReturn();
                frm.Show();
             //   frm.btnSave.Enabled = 
                frm.txtProductId.Text = dr.Cells[0].Value.ToString();
                frm.txtDrugName.Text = dr.Cells[2].Value.ToString();
                frm.txtBatchId.Text= dr.Cells[1].Value.ToString();
              
                frm.btnUpdate.Enabled = true;
                //frm.btnDelete.Enabled = true;
              //  frm.btnSave.Enabled = false;
                frm.cmbReason.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
