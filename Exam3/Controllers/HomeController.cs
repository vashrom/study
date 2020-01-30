using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam3.Models;

namespace Exam3.Controllers
{
    public class HomeController : Controller
    {
        TovarContext db = new TovarContext();

        public ActionResult Index()
        {

            IEnumerable<Tovar> tovars = db.Tovars;

            ViewBag.Tovars = tovars;

            return View();
        }

      


    }
}