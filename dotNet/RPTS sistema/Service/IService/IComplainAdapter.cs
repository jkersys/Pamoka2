using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.ComplainDto;

namespace RPTS_sistema.Service.IService
{
    public interface IComplainAdapter
    {
        Complain Bind(CreateComplain complain);
        GetComplain BindForOne(Complain complain);
    }
}
