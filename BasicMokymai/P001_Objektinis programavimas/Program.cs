namespace P001_Objektinis_programavimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Objektinis programavimas!");

            //deklaruojam nauja objekta naudodami zmogus kaip klase
            var zmogus = new zmogus();
            zmogus.vardas = "Andrius";

            Console.WriteLine($"Zmogus.Vardas: {zmogus.vardas}");

            var zmogus2 = zmogus;
        }


        public static void ZaistiSuPirmaisPavyzdziais()
        {
            var suo = new suo("Pilkius", 5);
        }




        class suo
        {
            public string vardas;
            public int amzius;

            public suo(string vardas, int amzius)
            {
                this.vardas = vardas;
                this.amzius = amzius;
            }
            public void Kalbeti()
            {
                Console.WriteLine($"{vardas} suo 'Au'");
            }

        }

        class seiminkas
        {
            public seimininkas()
            public string vardas { get; set; }
            

        }




        internal class zmogus // internal nebutina rasyti
        {
            public string vardas { get; set; }
            public string pavarde { get; set; }



        }

    }
}