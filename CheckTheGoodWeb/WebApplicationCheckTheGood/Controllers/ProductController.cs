using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationCheckTheGood.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SetProductDetails(string Pid, string PName,int Price, int Quantity) 
        {
            return Content(Pid);
        }
    }
}