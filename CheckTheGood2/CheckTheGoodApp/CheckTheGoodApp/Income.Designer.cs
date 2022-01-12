namespace CheckTheGoodApp
{
    partial class Income
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
            this.btnIncome = new System.Windows.Forms.Button();
            this.labelIncome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncome
            // 
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnIncome.Location = new System.Drawing.Point(12, 114);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(266, 66);
            this.btnIncome.TabIndex = 0;
            this.btnIncome.Text = "Check income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelIncome.Location = new System.Drawing.Point(333, 121);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(249, 47);
            this.labelIncome.TabIndex = 1;
            this.labelIncome.Text = "Income here";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 252);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGoHome
            // 
            this.btnGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnGoHome.Location = new System.Drawing.Point(12, 12);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(253, 72);
            this.btnGoHome.TabIndex = 3;
            this.btnGoHome.Text = "Return Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.btnIncome);
            this.Name = "Income";
            this.Text = "Income";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoHome;
    }
}