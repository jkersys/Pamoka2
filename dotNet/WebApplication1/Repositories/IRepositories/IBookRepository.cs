using ApiMokymai.Data;
using ApiMokymai.Models;

namespace ApiMokymai.Repositories.IRepositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Book Update(Book book);
    }
}