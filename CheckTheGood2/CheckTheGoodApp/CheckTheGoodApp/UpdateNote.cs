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
    public partial class UpdateNote : Form
    {
        public static string constr = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(constr);
        public static string username = LoginForm.instance.username;
        
        public UpdateNote()
        {
            InitializeComponent();
        }

        private void btnUpdateCheck_Click(object sender, EventArgs e)
        {
            string getUserImportlist = "Select * from OrderProduct ";
            SqlCommand cmd = new SqlCommand(getUserImportlist,cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void btnUpdateGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeMenu newHome = new HomeMenu();
            newHome.Show();
        }

        private void btnUpdateUpdateNote_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("Update OrderProduct set PaymentStatus = @PaymentStatus,ShipmentStatus = @ShipmentStatus where Oid = @Oid",cnn);
                    cmd2.Parameters.AddWithValue("@PaymentStatus", dataGridView1.Rows[i].Cells[2].Value);
                    cmd2.Parameters.AddWithValue("@ShipmentStatus", dataGridView1.Rows[i].Cells[3].Value);
                    cmd2.Parameters.AddWithValue("@Oid",dataGridView1.Rows[i].Cells[0].Value);
                    cnn.Open();
                    cmd2.ExecuteNonQuery();
                    cnn.Close();
                    
                }
                MessageBox.Show("Update Success");
            }
        }


    }
}
