namespace RPTS_sistema.Models.DTO.LocalUserDto
{
    public class GetLocalUserNameAndLastName
    {
        public GetLocalUserNameAndLastName(LocalUser investigator)
        {
            NameAndLastName = investigator.Name + " " + investigator.Lastname;
        }
        public string NameAndLastName { get; set; }
    }
}
