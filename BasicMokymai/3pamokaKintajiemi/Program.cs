namespace _3pamokaKintajiemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //skaičių kintamieji
            //sveikų skaičių kintamieji (kurie negali turėti po kalbelio)
            byte mazasSkaicius = 2; // gali turėti reikmę iki 255
            short trumpasskaicius = 2; // didžiausia reikšmė 32767
            int skaicius = 2; // 2+mlrd
            int maksimalusIntskaitmu = int.MaxValue; //maxreikšmės prisiskyrimas
            int minimalusIntskaitmuo = int.MinValue;    

            //Pavizdys
            Console.WriteLine(" maksimalusIntskaitmuo={0}\n minimalusIntskaitmuo={1}", minimalusIntskaitmuo,minimalusIntskaitmuo);

            long ilgasSkaicius = 2; // didesnio skaičiaus už long nėra.


            int? skaiciusKurisGaliButiNull;
            skaiciusKurisGaliButiNull = null;

            Nullable<int> skaiciusKurisGaliButiNull2 = null;

            uint tikTeigiamasSkaicius = 2; //4.294.967.295
            //tikTeigiamasSkaicius = -5; taip negalima

            Console.WriteLine("Floating point types"); // ne nullable, reikia priet ? ir parasyt nullable, kad pasidaryt null juos
            
            float maziausiasTrupmeninis = 8.5f;
            var trupmeninisVar = 8.5f;
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninis = 8.5m;

            Console.WriteLine("Loginiai Kintamieji"); //negali buti null reismes
            bool teisybe = true; //reprezentuoja teisybę. Gali būti įrašyta truearba false
            bool neteisybe = false;

            bool? nullableLoginis = null; // taip galima pasidaryt nullable

            Console.WriteLine("char kintamieji");

            char raide = 'n'; // naudojam viengubas kabutes. yra sveiko skaitmens tipas, nors atrodo kad talpina raide. char is similar to ant integer or ushort



            /*PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
    • MOKYKLOS PAVADINIMĄ
    • KURSO PAVADINIMĄ
    • STUDENTŲ SKAIČIŲ
    • ŠIANDIENOS DATĄ
    • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
            */

            var pavadinimas = "Codeacademy";
            var kursopavadinimas = "CA.NET";
            var studentuSkaicius = 19;
            var siandienosdata = new DateTime(2022,06,08);

            Console.WriteLine($"\n{pavadinimas}\n{kursopavadinimas}\n{studentuSkaicius}\n{siandienosdata}");

            /*PAPILDYTI PROGRAMĄ IR PRIDĖTI:
• KURSO PRADŽIOS DATĄ
• KURSO PABAIGOS DATĄ
• Sužinoti skirtumą tarp pradžios ir dabartinės datos(dienomis)
• VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
            */

            var pradziosdata = new DateTime(2022, 05, 30);
            var pabaigosdata = new DateTime(2022, 12, 30);
            TimeSpan dienuskirtumas = siandienosdata - pradziosdata;


            Console.WriteLine($"\n{pavadinimas}\n{kursopavadinimas}\n{studentuSkaicius}\n{siandienosdata}\n{pradziosdata}\n{pabaigosdata}\n{dienuskirtumas.Days}");

            /*Sukurkite tris kintamuosius.tekstinio, sveiko skaitmens ir loginio tipo.
Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu
            */

            //galima naudoti var vietoj strink int bool
            string tekstinis = "tekstas";
            int sveikasSkaicius = 2;
            bool loginis = true;

            Console.WriteLine($"{tekstinis} {sveikasSkaicius} {loginis}");



        }
    }
}