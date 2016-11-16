using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customerList = GetCustomers();
            return View(customerList);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Steve Jones"},
                new Customer { Id = 2, Name = "Timothy Zane"}
            };
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(x => x.Id == id);
            return View(customer);
        }

    }
}