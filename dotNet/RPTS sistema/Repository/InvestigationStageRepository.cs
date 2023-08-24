using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;

namespace RPTS_sistema.Repository
{
    public class InvestigationStageRepository : Repository<InvestigationStage>, IInvestigationStagesRepository
    {
        public InvestigationStageRepository(RptsContext db) : base(db)
        {
        }
    }
}
