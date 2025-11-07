using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class LibraryStaff
    {
        [Key]
        public int id { get; set; }
        public string Staffname { get; set; }
        public string position { get; set; }

        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public ICollection<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}
