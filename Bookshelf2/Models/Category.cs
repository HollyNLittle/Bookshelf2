using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf2.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        //lazy loading; virtual will access as needed cus what if you have a ton of books and don't need them all
        //a list of alllll book objects
        //ICollection inherits from IEnumerable
        public virtual ICollection<Book> Books { get; set; }

    }
}