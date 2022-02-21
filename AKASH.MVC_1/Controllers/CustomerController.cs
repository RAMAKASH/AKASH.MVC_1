using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AKASH.MVC_1.Models;

namespace AKASH.MVC_1.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext
            dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations =
                dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int Id) 
        {
            List<Customer> Customers =
                dbContext.Customers.Where(e =>
                e.Location.Id == Id).ToList();
            return View(model: Customers);
        }
    }
}
