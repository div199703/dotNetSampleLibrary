using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    public class LibraryDataContext : DbContext
    {
        public LibraryDataContext(DbContextOptions options) : base(options) { }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}
