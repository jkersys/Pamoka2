using P_032_OOPMetodaiDomain.Models;

namespace P_032_OOP_Metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var amzius = 25;
            var kaina = 9.99;

            Console.WriteLine("Hello, World!");
            var namas1 = new Namas(5, "Vilniaus g. 78"); //<----------------- this()
            
            foreach (var namogyventojovardas in namas1.ZmoniuVardai)
            {
                Console.WriteLine($"Namo gyventojo vardas: {namogyventojovardas}");
            }




        }
    }
}