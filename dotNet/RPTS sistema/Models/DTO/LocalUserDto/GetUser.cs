using RPTS_sistema.Models.DTO.AdministrativeInspectionDto;
using RPTS_sistema.Models.DTO.InvestigationDto;

namespace RPTS_sistema.Models.DTO.LocalUserDto
{
    public class GetUser
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public virtual ICollection<GetAdminInspections> Investigations { get; set; }
        public virtual ICollection<AdministrativeInspection> AdministrativeInspections { get; set; }
        public virtual ICollection<Complain> Complains { get; set; }

    }
}
