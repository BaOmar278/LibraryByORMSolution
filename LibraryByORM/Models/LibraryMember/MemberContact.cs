using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class MemberContact
    {
        [Key]
        public int Id { get; set; }
        public string contactValue { get; set; }
        public string contactType { get; set; }

        [ForeignKey(nameof(LibraryMember))]
        public int memberId { get; set; }
        public LibraryMember LibraryMember { get; set; }

    }
}
