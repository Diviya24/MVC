using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext context = new EmployeeContext();
            Employee employee=context.Employees.Single(emp => emp.EmployeeId == id);
            return View(employee);
        }
    }
}