using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.CompanyDto;

namespace RPTS_sistema.Service.IService
{
    public interface ICompanyAdapter
    {
        Company Bind(CreateCompany updateCompany);
        GetOneCompany Bind(Company company);
    }
}
