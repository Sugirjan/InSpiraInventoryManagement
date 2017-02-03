namespace Inspira
{
    partial class frmSalesRecord1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesRecord1));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaymentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet11 = new Inspira.logindataDataSet11();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet5 = new Inspira.logindataDataSet5();
            this.salesTableAdapter = new Inspira.logindataDataSet5TableAdapters.salesTableAdapter();
            this.salesTableAdapter1 = new Inspira.logindataDataSet11TableAdapters.salesTableAdapter();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet11)).BeginInit();
            this.GroupBox8.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(-1, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1312, 665);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPage3
            // 
            this.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabPage3.Controls.Add(this.GroupBox4);
            this.TabPage3.Controls.Add(this.DataGridView3);
            this.TabPage3.Controls.Add(this.GroupBox8);
            this.TabPage3.Controls.Add(this.GroupBox9);
            this.TabPage3.Location = new System.Drawing.Point(4, 26);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1304, 635);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "By Customer Name";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.TextBox4);
            this.GroupBox4.Controls.Add(this.TextBox5);
            this.GroupBox4.Controls.Add(this.TextBox6);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.Label8);
            this.GroupBox4.Location = new System.Drawing.Point(1029, 91);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(267, 142);
            this.GroupBox4.TabIndex = 29;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Total";
            this.GroupBox4.Visible = false;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(127, 99);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(125, 24);
            this.TextBox4.TabIndex = 25;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(127, 62);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(125, 24);
            this.TextBox5.TabIndex = 25;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(127, 25);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(125, 24);
            this.TextBox6.TabIndex = 24;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(18, 102);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(90, 18);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Due Payment";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(18, 66);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(95, 18);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "Total Payment";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(18, 31);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 18);
            this.Label8.TabIndex = 22;
            this.Label8.Text = "Amount";
            // 
            // DataGridView3
            // 
            this.DataGridView3.AutoGenerateColumns = false;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.customerIDDataGridViewTextBoxColumn1,
            this.customernameDataGridViewTextBoxColumn1,
            this.grandTotalDataGridViewTextBoxColumn1,
            this.totalPaymentDataGridViewTextBoxColumn1,
            this.paymentDueDataGridViewTextBoxColumn1,
            this.chequeNo,
            this.chequeDetails});
            this.DataGridView3.DataSource = this.salesBindingSource1;
            this.DataGridView3.Location = new System.Drawing.Point(6, 99);
            this.DataGridView3.MultiSelect = false;
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.Size = new System.Drawing.Size(1001, 540);
            this.DataGridView3.TabIndex = 28;
            this.DataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView3_RowHeaderMouseClick);
            this.DataGridView3.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView3_RowPostPaint);
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            // 
            // customernameDataGridViewTextBoxColumn1
            // 
            this.customernameDataGridViewTextBoxColumn1.DataPropertyName = "Customername";
            this.customernameDataGridViewTextBoxColumn1.HeaderText = "Customername";
            this.customernameDataGridViewTextBoxColumn1.Name = "customernameDataGridViewTextBoxColumn1";
            // 
            // grandTotalDataGridViewTextBoxColumn1
            // 
            this.grandTotalDataGridViewTextBoxColumn1.DataPropertyName = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn1.HeaderText = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn1.Name = "grandTotalDataGridViewTextBoxColumn1";
            // 
            // totalPaymentDataGridViewTextBoxColumn1
            // 
            this.totalPaymentDataGridViewTextBoxColumn1.DataPropertyName = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn1.HeaderText = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn1.Name = "totalPaymentDataGridViewTextBoxColumn1";
            // 
            // paymentDueDataGridViewTextBoxColumn1
            // 
            this.paymentDueDataGridViewTextBoxColumn1.DataPropertyName = "PaymentDue";
            this.paymentDueDataGridViewTextBoxColumn1.HeaderText = "PaymentDue";
            this.paymentDueDataGridViewTextBoxColumn1.Name = "paymentDueDataGridViewTextBoxColumn1";
            // 
            // chequeNo
            // 
            this.chequeNo.DataPropertyName = "chequeNo";
            this.chequeNo.HeaderText = "chequeNo";
            this.chequeNo.Name = "chequeNo";
            // 
            // chequeDetails
            // 
            this.chequeDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chequeDetails.DataPropertyName = "chequeDetails";
            this.chequeDetails.HeaderText = "chequeDetails";
            this.chequeDetails.Name = "chequeDetails";
            this.chequeDetails.Width = 160;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "sales";
            this.salesBindingSource1.DataSource = this.logindataDataSet11;
            // 
            // logindataDataSet11
            // 
            this.logindataDataSet11.DataSetName = "logindataDataSet11";
            this.logindataDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.button1);
            this.GroupBox8.Controls.Add(this.Button7);
            this.GroupBox8.Controls.Add(this.Button9);
            this.GroupBox8.Location = new System.Drawing.Point(354, 7);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(342, 87);
            this.GroupBox8.TabIndex = 26;
            this.GroupBox8.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "export Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(119, 29);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(94, 40);
            this.Button7.TabIndex = 2;
            this.Button7.Text = "&Export Excel";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.Location = new System.Drawing.Point(19, 29);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(94, 40);
            this.Button9.TabIndex = 1;
            this.Button9.Text = "&Reset";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.cmbCustomerName);
            this.GroupBox9.Controls.Add(this.Label16);
            this.GroupBox9.Location = new System.Drawing.Point(8, 6);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(340, 87);
            this.GroupBox9.TabIndex = 25;
            this.GroupBox9.TabStop = false;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(24, 45);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(301, 25);
            this.cmbCustomerName.TabIndex = 25;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(20, 18);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(107, 18);
            this.Label16.TabIndex = 9;
            this.Label16.Text = "Customer Name";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.logindataDataSet5;
            // 
            // logindataDataSet5
            // 
            this.logindataDataSet5.DataSetName = "logindataDataSet5";
            this.logindataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter1
            // 
            this.salesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmSalesRecord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1311, 664);
            this.Controls.Add(this.TabControl1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSalesRecord1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesRecord_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesRecord_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet11)).EndInit();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DataGridView DataGridView3;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.ComboBox cmbCustomerName;
        internal System.Windows.Forms.Label Label16;
        private logindataDataSet5 logindataDataSet5;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private logindataDataSet5TableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDetails;
        private logindataDataSet11 logindataDataSet11;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private logindataDataSet11TableAdapters.salesTableAdapter salesTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}