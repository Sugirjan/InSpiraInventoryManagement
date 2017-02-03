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
    public partial class frmReturn : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        String cs = Inspira.Properties.Settings.Default.connectionString;
        public frmReturn()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn1 frmret = new frmReturn1();
            frmret.Show();
            frmret.GetData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBatchId.Text = "";
            txtDrugName.Text = "";
            txtProductId.Text = "";
            txtQuantity.Text = "";
            cmbReason.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn2 fm1 = new frmReturn2();
            fm1.Show();
            fm1.GetData();
        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text == "")
            {
                MessageBox.Show("Please enter product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductId.Focus();
                return;
            }
            if (txtBatchId.Text == "")
            {
                MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBatchId.Focus();
                return;
            }
            if (txtDrugName.Text == "")
            {
                MessageBox.Show("Please select company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrugName.Focus();
                return;
            }
            if (cmbReason.Text == "")
            {
                MessageBox.Show("Please enter product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbReason.Focus();
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }

            try
            {
                con = new MySqlConnection(cs);

                con.Open();
                string cib = "insert into returnitems(productID,batchID,drugName,reason,quantity) VALUES (@d1,@d2,@d3,@d4,@d5)";
                cmd = new MySqlCommand(cib);
                cmd.Connection = con;

                cmd.Parameters.Add(new MySqlParameter("@d1", MySqlDbType.VarChar, 10, "productID"));
                cmd.Parameters.Add(new MySqlParameter("@d2", MySqlDbType.VarChar, 50, "batchID"));
                cmd.Parameters.Add(new MySqlParameter("@d3", MySqlDbType.VarChar, 50, "drugName"));
                cmd.Parameters.Add(new MySqlParameter("@d4", MySqlDbType.VarChar, 20, "reason"));
                cmd.Parameters.Add(new MySqlParameter("@d5", MySqlDbType.Int64, 25, "quantity"));

                cmd.Parameters["@d1"].Value = txtProductId.Text;
                cmd.Parameters["@d2"].Value = txtBatchId.Text;
                cmd.Parameters["@d3"].Value = txtDrugName.Text;
                cmd.Parameters["@d4"].Value = cmbReason.Text;
                cmd.Parameters["@d5"].Value = txtQuantity.Text;


                cmd.ExecuteReader();
                MessageBox.Show("Successfully saved", "Return Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
