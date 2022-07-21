namespace SuperSkaiciuotuvas
{
    public class Program
    {

        public static double? rezultatas = null;
        //  static string ivedimas = DuomenuIvedimas();
        public static string ivedimas = "";
       // public static List<string> ivedimas = new List<string>();
        public static double num1 = 0;
        public static double num2 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello SuperSkaiciuotuvas");

            //   Console.WriteLine("1. Nauja operacija");
            //  // Console.WriteLine("2. Iseiti");



            //   string pirmasSkaicius = ivedimas;
            // string antrasSkaicius = ivedimas;



            SuperSkaiciuotuvas(ivedimas);
            // Ivedimas(ref num1, ref num2);

            //   Console.WriteLine(num1);
            //    Console.WriteLine(num2);

            //Console.WriteLine("Hello, World!");
            /* ## Super Skaiciuotuvas ## 
              Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
              1. Nauja operacija 2 Iseiti. 

              Pasirinkus 1 vada į submeniu:
              1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba

              Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
              o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu. 
              1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
              Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
              Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.

          Pvz:
          > 1. Nauja operacija 2 Iseiti. 
          _1
          > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
          _1
          > pasirinktas veiksmas + 
          > iveskite pirma skaiciu
          _15
          > iveskite antra skaiciu
          _45
          > Rezultatas: 60
          > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
          _2
          > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
          _2
          > pasirinktas veiksmas - 
          > Iveskite skaiciu
          _10
          > Rezultatas: 50
          > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
          _1
          > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
          _2
          > pasirinktas veiksmas * 
            > iveskite pirma skaiciu
          _2
          > iveskite antra skaiciu
          _3
          > Rezultatas: 6
          > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
          _3
          > Baigta



          BONUS1: Iskelkite operacijas i metodus
          BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
                  - dalyba is nulio, neteisingu ivesciu prevencija 
                  - kada tikimasi gauti skaiciu, bet gaunamas char arba string.
                  - neteisingas meniu punkto pasirinkimas
          BONUS3: Parasyti unit testus uztikrinant operaciju veikima
          BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas

             */




        }

        /*
            static double? rezultatas = null;

          
            {

            }


            public static void SuperSkaiciuotuvas(string ivedimas)
            {
                //todo
            }

            public static double Rezultatas()
            {
                return rezultatas ?? 0;
            }
            public static void Reset()
            {
                //todo
                rezultatas = null;
            }

        */

        /*
        public static void IvedimasMeto(string num1, ref string num2, ref double rezultatas)
        {
            if (rezultatas != null)
            {
                Console.WriteLine("Iveskite pirmaji skaiciu");
                num1 = Console.ReadLine();
                Console.WriteLine("Iveskite antraji skaiciu");
                num2 = Console.ReadLine();
            }
            else
            {
                num1 = Convert.ToString(rezultatas);
                Console.WriteLine("Iveskite antraji skaiciu");
                num2 = Console.ReadLine();


            }


        }
            */
        /*
        public static void Pasirinkimas()
            Console.WriteLine("1. Nauja operacija");
            Console.WriteLine("2. Iseiti");

        */
        /*
        public static string Ivedimas()
        {
            string Ivedimas = Console.ReadLine();

            return Ivedimas;
        }
        */

        public static void Reset()
        {

            rezultatas = null;
        }

        public static double Rezultatas()
        {
            return rezultatas ?? 0;

        }
        public static void SuperSkaiciuotuvas(string ivedimas)
        {


            if (rezultatas == null)
            {
                Console.WriteLine("1. Nauja operacija");
                Console.WriteLine("2. Iseiti");
                ivedimas = Console.ReadLine();

                /*
                   switch (ivedimas)
                   {
                       case "1":
                           Reset();
                           SubMenu(ivedimas);
                           break;
                       case "2":
                           Console.WriteLine("Pasirinkote iseiti is programos");
                           Environment.Exit(0);
                           break;
                   }
               }*/
            }
            else if (rezultatas != null)
            {
                Console.WriteLine("1. Nauja operacija");
                Console.WriteLine("2. Testi su rezultatu");
                Console.WriteLine("2. Iseiti");
                ivedimas = Console.ReadLine();

            }


            if (ivedimas == "1" || ivedimas == "2")

                Console.WriteLine("1 Sudetis");
            Console.WriteLine("2 Atimtis");
            Console.WriteLine("3 Daugyba");
            Console.WriteLine("4 Dalyba");

            ivedimas = Console.ReadLine();



            if (ivedimas == "1")
                    {
                        if (rezultatas == null)
                        {
                            Console.WriteLine("Iveskite pirmajį skaičiu");
                            ivedimas = Console.ReadLine();
                            double.TryParse(ivedimas, out double num1);

                            Console.WriteLine("Iveskite antraji skaičiu");
                            ivedimas = Console.ReadLine();
                            double.TryParse(ivedimas, out double num2);
                            rezultatas = num1 + num2;
                            Console.WriteLine($"Rezultatas yra :{rezultatas}");
                        }

                        else if (rezultatas != null)
                        {
                            Console.WriteLine("Tesiate su rezultatu");
                            num1 = (double)rezultatas;
                            Console.WriteLine("Iveskite antraji skaiciu");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            rezultatas = num1 + num2;
                            Console.WriteLine($"Rezultatas yra :{rezultatas}");
                        }

                        SuperSkaiciuotuvas(ivedimas);
                    }
                    else if (ivedimas == "2")
                    {
                    if (rezultatas == null)
                    {
                        Console.WriteLine("Iveskite pirmajį skaičiu");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Iveskite antraji skaičiu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 - num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }

                    else if (rezultatas != null)
                    {
                        Console.WriteLine("Tesiate su rezultatu");
                        num1 = (double)rezultatas;
                        Console.WriteLine("Iveskite antraji skaiciu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 - num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }
                    SuperSkaiciuotuvas(ivedimas);
                }
                    else if (ivedimas == "3")
                    {
                    if (rezultatas == null)
                    {
                        Console.WriteLine("Iveskite pirmajį skaičiu");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Iveskite antraji skaičiu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 * num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }

                    else if (rezultatas != null)
                    {
                        Console.WriteLine("Tesiate su rezultatu");
                        num1 = (double)rezultatas;
                        Console.WriteLine("Iveskite antraji skaiciu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 * num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }
                    else if (ivedimas == "4")
                    {
                        if (rezultatas == null)
                        {
                            Console.WriteLine("Iveskite pirmajį skaičiu");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Iveskite antraji skaičiu");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            rezultatas = num1 / num2;
                            Console.WriteLine($"Rezultatas yra :{rezultatas}");
                        }

                        else if (rezultatas != null)
                        {
                            Console.WriteLine("Tesiate su rezultatu");
                            num1 = (double)rezultatas;
                            Console.WriteLine("Iveskite antraji skaiciu");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            rezultatas = num1 / num2;
                            Console.WriteLine($"Rezultatas yra :{rezultatas}");
                        }
                        SuperSkaiciuotuvas(ivedimas);
                    }


                }


            }
        

        /*
        public static void SuperSkaiciuotuvas(string ivedimas)
        {


            if (rezultatas == null)
            {
                Console.WriteLine("1. Nauja operacija");
                Console.WriteLine("2. Iseiti");
                ivedimas = Console.ReadLine();
                switch (ivedimas)
                {
                    case "1":
                        Reset();
                        SubMenu(ivedimas);
                        break;
                    case "2":
                        Console.WriteLine("Pasirinkote iseiti is programos");
                        Environment.Exit(0);
                        break;
                }
            }
            else if (rezultatas != null)
            {
                Console.WriteLine("1. Nauja operacija");
                Console.WriteLine("2. Testi su rezultatu");
                Console.WriteLine("2. Iseiti");
                ivedimas = Console.ReadLine();
                switch (ivedimas)
                {
                    case "1":
                        Reset();
                        SubMenu(ivedimas);
                        break;
                    case "2":
                        SubMenu(ivedimas);
                        break;
                    case "3":
                        Console.WriteLine("Pasirinkote iseiti is programos");
                        Environment.Exit(0);
                        break;
                }


            }
        }

        */
        /*
        public static void SubMenu(string ivedimas)
        {
            Console.WriteLine("1 Sudetis");
            Console.WriteLine("2 Atimtis");
            Console.WriteLine("3 Daugyba");
            Console.WriteLine("4 Dalyba");

            ivedimas = Console.ReadLine();

            switch (ivedimas)
            {
                case "1":
                    if (rezultatas == null)
                    {
                        Console.WriteLine("Iveskite pirmajį skaičiu");
                        double.TryParse(ivedimas, out double num1);
                        Console.WriteLine("Iveskite antraji skaičiu");
                        double.TryParse(ivedimas, out double num2);
                        rezultatas = num1 + num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }

                    else if (rezultatas != null)
                    {
                        Console.WriteLine("Tesiate su rezultatu");
                        num1 = (double)rezultatas;
                        Console.WriteLine("Iveskite antraji skaiciu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 + num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }
                                        
                    SuperSkaiciuotuvas(ivedimas);
                    break;
                case "2":
                    if (rezultatas == null)
                    {
                        Console.WriteLine("Iveskite pirmajį skaičiu");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Iveskite antraji skaičiu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 - num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }

                    else if (rezultatas != null)
                    {
                        Console.WriteLine("Tesiate su rezultatu");
                        num1 = (double)rezultatas;
                        Console.WriteLine("Iveskite antraji skaiciu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 - num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }
                    SuperSkaiciuotuvas(ivedimas);
                    break;
                case "3":
                    if (rezultatas == null)
                    {
                        Console.WriteLine("Iveskite pirmajį skaičiu");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Iveskite antraji skaičiu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 * num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }

                    else if (rezultatas != null)
                    {
                        Console.WriteLine("Tesiate su rezultatu");
                        num1 = (double)rezultatas;
                        Console.WriteLine("Iveskite antraji skaiciu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 * num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }
                    SuperSkaiciuotuvas(ivedimas);
                    break;
                case "4":
                    if (rezultatas == null)
                    {
                        Console.WriteLine("Iveskite pirmajį skaičiu");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Iveskite antraji skaičiu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 / num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }

                    else if (rezultatas != null)
                    {
                        Console.WriteLine("Tesiate su rezultatu");
                        num1 = (double)rezultatas;
                        Console.WriteLine("Iveskite antraji skaiciu");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        rezultatas = num1 / num2;
                        Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    }
                    SuperSkaiciuotuvas(ivedimas);
                    break;

    

            }

        }
        */

        /*
        public static void Operacija(ref double? rezultatas)
        {
            
            if (rezultatas == null)
            {
                Console.WriteLine("Iveskite pirmajį skaičiu");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite antraji skaičiu");
                num2 = Convert.ToDouble(Console.ReadLine());
                rezultatas = num1 + num2;
                Console.WriteLine($"{rezultatas}");
            }

            else if (rezultatas != null)
            {
                Console.WriteLine("Tesiate su rezultatu");
                num1 = (double)rezultatas;
                Console.WriteLine("Iveskite antraji skaiciu");
                num2 = Convert.ToDouble(Console.ReadLine());
                rezultatas = num1 + num2;
                Console.WriteLine(rezultatas);
            }
        
        // return (double)(rezultatas = num1 + num2);
    }
        */

        /*
        public static void Submenumenu()
        {
            Console.WriteLine("1. Nauja operacija");
            Console.WriteLine("2. Testi su rezultatu");
            Console.WriteLine("2. Iseiti");
            ivedimas = Console.ReadLine();
            switch (ivedimas)
            {
                case "1":
                    Reset();
                    SubMenu(ivedimas);
                    break;
                case "2":
                    SubMenu(ivedimas);
                    break;
                case "3":
                    Console.WriteLine("Pasirinkote iseiti is programos");
                    Environment.Exit(0);
                    break;
            }
        }

        */


    }
    }
      
