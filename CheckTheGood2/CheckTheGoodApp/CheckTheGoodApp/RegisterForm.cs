using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CheckTheGoodApp
{
    public partial class RegisterForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnGotoSig_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logF = new LoginForm();
            logF.Show();
        }

        private void btnRegRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string password = txtRegPassword.Text;
            string repassword = txtRegRePassword.Text;//comfirm pass
            string fullname = txtRegFullname.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("username and password cannot be empty");
            }
            else if (password != repassword)
            {
                MessageBox.Show("password comfirmation is incorrect");
            }
            else
            {
                string checkUsername = "Select Username from AccountList where Username ='" + username + "'";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(checkUsername, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("username has already been used try other");


                }
                else 
                {
                    SqlCommand addCmd = new SqlCommand("UserAdd", cnn);
                    addCmd.CommandType = CommandType.StoredProcedure;
                    addCmd.Parameters.AddWithValue("@Username", username);
                    addCmd.Parameters.AddWithValue("@Password", password);
                    addCmd.Parameters.AddWithValue("@Fullname", fullname);
                    MessageBox.Show("Resgistration success");
                    addCmd.ExecuteNonQuery();
                    this.Hide();
                    LoginForm newLog = new LoginForm();
                    newLog.Show();
                }
            }

        }
        void ClearForm()
        {
            txtRegUsername.Text = txtRegPassword.Text = txtRegRePassword.Text = "";
        }

    }
}
