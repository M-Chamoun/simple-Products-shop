using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pavol_projjt_mvc_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult testing()
        {
           //return View("~/Views/Test1/testing.cshtml");
            return View();
        }
    }
}
