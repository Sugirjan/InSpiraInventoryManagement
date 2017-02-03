namespace Inspira
{
    partial class frmSalesRecord
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
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet5 = new Inspira.logindataDataSet5();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logindataDataSet3 = new Inspira.logindataDataSet3();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Inspira.logindataDataSet3TableAdapters.salesTableAdapter();
            this.salesTableAdapter1 = new Inspira.logindataDataSet5TableAdapters.salesTableAdapter();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.logindataDataSet11 = new Inspira.logindataDataSet11();
            this.salesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter2 = new Inspira.logindataDataSet11TableAdapters.salesTableAdapter();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaymentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            this.TabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "sales";
            this.salesBindingSource1.DataSource = this.logindataDataSet5;
            // 
            // logindataDataSet5
            // 
            this.logindataDataSet5.DataSetName = "logindataDataSet5";
            this.logindataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logindataDataSet3
            // 
            this.logindataDataSet3.DataSetName = "logindataDataSet3";
            this.logindataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.logindataDataSet3;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter1
            // 
            this.salesTableAdapter1.ClearBeforeFill = true;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.DataGridView3);
            this.TabPage3.Controls.Add(this.GroupBox8);
            this.TabPage3.Controls.Add(this.GroupBox9);
            this.TabPage3.Location = new System.Drawing.Point(4, 26);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1027, 635);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "By Customer";
            this.TabPage3.UseVisualStyleBackColor = true;
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
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.button10);
            this.GroupBox8.Controls.Add(this.Button7);
            this.GroupBox8.Controls.Add(this.Button9);
            this.GroupBox8.Location = new System.Drawing.Point(354, 7);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(330, 87);
            this.GroupBox8.TabIndex = 26;
            this.GroupBox8.TabStop = false;
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
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(219, 29);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 40);
            this.button10.TabIndex = 4;
            this.button10.Text = "&View Report";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // DataGridView3
            // 
            this.DataGridView3.AutoGenerateColumns = false;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.Customername,
            this.grandTotalDataGridViewTextBoxColumn1,
            this.totalPaymentDataGridViewTextBoxColumn1,
            this.paymentDueDataGridViewTextBoxColumn1,
            this.chequeNo,
            this.chequeDetails});
            this.DataGridView3.DataSource = this.salesBindingSource2;
            this.DataGridView3.Location = new System.Drawing.Point(31, 125);
            this.DataGridView3.MultiSelect = false;
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.Size = new System.Drawing.Size(763, 515);
            this.DataGridView3.TabIndex = 28;
            this.DataGridView3.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView3_RowPostPaint);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(-1, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1035, 665);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.Click += new System.EventHandler(this.TabControl1_Click);
            // 
            // logindataDataSet11
            // 
            this.logindataDataSet11.DataSetName = "logindataDataSet11";
            this.logindataDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource2
            // 
            this.salesBindingSource2.DataMember = "sales";
            this.salesBindingSource2.DataSource = this.logindataDataSet11;
            // 
            // salesTableAdapter2
            // 
            this.salesTableAdapter2.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 70;
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            this.orderDateDataGridViewTextBoxColumn1.Width = 80;
            // 
            // Customername
            // 
            this.Customername.DataPropertyName = "Customername";
            this.Customername.HeaderText = "Customername";
            this.Customername.Name = "Customername";
            // 
            // grandTotalDataGridViewTextBoxColumn1
            // 
            this.grandTotalDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.grandTotalDataGridViewTextBoxColumn1.DataPropertyName = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn1.HeaderText = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn1.Name = "grandTotalDataGridViewTextBoxColumn1";
            this.grandTotalDataGridViewTextBoxColumn1.Width = 90;
            // 
            // totalPaymentDataGridViewTextBoxColumn1
            // 
            this.totalPaymentDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalPaymentDataGridViewTextBoxColumn1.DataPropertyName = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn1.HeaderText = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn1.Name = "totalPaymentDataGridViewTextBoxColumn1";
            this.totalPaymentDataGridViewTextBoxColumn1.Width = 90;
            // 
            // paymentDueDataGridViewTextBoxColumn1
            // 
            this.paymentDueDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paymentDueDataGridViewTextBoxColumn1.DataPropertyName = "PaymentDue";
            this.paymentDueDataGridViewTextBoxColumn1.HeaderText = "PaymentDue";
            this.paymentDueDataGridViewTextBoxColumn1.Name = "paymentDueDataGridViewTextBoxColumn1";
            this.paymentDueDataGridViewTextBoxColumn1.Width = 90;
            // 
            // chequeNo
            // 
            this.chequeNo.DataPropertyName = "chequeNo";
            this.chequeNo.HeaderText = "chequeNo";
            this.chequeNo.Name = "chequeNo";
            // 
            // chequeDetails
            // 
            this.chequeDetails.DataPropertyName = "chequeDetails";
            this.chequeDetails.HeaderText = "chequeDetails";
            this.chequeDetails.Name = "chequeDetails";
            // 
            // frmSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1032, 664);
            this.Controls.Add(this.TabControl1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSalesRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Record";
            this.Load += new System.EventHandler(this.frmSalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            this.TabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private logindataDataSet3 logindataDataSet3;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private logindataDataSet3TableAdapters.salesTableAdapter salesTableAdapter;
        private logindataDataSet5 logindataDataSet5;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private logindataDataSet5TableAdapters.salesTableAdapter salesTableAdapter1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.DataGridView DataGridView3;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.Button button10;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.ComboBox cmbCustomerName;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TabControl TabControl1;
        private logindataDataSet11 logindataDataSet11;
        private System.Windows.Forms.BindingSource salesBindingSource2;
        private logindataDataSet11TableAdapters.salesTableAdapter salesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDetails;
    }
}