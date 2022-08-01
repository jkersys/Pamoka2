﻿using System.Text;

namespace Hangman
{
    public class Program
    {
        public static int menuPasirinkimas = 0;
        public static int neteisinguSpejimuSkaicius = 0;
        public static string sugeneruotasZodis = "";
        public static string tema = "";
        public static List<string> spetosRaides = new List<string>();
        public static string spejimas = "";
        public static List<char> uzmaskuotasZodis = new List<char>();
        public static char spejamaRaide;
        public static bool laimeta = false;

        public static Dictionary<string, bool> panaudotiZodziai = new Dictionary<string, bool>();

        public static Dictionary<string, bool> pasirinktiZodziai;

        //public static string[] vardai = new[] { "Greta", "Karolina", "Tomas", "Petras", "Genutė", "Justinas", "Giedrė", "Gintarė", "Ratis", "Audrius" };
        public static Dictionary<string, bool> vardai = new Dictionary<string, bool>() { { "ŠarŪnas", false } };
        public static Dictionary<string, bool> miestai = new Dictionary<string, bool>() { { "Vilnius", false } };
        public static Dictionary<string, bool> salys = new Dictionary<string, bool>() { { "Lietuva", false } };
        public static Dictionary<string, bool> kita = new Dictionary<string, bool>() { { "Pienas", false } };

        //public static string[] miestai = new[] { "Vilnius", "Kaunas", "Molėtai", "Varėna", "Klaipėda", "Alytus", "Panevėžys", "Lazdijai", "Ignalina", "Utena" };
        //public static string[] salys = new[] { "Lietuva", "Latvija", "Estija", "Lenkija", "Ukraina", "Suomija", "Švedija", "Norvegija", "Danija", "Vokietija" };
        //public static string[] kita = new[] { "Stalas", "Kėdė", "Zemėlapis", "Pelė", "Kilimas", "Spausdintuvas", "Laikrodis", "Siena", "Grindys", "Lubos" };


        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            Kartuves();
        }
        public static void Kartuves()
        {
            Reset();

            //pakvieciam menu, temos pasirinkimui ir busenos priskyrimui
            KartuviuMenu();

            //pakvieciam metoda, kuris pagal esama busena sugeneruotu random zodi
            ZodzioParinkimas();
            ZodzioUzmaskavimas();

            while (neteisinguSpejimuSkaicius < 7)
            {
                Console.Clear();
                Console.WriteLine($"Tema: {tema}");
                KartuviuPiesimas();
                Console.WriteLine();
                Console.Write($"Spėtos raidės: ");
                SpetosRaides();
                Console.Write("\nZodis: ");
                Console.WriteLine(string.Join(" ", uzmaskuotasZodis));
                Console.WriteLine("\n\nSpekite raide, ar zodi");

                spejimas = Console.ReadLine();
                

                if (spejimas.Length == 1)
                {
                    spejamaRaide = spejimas[0];

                    if (char.IsLetter(spejamaRaide))
                    {       //ignoruoja didžiasias ir mazasias raides
                        if (sugeneruotasZodis.Contains(spejimas, StringComparison.CurrentCultureIgnoreCase)) 
                        {
                            for (int i = 0; i < sugeneruotasZodis.Length; i++)
                            {                   //suvienodina abi raides, kad suveiktu palyginimas
                                if (char.ToUpper(sugeneruotasZodis[i]) == char.ToUpper(spejamaRaide))
                                {
                                    uzmaskuotasZodis[i] = spejamaRaide;
                                }
                            }

                            if (!uzmaskuotasZodis.Contains('_'))
                            {
                                laimeta = true;
                                break;
                            }
                        }
                        else
                        {
                            neteisinguSpejimuSkaicius++;
                        }
                    }
                }
                else
                {                   //tikrina ar laimeta, ignuoroja didziosios ar mazosios raides
                    laimeta = sugeneruotasZodis.Equals(spejimas, StringComparison.CurrentCultureIgnoreCase) ? true : false;
                    break;
                }
            }

            ZaidimoPabaiga();
        }


        public static void Reset()
        {
            laimeta = false;
            neteisinguSpejimuSkaicius = 0;
            sugeneruotasZodis = "";
            spejamaRaide = ' ';
            uzmaskuotasZodis.Clear();
            spejimas = "";
            spetosRaides.Clear();
        }

        public static void ZaidimoPabaiga()
        {            
            if (laimeta)
            {
                ZaidimoPabaigosMeniu(new[] { "LAIMEJOT", "Pakartoti zaidima T/N?" });
            }
            else
            {
                Console.Clear();
                neteisinguSpejimuSkaicius = 7;
                KartuviuPiesimas();
                ZaidimoPabaigosMeniu(new[] { "PRALAIMEJOT", "Pakartoti zaidima T/N?" });
            }
        }

        public static void ZaidimoPabaigosMeniu(string[] meniuItems)
        {
            foreach (var meniuItem in meniuItems)
            {
                Console.WriteLine(meniuItem);
            }
            
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.T)
                {
                    break;
                }
                if (key.Key == ConsoleKey.N)
                {
                    Environment.Exit(0);
                }
            }

            Kartuves();
        }

        // metodas pasirinkti temai
        public static void KartuviuMenu()
        {
            Console.Clear();
            Console.WriteLine("Pasirinkite tema:");
            Console.WriteLine("1. Vardai");
            Console.WriteLine("2. Miestai");
            Console.WriteLine("3. Valstybes");
            Console.WriteLine("4. Kita");

            // int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out menuPasirinkimas);

            if (menuPasirinkimas <= 4 && menuPasirinkimas >= 1)
                switch (menuPasirinkimas)
                {
                    case 1:
                        menuPasirinkimas = 1;
                        tema = "VARDAI";
                        pasirinktiZodziai = vardai;
                        break;
                    case 2:
                        menuPasirinkimas = 2;
                        tema = "MIESTAI";
                        pasirinktiZodziai = miestai;
                        break;
                    case 3:
                        menuPasirinkimas = 3;
                        tema = "VALSTYBE";
                        pasirinktiZodziai = salys;
                        break;
                    case 4:
                        menuPasirinkimas = 4;
                        tema = "KITA";
                        pasirinktiZodziai = kita;
                        break;
                    default:
                        break;
                }
            else
            {
                Console.WriteLine($"{menuPasirinkimas} tokios temos nėra, pasirinkite kitą temą");
                KartuviuMenu();
            }
        }

        public static void ZodzioParinkimas()
        {       //pasifiltruojam nepanaudotus zodzius
            var nepanaudotiZodziai = NepanaudotiZodziai(pasirinktiZodziai);
            if (nepanaudotiZodziai.Count == 0)
            {
                ZaidimoPabaigosMeniu(new[] { "Tema: {kintamaji isirasyt}", "Temoje nebera zodziu, ar norite rinktis kita tema T/N" });
            }

            Random rnd = new Random();
            int random = rnd.Next(nepanaudotiZodziai.Count);
            sugeneruotasZodis = nepanaudotiZodziai[random];
            pasirinktiZodziai[sugeneruotasZodis] = true;
        }

        public static List<string> NepanaudotiZodziai(Dictionary<string, bool> zodziai)
        {
            List<string> nepanaudotiZodziai = new List<string>();
            foreach (var zodis in zodziai)
            {
                if (zodis.Value == false)
                {
                    nepanaudotiZodziai.Add(zodis.Key);
                }
            }
            return nepanaudotiZodziai;
        }

        public static void ZodzioUzmaskavimas()
        {
            for (int i = 0; i < sugeneruotasZodis.Length; i++)
            {
                uzmaskuotasZodis.Add('_');
            }
        }

        public static void SpetosRaides()
        {
            if (!sugeneruotasZodis.Contains(spejimas, StringComparison.CurrentCultureIgnoreCase) && !spetosRaides.Contains(spejimas))
            {
                if (char.IsLetter(spejimas[0])){
                    spetosRaides.Add(spejimas);
                }
            }
            Console.Write($"{string.Join(", ", spetosRaides)}");
        }

        public static void KartuviuPiesimas()
        {
            if (neteisinguSpejimuSkaicius == 0)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
                Console.WriteLine("|               ");
            }
            else if (neteisinguSpejimuSkaicius == 1)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|             ");
                Console.WriteLine("|             ");
                Console.WriteLine("|              ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
            else if (neteisinguSpejimuSkaicius == 2)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|              |");
                Console.WriteLine("|               ");
                Console.WriteLine("|              ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
            else if (neteisinguSpejimuSkaicius == 3)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|            \\|");
                Console.WriteLine("|               ");
                Console.WriteLine("|              ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
            else if (neteisinguSpejimuSkaicius == 4)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|             \\|/");
                Console.WriteLine("|              ");
                Console.WriteLine("|              ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
            else if (neteisinguSpejimuSkaicius == 5)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|             \\|/");
                Console.WriteLine("|              0 ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
            else if (neteisinguSpejimuSkaicius == 6)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|             \\|/");
                Console.WriteLine("|              0 ");
                Console.WriteLine("|             /  ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
            else if (neteisinguSpejimuSkaicius == 7)
            {
                Console.WriteLine("   - - - - - - |");
                Console.WriteLine("|              o ");
                Console.WriteLine("|             \\|/");
                Console.WriteLine("|              0 ");
                Console.WriteLine("|             / \\ ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
                Console.WriteLine("|                ");
            }
        }
    }
}