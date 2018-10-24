using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departmentsList = new List<Department>();
            departmentsList.Add(new Department(1, "Eletronics"));
            departmentsList.Add(new Department(2, "Fashion"));

            return View(departmentsList);
        }
    }
}