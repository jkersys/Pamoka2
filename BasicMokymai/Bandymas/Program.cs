namespace BM025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki atvykę į KARTUVES! \n");

            Kartuves();
        }


        // Klasės žodynai
        public static Dictionary<int, string> zodynasVardai = new Dictionary<int, string>
        {
            { 0, "Tomas" },
            { 1, "Matas" },
            { 2, "Lukas" },
            { 3, "Jonas" },
            { 4, "Tadas" },
            { 5, "Domas" },
            { 6, "Laima" },
            { 7, "Erika" },
            { 8, "Diana" },
            { 9, "Edita" }
        };
        public static Dictionary<int, string> zodynasMiestai = new Dictionary<int, string>
        {
            { 0, "Alytus" },
            { 1, "Garliava" },
            { 2, "Jonava" },
            { 3, "Kaunas" },
            { 4, "Ignalina" },
            { 5, "Lazdijai" },
            { 6, "Kretinga" },
            { 7, "Prienai" },
            { 8, "Trakai" },
            { 9, "Vilnius" }
        };
        public static Dictionary<int, string> zodynasValstybes = new Dictionary<int, string>
        {
            { 0, "Airija" },
            { 1, "Belgija" },
            { 2, "Danija" },
            { 3, "Egiptas" },
            { 4, "Haitis" },
            { 5, "Irakas" },
            { 6, "Kanada" },
            { 7, "Malta" },
            { 8, "Togas" },
            { 9, "Vanuatu" }
        };
        public static Dictionary<int, string> zodynasKita = new Dictionary<int, string>
        {
            { 0, "Kilpa" },
            { 1, "Sapnas" },
            { 2, "Rojus" },
            { 3, "Balsas" },
            { 4, "Pasaka" },
            { 5, "Magas" },
            { 6, "Garsas" },
            { 7, "Metras" },
            { 8, "Uogos" },
            { 9, "Batas" }
        };

        // Klasės kintamieji
        public static string kartuviuTema = "";
        public static string kartuviuZodis = "";
        public static string zodzioVizualas = "";

        public static bool arZaidziama = true;
        public static bool arLaimeta = false;
        public static int spejimai = 0;

        public static string atspetosRaides = "";
        public static string neatspetosRaides = "";


        public static void Kartuves()
        {
            // Prieš prasidedant žaidimui, visi "pagalbiniai" klasės kintamieji yra grąžinami į savo pirmines reikšmes
            kartuviuTema = "";
            kartuviuZodis = "";
            arZaidziama = true;
            arLaimeta = false;
            spejimai = 0;
            atspetosRaides = "";
            neatspetosRaides = "";

            // Žaidimas prasideda. Pirmiausiai išrenkamas žodis kurį spėlios vartotojas
            while (kartuviuZodis == "")
            {
                PasirinktiTema();
                PasirinktiZodi();
            }

            Console.Clear();

            // Tada nupiešiamos kartuvės ir žaidėjas pradeda spėlioti. Kartojasi iki kol žodis atspėjamas / žaidėjas pakariamas
            while (arZaidziama == true)
            {
                ZodzioVizualinimas();
                KartuviuLenta();
                ZaidejoSpejimas();
                Console.Clear();
            }

            Rezultatas();
        }


        public static void PasirinktiTema()
        {
            // Kintamieji temos pasirinkimui
            var vartojoPasirinkimas = "";

            // Vartotojo prašome pasirinkiti temą
            Console.WriteLine("Pasirinkite temą: \n");
            Console.WriteLine("1. Vardai \n2. Lietuvos Miestai \n3. Valstybes \n4. Kita \n");

            while (kartuviuTema == "")
            {
                vartojoPasirinkimas = Console.ReadLine();
                kartuviuTema = vartojoPasirinkimas switch
                {
                    "1" => "Vardai",
                    "2" => "Lietuvos Miestai",
                    "3" => "Valstybes",
                    "4" => "Kita",
                    _ => ""
                };

                // Jeigu klientas atlieka neteisingą įvestį, while'as kartojasi
                if (kartuviuTema == "") { Console.WriteLine($"\n{vartojoPasirinkimas} temos nėra, bandykite iš naujo"); }
            }
        }


        public static void PasirinktiZodi()
        {
            // Reikiamo zodyno išsitraukimas
            var reikiamasZodynas = kartuviuTema switch
            {
                "Vardai" => zodynasVardai,
                "Lietuvos Miestai" => zodynasMiestai,
                "Valstybes" => zodynasValstybes,
                "Kita" => zodynasKita
            };

            int zodynoIlgis = reikiamasZodynas.Count;

            // Jeigu pasirinktoje temoje nebėra žodžių, vartotojas turi pasirinkti kitą temą
            if (zodynoIlgis == 0)
            {
                Console.Clear();
                Console.WriteLine($"\"{kartuviuTema}\" temoje nebėra žodžių :( \n");
                kartuviuTema = "";
            }

            // Kitu atveju, kartuvių žodžis yra atsitiktinai pasirenkamas iš žodyno
            else
            {
                Random rnd = new Random();
                int zodzioVieta = -1;

                // Jeigu atrinkta žodyno vieta neturi reikšmės, bandoma iš naujo
                while (kartuviuZodis == "")
                {
                    zodzioVieta = rnd.Next(0, 11);

                    if (reikiamasZodynas.TryGetValue(zodzioVieta, out _) == true)
                    { kartuviuZodis = reikiamasZodynas[zodzioVieta]; }
                }

                // Atrinktas žodis yra pašalinamas iš žodyno ir daugiau nepasikartos
                reikiamasZodynas.Remove(zodzioVieta);
            }
        }


        public static void ZodzioVizualinimas()
        {
            char[] kartuviuZodzioMasyvas = kartuviuZodis.ToLower().ToArray();
            zodzioVizualas = "";

            // Atrinktas žodis yra užslapstinamas (nebent žaidėjas atspėjo kažkurias raides)
            foreach (char c in kartuviuZodzioMasyvas)
            {
                if (atspetosRaides.Contains(c))
                { zodzioVizualas += c; }
                else
                { zodzioVizualas += "_"; }

                zodzioVizualas += " ";
            }
        }


        public static void KartuviuLenta()
        {
            // Žodynas kuriuo bus naudojamasi nupiešti žmogeliuką
            Dictionary<int, string[]> zmogZodynas = new Dictionary<int, string[]>
            {
                { 0, new string[] { "   |   ", "  _|_  ", "  _|_  ", "  _|_  ", "  _|_  ",  "  _|_  ",  "  _|_  "  } },
                { 1, new string[] { "       ", " (o_O) ", " (o_O) ", " (o_O) ", " (o_O) ",  " (o_O) ",  " (x_X) "  } },
                { 2, new string[] { "       ", "       ", "  | |  ", " /| |  ", " /| |\\ ", " /| |\\ ", " /| |\\ " } },
                { 3, new string[] { "       ", "       ", "  | |  ", "/ | |  ", "/ | | \\", "/ | | \\", "/ | | \\" } },
                { 4, new string[] { "       ", "       ", "   -   ", "   -   ", "   -   ",  "  /-   ",  "  /-\\  " } },
                { 5, new string[] { "       ", "       ", "       ", "       ", "       ",  "_/     ",  "_/   \\_" } }
            };

            // Kartuvių lenta!
            Console.WriteLine($"Tema: {kartuviuTema}    \n" +
                $"     __________                       \n" +
                $"     |/       |                       \n" +
                $"     |     {zmogZodynas[0][spejimai]} \n" +
                $"     |     {zmogZodynas[1][spejimai]} \n" +
                $"     |     {zmogZodynas[2][spejimai]} \n" +
                $"     |     {zmogZodynas[3][spejimai]} \n" +
                $"     |     {zmogZodynas[4][spejimai]} \n" +
                $"     |     {zmogZodynas[5][spejimai]} \n" +
                $"     |                                \n" +
                $"   __|__                              \n");
        }


        public static void ZaidejoSpejimas()
        {
            Console.WriteLine($"\n" +
                $"Spetos raides: {neatspetosRaides}\n" +
                $"Zodis: {zodzioVizualas}\n\n" +
                $"Spėkite raidę arba žodį: \n");

            var ivedimas = "";

            // Vartotojo prašoma atlikti įvedimą tol kol jis kažką įrašo
            while (ivedimas == "") { ivedimas = Console.ReadLine(); }
            ivedimas = ivedimas.ToLower();

            // Jeigu įvedama raidė, patikrinima ar ji yra kartuvių žodyje / ar buvo spėta ankščiau
            if (char.TryParse(ivedimas, out _) == true)
            {
                if (kartuviuZodis.ToLower().Contains(ivedimas) && !(atspetosRaides.Contains(ivedimas)))
                { atspetosRaides += ivedimas; }

                else if (!(kartuviuZodis.ToLower().Contains(ivedimas)) && !(neatspetosRaides.Contains(ivedimas)))
                { neatspetosRaides += " " + ivedimas; spejimai++; }

            } // Kitu atveju palyginama ar tai kas įvesta yra kartuvių žodis
            else
            {
                if (ivedimas == kartuviuZodis.ToLower())
                { arLaimeta = true; }
                else
                { arLaimeta = false; spejimai = 6; }

                arZaidziama = false;
            }

            // Patikrinama ar vartotojas atspėjo visas raides (jeigu jau natspėjo žodžio)
            if (PatikrintiRaides() && arLaimeta == false)
            {
                arLaimeta = true;
                arZaidziama = false;
            }
            // Prie to paties patikrinama ar vartotojas išnaudojo visus spėjimus
            else if (spejimai > 5)
            {
                arLaimeta = false;
                arZaidziama = false;
            }
        }


        public static bool PatikrintiRaides()
        {
            bool arViskas = true;
            char[] kartuviuZodzioMasyvas = kartuviuZodis.ToLower().ToArray();

            // Patikrinima kiekviena raidė kartuvių žodyje (ar jos atspėtos)
            foreach (char c in kartuviuZodzioMasyvas)
            {
                if (atspetosRaides.Contains(c) == false)
                { arViskas = false; break; }
            }

            return arViskas;
        }


        public static void Rezultatas()
        {
            // Vizualas laimėjus/pralaimėjus žaidimą
            if (arLaimeta)
            {
                Console.WriteLine("\n!!!!! SVEIKINIMAI! !!!!! \nJus atspejote teisingai!\n");
            }
            else
            {
                KartuviuLenta();
                Console.WriteLine("\n----- PRALAIMEJOTE -----\n");
            }

            Console.WriteLine($"Žodis buvo: {kartuviuZodis}");

            // Patikrinama ar dar yra temų su žodžiais
            if (zodynasVardai.Count == 0 && zodynasMiestai.Count == 0 && zodynasValstybes.Count == 0 && zodynasKita.Count == 0)
            {
                Console.WriteLine("Išnaudojote visus žodžius, žaidimas baigtas :)");
            }
            else
            {
                // Žaidėjo paklausiama ar nori kartoti žaidimą
                Console.WriteLine($"Ar norite kartoti žaidimą? T/N \n");
                string? ivedimas = Console.ReadLine();

                if (ivedimas.ToLower() == "t") { Console.Clear(); Kartuves(); }
            }
        }
    }
}