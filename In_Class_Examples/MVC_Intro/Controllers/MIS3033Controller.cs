using Microsoft.AspNetCore.Mvc;
using MVC_Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Intro.Controllers
{
    public class MIS3033Controller : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                FirstName = "Micah",
                LastName = "Tison"
            };
            return View(s);
        }
    }
}
