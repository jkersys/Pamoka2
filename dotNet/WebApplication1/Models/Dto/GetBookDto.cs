namespace ApiMokymai.Models.Dto
{
    public class GetBookDto
    { 
        public int Id { get; set; }
        public string PavadinimasIrAutorius { get; set; }
        public int LeidybosMetai { get; set; }
        public int Kiekis { get; set; }
    }
}