using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dt_CRM.Models;

namespace Dt_CRM.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            DateTime dt = DateTime.Now;
            ViewBag.currentTime = dt;
            return View("Hello");
        }

        [HttpPost]
        public ViewResult Index(PointJobRecord pjRecord)
        {
            PointJobDatabase.AddRecord(pjRecord);
            return View("Hello");
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View();
        //}
    }
}
