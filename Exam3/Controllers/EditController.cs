using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam3.Models;

namespace Exam3.Controllers
{
    public class EditController : Controller
    {
        TovarContext db = new TovarContext();


        // GET: Edit
        public ActionResult Index()
        {
            IEnumerable<Tovar> tovars = db.Tovars;

            ViewBag.Tovars = tovars;

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.TovarId = id;
            return View();
        }


        [HttpPost]
        public void Edit(Tovar tovar)
        {
            db.Entry(tovar).State = EntityState.Modified;
            db.SaveChanges();
            Response.Redirect("/Home/Index");

        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.TovarId = id;
            
            return View();
        }


        [HttpPost]
        public void Delete(Tovar tovar)
        {

            db.Entry(tovar).State = EntityState.Deleted;
            db.Tovars.Remove(tovar);
            db.SaveChanges();
            Response.Redirect("/Home/Index");

            
        }

        [HttpGet]
        public ActionResult Add()
        {
          
            return View();
        }

        [HttpPost]
        public void Add(Tovar tovar)
        {
            db.Tovars.Add(tovar);
          
            db.SaveChanges();
            Response.Redirect("/Home/Index");
        }




    }
}