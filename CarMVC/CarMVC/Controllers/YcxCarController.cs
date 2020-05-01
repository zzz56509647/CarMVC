using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarMVC.Controllers
{
    public class YcxCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCars()
        {
            return View();
        }

    }
}