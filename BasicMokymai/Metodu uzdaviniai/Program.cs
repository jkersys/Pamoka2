namespace Metodu_uzdaviniai
{
    internal class Program
    {
        public static string tekstas = "";
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Globalus Metodai!");


            Console.WriteLine($"Iveskite teksta");
            tekstas = Console.ReadLine();
            IsvestiIvestaTeksta(); //paspaudus f12 numeta ant metodo

        }

        public static void IsvestiIvestaTeksta()
        {
            Console.WriteLine($"Ivestas tekstas yra {tekstas}");

        }
        /*
        Parašykite programą kurioje vienas metodas.
- Naudotojo paprašome įvesti betkokį tekstą Main metode.
-Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
Pvz:
> Iveskite teksta:
        _ ' as mokausi '
        > Teksto ilgis yra: 10
        */




        public static void BetKoksTekstas()
        {
            Console.WriteLine("Iveskite teksta ' as mokausi '");
            var tekstas = Console.ReadLine();
            Console.WriteLine($"Teksto ilgis yra {tekstas.Trim().Length}");
        }


        Console.WriteLine();
         










            }
            }

