using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf2.Models
{
    public class Book
    {
        //ALWAYS put the Key right after Key
        [Key]
        public int ID { get; set; }
        //ID, Title, Desc, ISBN, Date Published (date/time)
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public DateTime DatePublished { get; set; }

        //navigation property-has to be in both tables, when create an instance of book it will have title,
        //desc, isbn, date published and Category
        //1 to many relationship; 1 book has 1 category, but many
        //virtual is a variable?????
        //EACH BOOK has a CATEGORY so later can display LIST OF BOOKS under that CATEGORY
        //HORROR: 1. "IT" 2. "AMYTIVILLE" 3. "SCREAM"
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Author")]
        public int? AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}