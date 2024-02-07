using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebPageMvc.Models;

namespace WebPageMvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Games" });
            departments.Add(new Department { Id = 2, Name = "Joao" });
            return View();
        }
    }
}
