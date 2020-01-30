using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Exam3.Models;

namespace Exam3.Controllers
{
    public class TovarsController : ApiController
    {
        private TovarContext db = new TovarContext();

        // GET: api/Tovars
        public IQueryable<Tovar> GetTovars()
        {
            return db.Tovars;
        }

        // GET: api/Tovars/5
        [ResponseType(typeof(Tovar))]
        public IHttpActionResult GetTovar(int id)
        {
            Tovar tovar = db.Tovars.Find(id);
            if (tovar == null)
            {
                return NotFound();
            }

            return Ok(tovar);
        }

        // PUT: api/Tovars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTovar(int id, Tovar tovar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tovar.Id)
            {
                return BadRequest();
            }

            db.Entry(tovar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TovarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tovars
        [ResponseType(typeof(Tovar))]
        public IHttpActionResult PostTovar(Tovar tovar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tovars.Add(tovar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tovar.Id }, tovar);
        }

        // DELETE: api/Tovars/5
        [ResponseType(typeof(Tovar))]
        public IHttpActionResult DeleteTovar(int id)
        {
            Tovar tovar = db.Tovars.Find(id);
            if (tovar == null)
            {
                return NotFound();
            }

            db.Tovars.Remove(tovar);
            db.SaveChanges();

            return Ok(tovar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TovarExists(int id)
        {
            return db.Tovars.Count(e => e.Id == id) > 0;
        }
    }
}