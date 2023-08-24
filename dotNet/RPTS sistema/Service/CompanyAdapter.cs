using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Service.IService;

namespace RPTS_sistema.Service
{
    public class CompanyAdapter : ICompanyAdapter
    {
        public Company Bind(CreateCompany newCompany)
        {
            return new Company()
            {
                CompanyRegistrationNumber = newCompany.CompanyRegistrationNumber,
                CompanyFoundDate = newCompany.CompanyFoundDate,
                UpdateDate = DateTime.Now,
                CompanyName = newCompany.CompanyName,
                CompanyCategory = newCompany.CompanyCategory,
                CompanyAdress = newCompany.CompanyAdress,
                CompanyEmail = newCompany.CompanyEmail,
                CompanyPhone = newCompany.CompanyPhone
            };
        }

        public GetOneCompany Bind(Company company)
        {
            return new GetOneCompany()
            {
                CompanyRegistrationNumber = company.CompanyRegistrationNumber,
                CompanyFoundDate = company.CompanyFoundDate,
                CompanyName = company.CompanyName,
                CompanyCategory = company.CompanyCategory,
                CompanyAdress = company.CompanyAdress,
                CompanyEmail = company.CompanyEmail,
                CompanyPhone = company.CompanyPhone,
                //padaryt traukima tyrimu sukurt nauja dto
                Investigations = company.Investigations.ToList(),
                //padaryt traukima patikru sukurt nauja dto
                AdministrativeInspections = company.AdministrativeInspections.ToList(),
                //padaryt traukima skundu sukurt nauja dto
                Complain = company.Complain.ToList()



            };
        }
    }
}
