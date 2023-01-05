using ApiMokymai.Data;
using ApiMokymai.Models;
using ApiMokymai.Repositories.IRepositories;

namespace ApiMokymai.Repositories
{
    public class ReaderCardRepository : Repository<ReaderCard>, IReaderCardRepository
    {
        public ReaderCardRepository(BookContext db) : base(db)
        {
        }
    }
}
