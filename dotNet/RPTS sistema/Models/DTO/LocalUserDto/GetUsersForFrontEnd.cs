namespace RPTS_sistema.Models.DTO.LocalUserDto
{
    public class GetUsersForFrontEnd
    {
        public GetUsersForFrontEnd()
        {
                
        }
        public GetUsersForFrontEnd(LocalUser user)
        {
            Id = user.Id;
            NameAndLastname = user.Name + " " + user.Lastname;
        }

        public int Id { get; set; }
        public string NameAndLastname { get; set; }
    }
}
