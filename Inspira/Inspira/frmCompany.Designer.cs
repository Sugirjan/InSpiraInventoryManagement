﻿namespace Inspira
{
    partial class frmCompany
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(309, 14);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(68, 32);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "&Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(235, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(396, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(45, 36);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(314, 24);
            this.txtCompanyName.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(161, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(25, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 62);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(447, 210);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompany";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtCompanyName;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.TextBox textBox1;
    }
}