using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class PublisherContact
    {
        [Key]
        public int Id { get; set; }
        public string contactValue { get; set; }
        public string contactType { get; set; }


        [ForeignKey(nameof(Publisher))]
        public int publisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}
