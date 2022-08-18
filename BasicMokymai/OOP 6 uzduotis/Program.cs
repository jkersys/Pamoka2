namespace OOP_6_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        Zmogus zmogus1 = new Zmogus("Jonas", "Jonaitis");


        var bendrabutis = new Bendrabutis()
        {
            BendrabucioId = 1,
            Kaina = 200,
            KambariuSkaicius = 50,

        };
       
        be




        /*Uzduotis 6: (Savarankiskai)Sukurkite klasę “Bendrabutis”. Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:      
         * BendrabucioId       KambariuSkaicius       Kaina
         * Sujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip, kad kiekviename bendrabutyje galėtų gyventi daug žmonių, 
         * tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje.*/


    }
}