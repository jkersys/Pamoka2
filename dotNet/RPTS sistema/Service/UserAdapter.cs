using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.LocalUserDto;
using RPTS_sistema.Service.IService;

namespace RPTS_sistema.Service
{
    public class UserAdapter : IUserAdapter
    {
        public GetUsersForFrontEnd Bind(LocalUser user)
        {
            return new GetUsersForFrontEnd()
            {
                Id = user.Id,
                NameAndLastname = user.Name + " " + user.Lastname,
            };
        }
        public UsersForFEWithStatistic BindStatistic(LocalUser user)
        {
            return new UsersForFEWithStatistic()
            {
                UserId = user.Id,
                Name = user.Name,
                Lastname = user.Lastname,
                AllInvestigations = user.Investigations?.Where(x => x.IsInvestigationDeleted == false).Count(),
                FinishedInvestigations = user.Investigations?.Where(x => x.IsInvestigationDeleted == false).Where(x => x.IsCompleted == true).Count(),
                ActiveInvestigations = user.Investigations?.Where(x => x.IsInvestigationDeleted == false).Where(x => x.IsCompleted == false).Count(),
                AllInspections = user.AdministrativeInspections?.Where(x => x.InspectionDeleted == false).Count(),
                FinishedInspections = user.AdministrativeInspections?.Where(x => x.InspectionDeleted == false).Where(x => x.IsCompleted == true).Count(),
                ActiveInspections = user.AdministrativeInspections?.Where(x => x.InspectionDeleted == false).Where(x => x.IsCompleted == false).Count()
            };
        }
    }
    }


    