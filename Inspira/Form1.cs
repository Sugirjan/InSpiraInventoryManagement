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

namespace Inspira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {

                MySqlConnection myConnection1 = new MySqlConnection();

                myConnection1.ConnectionString = "server = localhost; user id = root; password = sivaneban3; database = LoginData";
                String Query = "SELECT productID,DrugName,ChemicalName,batchNo,companyName,unitPrice,manufacturedDate,expiryDate,purchaseDate,Quantity from stock";
                MySqlCommand myCommand1 = new MySqlCommand(Query, myConnection1);
                MySqlDataAdapter myAdapter1 = new MySqlDataAdapter();
                myAdapter1.SelectCommand = myCommand1;
                logindataDataSet5 cd1 = new logindataDataSet5();
                cd1.Clear();
                myAdapter1.Fill(cd1, "stock");
                 CrystalReport5 myReport= new CrystalReport5();
                myReport.SetDataSource(cd1);
                // Set the Report Source to ReportView 
                crystalReportViewer2.ReportSource = myReport;
                //adapter = new MySqlDataAdapter("SELECT ID,DrugName,ChemicalName from stock");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
