namespace CheckTheGoodApp
{
    partial class UpdateNote
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
            this.btnUpdateCheck = new System.Windows.Forms.Button();
            this.btnUpdateGoHome = new System.Windows.Forms.Button();
            this.btnUpdateUpdateNote = new System.Windows.Forms.Button();
            this.checkTheGoodDataSet = new CheckTheGoodApp.CheckTheGoodDataSet();
            this.checkTheGoodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkTheGoodDataSet2 = new CheckTheGoodApp.CheckTheGoodDataSet2();
            this.importListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importListTableAdapter = new CheckTheGoodApp.CheckTheGoodDataSet2TableAdapters.ImportListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdateCheck
            // 
            this.btnUpdateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnUpdateCheck.Location = new System.Drawing.Point(56, 59);
            this.btnUpdateCheck.Name = "btnUpdateCheck";
            this.btnUpdateCheck.Size = new System.Drawing.Size(207, 50);
            this.btnUpdateCheck.TabIndex = 1;
            this.btnUpdateCheck.Text = "View Import List";
            this.btnUpdateCheck.UseVisualStyleBackColor = true;
            this.btnUpdateCheck.Click += new System.EventHandler(this.btnUpdateCheck_Click);
            // 
            // btnUpdateGoHome
            // 
            this.btnUpdateGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnUpdateGoHome.Location = new System.Drawing.Point(547, 59);
            this.btnUpdateGoHome.Name = "btnUpdateGoHome";
            this.btnUpdateGoHome.Size = new System.Drawing.Size(207, 50);
            this.btnUpdateGoHome.TabIndex = 2;
            this.btnUpdateGoHome.Text = "Return Home";
            this.btnUpdateGoHome.UseVisualStyleBackColor = true;
            this.btnUpdateGoHome.Click += new System.EventHandler(this.btnUpdateGoHome_Click);
            // 
            // btnUpdateUpdateNote
            // 
            this.btnUpdateUpdateNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnUpdateUpdateNote.Location = new System.Drawing.Point(73, 378);
            this.btnUpdateUpdateNote.Name = "btnUpdateUpdateNote";
            this.btnUpdateUpdateNote.Size = new System.Drawing.Size(137, 47);
            this.btnUpdateUpdateNote.TabIndex = 3;
            this.btnUpdateUpdateNote.Text = "Update";
            this.btnUpdateUpdateNote.UseVisualStyleBackColor = true;
            this.btnUpdateUpdateNote.Click += new System.EventHandler(this.btnUpdateUpdateNote_Click);
            // 
            // checkTheGoodDataSet
            // 
            this.checkTheGoodDataSet.DataSetName = "CheckTheGoodDataSet";
            this.checkTheGoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkTheGoodDataSetBindingSource
            // 
            this.checkTheGoodDataSetBindingSource.DataSource = this.checkTheGoodDataSet;
            this.checkTheGoodDataSetBindingSource.Position = 0;
            // 
            // checkTheGoodDataSet2
            // 
            this.checkTheGoodDataSet2.DataSetName = "CheckTheGoodDataSet2";
            this.checkTheGoodDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importListBindingSource
            // 
            this.importListBindingSource.DataMember = "ImportList";
            this.importListBindingSource.DataSource = this.checkTheGoodDataSet2;
            // 
            // importListTableAdapter
            // 
            this.importListTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateUpdateNote);
            this.Controls.Add(this.btnUpdateGoHome);
            this.Controls.Add(this.btnUpdateCheck);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateNote";
            this.Text = "UpdateNote";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateCheck;
        private System.Windows.Forms.Button btnUpdateGoHome;
        private System.Windows.Forms.Button btnUpdateUpdateNote;
        private System.Windows.Forms.BindingSource checkTheGoodDataSetBindingSource;
        private CheckTheGoodDataSet checkTheGoodDataSet;
        private CheckTheGoodDataSet2 checkTheGoodDataSet2;
        private System.Windows.Forms.BindingSource importListBindingSource;
        private CheckTheGoodDataSet2TableAdapters.ImportListTableAdapter importListTableAdapter;
    }
}