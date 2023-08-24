namespace RPTS_sistema.Models.DTO.InvestigatorDto
{
    public class GetInvestigator
    {
        public GetInvestigator()
        {
        }

        public GetInvestigator(LocalUser investigator)
        {
            Name = investigator.Name;
            Lastname = investigator.Lastname;
            Email = investigator.Email;
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

    }
}
