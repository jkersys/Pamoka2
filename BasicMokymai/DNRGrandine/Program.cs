namespace DNRGrandine
{
    public class Program
    {
        public static bool arNormalizuota = false;
        public static bool arValidi = false;
        public static string grandine = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

        static void Main(string[] args)
        {
            Menu(ref grandine);
        }

        static void Menu(ref string grandine)
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


        static void NormalizationMenu(ref string grandine)
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
        static void SubMenu(ref string grandine)
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
                    grandine = grandine.Replace("GCT", "AGG");
                    Console.WriteLine($"{grandine}");
                    SubMenu(ref grandine);
                    break;
                case "2":
                    Console.WriteLine("Paspaustas 2");
                    Console.WriteLine($"Ar tekste yra CAT = {grandine.Contains("CAT")}");
                    SubMenu(ref grandine);
                    break;
                case "3":
                    Console.WriteLine("Paspaustas 3");
                    string TreciasSegmentas = grandine.Substring(8, 3);
                    string PentasSegmentas = grandine.Substring(16, 3);
                    Console.WriteLine($"Trecias segmentas = {TreciasSegmentas} Penktas segmentas = {PentasSegmentas}");
                    SubMenu(ref grandine);
                    break;
                case "4":
                    Console.WriteLine("Paspaustas 4");
                    var raidziuKiekis = grandine.Replace("-", "").Length;
                    Console.WriteLine($"Grandineje yra {raidziuKiekis} raidziu(-es)");
                    SubMenu(ref grandine);
                    break;
                case "5":
                    Console.WriteLine("Paspaustas 5");
                    var IvestasTekstasIsConsoles = Console.ReadLine();
                    SubMenu(ref grandine);
                    break;
                case "6":
                    Console.WriteLine("Paspaustas 6");
                    
                    Console.WriteLine("Iveskite 3 raides (A,T,C,G)");
                    var ivestasTekstas2 = Console.ReadLine();
                    var arIvestosRaidesValidzios = false;
                    if (arIvestosRaidesValidzios = ivestasTekstas2.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-') && ivestasTekstas2.Length == 3)
                    {
                        Console.WriteLine($"{grandine}-{ivestasTekstas2}");
                        SubMenu(ref grandine);
                    }
                    else
                        Console.WriteLine("Nevalidus tekstas");
                        SubMenu(ref grandine);

                    break;
                case "7":
                    Console.WriteLine("Paspaustas 7");
                    Console.WriteLine("Pasalinkite is grandines elementa");
                    string PanaikintiElementa = Console.ReadLine();
                    
                    string pasalintiElementa = grandine.Replace(PanaikintiElementa, "");
                    Console.WriteLine($"{pasalintiElementa}");
                   // grandine.Remove(pasalintiElementa);
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


     //   public static bool PrieGrandinesGaloTrysSimboliai(ref string grandine)
       // {
        //    var ivestasTekstas2 = Console.ReadLine();
        //    ivestasTekstas2.All(x => x == 'A' || x == 'T' || x == 'C' || x == 'G' || x == '-');
            
        }
     
        }

    
