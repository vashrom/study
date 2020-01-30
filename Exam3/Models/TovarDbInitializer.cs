using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Exam3.Models
{
    public class TovarDbInitializer : DropCreateDatabaseAlways<TovarContext>
    {
 

        protected override void Seed(TovarContext db)
        {
            db.Tovars.Add(new Tovar { Name = "Tomato", Price = 9.99, Count = 180 });
            db.Tovars.Add(new Tovar { Name = "Potato", Price = 12.99, Count = 120 });
            db.Tovars.Add(new Tovar { Name = "Carrot", Price = 8.50, Count = 355 });



            base.Seed(db);
        }

    }
}