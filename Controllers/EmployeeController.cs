using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details()
        { //hard coded data
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Aryan",
                Gender = "Male"
            }; //Now I will give this to a view and then that view will render it.
            return View(employee);
        }
    }
}