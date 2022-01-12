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
    public partial class LoginForm : Form
    {   
        
        string connectionString = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        public static LoginForm instance;
        public string username;
        public string fullname = "";
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }
        
        private void btnGotoReg_Click(object sender, EventArgs e)
        { 
            this.Hide();
            RegisterForm regF = new RegisterForm();
            regF.Show();
            
        }

        private void btnSigSignin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            username = txtSigUsername.Text;
            string password = txtSigPassword.Text;
            string checkLogin = "Select Username, Password From AccountList where Username ='" + username + "' and Password ='" + password + "'";
            SqlCommand cmd = new SqlCommand(checkLogin, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login successfull");
                SqlCommand cmd2 = new SqlCommand("getUserName", cnn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Username", username);
                cmd2.Parameters.Add("@Fullname", SqlDbType.NVarChar, 100);
                cmd2.Parameters["@Fullname"].Direction = ParameterDirection.Output;
                cmd2.ExecuteNonQuery();
                fullname = Convert.ToString(cmd2.Parameters["@Fullname"].Value);

                this.Hide();
                HomeMenu newH = new HomeMenu();
                newH.Show();
            }
            else
            {
                MessageBox.Show("wrong password or username");
            }
            cnn.Close();
        }
    }
}
