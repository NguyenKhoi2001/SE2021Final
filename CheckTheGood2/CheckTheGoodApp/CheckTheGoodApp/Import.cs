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
    public partial class Import : Form
    {
        public static Import instance;
        int Total = 0;
        List<Receipt> receiptList = new List<Receipt>();
        string constr = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        public Import()
        {
            InitializeComponent();
            instance = this;
        }

        private void Import_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'checkTheGoodDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.checkTheGoodDataSet.Product);

        }

        private void btnImAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(constr);
            string Pid = txtImPid.Text;
            string Pnum = txtImQuantity.Text;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("getPrice",cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Pid", SqlDbType.NVarChar,5)).Value=Pid;
            SqlParameter returnPrice = cmd.Parameters.Add("@Pprice", SqlDbType.Int);
            returnPrice.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int price = (int)returnPrice.Value;

            SqlCommand cmd2 = new SqlCommand("getName", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add(new SqlParameter("@Pid", SqlDbType.NVarChar,5)).Value = Pid;
            cmd2.Parameters.Add("@Pname", SqlDbType.NVarChar,50);
            cmd2.Parameters["@Pname"].Direction = ParameterDirection.Output;
            cmd2.ExecuteNonQuery();
            string Name = Convert.ToString(cmd2.Parameters["@Pname"].Value);

            if (!string.IsNullOrEmpty(Pid) && !string.IsNullOrEmpty(Pnum)){
                Receipt obj = new Receipt();
                obj.Id = Pid;
                obj.Quantity = Int32.Parse(Pnum);
                obj.Price = price;
                obj.PName = Name;
                Total += obj.Price * obj.Quantity;
                receiptBindingSource.Add(obj);
                receiptList.Add(obj);
                txtImQuantity.Text = "";
                txtImPid.Text = "";
                txtImTotal.Text = string.Format("{0}",Total);
            }
            cnn.Close();
            
        }

        private void btnImPrint_Click(object sender, EventArgs e)
        {   if (Total > 0)
            {
                
                SqlConnection cnn = new SqlConnection(constr);
                cnn.Open();
                
                
                string username = LoginForm.instance.username;
                SqlCommand addCmd = new SqlCommand("ImportAdd", cnn);
                addCmd.CommandType = CommandType.StoredProcedure;
                
                addCmd.Parameters.AddWithValue("@money", Total);
                addCmd.Parameters.AddWithValue("@username", username);
                MessageBox.Show("Transaction bill has been printed");
                int ImportId = (Int32)addCmd.ExecuteScalar();

                Total = 0;
                txtImTotal.Text = "";
                dataGridReceipt.Rows.Clear();
                dataGridReceipt.Refresh();

                SqlCommand addImportLine = new SqlCommand("ImportListAdd", cnn);
                addImportLine.CommandType = CommandType.StoredProcedure;
                addImportLine.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                int count = 1;
                addImportLine.Parameters.Add(new SqlParameter("@ImportId", SqlDbType.Int));
                addImportLine.Parameters.Add(new SqlParameter("@Pname", SqlDbType.NVarChar));
                addImportLine.Parameters.Add(new SqlParameter("@Pid", SqlDbType.NVarChar));
                addImportLine.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));
                addImportLine.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int));
                addImportLine.Parameters.Add(new SqlParameter("@total", SqlDbType.Int));
                foreach (var importLine in receiptList)
                {
                    addImportLine.Parameters["@OrderID"].Value = count;
                    count++;
                    addImportLine.Parameters["@ImportId"].Value = ImportId;
                    string Pid = importLine.Id.ToString();
                    addImportLine.Parameters["@Pid"].Value = Pid;
                    string Pname = importLine.PName.ToString();
                    addImportLine.Parameters["@Pname"].Value = Pname;
                    int Quantity = importLine.Quantity;
                    addImportLine.Parameters["@Quantity"].Value = Quantity;
                    int Price = importLine.Price;
                    addImportLine.Parameters["@Price"].Value = Price;
                    int total = importLine.total;
                    addImportLine.Parameters["@total"].Value = total;
                    addImportLine.ExecuteNonQuery();
                }
                receiptList.Clear(); 
            }
            else{
                MessageBox.Show("You haven't import anything so you can't make transaction");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeMenu newH = new HomeMenu();
            newH.Show();
        }
    }
}
