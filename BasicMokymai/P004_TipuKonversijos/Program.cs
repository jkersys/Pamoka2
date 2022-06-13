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

            //convert metodas
        }
    }
}