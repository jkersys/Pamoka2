using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.ConclusionDto;
using RPTS_sistema.Service.IService;

namespace RPTS_sistema.Service
{
    public class ConclusionAdapter : IConclusionAdapter
    {
        public GetConclusion Bind(Conclusion conclusion)
        {
            return new GetConclusion()
            {
                Conclusion = conclusion?.Decision
            };
        }

        public Conclusion Bind(string decision)
        {
            return new Conclusion()
            {
                Decision = decision
            };
        }
    }
}
