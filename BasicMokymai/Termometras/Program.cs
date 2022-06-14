namespace Termometras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("įvesti 1 skaičių - temperatūrą pagal Celsijų");
            var celcius = Convert.ToDouble(Console.ReadLine());
            var farenheitas = (celcius * 9) / 5 + 32;
            var kelvinas = celcius + 273;
            Console.WriteLine($"farenheitas = {farenheitas}");
            Console.WriteLine($"kelvinas = {kelvinas}");
            var farenheitasĮCelcijų = (farenheitas - 32) * 5 / 9;
            Console.WriteLine($" Celcius = farenheitasĮCelcijų {celcius == farenheitasĮCelcijų}");
            var kelvinasĮCelcijų = kelvinas - 273;
            Console.WriteLine($" kelvinas = kelvinasĮCelcijų {celcius == kelvinasĮCelcijų}");
            var farenheitasIKelvina = 273 + ((farenheitas - 32) * 5 / 9);
            Console.WriteLine($"farenheimasikelvina {farenheitasIKelvina}");
            Console.WriteLine($" farenheitas = farenheitasIKelvina {kelvinas == farenheitasIKelvina}");



            
            var TermometrasFarenheitas = (celcius * 9) / 5 + 32;

            double c9 = celcius;
            double c8 = c9 + 5;
            double c7 = c8 + 5;
            double c6 = c7 + 5;
            double c5 = c6 + 5;
            double c4 = c5 + 5;
            double c3 = c4 + 5;
            double c2 = c3 + 5;
            double c1 = c2 + 5;
            double c10 = celcius - 5;
            double c11 = c10 - 5;
            double c12 = c11 - 5;
            double c13 = c12 - 5;
            double c14 = c13 - 5;
            double c15 = c14 - 5;
            double c16 = c15 - 5;
            double c17 = c16 - 5;

            double f9 = TermometrasFarenheitas;
            double f8 = (c8 * 9) / 5 + 32;
            double f7 = (c7 * 9) / 5 + 32;
            double f6 = (c6 * 9) / 5 + 32;
            double f5 = (c5 * 9) / 5 + 32;
            double f4 = (c4 * 9) / 5 + 32;
            double f3 = (c3 * 9) / 5 + 32;
            double f2 = (c2 * 9) / 5 + 32;
            double f1 = (c1 * 9) / 5 + 32;
            double f10 = (c10 * 9) / 5 + 32;
            double f11 = (c11 * 9) / 5 + 32;
            double f12 = (c12 * 9) / 5 + 32;
            double f13 = (c13 * 9) / 5 + 32;
            double f14 = (c14 * 9) / 5 + 32;
            double f15 = (c15 * 9) / 5 + 32;
            double f16 = (c16 * 9) / 5 + 32;
            double f17 = (c17 * 9) / 5 + 32;





            Console.WriteLine($" |--------------------|");
            Console.WriteLine($" |   ^F     _    ^C   |");
            Console.WriteLine($" |  {f1} - | | - {c1} |");
            Console.WriteLine($" |  {f2} - | | - {c2} |");
            Console.WriteLine($" |  {f3} - | | - {c3} |");
            Console.WriteLine($" |  {f4} - | | - {c4} |");
            Console.WriteLine($" |  {f5} - | | - {c5} |");
            Console.WriteLine($" |  {f6} - | | - {c6} |");
            Console.WriteLine($" |  {f7} - | | - {c7} |");
            Console.WriteLine($" |  {f8} - | | - {c8} |");
            Console.WriteLine($" |  {f9} - | | - {c9} |");
            Console.WriteLine($"|  {f10} - | | - {c10} |");
            Console.WriteLine($"|  {f11} - | | - {c11} |");
            Console.WriteLine($"|  {f12} - | | - {c12} |");
            Console.WriteLine($"|  {f13} - | | - {c13} |");
            Console.WriteLine($"|  {f14} - | | - {c14} |");
            Console.WriteLine($"|  {f15} - | | - {c15} |");
            Console.WriteLine($"|  {f16} - | | - {c16} |");
            Console.WriteLine($"|  {f17} - | | - {c17} |");
            Console.WriteLine($"|         '***`       |");
            Console.WriteLine($"|        (*****)      |");
            Console.WriteLine($"|         `---'       |");
            Console.WriteLine($"|         '***`       |");
            Console.WriteLine($"|_____________________|");





            /*
 Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 
   - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
   - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
   - Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
   - Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
   - Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
   - Nupieškite termometrą pagal Celsijų 
     a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
       (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
     b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
        <HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir .Replace(). 
        if naudoti negalima, ternary operator (?) naudoti negalima.
rezultatas gali atrodyti taip:
                            |--------------------|
                            |   ^F     _    ^C   |
                            |  100  - | | -  40  |
                            |   95  - | | -  35  |
                            |   90  - | | -  30  |
                            |   80  - | | -  25  |
                            |   70  - | | -  20  |
                            |   60  - | | -  15  |
                            |   50  - |#| -  10  |
                            |   40  - |#| -   5  |
                            |   30  - |#| -   0  |
                            |   20  - |#| -  -5  |
                            |   10  - |#| - -10  |
                            |    5  - |#| - -15  |
                            |    0  - |#| - -20  |
                            |  -10  - |#| - -25  |
                            |  -20  - |#| - -30  |
                            |  -30  - |#| - -35  |
                            |  -40  - |#| - -40  |
                            |        '***`       |
                            |       (*****)      |
                            |        `---'       |
                            |____________________|


            */








        }
    }
}