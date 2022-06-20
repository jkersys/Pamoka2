namespace p007_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, If!");

            /*
            int nelyginisSkaicius = 5;
            int lyginisSkaicius = 2;
            bool tiesa = true;


            if (nelyginisSkaicius > lyginisSkaicius)

            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis už {lyginisSkaicius}");
            }


            if (nelyginisSkaicius < lyginisSkaicius)

            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis už {lyginisSkaicius}");

            }

            else
            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis už {lyginisSkaicius}");
            }
                Console.WriteLine($"Press any key to continue");

            Console.WriteLine($"If - else if - else");

            if (nelyginisSkaicius < lyginisSkaicius && tiesa)
            {
                Console.WriteLine($" {nelyginisSkaicius} yra mazesnis už {lyginisSkaicius} ir tiesa yra true");
            }

            else if (nelyginisSkaicius < lyginisSkaicius && !tiesa)
            {
                Console.WriteLine($" {nelyginisSkaicius} yra mazesnis už {lyginisSkaicius} ir tiesa yra true");
            }
            else if (nelyginisSkaicius > lyginisSkaicius && tiesa)
            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis už {lyginisSkaicius} ir tiesa yra true");
            }

            else
            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis už {lyginisSkaicius} ir tiesa yra true");
            }


            Console.WriteLine("------------------------");

            var score = 100;
            int pointNeedtoPass = 100;
            bool levelComplete = false; ;

            if (score >= pointNeedtoPass)

            {
               // bool kazkodel braukia nros neturetu levelComplete = true;
            }
            else
            {
               //kazkodel braukia bool levelComplete = true;
            }

            if (levelComplete)
            {
                Console.WriteLine("Valio baigete lygi");
            }

            Console.WriteLine((score >= pointNeedtoPass) ? "valio baigete lygi" : "nevalio turi dar kart");


            Console.WriteLine("-------------------");
            Console.WriteLine("if kompozicija, nesting");
            int shields = 1, armor = 2;
            if (shields <= 0)
            {
                if (armor <= 0)
                {
                    Console.WriteLine("jus mires");
                }
                else
                {
                    Console.WriteLine("jus dar turite armor");
                }

                Console.WriteLine();
            }

            Console.WriteLine("---------------");
            Console.WriteLine("null-coalesting operator (??)");

            bool? nullablebool = true;
            bool normalbool;
            //normalbool = nullableBool; // taip negalima

            normalbool = nullablebool ?? false;
            //----------------
            nullablebool ??= false;
           */

/* PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
-JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
- JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
- KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ
*/

/*
Console.WriteLine("Iveskite skaiciu");
var skaicius = Convert.ToInt32(Console.ReadLine());


if (skaicius % 2 == 0)

{
    Console.WriteLine("Skaicius yra lyginis");
}
if (skaicius < 0)
{
    Console.WriteLine("Skaicius yra neigiamas");
}
 if (skaicius % 2 != 0 && skaicius > 0)
{
    Console.WriteLine(" Skaicius " + skaicius);
}

*/
/*
PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA
„TAI SOLO ATLIKĖJAS“, JEI NARIŲ KIEKIS 2--„TAI
DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET
MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, JEI
DAUGIAU NEI 10 ––„TAI KAMERINIS
ANSAMBLIS“.
*/
/*

Console.WriteLine("Grupes nariu skaiciu");
var grupesSkaicius = Convert.ToInt32(Console.ReadLine());
if (grupesSkaicius == 1)
{
    Console.WriteLine("Tai solo atlikejas");
}
else if (grupesSkaicius == 2)
        {
    Console.WriteLine("Tai duetas");
}
else if (grupesSkaicius > 2 && grupesSkaicius < 10)
        {
    Console.WriteLine("Tai antsamblis");
}


else if (grupesSkaicius > 10)
{
    Console.WriteLine("Tai kamerinis antsamblis");
}
*/

/*PARAŠYTI PROGRAMĄ, KURI
PAPRAŠO VARTOTOJO ĮVESTI
IŠDIRBTAS VALANDAS.
JEI VALANDŲ YRA MAŽIAU NEI 160,
PROGRAMA TURI PARODYTI, KIEK
DAR REIKIA IŠDIRBTI, JEI LYGIAI 160,
PARODO, KAD IŠDIRBTAS PILNAS
ETATAS, JEI DAUGIAU PARODO
KIEK YRA VIRŠVALANDŽIŲ.
JEI VARTOTOJAS PADARO ĮVEDIMO
KLAIDĄ PRANEŠTI IR UŽBAIGTI
DARBĄ
*/


Console.WriteLine("Iveskite isdirbtas valandas");
var isdirbtosValandos = Convert.ToInt32(Console.ReadLine());
            var likoIsdirbti = 160 - isdirbtosValandos;


            if (isdirbtosValandos < 160)
            {
                Console.WriteLine($"Liko isdirbt {likoIsdirbti}");
            }




}
}
}