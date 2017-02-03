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
    public partial class frmCustomersReport : Form
    {
        public frmCustomersReport()
        {
            InitializeComponent();
            try
            {
                MySqlConnection myConnection1 = new MySqlConnection();

                myConnection1.ConnectionString = "server = localhost; user id = root; password = 0159; database = Logindata";
                String Query = "SELECT CustomerID,CustomerName,address,city,zipcode,Phone,email,mobileno,notes from customer";
                MySqlCommand myCommand1 = new MySqlCommand(Query, myConnection1);
                MySqlDataAdapter myAdapter1 = new MySqlDataAdapter();
                myAdapter1.SelectCommand = myCommand1;
                logindataDataSet2 cd = new logindataDataSet2();
                cd.Clear();
                myAdapter1.Fill(cd, "customer");
                customerReport myReport = new customerReport();
                myReport.SetDataSource(cd);
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
