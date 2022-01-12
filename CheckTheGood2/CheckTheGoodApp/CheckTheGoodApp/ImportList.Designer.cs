namespace CheckTheGoodApp
{
    partial class ImportList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelDNote = new System.Windows.Forms.Label();
            this.btnDNoteOList = new System.Windows.Forms.Button();
            this.labelDNoteOList = new System.Windows.Forms.Label();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDNoteImList = new System.Windows.Forms.Button();
            this.btnGotoH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(407, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(381, 283);
            this.dataGridView2.TabIndex = 1;
            // 
            // labelDNote
            // 
            this.labelDNote.AutoSize = true;
            this.labelDNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelDNote.Location = new System.Drawing.Point(12, 101);
            this.labelDNote.Name = "labelDNote";
            this.labelDNote.Size = new System.Drawing.Size(141, 31);
            this.labelDNote.TabIndex = 2;
            this.labelDNote.Text = "Import List";
            // 
            // btnDNoteOList
            // 
            this.btnDNoteOList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDNoteOList.Location = new System.Drawing.Point(700, 95);
            this.btnDNoteOList.Name = "btnDNoteOList";
            this.btnDNoteOList.Size = new System.Drawing.Size(88, 34);
            this.btnDNoteOList.TabIndex = 3;
            this.btnDNoteOList.Text = "Check";
            this.btnDNoteOList.UseVisualStyleBackColor = true;
            this.btnDNoteOList.Click += new System.EventHandler(this.btnDNoteOList_Click);
            // 
            // labelDNoteOList
            // 
            this.labelDNoteOList.AutoSize = true;
            this.labelDNoteOList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelDNoteOList.Location = new System.Drawing.Point(491, 21);
            this.labelDNoteOList.Name = "labelDNoteOList";
            this.labelDNoteOList.Size = new System.Drawing.Size(213, 31);
            this.labelDNoteOList.TabIndex = 4;
            this.labelDNoteOList.Text = "View Order by id";
            // 
            // txtImportID
            // 
            this.txtImportID.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.txtImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtImportID.Location = new System.Drawing.Point(550, 98);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(144, 31);
            this.txtImportID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(402, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type ImportId";
            // 
            // btnDNoteImList
            // 
            this.btnDNoteImList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDNoteImList.Location = new System.Drawing.Point(228, 99);
            this.btnDNoteImList.Name = "btnDNoteImList";
            this.btnDNoteImList.Size = new System.Drawing.Size(123, 33);
            this.btnDNoteImList.TabIndex = 7;
            this.btnDNoteImList.Text = "See List";
            this.btnDNoteImList.UseVisualStyleBackColor = true;
            this.btnDNoteImList.Click += new System.EventHandler(this.btnDNoteImList_Click);
            // 
            // btnGotoH
            // 
            this.btnGotoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnGotoH.Location = new System.Drawing.Point(18, 21);
            this.btnGotoH.Name = "btnGotoH";
            this.btnGotoH.Size = new System.Drawing.Size(191, 55);
            this.btnGotoH.TabIndex = 8;
            this.btnGotoH.Text = "Return Home";
            this.btnGotoH.UseVisualStyleBackColor = true;
            this.btnGotoH.Click += new System.EventHandler(this.btnGotoH_Click);
            // 
            // DeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGotoH);
            this.Controls.Add(this.btnDNoteImList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImportID);
            this.Controls.Add(this.labelDNoteOList);
            this.Controls.Add(this.btnDNoteOList);
            this.Controls.Add(this.labelDNote);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeliveryNote";
            this.Text = "DeliveryNote";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelDNote;
        private System.Windows.Forms.Button btnDNoteOList;
        private System.Windows.Forms.Label labelDNoteOList;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDNoteImList;
        private System.Windows.Forms.Button btnGotoH;
    }
}