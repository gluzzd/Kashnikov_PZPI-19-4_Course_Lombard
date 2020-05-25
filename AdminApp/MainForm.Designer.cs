﻿namespace AdminApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.DateCheck = new System.Windows.Forms.Button();
            this.DepositsGrid = new System.Windows.Forms.DataGridView();
            this.ForSaleGrid = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeBuyOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsGridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.ForSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ForSaleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToAddRows = false;
            this.ClientsGrid.AutoGenerateColumns = false;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientsGridName,
            this.ClientsGridEmail});
            this.ClientsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientsGrid.DataSource = this.ClientBindingSource;
            this.ClientsGrid.Location = new System.Drawing.Point(12, 27);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.ReadOnly = true;
            this.ClientsGrid.RowHeadersVisible = false;
            this.ClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsGrid.Size = new System.Drawing.Size(299, 600);
            this.ClientsGrid.TabIndex = 3;
            this.ClientsGrid.DoubleClick += new System.EventHandler(this.productList_DoubleClick);
            // 
            // DateCheck
            // 
            this.DateCheck.Location = new System.Drawing.Point(767, 633);
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.Size = new System.Drawing.Size(106, 28);
            this.DateCheck.TabIndex = 4;
            this.DateCheck.Text = "CheckDate";
            this.DateCheck.UseVisualStyleBackColor = true;
            this.DateCheck.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DepositsGrid
            // 
            this.DepositsGrid.AllowUserToAddRows = false;
            this.DepositsGrid.AllowUserToDeleteRows = false;
            this.DepositsGrid.AutoGenerateColumns = false;
            this.DepositsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepositsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.dateTimeBuyOutDataGridViewTextBoxColumn});
            this.DepositsGrid.DataSource = this.DepositBindingSource;
            this.DepositsGrid.Location = new System.Drawing.Point(370, 27);
            this.DepositsGrid.Name = "DepositsGrid";
            this.DepositsGrid.ReadOnly = true;
            this.DepositsGrid.RowHeadersVisible = false;
            this.DepositsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepositsGrid.Size = new System.Drawing.Size(343, 600);
            this.DepositsGrid.TabIndex = 5;
            // 
            // ForSaleGrid
            // 
            this.ForSaleGrid.AllowUserToAddRows = false;
            this.ForSaleGrid.AllowUserToDeleteRows = false;
            this.ForSaleGrid.AutoGenerateColumns = false;
            this.ForSaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForSaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ForSaleName});
            this.ForSaleGrid.DataSource = this.ForSaleBindingSource;
            this.ForSaleGrid.Location = new System.Drawing.Point(767, 27);
            this.ForSaleGrid.Name = "ForSaleGrid";
            this.ForSaleGrid.ReadOnly = true;
            this.ForSaleGrid.RowHeadersVisible = false;
            this.ForSaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ForSaleGrid.Size = new System.Drawing.Size(240, 600);
            this.ForSaleGrid.TabIndex = 6;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeBuyOutDataGridViewTextBoxColumn
            // 
            this.dateTimeBuyOutDataGridViewTextBoxColumn.DataPropertyName = "DateTimeBuyOut";
            this.dateTimeBuyOutDataGridViewTextBoxColumn.HeaderText = "DateTimeBuyOut";
            this.dateTimeBuyOutDataGridViewTextBoxColumn.Name = "dateTimeBuyOutDataGridViewTextBoxColumn";
            this.dateTimeBuyOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DepositBindingSource
            // 
            this.DepositBindingSource.DataSource = typeof(LibraryPawnShop.Models.Deposit);
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataSource = typeof(LibraryPawnShop.Models.Client);
            // 
            // ClientsGridName
            // 
            this.ClientsGridName.DataPropertyName = "Name";
            this.ClientsGridName.HeaderText = "Name";
            this.ClientsGridName.Name = "ClientsGridName";
            this.ClientsGridName.ReadOnly = true;
            // 
            // ClientsGridEmail
            // 
            this.ClientsGridEmail.DataPropertyName = "Email";
            this.ClientsGridEmail.HeaderText = "Email";
            this.ClientsGridEmail.Name = "ClientsGridEmail";
            this.ClientsGridEmail.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(889, 633);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 28);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ForSaleBindingSource
            // 
            this.ForSaleBindingSource.DataSource = typeof(LibraryPawnShop.Models.Product);
            // 
            // ForSaleName
            // 
            this.ForSaleName.DataPropertyName = "Name";
            this.ForSaleName.HeaderText = "Name";
            this.ForSaleName.Name = "ForSaleName";
            this.ForSaleName.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 784);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ForSaleGrid);
            this.Controls.Add(this.DepositsGrid);
            this.Controls.Add(this.DateCheck);
            this.Controls.Add(this.ClientsGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.Button DateCheck;
        private System.Windows.Forms.DataGridView DepositsGrid;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.DataGridView ForSaleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeBuyOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource DepositBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsGridEmail;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForSaleName;
        private System.Windows.Forms.BindingSource ForSaleBindingSource;
    }
}

