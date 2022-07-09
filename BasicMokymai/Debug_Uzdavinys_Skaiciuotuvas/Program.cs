namespace Debug_Uzdavinys_Skaiciuotuvas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Console.WriteLine("Iveskite pirma skaiciu");
            // var input1 = Console.ReadLine();
            // Console.WriteLine("Iveskite antra skaiciu");
            // var input2 = Console.ReadLine();

            // double sk1 = Convert.ToDouble(input1);
            //  double sk2 = Convert.ToDouble(input2);

            //Console.WriteLine($"{Skaiciuotuvas(3, 3, "*")}");

            Console.WriteLine("Iveskite skaiciu a");
            var a = Console.ReadLine();
            Console.WriteLine("Iveskite skaiciu b");
            var b = Console.ReadLine();


            Console.WriteLine(@"Pasirinkite veiksma
          1) +
          2) -
          3) *
          4) /
          5) a^2
          6) a^3");


            var veiksmas = Console.ReadLine();
           
            if (arSveikiejiSkaiciai(a, b))
            {
                rezultatas = Skaiciuotuvas(Convert.ToInt32(a), Convert.ToInt32(a), veiksmas);
            }
            else if (ArSkaiciai(a, b))
            {
                rezultatas = Skaiciuotuvas(Convert.ToDouble(a), Convert.ToDouble(b), veiksmas);
            }
            
        }


        /* MATEMATIKA ---------------------------------------------------
          1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
          - Main metode paprašykite įvesti 2 skaičius
          - Kiekvienas matematinis veiksmas turi turėti savo metodą 
            metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
          - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
          - Visų gautų rezultatų sumą atspausdinti Main metode.

         2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
          - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
          - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius (int tipo) ir veiksmą. 
          - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
          - parašyti testus
          - gautą rezultatą atspausdinti į ekraną Main metode.

          */

        public static int Suma(int a, int b) => a + b;
        public static int Atimtis(int a, int b) => a - b;
        public static int Daugyba(int a, int b) => a * b;
        public static double Dalyba(int a, int b) => (double)a / b;

        public static double? Skaiciuotuvas(int a, int b, string veiksmas)
        {
            switch (veiksmas)
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Atimtis(a, b);
                case "*":
                    return Daugyba(a, b);
                case "/":
                    return Dalyba(a, b);
                default:
                    return null;
            }
        }

        /*1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
        (prieštai sukurtų metodų ištrinti negalima)
      2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
        (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
      3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).
      4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas 
        (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija) 
        (Pasirinkimams panaudoti switch sakinį)
          1) +
          2) -
          3) *
          4) /
          5) a^2
          6) a^3
        */

       


        //tikrinam ar skaiciai su kableliu
        public static bool arSveikiejiSkaiciai(string a, string b) => int.TryParse(a, out _) && int.TryParse(b, out _);
        //tikrinam ar skaiciai be kablelio
        public static bool ArSkaiciai(string a, string b) => double.TryParse(a, out _) && double.TryParse(b, out _);


        public static double Suma(double a, double b) => a + b;
        public static double Atimtis(double a, double b) => a - b;
        public static double Daugyba(double a, double b) => a * b;
        public static double Dalyba(double a, double b) => a / b;
        public static double Kvadratu(double a, double b) => a * a;
        public static double Kubu(double a, double b) => a * a * a;





        public static void Daugiakampio_Plotas_Main(string[] args)
        {
            Console.WriteLine("Iveskite krasiniu kieki (n)");
            int n = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("Iveskite krasiniu ilgi (b)");
            int b = Convert.ToInt32(Console.ReadLine);

            int h = 0;
            int r = 0;
            if (n == 3)
            {
                Console.WriteLine("Iveskite krasiniu kieki (h)");
                h = Convert.ToInt32(Console.ReadLine);
            }
            else if (n > 4)
            {
                Console.WriteLine("Iveskite krasiniu kieki (r)");
                r = Convert.ToInt32(Console.ReadLine);
            }


               
                
                
            var A = PligonoPlotas(n, b, h);
            var S = VidineKampuSuma(n);
            Console.WriteLine($"plotas A = {A}");




        }

        
        
        private static double PligonoPlotas(int n, int b, int h = 0, int r = 0) //state machine
        {
            double A = n switch
            {
                3 => TrikampioPlotas(b, h),
                4 => KeturkampioPlotas(b),
                _ => DaugiakampioPlotas(n, b, r)

            };
            return A;
        }

        private static double DaugiakampioPlotas(int n, int b, int r) => n / 2 * b * r;
       
        private static double KeturkampioPlotas(int b) => b * b;
        
        private static double TrikampioPlotas(int b, int h) => 1d / 2 * b * h;
        private static object VidineKampuSuma(int n) => 180 * (n - 2);




    }

}