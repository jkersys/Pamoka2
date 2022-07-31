using System.Text;

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
        public static List<char> pasleptasZodis = new List<char>();
        public static char spejamaRaide;


        public static string[] vardai = new string[] { "Greta", "Karolina", "Tomas", "Petras", "Genute", "Justinas", "Giedre", "Gintare", "Ratis", "Audrius" };
        public static string[] miestai = new string[] { "Vilnius", "Kaunas", "Moletai", "Varena", "Klaipeda", "Alytus", "Panevezys", "Lazdijai", "Ignalina", "Utena" };
        public static string[] salys = new string[] { "Lietuva", "Latvija", "Estija", "Lenkija", "Ukraina", "Suomija", "Svedija", "Norvegija", "Danija", "Vokietija" };
        public static string[] kita = new string[] { "Stalas", "Kede", "Zemelapis", "Pele", "Kilimas", "Spausdintuvas", "Laikrodis", "Siena", "Grindys", "Lubos" };


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kartuves();


            // VardaiRandom(vardai, randomZodis);
            // KartuviuMenu(menubusena);

            /*

            int random = randomZodis.(vardai.Length);
           string zodis = vardai[random];

            */

            //Console.WriteLine(zodis);



























        }
















        public static void Kartuves()
        {
            Console.WriteLine("Pasirinkite tema:");
            Console.WriteLine("1. Vardai");
            Console.WriteLine("2. Miestai");
            Console.WriteLine("3. Valstybes");
            Console.WriteLine("4. Kita");

            //pakvieciam menu, temos pasirinkimui ir busenos priskyrimui
            KartuviuMenu();
            //pakvieciam metoda, kuris pagal esama busena sugeneruotu random zodi
            RandomZodzioGeneravimas();

            while (neteisinguSpejimuSkaicius <= 7)
            {

                Console.Clear();
                Console.WriteLine($"Tema: {tema}");
                KartuviuPiesimas();
                Console.WriteLine();
                Console.Write($"Spėtos raidės: ");
                SpetosRaides();
                Console.Write("\nZodis: ");
                ZodzioPaslepimas();
                Console.WriteLine("\n\nSpekite raide, ar zodi");
                // Console.WriteLine($"{string.Join(" ", pasleptasZodis)}");

                spejimas = Console.ReadLine();
                char.Parse(spejimas.ToLower());


                if (spejimas.Length == 1)
                {
                    spejamaRaide = spejimas[0];
                    if (sugeneruotasZodis.Contains(spejimas))
                    {
                        for (int i = 0; i < sugeneruotasZodis.Length; i++)
                        {
                            if (sugeneruotasZodis[i] == spejamaRaide)
                            {
                                pasleptasZodis[i] = spejamaRaide;
                            }

                        }


                    }

                }
                else
                {
                    if (spejimas.Length < 1)
                    {

                        for (int i = 0; i < sugeneruotasZodis.Length; i++)
                        {
                            if (sugeneruotasZodis[i] == spejamaRaide)
                            {
                                pasleptasZodis[i] = spejamaRaide;
                            }
                            else
                            {
                                neteisinguSpejimuSkaicius = 7;
                            }
                        }
                    }
                }


                /*
                if(sugeneruotasZodis.Contains(spejimas))
                {
                    for (int i = 0; i < sugeneruotasZodis.Length; i++)
                    {
                        if (spejimas = sugeneruotasZodis[i])
                        {

                        }
                    }
                }
                */




            }
        }


        // metodas pasirinkti temai
        public static void KartuviuMenu()
        {


            // int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out menuPasirinkimas);


            while (menuPasirinkimas != 1 || menuPasirinkimas != 2 || menuPasirinkimas != 3 || menuPasirinkimas != 4)

                if (menuPasirinkimas <= 4 && menuPasirinkimas >= 1)
                    switch (menuPasirinkimas)
                    {

                        case 1:
                            menuPasirinkimas = 1;
                            tema = "VARDAI";
                            if (vardai.Length <= 0)
                                Console.WriteLine("nebera zodziu rinkites kita tema");
                            return;
                            break;
                        case 2:
                            menuPasirinkimas = 2;
                            tema = "MIESTAI";
                            return;
                            break;
                        case 3:
                            menuPasirinkimas = 3;
                            tema = "VALSTYBE";
                            return;
                            break;
                        case 4:
                            menuPasirinkimas = 4;
                            tema = "KITA";
                            return;
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


        public static void RandomZodzioGeneravimas()
        {

            if (menuPasirinkimas >= 1 && menuPasirinkimas <= 4 || vardai.Length <= 0 || miestai.Length <= 0 || salys.Length <= 0 || kita.Length <= 0)
            {
                Console.WriteLine("Šioje temoje nebėra žodžių");
            }

            Random rnd = new Random();

            if (menuPasirinkimas == 1) //vardai
            {
                int random = rnd.Next(vardai.Length);
                sugeneruotasZodis = vardai[random].ToLower();

                Array.Resize(ref vardai, vardai.Length - 1);

            }
            if (menuPasirinkimas == 2)  //miestai
            {
                int random = rnd.Next(miestai.Length);
                sugeneruotasZodis = miestai[random];
                Array.Resize(ref vardai, vardai.Length - 1);

            }
            if (menuPasirinkimas == 3)  //salys
            {
                int random = rnd.Next(salys.Length);
                sugeneruotasZodis = salys[random];
                Array.Resize(ref vardai, vardai.Length - 1);

            }
            if (menuPasirinkimas == 4)  //kita
            {
                int random = rnd.Next(kita.Length);
                sugeneruotasZodis = kita[random] ;
                Array.Resize(ref vardai, vardai.Length - 1);


            }

        }


        public static void ZodzioPaslepimas()
        {
             
        for (int i = 0; i < sugeneruotasZodis.Length; i++)
        {
            pasleptasZodis.Add('_');
            Console.Write(pasleptasZodis[i]);

                
        }
        /*
        if (pasleptasZodis.Contains(spejimas))
        {

            for (int i = 0; i < sugeneruotasZodis.Length; i++)
            {
                Console.WriteLine(spejimas == su[i]);
                Console.WriteLine(pasleptasZodis[i]);
            }
        }
                /*
                if (sugeneruotasZodis.Contains(spejimas))
            {
                for (int i = 0; i < sugeneruotasZodis.Length; i++)
                {
                    pasleptasZodis.Remove(spejimas);

                }
            }
                */

        //     if (sugeneruotasZodis.Contains(spejimas))
        //     {
        //              pasleptasZodis.Add(spejimas);
        //     }

    }

                public static void SpetosRaides()
                {
                    if (!sugeneruotasZodis.Contains(spejimas))
                    spetosRaides.Add(spejimas);
                    Console.Write($"{string.Join(", ", spetosRaides)}");
                    neteisinguSpejimuSkaicius++;

                    //foreach (var spejimas in spetosRaides)
                    //{
                    // Console.Write($"{string.Join(", ", spejimas)}");
                    //}

                }


                /*

                while (menubusena == 0)
                {


                    if (pasirinkimas == 1)
                    {
                        menubusena = 1;
                        return;
                    }
                    if (pasirinkimas == 2)
                    {
                        menubusena = 2;
                        return;
                    }
                    if (pasirinkimas == 3)
                    {
                        menubusena = 3;
                        return;
                    }
                    if (pasirinkimas == 4)
                    {
                        menubusena = 4;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("tokio pasirinkimo nėra");
                    }


                }
                */



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










                /*
                else if (menuPasirinkimas == 2)
                {
                        int random = randomZodis.Next(vardai.Length);
                        pasirino = true;
                    }
                else if (menuPasirinkimas == 3)
                {
                    pasirino = true;
                }
                else if (menuPasirinkimas == 4)
                {
                    pasirino = true;
                }
                else
                {
                    Console.WriteLine("Tokio pasirinkimo nera");
                }
                */
















            }
        }
    

    

    




    


