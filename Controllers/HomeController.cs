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
            person.firstname = "Rameez";
            person.lastname = "Badri";
            person.address = new Address();
            person.address.city = "Brandon";
            person.address.street = "princeton lakes dr";
            return View(person);
        }
        public IActionResult ISM6225()
        {
            return View();
        }
    }
}
