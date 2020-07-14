using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DIS_Models person = new DIS_Models();
            person.name = "Rameez Badri";
            person.address = "princeton lakes dr";
            return View(person);
        }
        [HttpPost]
        public IActionResult Index(DIS_Models cityPop)
        {
            return View(cityPop);
        }

    }
}
