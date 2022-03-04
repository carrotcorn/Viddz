using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddz.Models;
using Viddz.ViewModels;


namespace Viddz.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Jally" },
                new Customer { Name = "Hobo" }
            };
        public ActionResult AllCustomers()
        {
            //Customer customer = new Customer();

            var vm = new CustomerViewModel
            {
                Customers = customers
            };

            return View(vm);
        }
        public ActionResult CustomerInfo()
        {
            var vm = new Customer
            {
                Customers = customers
            };

        }
    }
}
