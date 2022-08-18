namespace Nr._2_Skaičiuoklis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var skaiciuoklis = new Skaiciuoklis(1);
            skaiciuoklis.Atspausdinimas();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Atspausdinimas();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Atspausdinimas();
            skaiciuoklis.Reset();
            skaiciuoklis.Atspausdinimas();



        }







    }
}