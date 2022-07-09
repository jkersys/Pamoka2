using System.Diagnostics;
using System.Globalization;

namespace P_014_Debug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");


            Pinigas();

            DecimalHour(Console.ReadLine());









        }

        /*
        public static void Pinigas()
        {
            Console.WriteLine($"Ivesite pinigu suma");
            var suma = Console.ReadLine();
            var kursas = 5.6;
            //var rezultatas = Convert.ToInt32(suma) * kursas; //reikalinga korekcija del didelio skaiciaus pvz 888888888
            //var rezultatas = Convert.ToInt64(suma) * kursas; //reikalinga korekcija del skaiciau spvz 20.4
            //var rezultatas = Convert.ToDouble(suma) * kursas; //reikalinga korekcija del trupmenino skaiciaus su kableliu pvz 20,4

            var decimalSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var groupSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;

            var sumaPakeista = suma.Replace(decimalSeparator, groupSeparator);

            var rezultatas = Convert.ToDouble(sumaPakeista) * kursas;
            Console.WriteLine($"Jus turite rankoje {rezultatas} pinigus");
            Debug.WriteLine($"Jus turite rankoje {rezultatas} pinigus");
            Console.ReadKey();
        }
        */
        public static string DecimalHour(string input)
        {
            var isInputValid = IsDecimalHourValid(input, out msg);
            var a = input.Split(".");

            var dec = Convert.ToDecimal(a[0]) +  //valandos
                (Convert.ToDecimal(a[1])) / 60 + // pridedam minutes
                (a.Length > 2 ? (Convert.ToDecimal(a[2]) / 3600) : 0);

            Console.WriteLine($"Decimal hour: {dec,4}");
            return $"Decimal hour: {dec:0.0000}";


        }

        private static bool IsDecimalHourValid(string input)
        {
            var msg = null;
            var a = input.Split(".");
            if (a.Length < 2)
            {
                msg = "Invalid time";
                return false;
            }
            if (int.TryParse(a[0], out int hour) || hour < 0)
            {
                Console.WriteLine("Invalid hour");
                return;
            }
            if (!int.TryParse(a[1], out int minute) || hour < 0 || minute > 60)
            {
                Console.WriteLine("Invalide minutes");
                return;
            }
            if (a.Length > 2 && (!int.TryParse(a[2], out int sec) || sec < 0 || sec > 60))
            {
                Console.WriteLine("Invalid seconds");
                return;

            }

            private static bool IsIsDecimalHourInputTimeVlaid(string[] a) => a.Length < 2;
            {

            }





            }
        }

    }