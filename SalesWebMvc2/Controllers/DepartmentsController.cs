﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2.Models;

namespace SalesWebMvc2.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1, Name = "Eletrônicos"});
            list.Add(new Department { Id = 2, Name = "Fashion" });
            return View(list);
        }
    }
}
