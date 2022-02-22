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
            if (ModelState.IsValid) { 
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }
        public IActionResult Delete(int Id)

        {
            var emp = dbContext.Employees.SingleOrDefault
                (e => e.Id == Id);
            if (emp != null)
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Edit(int Id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == Id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            dbContext.Employees.Update(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
}
    }

