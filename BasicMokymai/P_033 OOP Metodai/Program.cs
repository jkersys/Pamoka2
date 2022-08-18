namespace P_033_OOP_Metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP Metodai!");


            var staciakampis1 = new Staciakampis();
            staciakampis1.Plotis = 5;
            staciakampis1.Ilgis = 5;

            Console.WriteLine($"Staciakampio 1 plotas yra : {staciakampis1.ApskaiciuotiPlota()}");
        }





        //static double ApskaiciuotiPlota(double ilgis, double plotis) // statinis Program Main metodas
        //{
        //    return ilgis * plotis;
        //}
    }
}