using System;
using System.Data.Entity;
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

        private ApplicationDbContext dbConnect;

        public CustomersController()
        {
            dbConnect = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            dbConnect.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = dbConnect.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                dbConnect.Customers.Add(customer);
            }
            else
            {
                var customerInDb = dbConnect.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;

            }

            dbConnect.SaveChanges();

            //redirect to all customers view
            return RedirectToAction("AllCustomers", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = dbConnect.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = dbConnect.MembershipTypes.ToList()
            };


            //specify view name or else will redirect to a non-existing Edit view
            return View("CustomerForm", viewModel);
        }


        // GET: Customers

        public ViewResult AllCustomers()
        {
            var customers = dbConnect.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult CustomerInfo(int id)
        {
            var customer = dbConnect.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);

        }



    }
}
