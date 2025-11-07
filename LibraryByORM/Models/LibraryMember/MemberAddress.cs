using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class MemberAddress
    {
        [Key]
        public int id { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postalCard { get; set; }

        [ForeignKey(nameof(LibraryMember))]
        public int memberId { get; set; }
        public LibraryMember LibraryMember { get; set; }
    }
}
