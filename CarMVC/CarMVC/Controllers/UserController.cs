﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult LoginUser()
        {
            return View();
        }
    }
}