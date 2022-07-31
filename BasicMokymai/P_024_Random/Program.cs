namespace P_024_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Random!");
            
            //naujo random formavimas
            Random random = new Random();

            int arRandomNumber = random.Next(); //bet koks skaicius nuo 0 iki int32.maxValue
            int arRandomNumber1 = random.Next(4); //bus sugeneruota 0,1,2 arba 3
            int arRandomNumber2 = random.Next(1, 4); // bus sugeneruota 1,2 arba 3

            double dRandomNumber = random.NextDouble(); // >= 0.0 iki < 1.0

            Console.WriteLine(RandomMetodasDebginamas()); ; // neimanoma testoti

            Console.WriteLine(RandomMetodasDebginamas()); //neimanoma testuoti  // hangmanui virsui formuotis randoma ir padavinet i testa


            //Atsitiktinis parinkimas is array ir list
            Console.WriteLine("-------------------------------------");
            Random rnd = new Random();
            List<char> vardai = new List<char> { "vienetas", "dvejetas", "trejetas", "ketvertas", "penketas" };
           
            int vrandom = rnd.Next(vardai.Count);
            Console.WriteLine(vardai[vrandom]);

            vardai.Remove(vardai[vrandom]); //jeigu atspeja isimt pabaigoj


            //atsitiktinio zodzio parinkimas tekste


        }


        static string RandomMetodasDebginamas()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10) > 5 ? "dideja" : "mazeja";
        }






    }
}