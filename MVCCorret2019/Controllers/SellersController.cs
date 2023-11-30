using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCorret2019.Services;

namespace MVCCorret2019.Controllers
{
    public class SellersController : Controller
        {

        private readonly SellerService _sellerService;
        
        public  SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
