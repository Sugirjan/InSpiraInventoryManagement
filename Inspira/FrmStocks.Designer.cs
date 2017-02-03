namespace Inspira
{
    partial class FrmStocks
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
            this.txtCompanyname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtBatchno = new System.Windows.Forms.TextBox();
            this.txtChemicalName = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpManufacturedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchasedDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompanyname
            // 
            this.txtCompanyname.Location = new System.Drawing.Point(191, 162);
            this.txtCompanyname.Name = "txtCompanyname";
            this.txtCompanyname.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyname.TabIndex = 81;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(16, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(16, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(326, 15);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(29, 21);
            this.Button2.TabIndex = 89;
            this.Button2.Text = "<";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnUpdate);
            this.GroupBox2.Controls.Add(this.btnSave);
            this.GroupBox2.Controls.Add(this.btnNew);
            this.GroupBox2.Location = new System.Drawing.Point(513, 1);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(119, 169);
            this.GroupBox2.TabIndex = 86;
            this.GroupBox2.TabStop = false;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(191, 201);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(119, 20);
            this.txtUnitPrice.TabIndex = 82;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.LightGray;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(62, -36);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(140, 22);
            this.Label11.TabIndex = 87;
            this.Label11.Text = "Customer Details";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(68, 284);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(71, 17);
            this.Label21.TabIndex = 97;
            this.Label21.Text = "Expiry Date";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(66, 243);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(114, 17);
            this.Label20.TabIndex = 96;
            this.Label20.Text = "Manufactured Date";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(63, 204);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(61, 17);
            this.Label19.TabIndex = 95;
            this.Label19.Text = "Unit Price";
            // 
            // txtBatchno
            // 
            this.txtBatchno.Location = new System.Drawing.Point(192, 124);
            this.txtBatchno.Name = "txtBatchno";
            this.txtBatchno.Size = new System.Drawing.Size(144, 20);
            this.txtBatchno.TabIndex = 80;
            // 
            // txtChemicalName
            // 
            this.txtChemicalName.Location = new System.Drawing.Point(191, 83);
            this.txtChemicalName.Name = "txtChemicalName";
            this.txtChemicalName.Size = new System.Drawing.Size(273, 20);
            this.txtChemicalName.TabIndex = 79;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(63, 162);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(95, 17);
            this.Label9.TabIndex = 94;
            this.Label9.Text = "Company name";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(68, 125);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 17);
            this.Label6.TabIndex = 93;
            this.Label6.Text = "Batch No";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(68, 86);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(94, 17);
            this.Label5.TabIndex = 92;
            this.Label5.Text = "Chemical Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(68, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 17);
            this.Label2.TabIndex = 91;
            this.Label2.Text = "Drug Name";
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(191, 50);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(273, 20);
            this.txtDrugName.TabIndex = 78;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(192, 16);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(118, 20);
            this.txtProductId.TabIndex = 88;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(68, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 17);
            this.Label4.TabIndex = 90;
            this.Label4.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Purchased Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(191, 360);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 104;
            // 
            // dtpManufacturedDate
            // 
            this.dtpManufacturedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpManufacturedDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpManufacturedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpManufacturedDate.Location = new System.Drawing.Point(191, 237);
            this.dtpManufacturedDate.Name = "dtpManufacturedDate";
            this.dtpManufacturedDate.Size = new System.Drawing.Size(120, 24);
            this.dtpManufacturedDate.TabIndex = 105;
            this.dtpManufacturedDate.Value = new System.DateTime(2016, 5, 18, 0, 0, 0, 0);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpExpiryDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(191, 277);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(120, 24);
            this.dtpExpiryDate.TabIndex = 106;
            // 
            // dtpPurchasedDate
            // 
            this.dtpPurchasedDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpPurchasedDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchasedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchasedDate.Location = new System.Drawing.Point(190, 322);
            this.dtpPurchasedDate.Name = "dtpPurchasedDate";
            this.dtpPurchasedDate.Size = new System.Drawing.Size(120, 24);
            this.dtpPurchasedDate.TabIndex = 107;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(16, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 429);
            this.Controls.Add(this.dtpPurchasedDate);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.dtpManufacturedDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyname);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txtBatchno);
            this.Controls.Add(this.txtChemicalName);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDrugName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.Label4);
            this.Name = "FrmStocks";
            this.Text = "Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStock_FormClosing);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCompanyname;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtUnitPrice;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtBatchno;
        internal System.Windows.Forms.TextBox txtChemicalName;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDrugName;
        internal System.Windows.Forms.TextBox txtProductId;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.DateTimePicker dtpManufacturedDate;
        internal System.Windows.Forms.DateTimePicker dtpExpiryDate;
        internal System.Windows.Forms.DateTimePicker dtpPurchasedDate;
        internal System.Windows.Forms.Button btnUpdate;
    }
}