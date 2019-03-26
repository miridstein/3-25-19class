using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3_25_19class.Models;

namespace _3_25_19class.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPeople(List<Person> people)
        {
            PersonManager pm = new PersonManager(Properties.Settings.Default.ppl);
            foreach(Person p in people)
            {
                pm.AddPerson(p);
            }
            return Redirect("/home/index");
        }

       
    }
}