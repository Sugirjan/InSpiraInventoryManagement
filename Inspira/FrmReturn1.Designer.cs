namespace Inspira
{
    partial class frmReturn1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logindataDataSet6 = new Inspira.logindataDataSet6();
            this.returnitemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.returnitemsTableAdapter = new Inspira.logindataDataSet6TableAdapters.returnitemsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logindataDataSet8 = new Inspira.logindataDataSet8();
            this.returnitemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.returnitemsTableAdapter1 = new Inspira.logindataDataSet8TableAdapters.returnitemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnitemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnitemsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.returnitemsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 201);
            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // logindataDataSet6
            // 
            this.logindataDataSet6.DataSetName = "logindataDataSet6";
            this.logindataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnitemsBindingSource1
            // 
            this.returnitemsBindingSource1.DataMember = "returnitems";
            this.returnitemsBindingSource1.DataSource = this.logindataDataSet6;
            // 
            // returnitemsTableAdapter
            // 
            this.returnitemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productID";
            this.dataGridViewTextBoxColumn1.HeaderText = "productID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "batchID";
            this.dataGridViewTextBoxColumn2.HeaderText = "batchID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "drugName";
            this.dataGridViewTextBoxColumn3.HeaderText = "drugName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "reason";
            this.dataGridViewTextBoxColumn4.HeaderText = "reason";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // logindataDataSet8
            // 
            this.logindataDataSet8.DataSetName = "logindataDataSet8";
            this.logindataDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnitemsBindingSource2
            // 
            this.returnitemsBindingSource2.DataMember = "returnitems";
            this.returnitemsBindingSource2.DataSource = this.logindataDataSet8;
            // 
            // returnitemsTableAdapter1
            // 
            this.returnitemsTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReturn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 277);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmReturn1";
            this.Text = "Return Items";
            this.Load += new System.EventHandler(this.frmReturn1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReturn1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnitemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindataDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnitemsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
 //       private stockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource returnitemsBindingSource;
//        private stockDataSetTableAdapters.returnitemsTableAdapter returnitemsTableAdapter;
        private logindataDataSet6 logindataDataSet6;
        private System.Windows.Forms.BindingSource returnitemsBindingSource1;
        private logindataDataSet6TableAdapters.returnitemsTableAdapter returnitemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private logindataDataSet8 logindataDataSet8;
        private System.Windows.Forms.BindingSource returnitemsBindingSource2;
        private logindataDataSet8TableAdapters.returnitemsTableAdapter returnitemsTableAdapter1;
    }
}