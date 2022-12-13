using ApiMokymai.Data;
using ApiMokymai.Models;
using ApiMokymai.Repositories.IRepositories;
using System.Linq.Expressions;

namespace ApiMokymai.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly BookContext _db;

        public BookRepository(BookContext db) : base(db)
        {
            _db = db;
        }

        public Book Update(Book book)
        {
            book.UpdateDateTime = DateTime.Now;
            _db.Books.Update(book);
            _db.SaveChanges();
            return book;
        }
    }
}