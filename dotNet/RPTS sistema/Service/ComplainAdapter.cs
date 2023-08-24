using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Models.DTO.ComplainDto;
using RPTS_sistema.Service.IService;

namespace RPTS_sistema.Service
{
    public class ComplainAdapter : IComplainAdapter
    {
        public Complain Bind(CreateComplain complain)
        {
            throw new NotImplementedException();
        }

        public GetComplain BindForOne(Complain complain)
        {
            return new GetComplain
            {
                ComplainId = complain.ComplainId,
                Company = new GetCompany(complain.Company),
                Complainant = complain.Complainant,                
                ComplaintDescription = complain.Description,
                ComplainStartDate = complain.ComplainDate.ToString("yyyy-MM-dd"),
                ComplainEndDate = complain.DecisionDate?.ToString("yyyy-MM-dd"),             
                Conclusion = complain.Conclusion?.Decision,

            };
        }
    }
}
