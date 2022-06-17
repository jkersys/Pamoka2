namespace Termometras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Paprašom įvesti skaičių kuris reiks Celcijaus laipsnius
            Console.WriteLine("įvesti 1 skaičių - temperatūrą pagal Celsijų");
            var celcius = Convert.ToDouble(Console.ReadLine());

            //Celcijų paverčiam farenheitu
            var farenheitas = (celcius * 9) / 5 + 32;
            //Celcojų paverčiam Kelvinu
            var kelvinas = celcius + 273;
            //Išvedam farenheitą ir kelviną į ekraną
            Console.WriteLine($"farenheitas = {farenheitas}");
            Console.WriteLine($"kelvinas = {kelvinas}");
            //farenheitą keičiam į celcijų
            var farenheitasĮCelcijų = (farenheitas - 32) * 5 / 9;
            //Patikrinam ar įvestas skaičius sutampa su skaičiumi kurį gavome konvertavę farenheitą į celcijų
            Console.WriteLine($" Celcius = farenheitasĮCelcijų {celcius == farenheitasĮCelcijų}");
            //Pakeičiam kelviną į celcijų
            var kelvinasĮCelcijų = kelvinas - 273;
            //Patikrinam ar įvestas skaičius sutampa su skaičiumi kurį gavome konvertavę farenheitą į celcijų
            Console.WriteLine($" kelvinas = kelvinasĮCelcijų {celcius == kelvinasĮCelcijų}");
            //Pakeičiam farenheitą į kelviną
            var farenheitasIKelvina = 273 + ((farenheitas - 32) * 5 / 9);
            Console.WriteLine($" kelvinasĮCelcijų = farenheitasIKelvina {kelvinasĮCelcijų == farenheitasIKelvina}");
            Console.WriteLine($" farenheitasĮCelcijų = farenheitasIKelvina {farenheitasĮCelcijų == farenheitasIKelvina}");




            //kad aiškiau man būtų pasidarau naują farenheto kintamąjį termometrui
            var TermometrasFarenheitas = (celcius * 9) / 5 + 32;

            //Celcijaus stulpelį susigraduojam po +5 ir -5
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


            //susigraduoju farenheito stulpelį pagal formulę
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



            //Tikrinam ar įvestas skaičius didesnis už esantį termometro eilutėje, bei pakeičiam boolean į string ir True su False keičiame į # ir "  "
            var b1 = (celcius >= c1).ToString().Replace("True", "#").Replace("False", " ");
            var b2 = (celcius >= c2).ToString().Replace("True", "#").Replace("False", " "); ;
            var b3 = (celcius >= c3).ToString().Replace("True", "#").Replace("False", " "); ;
            var b4 = (celcius >= c4).ToString().Replace("True", "#").Replace("False", " "); ;
            var b5 = (celcius >= c5).ToString().Replace("True", "#").Replace("False", " "); ;
            var b6 = (celcius >= c6).ToString().Replace("True", "#").Replace("False", " "); ;
            var b7 = (celcius >= c7).ToString().Replace("True", "#").Replace("False", " "); ;
            var b8 = (celcius >= c8).ToString().Replace("True", "#").Replace("False", " "); ;
            var b9 = (celcius >= c9).ToString().Replace("True", "#").Replace("False", " "); ;
            var b10 = (celcius >= c10).ToString().Replace("True", "#").Replace("False", " "); ;
            var b11 = (celcius >= c11).ToString().Replace("True", "#").Replace("False", " "); ;
            var b12 = (celcius >= c12).ToString().Replace("True", "#").Replace("False", " "); ;
            var b13 = (celcius >= c13).ToString().Replace("True", "#").Replace("False", " "); ;
            var b14 = (celcius >= c14).ToString().Replace("True", "#").Replace("False", " "); ;
            var b15 = (celcius >= c15).ToString().Replace("True", "#").Replace("False", " "); ;
            var b16 = (celcius >= c16).ToString().Replace("True", "#").Replace("False", " "); ;
            var b17 = (celcius >= c17).ToString().Replace("True", "#").Replace("False", " "); ;





            //Termometras
            Console.WriteLine($" |-----------------|");
            Console.WriteLine($" |   ^F    _    ^C |");
            Console.WriteLine($" |  {f1} - |{b1}| - {c1} |");
            Console.WriteLine($" |  {f2} - |{b2}| - {c2} |");
            Console.WriteLine($" |  {f3} - |{b3}| - {c3} |");
            Console.WriteLine($" |  {f4} - |{b4}| - {c4} |");
            Console.WriteLine($" |  {f5} - |{b5}| - {c5} |");
            Console.WriteLine($" |  {f6} - |{b6}| - {c6} |");
            Console.WriteLine($" |  {f7} - |{b7}| - {c7} |");
            Console.WriteLine($" |  {f8} - |{b8}| - {c8} |");
            Console.WriteLine($" |  {f9} - |{b9}| - {c9} |");
            Console.WriteLine($" |  {f10} - |{b10}| - {c10} |");
            Console.WriteLine($" |  {f11} - |{b11}| - {c11} |");
            Console.WriteLine($" |  {f12}  - |{b12}| - {c12} |");
            Console.WriteLine($" |  {f13}  - |{b13}| - {c13} |");
            Console.WriteLine($" |  {f14}  - |{b14}| - {c14} |");
            Console.WriteLine($" |  {f15}  - |{b15}| - {c15} |");
            Console.WriteLine($" |  {f16}  - |{b16}| - {c16} |");
            Console.WriteLine($" |  {f17}  - |{b17}| - {c17} |");
            Console.WriteLine($" |       '***`     |");
            Console.WriteLine($" |      (*****)    |");
            Console.WriteLine($" |       `---'     |");
            Console.WriteLine($" |       '***`     |");
            Console.WriteLine($" |_________________|");




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




            /*
 PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H). 
 VIENA TRANSPORTO PRIEMONĖS PRADEDA VAŽIUOTI IŠ A, KITA IŠ B.STARTUOJA VIENU METU.
  - PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS. 
  - PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS. 
  - PASKAIČIUOTI LAIKĄ, KADA TRASPORTUO PRIEMONĖS PASIEKS GALIUTINIUS TAŠKUS MINUTĖMIS.
  - PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.
  - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
    A) PARODYTI VISO KELIO ILGĮ KM
    B) PARODYTI SEGMENTO ILGĮ KM
    C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
    D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
    REZULTATAS GALI ARTODYTI TAIP:
   viso 100 km
 |--------------------------------------------------------------------------------------------------------------------------------------------|
 0      5     10     15     20      25     30     35     40     45     50     55     60     65     70     75     80     85     90     95    100
 |      |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
_A______|______|______|______|___V___|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______B_
 |-------------------------------|                                                                                                                                                        
   susitikimo vieta 23,1 km
   susitikimo laikas po 0,87 val.
 | >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   200 min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|
 |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   60 min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< |
 */
            /*

            Console.WriteLine("Iveskite atstumą tarp A ir B");
            var atstumas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite A transporto priemonės greitį");
            var atransportoPriemone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite A transporto priemonės greitį");
            var btransportoPriemone = Convert.ToDouble(Console.ReadLine());


            
            var metraiKilometruose = 1000;
            var minutesvalandoje = 60;
            var sekundesValandoje = 3600;
            var laikassusutikimoLaikas = atstumas / (atransportoPriemone + btransportoPriemone);
            var CO2 = 95;

            Console.WriteLine($"Transporto priemonės susitiks nuvažiavus {atransportoPriemone * laikassusutikimoLaikas * metraiKilometruose} metrų(us)");
            Console.WriteLine($"Transporto priemonės susitiks praėjus {atstumas / (atransportoPriemone + btransportoPriemone) * sekundesValandoje} sekundėms(ių)");
            Console.WriteLine($"A transporto priemonė galutinį tašką pasieks praėjus {atstumas / atransportoPriemone * minutesvalandoje} minutėms");
            Console.WriteLine($"B transporto priemonė galutinį tašką pasieks praėjus {atstumas / btransportoPriemone * minutesvalandoje} minutėms");
            Console.WriteLine($"Transporto priemonės kartu išskyrė {atstumas * 2 * CO2 } gramus CO2");


            */




        }
    }
}