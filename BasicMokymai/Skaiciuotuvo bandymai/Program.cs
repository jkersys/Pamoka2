using System.Text;

namespace Skaiciuotuvo_bandymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine($"{Skaiciuotuvas(1);}");


            Skaiciuotuvas();

        }


        public static void Skaiciuotuvas()
        {
            double sk1 = 0;
            double sk2 = 0;
            PirmasMainMeniu(sk1, sk2);
        }


        public static void PirmasMainMeniu(double sk1, double sk2)
        {
            Console.WriteLine(" 1. Nauja operacija \n 2. Testi su rezultatu \n 3. Iseiti. ");
            string mainMeniu = Convert.ToString(Console.ReadLine());
            switch (mainMeniu)
            {
                case "1":
                    // 1. Nauja operacija
                    AntrasSubMeniu(sk1, sk2);
                    break;

                case "2":
                    //  2. Testi su rezultatu
                    Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
                    string antrasSubmeniu = Convert.ToString(Console.ReadLine());
                    switch (antrasSubmeniu)
                    {
                        case "1":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = SudetiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(SudetiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "2":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = AtimtiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(AtimtiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "3":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = DaugintiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DaugintiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "4":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = DalintiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DalintiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "5":

                            sk1 = LaipsniuKelimoSkaicius(sk1);

                            Console.WriteLine(LaipsniuKelimoSkaicius(sk1));
                            Skaiciuotuvas();
                            break;
                        case "6":

                            sk1 = SakniesTraukimoSkaicius(sk1);
                            ;
                            Console.WriteLine(SakniesTraukimoSkaicius(sk1));
                            Skaiciuotuvas();
                            break;
                    }


                    break;
                case "3":
                    Console.WriteLine("Exit");
                    System.Environment.Exit(-1);
                    break;
            }
        }

        public static void AntrasSubMeniu(double sk1, double sk2)
        {

            Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
            string pirmasSubmeniu = Convert.ToString(Console.ReadLine());
            switch (pirmasSubmeniu)
            {
                case "1":
                    Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    sk2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(SudetiSkaicius(sk1, sk2));
                    Skaiciuotuvas();
                    break;
                case "2":
                    Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    sk2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AtimtiSkaicius(sk1, sk2));
                    Skaiciuotuvas();
                    break;
                case "3":
                    Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    sk2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(DaugintiSkaicius(sk1, sk2));
                    Skaiciuotuvas();
                    break;
                case "4":
                    Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    sk2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(DalintiSkaicius(sk1, sk2));
                    Skaiciuotuvas();
                    break;
                case "5":
                    Console.WriteLine("Iveskite 1 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(LaipsniuKelimoSkaicius(sk1));
                    Skaiciuotuvas();
                    break;
                case "6":
                    Console.WriteLine("Iveskite 1 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(SakniesTraukimoSkaicius(sk1));
                    Skaiciuotuvas();
                    break;

                default:
                    break;
            }
        }




        public static double SudetiSkaicius(double sk1, double sk2)
        {
            double suma = sk1 + sk2;
            return sk1 + sk2;
        }
        public static double AtimtiSkaicius(double sk1, double sk2)
        {
            return sk1 - sk2;
        }
        public static double DaugintiSkaicius(double sk1, double sk2)
        {
            return sk1 * sk2;
        }
        public static double DalintiSkaicius(double sk1, double sk2)
        {
            return (double)sk1 / sk2;
        }
        public static double LaipsniuKelimoSkaicius(double sk1)
        {
            int valSqr = 0;
            for (int i = 0, j = 1; i < sk1; i++, j += 2)
                valSqr += j;
            return valSqr;
        }
        public static double SakniesTraukimoSkaicius(double sk1)
        {
            double root = 1;
            int i = 0;

            while (true)
            {
                i = i + 1;
                root = (sk1 / root + root) / 2;
                if (i == sk1 + 1) { break; }
            }
            Console.WriteLine("Square root:{0}", root);
            return root;
















        }
        }
        }
