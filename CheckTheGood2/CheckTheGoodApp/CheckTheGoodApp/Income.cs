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
    public partial class Income : Form
    {
        string constr = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        List<Monthly> month = new List<Monthly>();
        public Income()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            HomeMenu newHome = new HomeMenu();
            newHome.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            int income = 0;
            SqlConnection cnn = new SqlConnection(constr);
            string getUserOrderPay = "Select * from OrderProduct where PaymentStatus = 'Y' ";
            SqlCommand cmd = new SqlCommand(getUserOrderPay, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                income += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            labelIncome.Text = income.ToString();
        }
    }
}
