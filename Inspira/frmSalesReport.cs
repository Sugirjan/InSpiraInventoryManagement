using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inspira
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
            try
            { 
            
            MySqlConnection myConnection1 = new MySqlConnection();

            myConnection1.ConnectionString = "server = localhost; user id = root; password = 0159; database = LoginData";
            String Query = "SELECT orderID,orderDate,CustomerID,GrandTotal,TotalPayment,PaymentDue,chequeNo,chequeDetails,Customername,orderStatus,orderSendDate from sales";
            MySqlCommand myCommand1 = new MySqlCommand(Query, myConnection1);
            MySqlDataAdapter myAdapter1 = new MySqlDataAdapter();
            myAdapter1.SelectCommand = myCommand1;
            logindataDataSet5 cd1 = new logindataDataSet5();
            cd1.Clear();
            myAdapter1.Fill(cd1, "sales");
            salesReport myReport = new salesReport();
            myReport.SetDataSource(cd1);
            // Set the Report Source to ReportView 
            crystalReportViewer1.ReportSource = myReport;
            //adapter = new MySqlDataAdapter("SELECT ID,DrugName,ChemicalName from stock");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
