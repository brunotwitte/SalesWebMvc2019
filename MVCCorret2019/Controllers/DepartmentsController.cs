using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCorret2019.Models;

namespace MVCCorret2019.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, name = "Eletronicos" });
            list.Add(new Department { Id = 2, name = "Fashion" });


            return View(list);

        }
    }
}
