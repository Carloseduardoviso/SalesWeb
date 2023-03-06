using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> ListaDeDepartamentos = new List<Department>();
            ListaDeDepartamentos.Add(new Department { Id = 1, Name = "oie"});
            ListaDeDepartamentos.Add(new Department { Id = 2, Name = "diga" });
            return View(ListaDeDepartamentos);
        }

        public IActionResult test()
        {
            ViewData["Message"] = "texte 1";
            ViewData["email"] = "email 1";

            return View();
        }

    }
}
