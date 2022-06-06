namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("išvedimas");
            Console.Write("vienoje ");
            Console.Write("eilutėje");
            Console.WriteLine();
            Console.WriteLine("tekstas kitoje eilutėje");
            Console.Write("tekstas");

            Console.WriteLine("---------------");
            Console.WriteLine("išvedimas" + "vienoje" + "eilutėje"); //konkatnacija
            Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eilutėje"); // kompozicija
            Console.WriteLine($"{"išvedimas"} {"vienoje"} {"eilutėje"}"); // interpoliacija
        }
    }
}