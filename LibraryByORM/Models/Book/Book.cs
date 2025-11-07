
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace LibraryByORM
{
    
    public class Book
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int ISBN { get; set; }
        public DateOnly publicationYear { get; set; }

        [ForeignKey(nameof(Genre))]
        public int genreId { get; set; }
        public Genre Genre { get; set; }

        [ForeignKey(nameof(Publisher))]
        public int publisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();


    }
}
