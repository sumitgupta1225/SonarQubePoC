﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Runtime;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreDemo.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}