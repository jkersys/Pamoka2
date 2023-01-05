using ApiMokymai.Data;
using ApiMokymai.Models;
using ApiMokymai.Repositories.IRepositories;
using System.Linq.Expressions;

namespace ApiMokymai.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookContext db) : base(db)
        {
        }

        public Book Update(Book book)
        {
            book.UpdateDateTime = DateTime.Now;
            _db.Books.Update(book);
            Save();
            return book;
        }
    }
}