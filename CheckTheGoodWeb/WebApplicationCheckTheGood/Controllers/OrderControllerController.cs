using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using WebApplicationCheckTheGood.Models;

namespace WebApplicationCheckTheGood.Controllers
{
    public class OrderControllerController : Controller
    {
        // GET: OrderController
        public static string connectionString = @"Data Source=DESKTOP-KDIOCV5\SQLEXPRESS;Initial Catalog=CheckTheGood;Integrated Security=True";
        [HttpPost]
        public string AddOrder(string Pid, int Quantity)
        {
            ViewBag.Message = "Message Sent";
            return "Form Parameter "+Pid+", and "+Quantity;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}