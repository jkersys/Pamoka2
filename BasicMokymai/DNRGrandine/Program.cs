namespace DNRGrandine
{
    public class Program
    {
        static bool arNormalizuota = false;
        static bool arValidi = false;
        static string grandine = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

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
                    break;
                case "2":
                    Console.WriteLine("Paspaustas 2");
                    break;
                case "3":
                    Console.WriteLine("Paspaustas 3");
                    break;
                case "4":
                    Console.WriteLine("Paspaustas 4");
                    break;
                case "5":
                    Console.WriteLine("Paspaustas 5");
                    break;
                case "6":
                    Console.WriteLine("Paspaustas 6");
                    break;
                case "7":
                    Console.WriteLine("Paspaustas 7");
                    break;
                case "8":
                    Console.WriteLine("Paspaustas 8");
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
    }
}