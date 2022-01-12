namespace CheckTheGoodApp
{
    partial class Import
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
            this.btnImPrint = new System.Windows.Forms.Button();
            this.txtImTotal = new System.Windows.Forms.TextBox();
            this.labelImTotal = new System.Windows.Forms.Label();
            this.labelImReciept = new System.Windows.Forms.Label();
            this.dataGridReceipt = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImAdd = new System.Windows.Forms.Button();
            this.dataImport = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkTheGoodDataSet = new CheckTheGoodApp.CheckTheGoodDataSet();
            this.txtImQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImPid = new System.Windows.Forms.TextBox();
            this.labelImPid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productTableAdapter = new CheckTheGoodApp.CheckTheGoodDataSetTableAdapters.ProductTableAdapter();
            this.recieptClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recieptClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImPrint
            // 
            this.btnImPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnImPrint.Location = new System.Drawing.Point(18, 385);
            this.btnImPrint.Name = "btnImPrint";
            this.btnImPrint.Size = new System.Drawing.Size(215, 38);
            this.btnImPrint.TabIndex = 24;
            this.btnImPrint.Text = "getReceipt";
            this.btnImPrint.UseVisualStyleBackColor = true;
            this.btnImPrint.Click += new System.EventHandler(this.btnImPrint_Click);
            // 
            // txtImTotal
            // 
            this.txtImTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtImTotal.Location = new System.Drawing.Point(124, 317);
            this.txtImTotal.Name = "txtImTotal";
            this.txtImTotal.Size = new System.Drawing.Size(109, 31);
            this.txtImTotal.TabIndex = 23;
            // 
            // labelImTotal
            // 
            this.labelImTotal.AutoSize = true;
            this.labelImTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelImTotal.Location = new System.Drawing.Point(13, 323);
            this.labelImTotal.Name = "labelImTotal";
            this.labelImTotal.Size = new System.Drawing.Size(60, 25);
            this.labelImTotal.TabIndex = 22;
            this.labelImTotal.Text = "Total";
            // 
            // labelImReciept
            // 
            this.labelImReciept.AutoSize = true;
            this.labelImReciept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelImReciept.Location = new System.Drawing.Point(253, 289);
            this.labelImReciept.Name = "labelImReciept";
            this.labelImReciept.Size = new System.Drawing.Size(85, 25);
            this.labelImReciept.TabIndex = 21;
            this.labelImReciept.Text = "Reciept";
            // 
            // dataGridReceipt
            // 
            this.dataGridReceipt.AutoGenerateColumns = false;
            this.dataGridReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridReceipt.DataSource = this.receiptBindingSource;
            this.dataGridReceipt.Location = new System.Drawing.Point(258, 317);
            this.dataGridReceipt.Name = "dataGridReceipt";
            this.dataGridReceipt.Size = new System.Drawing.Size(530, 119);
            this.dataGridReceipt.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(CheckTheGoodApp.Receipt);
            // 
            // btnImAdd
            // 
            this.btnImAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnImAdd.Location = new System.Drawing.Point(93, 237);
            this.btnImAdd.Name = "btnImAdd";
            this.btnImAdd.Size = new System.Drawing.Size(140, 36);
            this.btnImAdd.TabIndex = 19;
            this.btnImAdd.Text = "Import item";
            this.btnImAdd.UseVisualStyleBackColor = true;
            this.btnImAdd.Click += new System.EventHandler(this.btnImAdd_Click);
            // 
            // dataImport
            // 
            this.dataImport.AutoGenerateColumns = false;
            this.dataImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn1,
            this.ppriceDataGridViewTextBoxColumn});
            this.dataImport.DataSource = this.productBindingSource;
            this.dataImport.Location = new System.Drawing.Point(258, 93);
            this.dataImport.Name = "dataImport";
            this.dataImport.Size = new System.Drawing.Size(530, 180);
            this.dataImport.TabIndex = 18;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn1
            // 
            this.pNameDataGridViewTextBoxColumn1.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn1.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn1.Name = "pNameDataGridViewTextBoxColumn1";
            // 
            // ppriceDataGridViewTextBoxColumn
            // 
            this.ppriceDataGridViewTextBoxColumn.DataPropertyName = "Pprice";
            this.ppriceDataGridViewTextBoxColumn.HeaderText = "Pprice";
            this.ppriceDataGridViewTextBoxColumn.Name = "ppriceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.checkTheGoodDataSet;
            // 
            // checkTheGoodDataSet
            // 
            this.checkTheGoodDataSet.DataSetName = "CheckTheGoodDataSet";
            this.checkTheGoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtImQuantity
            // 
            this.txtImQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtImQuantity.Location = new System.Drawing.Point(124, 169);
            this.txtImQuantity.Name = "txtImQuantity";
            this.txtImQuantity.Size = new System.Drawing.Size(109, 31);
            this.txtImQuantity.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "number";
            // 
            // txtImPid
            // 
            this.txtImPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtImPid.Location = new System.Drawing.Point(124, 93);
            this.txtImPid.Name = "txtImPid";
            this.txtImPid.Size = new System.Drawing.Size(109, 31);
            this.txtImPid.TabIndex = 15;
            // 
            // labelImPid
            // 
            this.labelImPid.AutoSize = true;
            this.labelImPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelImPid.Location = new System.Drawing.Point(12, 93);
            this.labelImPid.Name = "labelImPid";
            this.labelImPid.Size = new System.Drawing.Size(106, 25);
            this.labelImPid.TabIndex = 14;
            this.labelImPid.Text = "ProductID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose item to import";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(571, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Return Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImPrint);
            this.Controls.Add(this.txtImTotal);
            this.Controls.Add(this.labelImTotal);
            this.Controls.Add(this.labelImReciept);
            this.Controls.Add(this.dataGridReceipt);
            this.Controls.Add(this.btnImAdd);
            this.Controls.Add(this.dataImport);
            this.Controls.Add(this.txtImQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImPid);
            this.Controls.Add(this.labelImPid);
            this.Controls.Add(this.label1);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptClassBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImPrint;
        private System.Windows.Forms.TextBox txtImTotal;
        private System.Windows.Forms.Label labelImTotal;
        private System.Windows.Forms.Label labelImReciept;
        private System.Windows.Forms.DataGridView dataGridReceipt;
        private System.Windows.Forms.Button btnImAdd;
        private System.Windows.Forms.DataGridView dataImport;
        private System.Windows.Forms.TextBox txtImQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImPid;
        private System.Windows.Forms.Label labelImPid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource recieptClassBindingSource;
        private CheckTheGoodDataSet checkTheGoodDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private CheckTheGoodDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recieptClassBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.Button button1;
    }
}