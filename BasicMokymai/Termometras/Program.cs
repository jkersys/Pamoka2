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

           


            //Su kelio grafiko braižymu buvo problemų, teko daug naudotis Jūsų rodytu brėžiniu :)

            //Paprašom įvesti atstumą
            Console.WriteLine("Iveskite atstumą tarp A ir B");
            var atstumas = Convert.ToDouble(Console.ReadLine());

            //Paprašom įvesti transporto priemonių greitį ir išvedam į ekraną
            Console.WriteLine("Iveskite A transporto priemonės greitį");
            var atransportoPriemone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite A transporto priemonės greitį");
            var btransportoPriemone = Convert.ToDouble(Console.ReadLine());


            //Pasidarom kintamuosius skaičiavimams.
            var metraiKilometruose = 1000;
            var minutesvalandoje = 60;
            var sekundesValandoje = 3600;            
            var CO2 = 95;
            //Pasiskaičiuojam susitikimo laiką, nes reikalingas skaičiuojant kada transporto priemonės susitiks.
            var susutikimoLaikas = atstumas / (atransportoPriemone + btransportoPriemone);

            var aTrukme = atstumas / atransportoPriemone * minutesvalandoje;
            var bTrukme = atstumas / btransportoPriemone * minutesvalandoje;

            //Skaičiuojam naudodami formules pagal tai ko prašo salygair pasidar om kad rodytų 2 skaičius po kalbelio (:0.00)
            Console.WriteLine($"Transporto priemonės susitiks nuvažiavus {atransportoPriemone * susutikimoLaikas * metraiKilometruose:0.00} metrų(us)");
            Console.WriteLine($"Transporto priemonės susitiks praėjus {atstumas / (atransportoPriemone + btransportoPriemone) * sekundesValandoje:0.00} sekundėms(ių)");
            Console.WriteLine($"A transporto priemonė galutinį tašką pasieks praėjus {atstumas / atransportoPriemone * minutesvalandoje} minutėms");
            Console.WriteLine($"B transporto priemonė galutinį tašką pasieks praėjus {atstumas / btransportoPriemone * minutesvalandoje} minutėms");
            Console.WriteLine($"Transporto priemonės kartu išskyrė {atstumas * 2 * CO2:0.00} gramus CO2");




            //segmento skaičiai
            var segskaic1 = atstumas / 20 * 0;
            var segskaic2 = atstumas / 20 * 1;
            var segskaic3 = atstumas / 20 * 2;
            var segskaic4 = atstumas / 20 * 3;
            var segskaic5 = atstumas / 20 * 4;
            var segskaic6 = atstumas / 20 * 5;
            var segskaic7 = atstumas / 20 * 6;
            var segskaic8 = atstumas / 20 * 7;
            var segskaic9 = atstumas / 20 * 8;
            var segskaic10 = atstumas / 20 * 9;
            var segskaic11 = atstumas / 20 * 10;
            var segskaic12 = atstumas / 20 * 11;
            var segskaic13 = atstumas / 20 * 12;
            var segskaic14 = atstumas / 20 * 13;
            var segskaic15 = atstumas / 20 * 14;
            var segskaic16 = atstumas / 20 * 15;
            var segskaic17 = atstumas / 20 * 16;
            var segskaic18 = atstumas / 20 * 17;
            var segskaic19 = atstumas / 20 * 18;
            var segskaic20 = atstumas / 20 * 19;
            var segskaic21 = atstumas / 20 * 20;

            //Sustikimo vieta
            var susutikimoVieta = atransportoPriemone * susutikimoLaikas;

                   
            //V raidės nustatymas, tikrinam kur susitiks ( 10 daugiau už 5 = 10 mažiau arba lygu 15) True keiciam V False ""  
            var SegV1 = ((susutikimoVieta > segskaic1) && (susutikimoVieta <= segskaic2)).ToString().Replace("True", "V").Replace("False", "");
            var SegV2 = ((susutikimoVieta > segskaic2) && (susutikimoVieta <= segskaic3)).ToString().Replace("True", "V").Replace("False", "");
            var SegV3 = ((susutikimoVieta > segskaic3) && (susutikimoVieta <= segskaic4)).ToString().Replace("True", "V").Replace("False", "");
            var SegV4 = ((susutikimoVieta > segskaic4) && (susutikimoVieta <= segskaic5)).ToString().Replace("True", "V").Replace("False", "");
            var SegV5 = ((susutikimoVieta > segskaic5) && (susutikimoVieta <= segskaic6)).ToString().Replace("True", "V").Replace("False", "");
            var SegV6 = ((susutikimoVieta > segskaic6) && (susutikimoVieta <= segskaic7)).ToString().Replace("True", "V").Replace("False", "");
            var SegV7 = ((susutikimoVieta > segskaic7) && (susutikimoVieta <= segskaic8)).ToString().Replace("True", "V").Replace("False", "");
            var SegV8 = ((susutikimoVieta > segskaic8) && (susutikimoVieta <= segskaic9)).ToString().Replace("True", "V").Replace("False", "");
            var SegV9 = ((susutikimoVieta > segskaic9) && (susutikimoVieta <= segskaic10)).ToString().Replace("True", "V").Replace("False", "");
            var SegV10 = ((susutikimoVieta > segskaic10) && (susutikimoVieta <= segskaic11)).ToString().Replace("True", "V").Replace("False", "");
            var SegV11 = ((susutikimoVieta > segskaic11) && (susutikimoVieta <= segskaic12)).ToString().Replace("True", "V").Replace("False", "");
            var SegV12 = ((susutikimoVieta > segskaic12) && (susutikimoVieta <= segskaic13)).ToString().Replace("True", "V").Replace("False", "");
            var SegV13 = ((susutikimoVieta > segskaic13) && (susutikimoVieta <= segskaic14)).ToString().Replace("True", "V").Replace("False", "");
            var SegV14 = ((susutikimoVieta > segskaic14) && (susutikimoVieta <= segskaic15)).ToString().Replace("True", "V").Replace("False", "");
            var SegV15 = ((susutikimoVieta > segskaic15) && (susutikimoVieta <= segskaic16)).ToString().Replace("True", "V").Replace("False", "");
            var SegV16 = ((susutikimoVieta > segskaic16) && (susutikimoVieta <= segskaic17)).ToString().Replace("True", "V").Replace("False", "");
            var SegV17 = ((susutikimoVieta > segskaic17) && (susutikimoVieta <= segskaic18)).ToString().Replace("True", "V").Replace("False", "");
            var SegV18 = ((susutikimoVieta > segskaic18) && (susutikimoVieta <= segskaic19)).ToString().Replace("True", "V").Replace("False", "");
            var SegV19 = ((susutikimoVieta > segskaic19) && (susutikimoVieta <= segskaic20)).ToString().Replace("True", "V").Replace("False", "");
            var SegV20 = ((susutikimoVieta > segskaic20) && (susutikimoVieta <= segskaic21)).ToString().Replace("True", "V").Replace("False", "");

            
            //Tikrinam kur reikia piesti kelia (---) pvz 10 > 5 (----) 10 > 15 ("    ") 
            var segB1 = (susutikimoVieta > segskaic1).ToString().Replace("True", "---").Replace("False", "   ");
            var segA1 = (susutikimoVieta > segskaic2).ToString().Replace("True", "----").Replace("False", "   ");
            var segB2 = (susutikimoVieta > segskaic2).ToString().Replace("True", "---").Replace("False", "   ");
            var segA2 = (susutikimoVieta > segskaic3).ToString().Replace("True", "----").Replace("False", "   ");
            var segB3 = (susutikimoVieta > segskaic3).ToString().Replace("True", "---").Replace("False", "   ");
            var segA3 = (susutikimoVieta > segskaic4).ToString().Replace("True", "----").Replace("False", "   ");
            var segB4 = (susutikimoVieta > segskaic4).ToString().Replace("True", "---").Replace("False", "   ");
            var segA4 = (susutikimoVieta > segskaic5).ToString().Replace("True", "----").Replace("False", "   ");
            var segB5 = (susutikimoVieta > segskaic5).ToString().Replace("True", "---").Replace("False", "   ");
            var segA5 = (susutikimoVieta > segskaic6).ToString().Replace("True", "----").Replace("False", "   ");
            var segB6 = (susutikimoVieta > segskaic6).ToString().Replace("True", "---").Replace("False", "   ");
            var segA6 = (susutikimoVieta > segskaic7).ToString().Replace("True", "----").Replace("False", "   ");
            var segB7 = (susutikimoVieta > segskaic7).ToString().Replace("True", "---").Replace("False", "   ");
            var segA7 = (susutikimoVieta > segskaic8).ToString().Replace("True", "----").Replace("False", "   ");
            var segB8 = (susutikimoVieta > segskaic8).ToString().Replace("True", "---").Replace("False", "   ");
            var segA8 = (susutikimoVieta > segskaic9).ToString().Replace("True", "----").Replace("False", "   ");
            var segB9 = (susutikimoVieta > segskaic9).ToString().Replace("True", "---").Replace("False", "   ");
            var segA9 = (susutikimoVieta > segskaic10).ToString().Replace("True", "----").Replace("False", "   ");
            var segB10 = (susutikimoVieta > segskaic10).ToString().Replace("True", "---").Replace("False", "   ");
            var segA10 = (susutikimoVieta > segskaic11).ToString().Replace("True", "----").Replace("False", "   ");
            var segB11 = (susutikimoVieta > segskaic11).ToString().Replace("True", "---").Replace("False", "   ");
            var segA11 = (susutikimoVieta > segskaic12).ToString().Replace("True", "----").Replace("False", "   ");
            var segB12 = (susutikimoVieta > segskaic12).ToString().Replace("True", "---").Replace("False", "    ");
            var segA12 = (susutikimoVieta > segskaic13).ToString().Replace("True", "----").Replace("False", "   ");
            var segB13 = (susutikimoVieta > segskaic13).ToString().Replace("True", "---").Replace("False", "    ");
            var segA13 = (susutikimoVieta > segskaic14).ToString().Replace("True", "----").Replace("False", "   ");
            var segB14 = (susutikimoVieta > segskaic14).ToString().Replace("True", "---").Replace("False", "    ");
            var segA14 = (susutikimoVieta > segskaic15).ToString().Replace("True", "----").Replace("False", "   ");
            var segB15 = (susutikimoVieta > segskaic15).ToString().Replace("True", "---").Replace("False", "    ");
            var segA15 = (susutikimoVieta > segskaic16).ToString().Replace("True", "----").Replace("False", "   ");
            var segB16 = (susutikimoVieta > segskaic16).ToString().Replace("True", "---").Replace("False", "    ");
            var segA16 = (susutikimoVieta > segskaic17).ToString().Replace("True", "----").Replace("False", "   ");
            var segB17 = (susutikimoVieta > segskaic17).ToString().Replace("True", "---").Replace("False", "    ");
            var segA17 = (susutikimoVieta > segskaic18).ToString().Replace("True", "----").Replace("False", "   ");
            var segB18 = (susutikimoVieta > segskaic18).ToString().Replace("True", "---").Replace("False", "    ");
            var segA18 = (susutikimoVieta > segskaic19).ToString().Replace("True", "----").Replace("False", "   ");
            var segB19 = (susutikimoVieta > segskaic19).ToString().Replace("True", "---").Replace("False", "    ");
            var segA19 = (susutikimoVieta > segskaic20).ToString().Replace("True", "----").Replace("False", "   ");
            var segB20 = (susutikimoVieta > segskaic20).ToString().Replace("True", "---").Replace("False", "    ");
            var segA20 = (susutikimoVieta > segskaic21).ToString().Replace("True", "----").Replace("False", "   ");
            




         
            //Piešiam grafiką pagal destytojo sabloną
            var keliopiesinys =
                $"   viso {atstumas} km \n" +
                $" |--------------------------------------------------------------------------------------------------------------------------------------------|\n\n" +
             //skaičiai padariau pagal destytoją su {SegV1.Replace("V", " ")} nes be sito išsikraipo grafikas ir nesulygiuoja gražiai skaičių viršui.
             $" {SegV1.Replace("V", " ")}{segskaic1}" +
              $" {SegV2.Replace("V", " ")}     {segskaic2}" +
              $"{SegV3.Replace("V", " ")}     {segskaic3}" +
              $"{SegV4.Replace("V", " ")}     {segskaic4}" +
              $"{SegV5.Replace("V", " ")}     {segskaic5}" +
              $"{SegV6.Replace("V", " ")}     {segskaic6}" +
              $"{SegV7.Replace("V", " ")}     {segskaic7}" +
              $"{SegV8.Replace("V", " ")}     {segskaic8}" +
              $"{SegV9.Replace("V", " ")}     {segskaic9}" +
              $"{SegV10.Replace("V", " ")}     {segskaic10}" +
              $"{SegV11.Replace("V", " ")}     {segskaic11}" +
              $"{SegV12.Replace("V", " ")}     {segskaic12}" +
              $"{SegV13.Replace("V", " ")}     {segskaic13}" +
              $"{SegV14.Replace("V", " ")}     {segskaic14}" +
              $"{SegV15.Replace("V", " ")}     {segskaic15}" +
              $"{SegV16.Replace("V", " ")}     {segskaic16}" +
              $"{SegV17.Replace("V", " ")}     {segskaic17}" +
              $"{SegV18.Replace("V", " ")}     {segskaic18}" +
              $"{SegV19.Replace("V", " ")}     {segskaic19}" +
              $"{SegV20.Replace("V", " ")}     {segskaic20}" +
              $"{SegV20.Replace("V", " ")}     {segskaic21}" +

                $"\n" +
               //Tarpeliai |  | padariau pagal destytoją su {SegV1.Replace("V", " ")} nes be sito išsikraipo grafikas
               $" |   {SegV1.Replace("V", " ")}  " +
                $" |   {SegV2.Replace("V", " ")}  " +
                $" |   {SegV3.Replace("V", " ")}  " +
                $" |   {SegV4.Replace("V", " ")}  " +
                $" |   {SegV5.Replace("V", " ")}  " +
                $" |   {SegV6.Replace("V", " ")}  " +
                $" |   {SegV7.Replace("V", " ")}  " +
                $" |   {SegV8.Replace("V", " ")}  " +
                $" |   {SegV9.Replace("V", " ")}  " +
                $" |   {SegV10.Replace("V", " ")}  " +
                $" |   {SegV11.Replace("V", " ")}  " +
                $" |   {SegV12.Replace("V", " ")}  " +
                $" |   {SegV13.Replace("V", " ")}  " +
                $" |   {SegV14.Replace("V", " ")}  " +
                $" |   {SegV15.Replace("V", " ")}  " +
                $" |   {SegV16.Replace("V", " ")}  " +
                $" |   {SegV17.Replace("V", " ")}  " +
                $" |   {SegV18.Replace("V", " ")}  " +
                $" |   {SegV19.Replace("V", " ")}  " +
                $" |   {SegV20.Replace("V", " ")}  " +
                $" |   {SegV20.Replace("V", " ")}  " +

                $"\n" +
                //Eilutė kur su V raide, randa kur padėt V
                $"_A___{SegV1}___" +
                $"|___{SegV2}___" +
                $"|___{SegV3}___" +
                $"|___{SegV4}___" +
                $"|___{SegV5}___" +
                $"|___{SegV6}___" +
                $"|___{SegV7}___" +
                $"|___{SegV8}___" +
                $"|___{SegV9}___" +
                $"|___{SegV10}___" +
                $"|___{SegV11}___" +
                $"|___{SegV12}___" +
                $"|___{SegV13}___" +
                $"|___{SegV14}___" +
                $"|___{SegV15}___" +
                $"|___{SegV16}___" +
                $"|___{SegV17}___" +
                $"|___{SegV18}___" +
                $"|___{SegV19}___" +
                $"|___{SegV20}___B\n" +

                //kelio piešimas randa nupiešia kelia ----- ir randa kur padėt |
                $" |" +
                $"{segB1}{SegV1.Replace("V", "|")}{segA1}" +
                $"{segB2}{SegV2.Replace("V", "|")}{segA2}" +
                $"{segB3}{SegV3.Replace("V", "|")}{segA3}" +
                $"{segB4}{SegV4.Replace("V", "|")}{segA4}" +
                $"{segB5}{SegV5.Replace("V", "|")}{segA5}" +
                $"{segB6}{SegV6.Replace("V", "|")}{segA6}" +
                $"{segB7}{SegV7.Replace("V", "|")}{segA7}" +
                $"{segB8}{SegV8.Replace("V", "|")}{segA8}" +
                $"{segB9}{SegV9.Replace("V", "|")}{segA9}" +
                $"{segB10}{SegV10.Replace("V", "|")}{segA10}" +
                $"{segB11}{SegV11.Replace("V", "|")}{segA11}" +
                $"{segB12}{SegV12.Replace("V", "|")}{segA12}" +
                $"{segB13}{SegV13.Replace("V", "|")}{segA13}" +
                $"{segB14}{SegV14.Replace("V", "|")}{segA14}" +
                $"{segB15}{SegV15.Replace("V", "|")}{segA15}" +
                $"{segB16}{SegV16.Replace("V", "|")}{segA16}" +
                $"{segB17}{SegV17.Replace("V", "|")}{segA17}" +
                $"{segB18}{SegV18.Replace("V", "|")}{segA18}" +
                $"{segB19}{SegV19.Replace("V", "|")}{segA19}" +
                $"{segB20}{SegV20.Replace("V", "|")}{segA20}" +
                $"\n" +

                $"Susitikimo vieta {susutikimoVieta:0.0} km\n" +
                $"Susitikimo laikas po {susutikimoLaikas:0.00} val. \n" +
                $"\n" +


                $">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>{aTrukme:0.00} min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n" +
                $">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>{bTrukme:0.00} min<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n";


            Console.WriteLine(keliopiesinys);



        }
    }
}