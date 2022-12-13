using ApiMokymai.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMokymai.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        // Registruojamos lenteles
        // Prop pavadinimas = Lenteles pavadinimas
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReaderCard> ReaderCard { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
              new Book(1, "Hobbit", "Tolkin", ECoverType.HardCover, 2012, 6),
              new Book(2, "War and peace", "Leo Tolstoy", ECoverType.HardCover, 1992,7),
              new Book(3, "Hamlet", "William Shakespeare", ECoverType.Paperback, 2005, 6),
              new Book(4, "The Odyssey", "Homer", ECoverType.Electronic, 1994, 2),
              new Book(5, " Crime and Punishment", "Fyodor Dostoyevsky", ECoverType.HardCover, 1995, 7),
              new Book(6, "Hobbit", "Tolkin", ECoverType.HardCover, 1991, 12),
              new Book(7, "War and peace", "Leo Tolstoy", ECoverType.HardCover, 2018, 1),
              new Book(8, " Heart of Darkness", "Joseph Conrad", ECoverType.Paperback, 1998, 5),
              new Book(9, "Great Expectations", "Great Expectations", ECoverType.Electronic, 1999, 8),
              new Book(10, "Hobbit", "Tolkin", ECoverType.HardCover, 2000, 2)
              );
        }

    }
}
