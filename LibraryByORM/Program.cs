namespace LibraryByORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {

                var genre = new Genre { GenreName = "Science Fiction" };
                var publisher = new Publisher { publisherName = "Future Press" };
                var author = new Author { authorName = "Isaac Asimov", authorNationality = "Russian-American" };

                var book = new Book
                {
                    title = "Foundation",
                    ISBN = 123456,
                    publicationYear = new DateOnly(1951, 1, 1),
                    Genre = genre,
                    Publisher = publisher
                };


                var bookAuthor = new BookAuthor
                {
                    Book = book,
                    Author = author
                };

                var branch = new Branch { BranchName = "Central Library" };
                var staff = new LibraryStaff { Staffname = "Ahmed", position = "Librarian", Branch = branch };
                var member = new LibraryMember { memberName = "Fatma", memberShipStatus = "Active" };

                var transaction = new Transaction
                {
                    barrowDate = new DateOnly(2025, 11, 1),
                    dueDate = new DateOnly(2025, 11, 15),
                    returnDate = new DateOnly(2025, 11, 10),
                    fineAmount = 0,
                    Book = book,
                    LibraryMember = member,
                    LibraryStaff = staff,
                    Branch = branch
                };


                context.AddRange(genre, publisher, author, book, bookAuthor, branch, staff, member, transaction);


                context.SaveChanges();


            }

            using (var context = new ApplicationDbContext())
            {
                Console.WriteLine("Welcome to the Library Management System\n");


                Console.WriteLine("Books List");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"{"ID",-3} {"Title",-20} {"ISBN",-10} {"Genre",-10} {"Publisher",-10}");
                Console.WriteLine("------------------------------------------------------------");

                var books = context.Books
                    .Select(b => new
                    {
                        b.Id,
                        b.title,
                        b.ISBN,
                        Genre = b.Genre.GenreName,
                        Publisher = b.Publisher.publisherName
                    })
                    .ToList();

                foreach (var b in books)
                {
                    Console.WriteLine($"{b.Id,-3} {b.title,-20} {b.ISBN,-10} {b.Genre,-10} {b.Publisher,-10}");
                }

                Console.WriteLine("\nMembers");
                Console.WriteLine("--------------------------------------------");
                var members = context.LibraryMembers.ToList();
                foreach (var m in members)
                {
                    Console.WriteLine($"ID: {m.id,-3} | Name: {m.memberName,-15} | Status: {m.memberShipStatus}");
                }


                Console.WriteLine("\nLibrary Staff");
                Console.WriteLine("--------------------------------------------");
                var staffList = context.LibraryStaffs.ToList();
                foreach (var s in staffList)
                {
                    Console.WriteLine($"ID: {s.id,-3} | Name: {s.Staffname,-15} | Position: {s.position}");
                }

                // عرض المعاملات
                Console.WriteLine("\n🔄 Transactions");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine($"{"ID",-3} {"Book",-15} {"Member",-15} {"Staff",-15} {"Branch",-15} {"Fine",-5}");
                Console.WriteLine("-----------------------------------------------------------------------------------");

                var transactions = context.Transactions
                    .Select(t => new
                    {
                        t.id,
                        BookTitle = t.Book != null ? t.Book.title : "N/A",
                        MemberName = t.LibraryMember != null ? t.LibraryMember.memberName : "N/A",
                        StaffName = t.LibraryStaff != null ? t.LibraryStaff.Staffname : "N/A",
                        BranchName = t.Branch != null ? t.Branch.BranchName : "N/A",
                        t.fineAmount
                    })
                    .ToList();

                foreach (var t in transactions)
                {
                    Console.WriteLine($"{t.id,-3} {t.BookTitle,-15} {t.MemberName,-15} {t.StaffName,-15} {t.BranchName,-15} {t.fineAmount,-5}");
                }

                Console.WriteLine("\n✅ Display completed successfully.");

            }
        }
    }
}
    

