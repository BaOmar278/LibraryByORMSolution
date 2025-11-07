using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class LibraryMember
    {
        [Key]
        public int id { get; set; }
        public string memberName { get; set; }
        public string  memberShipStatus{ get; set; }

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
