﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace Inspira
{
    public partial class frmStockRecord : Form
    {

        DataTable dtable = new DataTable();
        MySqlConnection con = null;
        //  DataSet ds = new DataSet();
        MySqlCommand cmd = null;
        //  DataTable dt = new DataTable();
        String cs = Inspira.Properties.Settings.Default.connectionString;
        public frmStockRecord()
        {
            InitializeComponent();
        }
       
            public void GetData()
        {
            try
            {
                con = new MySqlConnection(cs);
                con.Open();
                //String sql = "SELECT D,Config.ConfigID,ProductName,Features,Price,Quantity,Totalprice,Stockdate from Stock,Config where Stock.ConfigID=Config.ConfigID order by ProductName";
                String sql = "SELECT productID,DrugName,ChemicalName,batchNo,companyName,unitPrice,Quantity,manufacturedDate,expiryDate,purchasedDate from stock order by DrugName";
                cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter myDA = new MySqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "stock");
                dataGridView1.DataSource = myDataSet.Tables["stock"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmStockRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindataDataSet10.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter1.Fill(this.logindataDataSet10.stock);
            // TODO: This line of code loads data into the 'logindataDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.logindataDataSet.stock);
            GetData();
        }

        private void txtProductname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);
                //con = new OleDbConnection(cs);
                con.Open();
                String sql = "SELECT productID,DrugName,ChemicalName,batchNo,companyName,unitPrice,Quantity,manufacturedDate,expiryDate,purchasedDate from stock where DrugName like '" + txtProductname.Text + "%' order by DrugName";
                cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter myDA = new MySqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "stock");
                dataGridView1.DataSource = myDataSet.Tables["stock"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);
                //con = new OleDbConnection(cs);
                con.Open();
                String sql = "SELECT productID,DrugName,ChemicalName,batchNo,companyName,unitPrice,Quantity,manufacturedDate,expiryDate,purchasedDate from stock where quantity <= 0  order by DrugName";
                cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter myDA = new MySqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "stock");
                dataGridView1.DataSource = myDataSet.Tables["stock"].DefaultView;
                con.Close();
                //                 con = new OleDbConnection(cs);
                //                 con.Open();
                //                 String sql = "SELECT StockID,Config.ConfigID,ProductName,Features,Price,Quantity,Totalprice,Stockdate from Stock,Config where Stock.ConfigID=Config.ConfigID and Quantity <= 0 order by ProductName";
                //                 cmd = new OleDbCommand(sql, con);
                //                 rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //                 dataGridView1.Rows.Clear();
                //                 while (rdr.Read() == true)
                //                 {
                //                     dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7]);
                //                 }
                //                 con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

           private void Button4_Click(object sender, EventArgs e)
           {

               int rowsTotal = 0;
               int colsTotal = 0;
               int I = 0;
               int j = 0;
               int iC = 0;
               System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
               Excel.Application xlApp = new Excel.Application();

               try
               {
                   Excel.Workbook excelBook = xlApp.Workbooks.Add();
                   Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                   xlApp.Visible = true;

                   rowsTotal = dataGridView1.RowCount - 1;
                   colsTotal = dataGridView1.Columns.Count - 1;
                   var _with1 = excelWorksheet;
                   _with1.Cells.Select();
                   _with1.Cells.Delete();
                   for (iC = 0; iC <= colsTotal; iC++)
                   {
                       _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                   }
                   for (I = 0; I <= rowsTotal - 1; I++)
                   {
                       for (j = 0; j <= colsTotal; j++)
                       {
                           _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
                       }
                   }
                   _with1.Rows["1:1"].Font.FontStyle = "Bold";
                   _with1.Rows["1:1"].Font.Size = 12;

                   _with1.Cells.Columns.AutoFit();
                   _with1.Cells.Select();
                   _with1.Cells.EntireColumn.AutoFit();
                   _with1.Cells[1, 1].Select();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               finally
               {
                   //RELEASE ALLOACTED RESOURCES
                   System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                   xlApp = null;
               }
           }
           
        private void button2_Click(object sender, EventArgs e)
        {
            txtProductname.Text = "";
            GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmst
        }
    }
}
