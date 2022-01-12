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
    public partial class HomeMenu : Form
    {
        public static HomeMenu instance;
        public HomeMenu()//agent home
        {
            InitializeComponent();
            string fullname = LoginForm.instance.fullname;
            labelHomeFullname.Text = "" + fullname;
            instance = this;
        }

        private void btnHimport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import newIm = new Import();
            newIm.Show();

        }

        private void btnHNote_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportList newDN = new ImportList();
            newDN.Show();
        }

        private void btnHomeLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newLog = new LoginForm();
            newLog.Show();
        }

        private void btnHomeUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateNote newUp = new UpdateNote();
            newUp.Show();
        }

        private void btnHViewStocl_Click(object sender, EventArgs e)
        {
            Income newForm = new Income();
            this.Hide();
            newForm.Show();
        }
    }
}
