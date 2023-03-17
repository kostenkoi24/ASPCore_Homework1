using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Controllers
{
    public class TestController : Controller
    {

       
        public IActionResult Message()
        {
            return View();
        }


    }
}
