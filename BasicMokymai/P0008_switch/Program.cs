namespace P0008_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Switch!");

            /*
            Console.WriteLine("Iveskite meniu punkta");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {

                case 1:
                    Console.WriteLine("vartotojas pasirinko 1");
                        Console.WriteLine("Dar kazkokia info");
                    break; // iki break vykdomas kodas
                        case 2:
                    Console.WriteLine("vartotojas pasirinko 2");
                        break;
                case 3:
                    Console.WriteLine("vartotojas pasirinko 3");
                    break;
                case 4:
                    Console.WriteLine("vartotojas pasirinko 4");
                    break;
                default: // galima isivesti default, kuri vykdoma jeigu nei vienas case neatitiko salygos
                    Console.WriteLine("Klaida");
                    break;

                    //------------swtich expresion--------------
                    var isvedamasRezultatas = menuChoice switch
                    {
                        1 => "vartotojas pasirinko 1",
                        2 => "vartotojas pasirinko 2",
                        3 => "vartotojas pasirinko 3",
                        _ => "vartotojas nieko nepasirinko"
                    };
                    Console.WriteLine(isvedamasRezultatas);

                    //-----------------
                    Console.WriteLine("---------------------------");
                    switch (menuChoice)
                    {
                        case 1:
                        case 2:
                            Console.WriteLine("vartotojas pasirinko 1 arba 2");
            */

            /*PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
            EGZAMINO PAŽYMĮ. IŠVESTI:
            0 - 4: NEPATEKINAMAI
            5: SILPNAI
            6: PATENKINAMAI
            7: VIDUTINIŠKAI
            8: GERAI
            9: LABAI GERAI
            10: PUIKIAI
            */

            /*

            Console.WriteLine("iveskite pazimi");
            int pazimys = Convert.ToInt32(Console.ReadLine());

            if (pazimys <= 4)
            {
                Console.WriteLine("Nepatenkinamai");
            }
            else if (pazimys == 5)
            {
                Console.WriteLine("patenkinamai");
            }
            else if (pazimys == 7)
            {
                Console.WriteLine("vidutiniskai");
            }
            else if (pazimys == 8)
            {
                Console.WriteLine("gerai");
            }
            else if (pazimys == 9)
            {
                Console.WriteLine("labai gerai");
            }
            else if (pazimys == 10)
            {
                Console.WriteLine("puikiai");
            }


            Console.WriteLine("iveskite pazimi");
            int pazimys1 = Convert.ToInt32(Console.ReadLine());

            switch (pazimys1)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("nepatenkinamai");

                    break;
                case 5:
                    Console.WriteLine("silpnai");
                    break;
                case 6:
                    Console.WriteLine("patenkinamai");
                    break;
                case 7:
                    Console.WriteLine("vidutiniskai");
                    break;
                case 8:
                    Console.WriteLine("gerai");
                    break;
                case 9:
                    Console.WriteLine("labai gerai");
                    break;
                case 10:
                    Console.WriteLine("puikiai");
                    break;
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }

            //------------swtich expresion--------------
            Console.WriteLine("-------------------");
            Console.WriteLine(pazimys switch

            {
                1 => "nepatenkinamai", // galima naudot 0 or 1 or 2 or 3 or 4 => nepatenkinamai vietoj 1 => 2 => 3 => 4 =>
                2 => "nepatenkinamai",
                3 => "nepatenkinamai",
                4 => "nepatenkinamai",
                5 => "silpnai",
                6 => "patenkinamai",
                7 => "vidutiniskai",
                8 => "gerai",
                9 => "labai gerai",
                10 => "puikiai",
                _ => "vartotojas nieko nepasirinko"
            });

            /*** Nemokama kava **
            Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
            Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
            - Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
            - Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"
            */
            /*
            //nesigavo jeigu perka tarkim 7 puodelius, kad priklauso 2 nemokami
            int kavosPuodeliai = Convert.ToInt32(Console.ReadLine());
            var kavosPuodeliai2 = kavosPuodeliai / 3;
            if (kavosPuodeliai / 3 == 0)
            {
                Console.WriteLine($"Jums priklauso {kavosPuodeliai2} nemokami kavos puodeliai");
            }
            else
            {
                Console.WriteLine("pirkejui nepriklauso nemokama kava");
            }


            //-----------------------
            Console.WriteLine("Iveskite kiek perkate puodeliu kavos");
            var kava = Convert.ToInt32(Console.ReadLine()) / 3;

            Console.WriteLine(kava == 0 ?
                "pirkejui nepriklauso nemokama kava" :
                $"pirkejui priklauso {kava} nemokami puoeliai");
            */
            /*
             Piešingi skaičiai **
            Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
            - Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
            - Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A; */

            /*
            //Pasiziuret kaip kiti dare, reikejo darytis 4 var'us
            Console.WriteLine("Iveskite 4 skaicius");
            var ivestasSkaicius = Convert.ToInt32(Console.ReadLine()) * -1;

            if (ivestasSkaicius >= 1)
            {
                Console.WriteLine($"{ivestasSkaicius}");
            }
            */

            /*
            Console.WriteLine("Iveskite pirma skaiciu");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            var sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ketvirta skaiciu");
            var sk4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(sk1 != 0 ? $"{sk1} -> {sk1*-1}": $"0 => N/A");
            Console.WriteLine(sk2 != 0 ? $"{sk1} -> {sk1*-1}" : $"0 => N/A");
            Console.WriteLine(sk3 != 0 ? $"{sk1} -> {sk1*-1}" : $"0 => N/A");
            Console.WriteLine(sk4 != 0 ? $"{sk1} -> {sk1*-1}" : $"0 => N/A");
            */

            /*ŽAIDIMAS ATSPĖK SKAIČIŲ
            - ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
            - NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
            - JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
            - JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
            - JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
            nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.
            */

            /*
            Random rnd = new Random();
            int number = rnd.Next(0, 20); //returns random number between 0-99
            Console.WriteLine($"{number}");
            var skaic1 = Convert.ToInt32(Console.ReadLine());
            // var skaic3 = Convert.ToInt32(Console.ReadLine());
            // var skaic4 = Convert.ToInt32(Console.ReadLine());
            // var skaic5 = Convert.ToInt32(Console.ReadLine());
            //  var skaic6 = Convert.ToInt32(Console.ReadLine());

            if (number == skaic1)
            {
                Console.WriteLine("Teisingai");
            }
                else if (number > skaic1)
            {
                Console.WriteLine("Skaicius yra didesnis");
            }
                else if (number < skaic1)
            {
                Console.WriteLine("Skaicius yra mazesnis");
            }
            var skaic2 = Convert.ToInt32(Console.ReadLine());
            if (number == skaic2)
            {
                Console.WriteLine("Teisingai");
            }
            else if (number > skaic2)
            {
                Console.WriteLine("Skaicius yra didesnis");
            }
            else if (number < skaic2)
            {
                Console.WriteLine("Skaicius yra mazesnis");

                var skaic3 = Convert.ToInt32(Console.ReadLine());
                if (number == skaic3)
                {
                    Console.WriteLine("Teisingai");
                }
                else if (number > skaic3)
                {
                    Console.WriteLine("Skaicius yra didesnis");
                }
                else if (number < skaic3)
                {
                    Console.WriteLine("Skaicius yra mazesnis");

                }
                var skaic4 = Convert.ToInt32(Console.ReadLine());
                if (number == skaic4)
                {
                    Console.WriteLine("Teisingai");
                }
                else if (number > skaic4)
                {
                    Console.WriteLine("Skaicius yra didesnis");
                }
                else if (number < skaic4)
                {
                    Console.WriteLine("Skaicius yra mazesnis");

                    var skaic5 = Convert.ToInt32(Console.ReadLine());
                    if (number == skaic5)
                    {
                        Console.WriteLine("Teisingai");
                    }
                    else if (number > skaic5)
                    {
                        Console.WriteLine("Skaicius yra didesnis");
                    }
                    else if (number < skaic5)
                    {
                        Console.WriteLine("Skaicius yra mazesnis");

                        var skaic6 = Convert.ToInt32(Console.ReadLine());
                        if (number == skaic4)
                        {
                            Console.WriteLine("Teisingai");
                        }
                        else if (number > skaic6)
                        {
                            Console.WriteLine("Skaicius yra didesnis");
                        }
                        else if (number < skaic6)
                        {
                            Console.WriteLine("Skaicius yra mazesnis");

                        }


                        */

            /** SKAIČIUOTUVAS *
Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
- Parašykite programą kuri į ekraną išves skaičių rezultatą
- naudokite if
- naudokite switch*/
            /*
            Console.WriteLine("Įveskite pirmą skaičiu");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antra skaičiu");
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite +, -, *, /");
            String MatematineOperacija = Console.ReadLine();

            if (MatematineOperacija == "+")
            {
                Console.WriteLine($"{skaicius1 + skaicius2}");
            }
            */

            /*Trys draugai *
            - Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
            - Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
            - Atspausdinti draugų amžiaus vidurkį
            - Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
            - Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
            <Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
            konstrukcijas kurias iki šiol išėjome.
            */


            Console.WriteLine("Iveskite pirmojo draugo Varda");
            string PirmoV = Console.ReadLine();
            Console.WriteLine("Iveskite pirmojo draugo amziu");
            var PirmoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pirmojo draugo Varda");
            string anttoV = Console.ReadLine();
            Console.WriteLine("Iveskite pirmojo draugo amziu");
            var antroA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pirmojo draugo Varda");
            string trecioV = Console.ReadLine();
            Console.WriteLine("Iveskite pirmojo draugo amziu");
            var trecioA = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Vidurkis = {PirmoA + antroA + trecioA / 3}");

            //jaunausias amzius
            if (PirmoA < antroA && PirmoA < trecioA)
            {
                Console.WriteLine($"{PirmoV} {PirmoA}");
            }
            else if (antroA < PirmoA && antroA < trecioA)
            {
                Console.WriteLine($"{anttoV} {antroA}");
            }

            else if (trecioA < PirmoA && trecioA < antroA)
            {
                Console.WriteLine($"{trecioV} {trecioA}");
            }
            //vyriausias amzius
            if (PirmoA > antroA && PirmoA > trecioA)
            {
                Console.WriteLine($"{PirmoV} {PirmoA}");
            }
            else if (antroA > PirmoA && antroA > trecioA)
            {
                Console.WriteLine($"{anttoV} {antroA}");
            }

            else if (trecioA > PirmoA && trecioA > antroA)
            {
                Console.WriteLine($"{trecioV} {trecioA}");
            }


            /* Kalėdų sausainiai **
- Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
- Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
- Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
- Jei nėra išveda - "Palaukite kalėdų"
Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
<Hint> metodai data.Month ir data.Day
            */




        }
    }
}