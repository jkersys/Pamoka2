namespace DNRGrandine
{
    public class Program
    {
        public static bool arNormalizuota = false;
        public static bool arValidi = false;
        public static string grandine = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

        static void Main(string[] args)

            /*
             * Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
        Galimos bazės: Adenine, Thymine, Cytosine, Guanine
          Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
          1. Atlikti DNR grandinės normalizavimo veiksmus:
             - pašalina tarpus.
             - visas raides keičia didžiosiomis.
          2. Atlikti grandinės validaciją
             - patikrina ar nėra kitų nei ATCG raidžių
          3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
              - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui
              1) normalizuoti grandinę
              2) išeiti iš programos
              - jei grandinė normalizuota arba kai buvo atlikta normalizacija
              1) GCT pakeis į AGG
              2) Išvesti ar yra tekste CAT
              3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
              4) Išvesti raidžių kiekį tekste (naudoti string composition)
              5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas
              6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
                  (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
              7) Iš grandinės pašalinti pasirinką elementą  
              8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
                  (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
              9) Gryžti į ankstesnį meniu
        Visoms operacijoms reikalingi testai.
            */


        {
            Menu(ref grandine);
        }

       

        public static void Menu(ref string grandine)
        {
            Console.WriteLine("1. Atlikti DNR grandinės normalizavimo veiksmus");
            Console.WriteLine("2. Atlikti grandinės validaciją");
            Console.WriteLine("3. Atlieka veiksmus su DNR grandine");

            switch (Console.ReadLine())
            {
                case "1":
                    NormalizuotiGrandine(ref grandine);
                    arNormalizuota = true;
                    Console.WriteLine("Normalizacija atlikta");
                    Menu(ref grandine);
                    break;
                case "2":
                    arValidi = ArValidiGrandine(grandine);
                    Console.WriteLine(arValidi == true ? "Grandine validi" : "Grandine nevalidi");
                    Menu(ref grandine);
                    break;
                case "3":
                    Console.WriteLine("Paspaustas 3");
                    if (arNormalizuota == false)
                    {
                        NormalizationMenu(ref grandine);
                    }
                    else
                    {
                        SubMenu(ref grandine);
                    }
                    break;
            }
        }


        public static void NormalizationMenu(ref string grandine)
        {
            Console.Clear();
            Console.WriteLine("1. Normalizuoti grandine");
            Console.WriteLine("2. Iseiti is programos");

            switch (Console.ReadLine())
            {
                case "1":
                    NormalizuotiGrandine(ref grandine);
                    arNormalizuota = true;
                    SubMenu(ref grandine);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    NormalizationMenu(ref grandine);
                    break;

            }
        }
        public static void SubMenu(ref string grandine)
        {
            Console.WriteLine("1. GCT pakeis į AGG");
            Console.WriteLine("2. Išvesti ar yra tekste CAT");
            Console.WriteLine("3. Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).");
            Console.WriteLine("4. Išvesti raidžių kiekį tekste (naudoti string composition).");
            Console.WriteLine("5. Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas");
            Console.WriteLine("6. Prie grandinės galo pridėti iš klaviatūros įvesta segmentą(reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)");
            Console.WriteLine("7. Iš grandinės pašalinti pasirinką elementą");
            Console.WriteLine("8. Pakeisti pasirinkti segmentą įvestu iš klaviatūros(reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)");
            Console.WriteLine("9. Grįzti i pagrinidni meniu.");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Paspaustas 1");
                    PakeistiGctIAgg(ref grandine);
                    SubMenu(ref grandine);
                    break;
                case "2":
                    Console.WriteLine("Paspaustas 2");
                    Console.WriteLine($"Ar grandinėje yra CAT  {ArYraCat(ref grandine)}");
                    SubMenu(ref grandine);
                    break;
                case "3":
                    Console.WriteLine("Paspaustas 3");
                    TreciasIrPenktasSegmentas(ref grandine);
                    SubMenu(ref grandine);
                    break;
                case "4":
                    Console.WriteLine("Paspaustas 4");
                    KiekRaidziuGrandineje(ref grandine);
                    SubMenu(ref grandine);
                    break;
                case "5":
                    Console.WriteLine("Paspaustas 5");
                    string tekstas = "";
                    KiekKartuKartojasiKodas(ref grandine, tekstas);
                    SubMenu(ref grandine);
                    break;
                case "6":
                    Console.WriteLine("Paspaustas 6");
                    
                    PridediPrieGRandinesIvestaSegmenta(ref grandine);

                    break;
                case "7":
                    Console.WriteLine("Paspaustas 7");
                    string PanaikintiElementa = "";
                    IstrintiSegmenta(ref grandine, PanaikintiElementa);
                    SubMenu(ref grandine);
                   
                    break;
                case "8":
                   Console.WriteLine("Paspaustas 8");
                    
            
                   Console.WriteLine("Pasirinkite kuri grandines elementa norite pasalinti");
                   string IvestiKaKeisti = Console.ReadLine();
                   Console.WriteLine("Iveskite kuo norite pakeisti");
                   string IvestiIKaKeisti = Console.ReadLine();
                    
                    if (IvestiKaKeisti.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-') && 
                        (IvestiIKaKeisti.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-')))
                         {
                        string PakeistasElementasIsI = grandine.Replace(IvestiKaKeisti, IvestiIKaKeisti);
                        Console.WriteLine($"{PakeistasElementasIsI}");
                         }
                    else
                        Console.WriteLine("Nevalidus teksas");                                      
                    SubMenu(ref grandine);
                    break;
                case "9":
                    Console.WriteLine("Gryztii pradini meniu");
                    Menu(ref grandine);
                    break;
            }
        }

        public static void NormalizuotiGrandine(ref string grandine)
        {
            grandine = grandine.Replace(" ", "").ToUpper();
        }

        public static bool ArValidiGrandine(string grandine)
        {
           return grandine.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-');
        }

        //Metodas pakeisti GCT I AGG
        public static string PakeistiGctIAgg(ref string grandine)
        {
           string grandineAGG = grandine.Replace("GCT", "AGG");
            Console.WriteLine($"Operacija atlikta \n{grandineAGG}");
            return grandineAGG;
        }

        //Metodas ar grandineje yra CAT
        public static bool ArYraCat(ref string grandine) => grandine.Contains("CAT");

        //trecias ir penktas segmentas
        public static string TreciasIrPenktasSegmentas(ref string grandine)
        {
            string TreciasSegmentas = grandine.Substring(8, 3);
            string PentasSegmentas = grandine.Substring(16, 3);
            Console.WriteLine($"Trecias segmentas = {TreciasSegmentas} Penktas segmentas = {PentasSegmentas}");
            return TreciasSegmentas;
            
        }
       
        
        //Kiek raidziu grandineje
        public static int KiekRaidziuGrandineje(ref string grandine)
        {
            var raidziuKiekis = grandine.Replace("-", "").Length;
            Console.WriteLine($"Gradineje yra {raidziuKiekis} raide(es)");
            return raidziuKiekis;
        }
        //kiek kartu kartojasi segmentas
        public static int KiekKartuKartojasiKodas(ref string grandine, string tekstas)
        {
            Console.WriteLine("Iveskite triju raidziu segmenta sudaryta is A,G,T,C");
            tekstas = Console.ReadLine().ToUpper();
            var KiekRandaSegmenta = grandine.Replace(tekstas, "");
            var KiekKartuKartojasi = (grandine.Length - KiekRandaSegmenta.Length) / 3;
            Console.WriteLine($"Segmentas {tekstas} rastas {KiekKartuKartojasi} karta(us)");
            return KiekKartuKartojasi;
        }
        //Prie grandines galo prideti is klaviaturos ivesta segmetna
        public static void PridediPrieGRandinesIvestaSegmenta(ref string grandine)
        {
            Console.WriteLine("Iveskite 3 raides (A,T,C,G)");
            string ivestasTekstas2 = Console.ReadLine().ToUpper();
            var arIvestosRaidesValidzios = false;
            
            if (arIvestosRaidesValidzios = ivestasTekstas2.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-') && ivestasTekstas2.Length == 3)
            {
                var pridetasSegmentas = grandine + "-" + ivestasTekstas2;
                Console.WriteLine($"Jusu ivesta segmentas pridetas {pridetasSegmentas}");
                SubMenu(ref grandine);


            }
            else
                Console.WriteLine("Nevalidus tekstas");
                SubMenu(ref grandine);
           
        }
       
        //Pasalinti segmenta
        public static string IstrintiSegmenta(ref string grandine, string PanaikintiElementa)
        {
            Console.WriteLine($"Iveskite kutri grandines elementa norite pasalinti {grandine}");
            PanaikintiElementa = Console.ReadLine().ToUpper();

            string pasalintiElementa = grandine.Replace(PanaikintiElementa, "");
            Console.WriteLine($"Is grandines pasalintas {PanaikintiElementa} siuo metu atrodo taip: \n{pasalintiElementa}");
            return pasalintiElementa;
        }


        //pakeisti grandines elementa
        public static void PakeistiGrandinesElementa(ref string grandine)
        {
            Console.WriteLine("Pasirinkite kuri grandines elementa norite pasalinti");
            string IvestiKaKeisti = Console.ReadLine().ToUpper();
            Console.WriteLine("Iveskite kuo norite pakeisti");
            string IvestiIKaKeisti = Console.ReadLine().ToUpper();

            if (IvestiKaKeisti.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-') &&
                (IvestiIKaKeisti.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-')))
            {
                string PakeistasElementasIsI = grandine.Replace(IvestiKaKeisti, IvestiIKaKeisti);
                Console.WriteLine($"Elementas pakeistas {PakeistasElementasIsI}");
            }
            else
                Console.WriteLine("Nevalidus teksas");
        }


    }

            
        }
     
        

    
