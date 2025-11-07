
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class BookAuthor
    {

        public int id { get; set; }
        [ForeignKey(nameof(Book))]
        public int bookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey(nameof(Author))]
        public int authorId { get; set; }
        public Author Author {get; set; }
    }
}