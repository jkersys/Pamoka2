using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.ConclusionDto;

namespace RPTS_sistema.Service.IService
{
    public interface IConclusionAdapter
    {
        GetConclusion Bind(Conclusion conclusion);
        Conclusion Bind(string conlusion);
    }
}
