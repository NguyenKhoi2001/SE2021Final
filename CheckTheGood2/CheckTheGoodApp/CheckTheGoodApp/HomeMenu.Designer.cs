namespace CheckTheGoodApp
{
    partial class HomeMenu
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
            this.btnHimport = new System.Windows.Forms.Button();
            this.labelHWelcome = new System.Windows.Forms.Label();
            this.btnHNote = new System.Windows.Forms.Button();
            this.labelHomeWelcome = new System.Windows.Forms.Label();
            this.labelHomeFullname = new System.Windows.Forms.Label();
            this.btnHomeLogout = new System.Windows.Forms.Button();
            this.btnHomeUpdate = new System.Windows.Forms.Button();
            this.btnHViewStocl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHimport
            // 
            this.btnHimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnHimport.Location = new System.Drawing.Point(20, 149);
            this.btnHimport.Name = "btnHimport";
            this.btnHimport.Size = new System.Drawing.Size(294, 92);
            this.btnHimport.TabIndex = 3;
            this.btnHimport.Text = "Import Goods";
            this.btnHimport.UseVisualStyleBackColor = true;
            this.btnHimport.Click += new System.EventHandler(this.btnHimport_Click);
            // 
            // labelHWelcome
            // 
            this.labelHWelcome.AutoSize = true;
            this.labelHWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelHWelcome.Location = new System.Drawing.Point(12, 31);
            this.labelHWelcome.Name = "labelHWelcome";
            this.labelHWelcome.Size = new System.Drawing.Size(0, 47);
            this.labelHWelcome.TabIndex = 2;
            // 
            // btnHNote
            // 
            this.btnHNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnHNote.Location = new System.Drawing.Point(20, 247);
            this.btnHNote.Name = "btnHNote";
            this.btnHNote.Size = new System.Drawing.Size(294, 92);
            this.btnHNote.TabIndex = 5;
            this.btnHNote.Text = "View Import List";
            this.btnHNote.UseVisualStyleBackColor = true;
            this.btnHNote.Click += new System.EventHandler(this.btnHNote_Click);
            // 
            // labelHomeWelcome
            // 
            this.labelHomeWelcome.AutoSize = true;
            this.labelHomeWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelHomeWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHomeWelcome.Location = new System.Drawing.Point(173, 31);
            this.labelHomeWelcome.Name = "labelHomeWelcome";
            this.labelHomeWelcome.Size = new System.Drawing.Size(473, 47);
            this.labelHomeWelcome.TabIndex = 6;
            this.labelHomeWelcome.Text = "Welcome to Home menu";
            // 
            // labelHomeFullname
            // 
            this.labelHomeFullname.AutoSize = true;
            this.labelHomeFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelHomeFullname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHomeFullname.Location = new System.Drawing.Point(302, 94);
            this.labelHomeFullname.Name = "labelHomeFullname";
            this.labelHomeFullname.Size = new System.Drawing.Size(186, 31);
            this.labelHomeFullname.TabIndex = 7;
            this.labelHomeFullname.Text = "Fullname here";
            // 
            // btnHomeLogout
            // 
            this.btnHomeLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnHomeLogout.Location = new System.Drawing.Point(295, 345);
            this.btnHomeLogout.Name = "btnHomeLogout";
            this.btnHomeLogout.Size = new System.Drawing.Size(170, 92);
            this.btnHomeLogout.TabIndex = 8;
            this.btnHomeLogout.Text = "Log out";
            this.btnHomeLogout.UseVisualStyleBackColor = true;
            this.btnHomeLogout.Click += new System.EventHandler(this.btnHomeLogout_Click);
            // 
            // btnHomeUpdate
            // 
            this.btnHomeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnHomeUpdate.Location = new System.Drawing.Point(462, 149);
            this.btnHomeUpdate.Name = "btnHomeUpdate";
            this.btnHomeUpdate.Size = new System.Drawing.Size(294, 92);
            this.btnHomeUpdate.TabIndex = 9;
            this.btnHomeUpdate.Text = "Change Delivery Note";
            this.btnHomeUpdate.UseVisualStyleBackColor = true;
            this.btnHomeUpdate.Click += new System.EventHandler(this.btnHomeUpdate_Click);
            // 
            // btnHViewStocl
            // 
            this.btnHViewStocl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnHViewStocl.Location = new System.Drawing.Point(462, 247);
            this.btnHViewStocl.Name = "btnHViewStocl";
            this.btnHViewStocl.Size = new System.Drawing.Size(294, 92);
            this.btnHViewStocl.TabIndex = 10;
            this.btnHViewStocl.Text = "View income/stock";
            this.btnHViewStocl.UseVisualStyleBackColor = true;
            this.btnHViewStocl.Click += new System.EventHandler(this.btnHViewStocl_Click);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHViewStocl);
            this.Controls.Add(this.btnHomeUpdate);
            this.Controls.Add(this.btnHomeLogout);
            this.Controls.Add(this.labelHomeFullname);
            this.Controls.Add(this.labelHomeWelcome);
            this.Controls.Add(this.btnHNote);
            this.Controls.Add(this.btnHimport);
            this.Controls.Add(this.labelHWelcome);
            this.Name = "HomeMenu";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHimport;
        private System.Windows.Forms.Label labelHWelcome;
        private System.Windows.Forms.Button btnHNote;
        private System.Windows.Forms.Label labelHomeWelcome;
        private System.Windows.Forms.Label labelHomeFullname;
        private System.Windows.Forms.Button btnHomeLogout;
        private System.Windows.Forms.Button btnHomeUpdate;
        private System.Windows.Forms.Button btnHViewStocl;
    }
}