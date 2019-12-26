using Microsoft.EntityFrameworkCore;

namespace _1111webapi.Models
{
    public class BookContext : DbContext
    {

        public BookContext(DbContextOptions<BookContext> options)
      : base(options)
        {
            Database.EnsureCreated();
          //  Database.Migrate();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Transaction> Trnsactions { get; set; }
    }


}