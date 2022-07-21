namespace P023_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Zodynai!");

            DictionaryPavyzdziai();

        }


        public static void DictionaryPavyzdziai()
        {   //zodyno deklaravimas
            Dictionary<string, float> kainuZodynas = new Dictionary<string, float>();
            var kainuKintamasisZodynas = new Dictionary<string, float>();
            Dictionary<string, int> miestai = new Dictionary<string, int>
             {
                 {"Vilnius", 7 },
                 {"Kaunas", 6 },
                 {"Siauliai", 8 },
                 {"Jonava", 6 },
             };
            Dictionary<string, string> ZodziuReiksmes = new Dictionary<string, string>()
            {
                { "Macnus", "Stipraus, astraus skonio"},
                { "Unaravas", "Pasiputes arba arogantiskas"},
                { "Ceckavot", "Smulkiai pjaustyti"},
                { "Bimbineti", "Leisti laika be jokio tikslo"},
                { "Katras", "Kuris is keliu pasirinkimu"}
            };
          //  var vardai = new Dictionary<string, int>()
           // {
         //       { 1. "Andrius" },
            //    { 2."Ieva"},
              //  { 3."Aiste"},
               // { 4."Ieva"},
                //{ 5."Eigenijus"}
            //};
            //Zodyno skaitymas
            Console.WriteLine($"{miestai["Vilnius"]}   {miestai["Kaunas"]}");
            var miestopavadinimoIlgis = miestai["Vilnius"];
            Console.WriteLine($"Kintamojo ilgis {miestopavadinimoIlgis}");

            //zodyno pildymas KeyValuePair
            miestai.Add("Klaipeda", 8);
            Console.WriteLine($"Klaipeda {miestai["Klaipeda"]}");
            miestai["Silute"] = 6;

            // Zodyno perskaitymas
            foreach (KeyValuePair<string, int> miestas in miestai) //galima naudoti var vietoj KeyValuePair<string, int>
            {
                Console.WriteLine(miestas.Value);
            }

            // Zodyno iraso validavimas
            if (miestai.TryGetValue("Klaipeda", out int miestoSkaicius))
            {
                Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            }
            else
            {
                Console.WriteLine("Neradome iraso");
            }
            if(!miestai.ContainsKey("Klaipeda"))
            {
                Console.WriteLine($"Neradome iraso");
            }
            else 
            {
                Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            }

            // Zodyno ValueCollection
            Dictionary<string, int>.ValueCollection miestuReiksmes = miestai.Values;

            foreach (int miestopavadinimoReiksme in miestuReiksmes)
            {
                Console.WriteLine($"Reiksme: {miestopavadinimoReiksme}");
            }

            var skaiciuZodynas = new Dictionary<int, int>
            {
                {1, 1 },
                {2, 2 },
                {3, 3 },
                {4, 4 },
                {5, 5 },
            };

            skaiciuZodynas.Clear();

            if(skaiciuZodynas.Count == 0)
            {
                Console.WriteLine("Irasu nerasta");
            }
            else
            {
                Console.WriteLine("zodynas turi daugiau nei 0 irasu");
            }


        }

        public static void ()









    }
}