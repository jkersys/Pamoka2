namespace Enum
{
    public class CustomEnum
    {
        public CustomEnum()
        {

        }

        public CustomEnum(int id, string aame) 
        {
            Id = id;
            Name = aame;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
        
    }



}