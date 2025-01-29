using System.Data.Entity;

namespace AspNetMVCLibraryManagement.Model
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext() : base("name=LibraryContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
