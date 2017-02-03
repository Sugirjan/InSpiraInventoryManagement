using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Inspira
{
    public partial class FrmStocks : Form
    {
        MySqlCommand cmd;
        MySqlConnection con;
        // MySqlDataReader rdr;
        String cs = Inspira.Properties.Settings.Default.connectionString;
        public FrmStocks()
        {
            InitializeComponent();
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();


        }

        private void frmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
           // frm.lblUser.Text = label6.Text;
            frm.Show();
        }

        private void auto()
        {
            txtProductId.Text =  GetUniqueKey(6);
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void Reset()
        {

            txtProductId.Text = "";
            txtDrugName.Text = "";
            txtChemicalName.Text = "";
            txtCompanyname.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            txtBatchno.Text = "";
            dtpExpiryDate.Text = DateTime.Today.ToString();
            dtpManufacturedDate.Text = DateTime.Today.ToString();
            dtpPurchasedDate.Text = DateTime.Today.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text == "")
            {
                MessageBox.Show("Please Drug Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrugName.Focus();
                return;
            }
            if (txtChemicalName.Text == "")
            {
                MessageBox.Show("Please Chemical Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrugName.Focus();
                return;
            }
            if (txtCompanyname.Text == "")
            {
                MessageBox.Show("Please Comapany Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompanyname.Focus();
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            if (txtUnitPrice.Text == "")
            {
                MessageBox.Show("Please Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitPrice.Focus();
                return;
            }
            try
            {
                con = new MySqlConnection(cs);

                con.Open();
                string cib = "insert into stock(productID,DrugName,ChemicalName,batchNo,companyName,unitPrice,manufacturedDate,expiryDate,purchasedDate,Quantity) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)";
                cmd = new MySqlCommand(cib);
                cmd.Connection = con;
                auto();
                cmd.Parameters.Add(new MySqlParameter("@d1", MySqlDbType.VarChar, 10, "productID"));
                cmd.Parameters.Add(new MySqlParameter("@d2", MySqlDbType.VarChar, 50, "DrugName"));
                cmd.Parameters.Add(new MySqlParameter("@d3", MySqlDbType.VarChar, 50, "ChemicalName"));
                cmd.Parameters.Add(new MySqlParameter("@d4", MySqlDbType.VarChar, 20, "batchNo"));
                cmd.Parameters.Add(new MySqlParameter("@d5", MySqlDbType.VarChar, 25, "companyName"));
                cmd.Parameters.Add(new MySqlParameter("@d6", MySqlDbType.Float, 15, "unitPrice"));
                cmd.Parameters.Add(new MySqlParameter("@d7", MySqlDbType.DateTime, 150, "manufacturedDate")); 
                 cmd.Parameters.Add(new MySqlParameter("@d8", MySqlDbType.DateTime, 50, "expiryDate"));
                cmd.Parameters.Add(new MySqlParameter("@d9", MySqlDbType.DateTime, 250, "purchasedDate"));
                cmd.Parameters.Add(new MySqlParameter("@d10", MySqlDbType.Int64, 250, "Quantity"));
                cmd.Parameters["@d1"].Value = txtProductId.Text;
                cmd.Parameters["@d2"].Value = txtDrugName.Text;
                cmd.Parameters["@d3"].Value = txtChemicalName.Text;
                cmd.Parameters["@d4"].Value = txtBatchno.Text;
                cmd.Parameters["@d5"].Value = txtCompanyname.Text;
                cmd.Parameters["@d6"].Value = txtUnitPrice.Text;
               cmd.Parameters["@d7"].Value = dtpManufacturedDate.Value.Date;
                cmd.Parameters["@d8"].Value = dtpExpiryDate.Value;
                cmd.Parameters["@d9"].Value = dtpPurchasedDate.Value;
                cmd.Parameters["@d10"].Value = txtQuantity.Text;

                cmd.ExecuteReader();
                MessageBox.Show("Successfully saved", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStockRecord1 frm = new frmStockRecord1();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs);

                con.Open();
                //update customer set Customername = '" + txtCustomerName.Text + "',address= '" + txtAddress.Text + "',city= '" + txtCity.Text + "',zipcode= '" + txtZipCode.Text + "',Phone= '" + txtPhone.Text + "',email= '" + txtEmail.Text + "',mobileno= '" + txtMobileNo.Text + "',notes= '" + txtNotes.Text + "' where CustomerID= '" + txtCustomerID.Text + "'";
                // string cib = "update stock set DrugName,ChemicalName,batchNo,companyName,unitPrice,manufacturedDate,expiryDate,purchasedDate,Quantity VALUES (@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)";
                string cib = "update stock set DrugName='"+txtDrugName.Text+"',ChemicalName='"+txtChemicalName.Text+"',batchNo = '" + txtBatchno.Text + "',companyName = '" + txtCompanyname.Text + "',unitPrice = '" + txtUnitPrice.Text + "',manufacturedDate = '"+ dtpManufacturedDate.Value.Date+ "',expiryDate = '" + dtpExpiryDate.Value + "',purchasedDate = '" +dtpPurchasedDate.Value + "',Quantity = " + txtQuantity.Text  + " where productID = '" + txtProductId.Text  + "' ";
                cmd = new MySqlCommand(cib);
                // cmd = new OleDbCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                //                 cmd = new MySqlCommand(cib);
                //                 cmd.Connection = con;
                //                 auto();
                //                // cmd.Parameters.Add(new MySqlParameter("@d1", MySqlDbType.VarChar, 10, "productID"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d2", MySqlDbType.VarChar, 50, "DrugName"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d3", MySqlDbType.VarChar, 50, "ChemicalName"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d4", MySqlDbType.VarChar, 20, "batchNo"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d5", MySqlDbType.VarChar, 25, "companyName"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d6", MySqlDbType.Float, 15, "unitPrice"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d7", MySqlDbType.DateTime, 150, "manufacturedDate"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d8", MySqlDbType.DateTime, 50, "expiryDate"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d9", MySqlDbType.DateTime, 250, "purchasedDate"));
                //                 cmd.Parameters.Add(new MySqlParameter("@d10", MySqlDbType.Int64, 250, "Quantity"));
                //               //  cmd.Parameters["@d1"].Value = txtProductId.Text;
                //                 cmd.Parameters["@d2"].Value = txtDrugName.Text;
                //                 cmd.Parameters["@d3"].Value = txtChemicalName.Text;
                //                 cmd.Parameters["@d4"].Value = txtBatchno.Text;
                //                 cmd.Parameters["@d5"].Value = txtCompanyname.Text;
                //                 cmd.Parameters["@d6"].Value = txtUnitPrice.Text;
                //                 cmd.Parameters["@d7"].Value = dtpManufacturedDate.Value;
                //                 cmd.Parameters["@d8"].Value = dtpExpiryDate.Value;
                //                 cmd.Parameters["@d9"].Value = dtpPurchasedDate.Value;
                //                 cmd.Parameters["@d10"].Value = txtQuantity.Text;
                // 
                //                 cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate.Enabled = false;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
