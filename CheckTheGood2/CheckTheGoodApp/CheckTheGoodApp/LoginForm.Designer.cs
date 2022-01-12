namespace CheckTheGoodApp
{
    partial class LoginForm
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
            this.btnSigSignin = new System.Windows.Forms.Button();
            this.btnGotoReg = new System.Windows.Forms.Button();
            this.tittleSignin = new System.Windows.Forms.Label();
            this.txtSigPassword = new System.Windows.Forms.TextBox();
            this.txtSigUsername = new System.Windows.Forms.TextBox();
            this.labelSigPassword = new System.Windows.Forms.Label();
            this.labelSigUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSigSignin
            // 
            this.btnSigSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSigSignin.Location = new System.Drawing.Point(436, 324);
            this.btnSigSignin.Name = "btnSigSignin";
            this.btnSigSignin.Size = new System.Drawing.Size(192, 51);
            this.btnSigSignin.TabIndex = 13;
            this.btnSigSignin.Text = "Sign in";
            this.btnSigSignin.UseVisualStyleBackColor = true;
            this.btnSigSignin.Click += new System.EventHandler(this.btnSigSignin_Click);
            // 
            // btnGotoReg
            // 
            this.btnGotoReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnGotoReg.Location = new System.Drawing.Point(150, 324);
            this.btnGotoReg.Name = "btnGotoReg";
            this.btnGotoReg.Size = new System.Drawing.Size(212, 103);
            this.btnGotoReg.TabIndex = 12;
            this.btnGotoReg.Text = "I want to Register";
            this.btnGotoReg.UseVisualStyleBackColor = true;
            this.btnGotoReg.Click += new System.EventHandler(this.btnGotoReg_Click);
            // 
            // tittleSignin
            // 
            this.tittleSignin.AutoSize = true;
            this.tittleSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tittleSignin.Location = new System.Drawing.Point(113, 23);
            this.tittleSignin.Name = "tittleSignin";
            this.tittleSignin.Size = new System.Drawing.Size(575, 47);
            this.tittleSignin.TabIndex = 11;
            this.tittleSignin.Text = "Welcome To Check The Good";
            this.tittleSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSigPassword
            // 
            this.txtSigPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.txtSigPassword.Location = new System.Drawing.Point(436, 197);
            this.txtSigPassword.Name = "txtSigPassword";
            this.txtSigPassword.PasswordChar = '#';
            this.txtSigPassword.Size = new System.Drawing.Size(192, 53);
            this.txtSigPassword.TabIndex = 10;
            // 
            // txtSigUsername
            // 
            this.txtSigUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.txtSigUsername.Location = new System.Drawing.Point(436, 113);
            this.txtSigUsername.Name = "txtSigUsername";
            this.txtSigUsername.Size = new System.Drawing.Size(192, 53);
            this.txtSigUsername.TabIndex = 9;
            // 
            // labelSigPassword
            // 
            this.labelSigPassword.AutoSize = true;
            this.labelSigPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelSigPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSigPassword.Location = new System.Drawing.Point(151, 203);
            this.labelSigPassword.Name = "labelSigPassword";
            this.labelSigPassword.Size = new System.Drawing.Size(202, 47);
            this.labelSigPassword.TabIndex = 8;
            this.labelSigPassword.Text = "Password";
            // 
            // labelSigUsername
            // 
            this.labelSigUsername.AutoSize = true;
            this.labelSigUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelSigUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSigUsername.Location = new System.Drawing.Point(151, 119);
            this.labelSigUsername.Name = "labelSigUsername";
            this.labelSigUsername.Size = new System.Drawing.Size(211, 47);
            this.labelSigUsername.TabIndex = 7;
            this.labelSigUsername.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSigSignin);
            this.Controls.Add(this.btnGotoReg);
            this.Controls.Add(this.tittleSignin);
            this.Controls.Add(this.txtSigPassword);
            this.Controls.Add(this.txtSigUsername);
            this.Controls.Add(this.labelSigPassword);
            this.Controls.Add(this.labelSigUsername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSigSignin;
        private System.Windows.Forms.Button btnGotoReg;
        private System.Windows.Forms.Label tittleSignin;
        private System.Windows.Forms.TextBox txtSigPassword;
        private System.Windows.Forms.TextBox txtSigUsername;
        private System.Windows.Forms.Label labelSigPassword;
        private System.Windows.Forms.Label labelSigUsername;
    }
}

