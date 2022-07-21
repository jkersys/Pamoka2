namespace P018_Skaiciuotuvas
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            bool arTesti = true;
            double skaicius1 = 0;
            double skaicius2 = 0;
            double rezultatas = 0;


            Menu(ref skaicius1, ref skaicius2, ref rezultatas);

            

        }






        /*
         *3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. 
         *Iseiti”. Pasirinkus 1 turetu ismesti ”
1. Sudetis
2. Atimtis
3. Daugyba
4. Dalyba”
Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir 
        uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
“1
15
45
Rezultatas: 60
1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
BONUS1: Iskelkite operacijas i metodus
BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
BONUS3: Parasyti unit testus uztikrinant operaciju veikima
BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
        */

        public static void Menu(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
        Console.WriteLine("1. Nauja operacija");
        Console.WriteLine("2. Testi su rezultatu");
        Console.WriteLine("3. Iseiti");

            switch(Console.ReadLine())
            {
                case "1":
                SubMenu(ref skaicius1, ref skaicius2, ref rezultatas);
                    break;
                case "2":
                    Console.WriteLine("Iveskite skaiciu");
                    skaicius1 = rezultatas;
                    Sudetis(ref skaicius1, ref skaicius2, ref rezultatas);
                    Console.WriteLine(Sudetis(ref skaicius1, ref skaicius2, ref rezultatas));
                    break;
                case "3":
                    Environment.Exit(0);
                    break;




            }
               


        }

        public static void SubMenu(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
            Console.WriteLine("1 Sudetis");
            Console.WriteLine("2 Atimtis");
            Console.WriteLine("3 Daugyba");
            Console.WriteLine("4 Dalyba");


          
            switch (Console.ReadLine())
            {
                case "1":
                    if (true)
                    {
                        Sudetis(ref skaicius1, ref skaicius2, ref rezultatas);
                    }
                    else if (false)
                    {
                        
                    }

                    
                    break;
                case "2":
                    Atimtis(ref skaicius1, ref skaicius2, ref rezultatas);
                  //  SubMenuMenu(ref skaicius1, ref skaicius2);
                    break;
                case "3":
                    Daugyba(ref skaicius1, ref skaicius2, ref rezultatas);
                 //   SubMenuMenu(ref skaicius1, ref skaicius2);
                    break;
                case "4":
                    Daugyba(ref skaicius1, ref skaicius2, ref rezultatas);
                //    SubMenuMenu(ref skaicius1, ref skaicius2);
                    break;



            }

        }

        /*
        public static bool SubMenuMenu(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
            Console.WriteLine("Paspauskite 1 jeigu norite testi");
            Console.WriteLine("Paspauskite 2 jeigu norite testi su rezultatu");
            bool vienas = true;
            
            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                   
                   SubMenu(ref skaicius1, ref skaicius2, ref rezultatas);

                    break;
                case "2":
                    return false;
                    break;

            }

        }
        */

            public static double Sudetis(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
            if (true)
            {
                Console.WriteLine("Iveskite pirmajį skaičiu");
                skaicius1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite antraji skaičiu");
                skaicius2 = Convert.ToDouble(Console.ReadLine());
                rezultatas = skaicius1 + skaicius2;
                Console.WriteLine($"Rezultatas yra {rezultatas}");
                Console.WriteLine(rezultatas);
                Menu(ref skaicius1, ref skaicius2, ref rezultatas);
                return rezultatas;
            }
            else if (false)
            {
                Console.WriteLine("Iveskite skaiciu");
                skaicius1 = rezultatas;
                skaicius2 = Convert.ToDouble(Console.ReadLine());
                rezultatas = skaicius1 + skaicius2;
                Console.WriteLine($"{rezultatas}");

            }

            
            




         }

        public static double Atimtis(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
            Console.WriteLine("Iveskite pirmajį skaičiu");
            skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite pirmajį skaičiu");
            skaicius2 = Convert.ToDouble(Console.ReadLine());

            return rezultatas = skaicius1 - skaicius2;

        }


        public static double Daugyba(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
            Console.WriteLine("Iveskite pirmajį skaičiu");
            skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite pirmajį skaičiu");
            skaicius2 = Convert.ToDouble(Console.ReadLine());

            return rezultatas = skaicius1 * skaicius2;

        }


        public static double Dalyba(ref double skaicius1, ref double skaicius2, ref double rezultatas)
        {
            Console.WriteLine("Iveskite pirmajį skaičiu");
            skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite pirmajį skaičiu");
            skaicius2 = Convert.ToDouble(Console.ReadLine());

            return rezultatas = skaicius1 / skaicius2;

        }

        public static bool arTesti(ref double skaicius1, ref double rezultatas, ref bool arTesti)
      {

            if (skaicius1 == rezultatas)
            {
                return false;
            }
            return false;

        }
        


    }
}