using System;

namespace P_003_OOP_Konstruktoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OOP Konstruktoriai!");
            //KonstruktoriuPavyzdziuPaleidimas();

            var knyga1 = new Knyga();
            var knyga2 = new Knyga("Minkstas", 50, "Marksas", 100_000_000, "Vaga", "Traktatas");
            var knyga3 = new Knyga(knyga2);

            //var masina = new Masina();
            //var masina2 = new Masina();
            //var masina3 = new Masina(masina2);



            var zmogus1 = new Zmogus();
            var zmogus2 = new Zmogus("Petras", "Petrauskas", 1990, "Vyras", "Lietuva");
            var zmogus3 = new Zmogus(zmogus2)
            {
                vardas = "Jonas"
            };
            var zmogus4 = new Zmogus(new Zmogus());
            var zmogusArgumentas = new Zmogus();
            var zmogus6 = new Zmogus(zmogusArgumentas);
            // var zmogus5 = new Zmogus(null);

            var masina1 = new Masina();
            var masina2 = new Masina("Toyota", "Yaris", 2012, true, "Jaroslavas");
            var masina3 = new Masina(masina2)
            {
                Gamintojas = "Audi",
                Modelis = "A4",
                GamybosMetai = 2000
            };

            var ismanusisTelefonas1 = new IsmanusisTelefonas();
            var ismanusisTelefonas2 = new IsmanusisTelefonas(50, 64, 4800, new Dekliukas() { Gamintojas = "Tokai", Kaina = 9.99, Medziaga = "Guminis" })
            {
                Dimensija = "4/3",
                Stiklas = "Grudintas",
                Modelis = "iProdus",
                Rezoliucija = "1080x800"
            };
            var ismanusisTelefonas3 = new IsmanusisTelefonas(ismanusisTelefonas2);
        }

        private static void KonstruktoriuPavyzdziuPaleidimas()
        {
            var klientas1 = new Customer();
            Console.WriteLine($"Kliento 1 vardas: {klientas1.Vardas}"); // Stiuartas
            klientas1.Vardas = "Benas";
            Console.WriteLine($"Kliento 1 vardas: {klientas1.Vardas}"); // Benas

            Customer klientas2 = new Customer
            {
                Vardas = "Ieva"
            };

            var klientas3 = new Customer("Aiste");
            Console.WriteLine($"Kliento 3 vardas: {klientas3.Vardas}");

            var masina = new Masina();
        }

        /*
         * Uzduotis 3: Aprasykite kiekvienai is klasiu aprasytu 1 uzduotyje (P030) po 3 konstruktorius
         */


    }
}