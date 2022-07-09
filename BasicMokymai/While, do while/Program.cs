namespace While__do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, While/Do-While Ciklai!");
            // WhileCikloPavyzdys();
            //  DoWHilePavyzdys();
            // Uzduotis1();
            // Uzduotis2();
            //uzduotis3();
            uzduotis4();




        }

        public static void WhileCikloPavyzdys()
        {
            int skaicius = 1;

            while(skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }

            int zaidejuSkaicius = -1;
                while(zaidejuSkaicius < 0 || zaidejuSkaicius > 10)
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine()); 
            }
        }

        public static void DoWHilePavyzdys()
        {
            int zaidejuSkaicius = -1;

            do
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());
           
            } while (zaidejuSkaicius < 0 || zaidejuSkaicius > 10);
         
             }

        /*
         * * 1.Paprašyti vartotojo įvesti bet kokį skaičių.          * Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.         */

        public static void Uzduotis1()
        {
            int suma = 0;
            int IvestiSkaiciu = 0;

            Console.WriteLine("iveskite skaiciu sumai isgauti");
            IvestiSkaiciu = Convert.ToInt32(Console.ReadLine());
            while (IvestiSkaiciu > 0)
            {
                Console.WriteLine($"Skaiciuojama suma: {suma}");
                suma += IvestiSkaiciu;
                Console.WriteLine($"i: {suma}\n");
                IvestiSkaiciu--;

            }
            Console.WriteLine($"--------------"); 
            Console.WriteLine($"Suma: {suma}");
        }

        /*
         * * Paprašyti vartotojo įvesti bet kokį skaičių.         
         * * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus,         
         * * vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....         */

        public static void Uzduotis2()
        {
            int i = 0;
            int j = 0;

            Console.WriteLine("Iveskite bet koki skaiciu");
            i = Convert.ToInt32(Console.ReadLine());


            while (j < i) ;
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine($"{j}");
                }
                j++;
            }
        }

        /** Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma,          
         * * kurie buvo ivesti iki ivesto neigiamo skaiciaus       
         * *  PVZ         * 1,23,4,5,7,8,-1         */
        public static void uzduotis3()
        {
            int suma = 0;
            int i = 0;
            Console.WriteLine("Iveskite bet koki skaiciu");
            i = Convert.ToInt32(Console.ReadLine());

            while (i >= 0)
            {
                suma += i;
            }

        }

        /*         * 6. Parasykite slaptazodzio ivedimo simuliacija. 
         *         Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi. 
         *         Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. 
         *         Bandykite dar karta”. 
         *         * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.        
         *         * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo.         */

        public static void uzduotis4()
        {
            do
            {
                Console.WriteLine("Nustatytite slaptazodi");
                var slaptazodis = Console.ReadLine;

                Console.WriteLine("Pakartokite slaptazodi");
                var pakartotasSlaptazodis = Console.ReadLine;

            } while (slaptazodis == pakartotasSlaptazodis);


                if (slaptazodis != pakartotasSlaptazodis)
            {
                Console.WriteLine("pakartokit slaptazodi");
            }
        }


        }

        }
        /*
        public static void MathRandomPavyzdys()
        {
            var randomObjektas = new Random();
            var IsmestaMoneta = randomObjektas.Next(1, 2);
            var MonetosMetimas = 0;


            while (MonetosMetimas < 10) ;
        }
        */

  