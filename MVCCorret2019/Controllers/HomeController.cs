using Microsoft.AspNetCore.Mvc;
using MVCCorret2019.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCorret2019.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Venda WEB MVC App from C#";
            ViewData["Developer"] = "Bruno Alves da Silva";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ViewModels.ErrorViewModels { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
