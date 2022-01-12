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
    public partial class ImportList : Form
    {
        string constr = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        public ImportList()
        {
            InitializeComponent();
        }

        private void btnGotoH_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeMenu newH = new HomeMenu();
            newH.Show();
        }

        private void btnDNoteImList_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(constr);
            string username = LoginForm.instance.username;
            string getUserImportlist = "Select * from Import where username ='" + username+"'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(getUserImportlist, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDNoteOList_Click(object sender, EventArgs e)
        {
            int ImportId;
            if (!int.TryParse(txtImportID.Text, out ImportId))
            {
                MessageBox.Show("Please try to input integer value");
                return;
            }
            else {
                SqlConnection cnn = new SqlConnection(constr);
                cnn.Open();
                string username = LoginForm.instance.username;
                string checkUserQuerry = "Select ImportId from Import where Username = '" + username + "' and ImportId = '" + ImportId + "'";
                SqlCommand checkUser = new SqlCommand(checkUserQuerry, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string getUserImportlistOrder = "Select * from ImportList where ImportId =" + ImportId;
                    SqlCommand cmd = new SqlCommand(getUserImportlistOrder, cnn);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("You don't have this import list");
                }
            }
        }
    }
}
