using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationCheckTheGood.Models;
using System.Data.SqlClient;

namespace WebApplicationCheckTheGood.Controllers
{
    public class HomeController : Controller
    {
        ProductData product = new ProductData();
        public static string connectionString = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        List<ProductData> products = new List<ProductData>();
        public ActionResult Index()
        {
            FetchData();
            return View(products);
        }
        private void FetchData()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from product";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                products.Add(new ProductData() { ProductId=dr["Pid"].ToString(), 
                    ProductName = dr["PName"].ToString(), 
                    ProductPrice = Convert.ToInt32(dr["Pprice"].ToString())});

            }
            cnn.Close();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}