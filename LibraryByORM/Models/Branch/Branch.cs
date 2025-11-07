using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public ICollection<LibraryStaff> LibraryStaffs { get; set; } = new List<LibraryStaff>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
