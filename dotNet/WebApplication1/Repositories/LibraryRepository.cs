using ApiMokymai.Data;
using ApiMokymai.Models;
using System.Linq.Expressions;

namespace ApiMokymai.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly BookContext _context;

        public LibraryRepository(BookContext context)
        {
            _context = context;
        }

        public void Create(ReaderCard entity)
        {
            throw new NotImplementedException();
        }

        public ReaderCard Get(Expression<Func<ReaderCard, bool>> filter, bool tracked = true)
        {
            throw new NotImplementedException();
        }

        public List<ReaderCard> GetAll(Expression<Func<ReaderCard, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(ReaderCard entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
