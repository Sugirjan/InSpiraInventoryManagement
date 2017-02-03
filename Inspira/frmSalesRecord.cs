using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Inspira
{
    public partial class frmSalesRecord : Form
    {

        DataTable dTable;
        MySqlConnection con = null;
        //OleDbConnection con = null;
        MySqlDataAdapter adp;
        //OleDbDataAdapter adp;
        DataSet ds;
        MySqlCommand cmd = null;
        //OleDbCommand cmd = null;
        DataTable dt = new DataTable();
      //  MySqlDataReader rdr;
        //  OleDbDataReader rdr;
        String cs = Inspira.Properties.Settings.Default.connectionString;
        public frmSalesRecord()
        {
            InitializeComponent();
        }

        private void frmSalesRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindataDataSet11.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter2.Fill(this.logindataDataSet11.sales);
            // TODO: This line of code loads data into the 'logindataDataSet5.sales' table. You can move, or remove it, as needed.
           // this.salesTableAdapter1.Fill(this.logindataDataSet5.sales);
            // TODO: This line of code loads data into the 'logindataDataSet3.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.logindataDataSet3.sales);
            FillCombo();
        }

       
        private void Button7_Click(object sender, EventArgs e)
        {
            if (DataGridView3.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

                rowsTotal = DataGridView3.RowCount - 1;
                colsTotal = DataGridView3.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = DataGridView3.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = DataGridView3.Rows[I].Cells[j].Value;
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


        private void Button9_Click(object sender, EventArgs e)
        {
            DataGridView3.DataSource = null;
            cmbCustomerName.Text = "";
        }

       
        public void FillCombo()
        {

            try
            {
                con = new MySqlConnection(cs);
                // con = new OleDbConnection(cs);
                con.Open();

                // adp = new OleDbDataAdapter();

                adp = new MySqlDataAdapter();

                adp.SelectCommand = new MySqlCommand("SELECT  distinct Customername FROM customer,sales where sales.CustomerID=customer.CustomerID", con);
                // adp.SelectCommand = new OleDbCommand("SELECT distinct CustomerName FROM Sales,Customer where Sales.CustomerID=Customer.CustomerID", con);
                ds = new DataSet("ds");
                adp.Fill(ds);
                dTable = ds.Tables[0];
                cmbCustomerName.Items.Clear();
                foreach (DataRow drow in dTable.Rows)
                {
                    cmbCustomerName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                con = new MySqlConnection(cs);
                // con = new OleDbConnection(cs);
                con.Open();
                cmd = new MySqlCommand("SELECT orderID,orderDate,CustomerID,Customername,grandTotal,TotalPayment,PaymentDue from sales WHERE sales.CustomerID=customer.CustomerID and Customername='" + cmbCustomerName.Text + "' order by Customername,InvoiceDate", con);
                // cmd = new OleDbCommand("SELECT (invoiceNo) as [Invoice No],(s from Sales,Customer where Sales.CustomerID=Customer.CustomerID and Customername='" + cmbCustomerName.Text + "' order by CustomerName,InvoiceDate", con);
                MySqlDataAdapter myDA = new MySqlDataAdapter(cmd);
                //    OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "sales");
                myDA.Fill(myDataSet, "customer");
                DataGridView3.DataSource = myDataSet.Tables["customer"].DefaultView;
                DataGridView3.DataSource = myDataSet.Tables["sales"].DefaultView;
                Int64 sum = 0;
                Int64 sum1 = 0;
                Int64 sum2 = 0;

                foreach (DataGridViewRow r in this.DataGridView3.Rows)
                {
                    Int64 i = Convert.ToInt64(r.Cells[7].Value);
                    Int64 j = Convert.ToInt64(r.Cells[8].Value);
                    Int64 k = Convert.ToInt64(r.Cells[9].Value);
                    sum = sum + i;
                    sum1 = sum1 + j;
                    sum2 = sum2 + k;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       





        private void DataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (DataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                DataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        

        private void TabControl1_Click(object sender, EventArgs e)
        {
           
            DataGridView3.DataSource = null;
            cmbCustomerName.Text = "";

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
          /*  try
            {
                if (cmbCustomerName.Text == "")
                {
                    MessageBox.Show("Please select Customer name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCustomerName.Focus();
                    return;
                }
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;

                rptSales rpt = new rptSales();
                //The report you created.
                cmd = new OleDbCommand();
                OleDbDataAdapter myDA = new OleDbDataAdapter();
                SIS_DBDataSet myDS = new SIS_DBDataSet();
                //The DataSet you created.
                con = new OleDbConnection(cs);
                cmd.Connection = con;
                cmd.CommandText = "SELECT Sales.InvoiceNo, Sales.InvoiceDate, Sales.CustomerID, Sales.SubTotal, Sales.VATPercentage, Sales.VATAmount, Sales.GrandTotal, Sales.TotalPayment,Sales.PaymentDue, Sales.Remarks, Customer.CustomerID AS Expr1, Customer.CustomerName, Customer.Address, Customer.Landmark, Customer.City, Customer.State, Customer.ZipCode, Customer.Phone, Customer.MobileNo, Customer.FaxNo, Customer.Email, Customer.Notes FROM (Sales INNER JOIN Customer ON Sales.CustomerID = Customer.CustomerID) where Customername='" + cmbCustomerName.Text + "' order by CustomerName,InvoiceDate";
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Sales");
                myDA.Fill(myDS, "Customer");
                rpt.SetDataSource(myDS);
                frmSalesReport frm = new frmSalesReport();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void button11_Click(object sender, EventArgs e)
        {
           /* try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;

                rptSales rpt = new rptSales();
                //The report you created.
                cmd = new OleDbCommand();
                OleDbDataAdapter myDA = new OleDbDataAdapter();
                SIS_DBDataSet myDS = new SIS_DBDataSet();
                //The DataSet you created.
                con = new OleDbConnection(cs);
                cmd.Connection = con;
                cmd.CommandText = "SELECT Sales.InvoiceNo, Sales.InvoiceDate, Sales.CustomerID, Sales.SubTotal, Sales.VATPercentage, Sales.VATAmount, Sales.GrandTotal, Sales.TotalPayment,Sales.PaymentDue, Sales.Remarks, Customer.CustomerID AS Expr1, Customer.CustomerName, Customer.Address, Customer.Landmark, Customer.City, Customer.State, Customer.ZipCode, Customer.Phone, Customer.MobileNo, Customer.FaxNo, Customer.Email, Customer.Notes FROM (Sales INNER JOIN Customer ON Sales.CustomerID = Customer.CustomerID) Where InvoiceDate between #" + DateTimePicker2.Text + "# And #" + DateTimePicker1.Text + "# and PaymentDue > 0 order by InvoiceDate desc";
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Sales");
                myDA.Fill(myDS, "Customer");
                rpt.SetDataSource(myDS);
                frmSalesReport frm = new frmSalesReport();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }

}
