namespace P004_TipuKonversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tipų Konversijos!");

            // implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintaslong = (long)skaiciusInt;
            long castintaslong1 = skaiciusInt; // tipo konversija daroma automatiškai

            var castintasLong2 = (long)skaiciusInt;

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat1 = skaiciusInt2;
            float skaiciusFloat2 = skaiciusLong2;
            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble1 = skaiciusInt2;
            double skaiciusDouble2 = skaiciusLong2;
            double skaiciusDouble3 = skaiciusFloat2;
            decimal skaiciusDecimal = skaiciusByte;

            //byte->short->int->float->double->decimal

            //eplict casting

            int castintasInt = (int)skaiciusLong;

            //decimal->double->float->long->int->chat

            float fl = 5.9f;
            int castintasint1 = (int)fl;
            Console.WriteLine("  i={0}", castintasint1);

            char skaiciusRaide = 'a';
            int castintasInt2 = (int)skaiciusRaide;
            Console.WriteLine($" castintasInt2 ={castintasInt2}");
            long castintasLong3 = skaiciusRaide;
            //char->ushort->int->long->ulong->float->doube->decimal

            //castintas didesnis į mažesnį skaičius pats baisiausias dalykas, kad aplikacija nelūžta, bet veikia, bet veikia nekorektiškai.
            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongDidesnis;
            Console.WriteLine($" castintasInt4={castintasInt4}");


            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($" castintasInt5= {skaiciusLongDarDidesnis}");

            //*** Type conversion Method
            string konvertuotasString = Convert.ToString(skaiciusInt);
            string convertuotasString = skaiciusInt.ToString();
            long konvertuotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);

            //is didesnio i mazesni
            //int konvertuotasInt = Convert.ToInt32(skaiciusLongDidesnis); //luzta nes netelpa

            //darbas su nullable tipais
            int? skaiciusIntNull = null; //klaustukas rasomas, kad i skaitmenini tipa gali buti irasytas nullas (nieko nera)
            //long castintasLong5 = (long)skaiciusIntNull; // luzta
            long convertuoasLong1 = Convert.ToInt64(skaiciusIntNull); // programa neluzta, o grąžinama long tipo default reikšmė t.y. 0
            Console.WriteLine($" convertuotasLong1 = {convertuoasLong1}");

            //parsinimas
            string skaiciusString = "100";
            string skaiciusDidelisString = "9999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);
            Console.WriteLine($" skaiciusString + 1 = {skaiciusString + 1}");
            Console.WriteLine($" skaiciusIntParsintas + 1 = {skaiciusIntParsintas + 1}");

            //int skaiciusIntParsintas1 = int.Parse(skaiciusDidelisString); //lužta
            //int tekstasIntParsintas = int.Parse(tekstas); //klaida


        }
    }
}