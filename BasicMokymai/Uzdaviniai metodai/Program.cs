namespace P010_Methods
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            Console.WriteLine("Iveskite teksta su tarpais");
            var tekstas = Console.ReadLine();



            /*
             * Parašykite programą kurioje vienas metodas.
- Naudotojo paprašome įvesti betkokį tekstą Main metode.
- Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
Pvz:
> Iveskite teksta:
_ ' as mokausi '
> Teksto ilgis yra: 10
            */

            BetKoksTekstas();







        }

        public static void BetKoksTekstas()
        {
            Console.WriteLine("Iveskite teksta ' as mokausi '");
            var tekstas = Console.ReadLine();
            Console.WriteLine($"Teksto ilgis yra {tekstas.Trim().Length}");
        }


        /*
         *Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
   - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
   - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
   - Main metode į ekraną išveskite žodžių kiekį
   Pvz: 
   > Iveskite teksta:
   _ as mokausi programuoti
   > Zodziu kiekis yra: 3
       */

    
        public static int KiekYraZodziu(string tekstas)
        {
            // return tekstas.Trim().Length - tekstas.Replace(" ", "").Length + 1;
            return tekstas.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }




        public static void KiekYratarpuPriekyjeirgale(string tekstas, out int priekyje, out int gale)
        {
            priekyje = tekstas.Length - tekstas.TrimStart().Length;
            gale = tekstas.Length - tekstas.TrimEnd().Length;
        }




    }

        }
