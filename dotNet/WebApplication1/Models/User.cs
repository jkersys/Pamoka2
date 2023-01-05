namespace ApiMokymai.Models
{
    public class User
    {
        public int Id { get; set; }
        //public int ReaderCardId { get; set; }
        public string Username { get; set; }        
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public virtual ReaderCard UserReaderCard { get; set; }
        public virtual UserRole Role { get; set; }
        //public virtual UserBooks UserBooks { get; set; }
        

    }
}
