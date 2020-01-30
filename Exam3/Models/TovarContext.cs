using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Exam3.Models
{
    public class TovarContext: DbContext
    {
        public DbSet<Tovar> Tovars { get; set; }


    }
}