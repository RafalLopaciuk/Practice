using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LooksLikeVidly.Models;
using LooksLikeVidly.ViewModels;

namespace LooksLikeVidly.Controllers
{
    public class CustomerController : Controller
    {

        public ActionResult Index()
        {
            var Customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith" },
                new Customer {Id = 2, Name = "Rin Kioshi" },
                new Customer {Id = 3, Name = "Tomasz Adamczyk" }
            };

            var viewModel = new CustomersListViewModel
            {
                Customer = Customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var Customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith" },
                new Customer {Id = 2, Name = "Rin Kioshi" },
                new Customer {Id = 3, Name = "Tomasz Adamczyk" }
            };

            var SearchCustomer = new Customer();
            SearchCustomer = Customers[id-1];

            return View(SearchCustomer);
        }
    }
}