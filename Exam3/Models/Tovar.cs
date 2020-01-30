using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam3.Models
{
    public class Tovar
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Empty field")]
        public string Name { get; set; }

       // [RegularExpression(@"0-9", ErrorMessage = "Incorrect")]
        public double Price { get; set; }

      //  [RegularExpression(@"0-9", ErrorMessage = "Incorrect")]
        public int Count { get; set; }


    }
}