namespace CheckTheGoodApp
{
    partial class RegisterForm
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
            System.Windows.Forms.Label labelRegFullname;
            this.txtRegRePassword = new System.Windows.Forms.TextBox();
            this.labelRegRePassword = new System.Windows.Forms.Label();
            this.btnRegRegister = new System.Windows.Forms.Button();
            this.btnGotoSig = new System.Windows.Forms.Button();
            this.Reg_label = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.labelRegPassword = new System.Windows.Forms.Label();
            this.labelRegUsername = new System.Windows.Forms.Label();
            this.checkTheGoodDataSet1 = new CheckTheGoodApp.CheckTheGoodDataSet1();
            this.accountListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountListTableAdapter = new CheckTheGoodApp.CheckTheGoodDataSet1TableAdapters.AccountListTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegFullname = new System.Windows.Forms.TextBox();
            labelRegFullname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegFullname
            // 
            labelRegFullname.AutoSize = true;
            labelRegFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            labelRegFullname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            labelRegFullname.Location = new System.Drawing.Point(162, 255);
            labelRegFullname.Name = "labelRegFullname";
            labelRegFullname.Size = new System.Drawing.Size(106, 25);
            labelRegFullname.TabIndex = 26;
            labelRegFullname.Text = "Full name";
            // 
            // txtRegRePassword
            // 
            this.txtRegRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtRegRePassword.Location = new System.Drawing.Point(447, 193);
            this.txtRegRePassword.Name = "txtRegRePassword";
            this.txtRegRePassword.PasswordChar = '#';
            this.txtRegRePassword.Size = new System.Drawing.Size(192, 31);
            this.txtRegRePassword.TabIndex = 24;
            // 
            // labelRegRePassword
            // 
            this.labelRegRePassword.AutoSize = true;
            this.labelRegRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelRegRePassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRegRePassword.Location = new System.Drawing.Point(162, 193);
            this.labelRegRePassword.Name = "labelRegRePassword";
            this.labelRegRePassword.Size = new System.Drawing.Size(222, 25);
            this.labelRegRePassword.TabIndex = 23;
            this.labelRegRePassword.Text = "Enter again Password";
            // 
            // btnRegRegister
            // 
            this.btnRegRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnRegRegister.Location = new System.Drawing.Point(447, 323);
            this.btnRegRegister.Name = "btnRegRegister";
            this.btnRegRegister.Size = new System.Drawing.Size(192, 51);
            this.btnRegRegister.TabIndex = 22;
            this.btnRegRegister.Text = "Register";
            this.btnRegRegister.UseVisualStyleBackColor = true;
            this.btnRegRegister.Click += new System.EventHandler(this.btnRegRegister_Click);
            // 
            // btnGotoSig
            // 
            this.btnGotoSig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnGotoSig.Location = new System.Drawing.Point(161, 323);
            this.btnGotoSig.Name = "btnGotoSig";
            this.btnGotoSig.Size = new System.Drawing.Size(245, 103);
            this.btnGotoSig.TabIndex = 21;
            this.btnGotoSig.Text = "I already have account (sign in)";
            this.btnGotoSig.UseVisualStyleBackColor = true;
            this.btnGotoSig.Click += new System.EventHandler(this.btnGotoSig_Click);
            // 
            // Reg_label
            // 
            this.Reg_label.AutoSize = true;
            this.Reg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.Reg_label.Location = new System.Drawing.Point(192, 24);
            this.Reg_label.Name = "Reg_label";
            this.Reg_label.Size = new System.Drawing.Size(428, 47);
            this.Reg_label.TabIndex = 20;
            this.Reg_label.Text = "Let\'s Register account";
            this.Reg_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtRegPassword.Location = new System.Drawing.Point(447, 141);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '#';
            this.txtRegPassword.Size = new System.Drawing.Size(192, 31);
            this.txtRegPassword.TabIndex = 19;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtRegUsername.Location = new System.Drawing.Point(447, 91);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(192, 31);
            this.txtRegUsername.TabIndex = 18;
            // 
            // labelRegPassword
            // 
            this.labelRegPassword.AutoSize = true;
            this.labelRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelRegPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRegPassword.Location = new System.Drawing.Point(162, 141);
            this.labelRegPassword.Name = "labelRegPassword";
            this.labelRegPassword.Size = new System.Drawing.Size(106, 25);
            this.labelRegPassword.TabIndex = 17;
            this.labelRegPassword.Text = "Password";
            // 
            // labelRegUsername
            // 
            this.labelRegUsername.AutoSize = true;
            this.labelRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelRegUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRegUsername.Location = new System.Drawing.Point(162, 91);
            this.labelRegUsername.Name = "labelRegUsername";
            this.labelRegUsername.Size = new System.Drawing.Size(110, 25);
            this.labelRegUsername.TabIndex = 16;
            this.labelRegUsername.Text = "Username";
            // 
            // checkTheGoodDataSet1
            // 
            this.checkTheGoodDataSet1.DataSetName = "CheckTheGoodDataSet1";
            this.checkTheGoodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountListBindingSource
            // 
            this.accountListBindingSource.DataMember = "AccountList";
            this.accountListBindingSource.DataSource = this.checkTheGoodDataSet1;
            // 
            // accountListTableAdapter
            // 
            this.accountListTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // txtRegFullname
            // 
            this.txtRegFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtRegFullname.Location = new System.Drawing.Point(447, 255);
            this.txtRegFullname.Name = "txtRegFullname";
            this.txtRegFullname.Size = new System.Drawing.Size(192, 31);
            this.txtRegFullname.TabIndex = 27;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegFullname);
            this.Controls.Add(labelRegFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegRePassword);
            this.Controls.Add(this.labelRegRePassword);
            this.Controls.Add(this.btnRegRegister);
            this.Controls.Add(this.btnGotoSig);
            this.Controls.Add(this.Reg_label);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.labelRegPassword);
            this.Controls.Add(this.labelRegUsername);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.checkTheGoodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegRePassword;
        private System.Windows.Forms.Label labelRegRePassword;
        private System.Windows.Forms.Button btnRegRegister;
        private System.Windows.Forms.Button btnGotoSig;
        private System.Windows.Forms.Label Reg_label;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label labelRegPassword;
        private System.Windows.Forms.Label labelRegUsername;
        private CheckTheGoodDataSet1 checkTheGoodDataSet1;
        private System.Windows.Forms.BindingSource accountListBindingSource;
        private CheckTheGoodDataSet1TableAdapters.AccountListTableAdapter accountListTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegFullname;
    }
}