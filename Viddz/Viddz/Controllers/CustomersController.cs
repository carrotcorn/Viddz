using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddz.Models;



namespace Viddz.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customers
        //private IEnumerable<Customer> GetCustomers()
        //{ return new List<Customer>
        //    {
        //        new Customer { Id = 1, Name = "Jally" },
        //        new Customer { Id = 2, Name = "Hobo" }
        //    }; 
        //}
        public ViewResult AllCustomers()
        {

            var customers = _context.Customers.ToList();
            return View(customers);
        }
        public ActionResult CustomerInfo(int id)
        {
            var customers = _context.Customers.SingleOrDefault(c => c.Id == id);

            return View(customers);

        }
    }
}
