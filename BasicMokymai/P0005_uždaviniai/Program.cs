namespace P0005_uždaviniai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
- padalinkite didesnį skaičių iš mažesnio
- iš rezultato atimkite maksimalų long skaičių
- ir pridėkite maksimalų int skaičių
            */
            /*
            long longSkaicius = long.MaxValue;
            short shortSkaicius = short.MaxValue;
            var rezultatas = (double)longSkaicius / shortSkaicius;
            Console.WriteLine($"padalinkite didesnį skaičių iš mažesnio {(double)longSkaicius / shortSkaicius}");
            double rezultatas1 = rezultatas - longSkaicius;
            Console.WriteLine($" iš rezultato atimkite maksimalų long skaičių {rezultatas1}");
            Console.WriteLine($" pridėkite maksimalų int skaičių {rezultatas1 + int.MaxValue} ");
            */
            /*PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
            INT , SHORT , BYTE
            STEBĖTI REZULTATĄ.
            */
            /*
            double doubleDidelisSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($" Int = {(int)doubleDidelisSkaicius}");
            Console.WriteLine($" Short = {(short)doubleDidelisSkaicius}");
            Console.WriteLine($" byte = {(byte)doubleDidelisSkaicius}");

            Console.WriteLine(Convert.ToInt32(doubleDidelisSkaicius));
            */
            /* parasyti programa kuri
            praso ivesti rutulio diametra
                o isveda plota ir turi
            plotas 4pr(kvadratu)
            turis 4/3 pr(kvadratu)

            */
            /*
            var sphereDiametre = double.Parse(Console.ReadLine());
             var sphereDiametre = double.Parse(Console.ReadLine());
            var sphereRadius = sphereDiametre / 2;
            var sphereArea = 4 * 3.14 * sphereRadius * sphereDiametre;
            var sphereVolume = (4 / 3) * 3.14 (sphereRadius * sphereRadius * sphereRadius);
            */
            /* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ(METRAIS) IR LAIKĄ(SEKUNDĖMIS),
            -IŠVEDA GREITĮ km/ h.
            - IŠVEDA GREITĮ km/ s.
            */

            /*
             * 
             * PASIBAIGT PAGAL SEMINARO VIDEO
            Console.WriteLine(" Iveskite atstuma metrais");
            var atstumas = double.Parse(Console.ReadLine());

            Console.WriteLine(" Iveskite laika sekundemis");
            var laikas = double.Parse(Console.ReadLine());

            Console.WriteLine($"Greitis km/h" );
            */

            /*Nuskaitykite iš klaviatūros 2 skaičius(x ir y).
            Išveskite į ekraną funkciją y + 2y + x + 1 ir apskaičiuokite šios funkcijos rezultatą.
            Išveskite į ekraną funkciją y²+x / 2 apskaičiuokite šios funkcijos rezultatą.
            */

            /*
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            Console.WriteLine($"y+2y+x+1 = {y + 2 * y + x +1}");
            Console.WriteLine($"y²+x / 2 = {y * y + x / 2}");
            */

            /*PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
            VISUS ĮVESTUS 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            PVZ BUVO ĮVESTA 12345
            REZULTATAS 2345/2=1172,5
            <HINT> naudokite replace
            */

            /*
            Console.WriteLine("Įveskite penkiaženklį sveiką skaičių");
            var penkiazenklisSkaicius = Convert.ToDouble(Console.ReadLine().Replace("1", "0"));
            Console.WriteLine($"{penkiazenklisSkaicius} /2 = {penkiazenklisSkaicius / 2}");
             */

            /*
             PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
            VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            PVZ BUVO ĮVESTA 12345
            REZULTATAS 10000/2=5000
            <HINT> naudokite replace
            */
            /*
            Console.WriteLine("Iveskite penkiazenkli sveika skaiciu");
            var skaicius1 = Convert.ToDouble(Console.ReadLine()
                .Replace("2", "0")
                .Replace("3", "0")
                .Replace("4", "0")
                .Replace("5", "0")
                .Replace("6", "0")
                .Replace("7", "0")
                .Replace("8", "0")
                .Replace("9", "0"));

            Console.WriteLine($"{skaicius1} /2= {skaicius1 / 2}");

            */
            /*
            PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI SVEIKĄ SKAIČIŲ
VIENOJE EILUTĖJE IŠVESKITE ŠĮ SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU.
PVZ BUVO ĮVESTA 5
REZULTATAS 6 7 8 9 10
            */

            /*
            Console.WriteLine("Iveskite sveiką skaičių");
            var s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU {++s} {++s} {++s} {++s} {++s} ");
            */





}
}
}