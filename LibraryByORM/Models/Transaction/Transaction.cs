using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class Transaction
    {
        public int id { get; set; }
        public DateOnly barrowDate { get; set; }
        public DateOnly dueDate { get; set; }
        public DateOnly returnDate { get; set; }
        public decimal fineAmount { get; set; }

        [ForeignKey(nameof(Book))]
        public int bookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey(nameof(LibraryMember))]
        public int memberId { get; set; }
        public LibraryMember LibraryMember { get; set; }

        [ForeignKey(nameof(LibraryStaff))]
        public int staffId { get; set; }
        public LibraryStaff LibraryStaff { get; set; }

        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
      }
}
