
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryByORM
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "Data Source=localhost\\MSSQLSERVER05;Database= LibraryORM;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server" +
                " Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(con);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.LibraryStaff) // Use the correct navigation property
                .WithMany(s => s.Transactions) // Ensure LibraryStaff has a Transactions collection
                .HasForeignKey(t => t.staffId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transaction>()
    .Property(t => t.fineAmount)
    .HasPrecision(18, 2);
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchContact> BranchContacts { get; set; }
        public DbSet<BranchAddress> BranchAddresses { get; set; }

        public DbSet<LibraryStaff> LibraryStaffs { get; set; }
        public DbSet<StaffContact> StaffContacts { get; set; }

        public DbSet<LibraryMember> LibraryMembers { get; set; }
        public DbSet<MemberAddress> MemberAddresses { get; set; }
        public DbSet<MemberContact> MemberContacts { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublisherContact> PublisherContacts { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

    }
}
