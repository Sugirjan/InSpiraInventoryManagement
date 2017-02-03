namespace Inspira
{
    partial class frmReturn2
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
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet9 = new Inspira.logindataDataSet9();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.stockTableAdapter = new Inspira.logindataDataSet9TableAdapters.stockTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet7 = new Inspira.logindataDataSet7();
            this.stockBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter1 = new Inspira.logindataDataSet7TableAdapters.stockTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.logindataDataSet9BindingSource;
            // 
            // logindataDataSet9BindingSource
            // 
            this.logindataDataSet9BindingSource.DataSource = this.logindataDataSet9;
            this.logindataDataSet9BindingSource.Position = 0;
            // 
            // logindataDataSet9
            // 
            this.logindataDataSet9.DataSetName = "logindataDataSet9";
            this.logindataDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductname);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Drug Name";
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(16, 40);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(178, 24);
            this.txtProductname.TabIndex = 0;
            this.txtProductname.TextChanged += new System.EventHandler(this.txtProductname_TextChanged);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.batchNoDataGridViewTextBoxColumn,
            this.drugNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(79, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 301);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "stock";
            this.stockBindingSource1.DataSource = this.logindataDataSet9BindingSource;
            // 
            // stockBindingSource2
            // 
            this.stockBindingSource2.DataMember = "stock";
            this.stockBindingSource2.DataSource = this.logindataDataSet9BindingSource;
            // 
            // logindataDataSet7
            // 
            this.logindataDataSet7.DataSetName = "logindataDataSet7";
            this.logindataDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource3
            // 
            this.stockBindingSource3.DataMember = "stock";
            this.stockBindingSource3.DataSource = this.logindataDataSet7;
            // 
            // stockTableAdapter1
            // 
            this.stockTableAdapter1.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // batchNoDataGridViewTextBoxColumn
            // 
            this.batchNoDataGridViewTextBoxColumn.DataPropertyName = "batchNo";
            this.batchNoDataGridViewTextBoxColumn.HeaderText = "batchNo";
            this.batchNoDataGridViewTextBoxColumn.Name = "batchNoDataGridViewTextBoxColumn";
            // 
            // drugNameDataGridViewTextBoxColumn
            // 
            this.drugNameDataGridViewTextBoxColumn.DataPropertyName = "DrugName";
            this.drugNameDataGridViewTextBoxColumn.HeaderText = "DrugName";
            this.drugNameDataGridViewTextBoxColumn.Name = "drugNameDataGridViewTextBoxColumn";
            // 
            // frmReturn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmReturn2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductsRecord_FormClosing);
            this.Load += new System.EventHandler(this.frmProductsRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.BindingSource logindataDataSet9BindingSource;
        private logindataDataSet9 logindataDataSet9;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private logindataDataSet9TableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.BindingSource stockBindingSource2;
        private logindataDataSet7 logindataDataSet7;
        private System.Windows.Forms.BindingSource stockBindingSource3;
        private logindataDataSet7TableAdapters.stockTableAdapter stockTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameDataGridViewTextBoxColumn;
    }
}