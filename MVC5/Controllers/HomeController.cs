using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        FabricsEntities db = new FabricsEntities();
        // GET: Home
        public ActionResult Index()
        {
            var customers = db.Client;
            return View(customers);
        }


        public ActionResult UpdteFiveCustomerCity()
        {
            var Top5Customer = db.Client.Take(5);

            foreach (var cust in Top5Customer)
            {
                cust.City = "Taipei";
            }

            db.SaveChanges();

            return View(Top5Customer);
        }
    }
}