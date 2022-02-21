using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AKASH.MVC_1.Models;


namespace AKASH.MVC_1.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public EmployeeController(ApplicationDbContext dbcontext) 
        {
            this.dbContext = dbcontext;
        }
        public IActionResult Index()
        {
            List<Employee> emps = dbContext.Employees.ToList();
            return View(emps);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
