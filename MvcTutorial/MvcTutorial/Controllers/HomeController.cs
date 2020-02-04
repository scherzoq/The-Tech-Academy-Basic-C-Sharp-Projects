using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\John\sample\log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num;

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("");

            //return RedirectToAction("Contact");

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

            //int number = 5;
            //return View(number);

            User user = new User();
            user.Id = 1;
            user.FirstName = "John";
            user.LastName = "Chin";
            user.Age = 39;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}