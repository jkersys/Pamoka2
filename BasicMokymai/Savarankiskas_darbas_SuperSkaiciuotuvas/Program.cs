namespace Savarankiskas_darbas_SuperSkaiciuotuvas
{

    public class Program
    {

        public static double? rezultatas = null;
        public static double? num1;
        public static double? num2;
        public static string ivedimas = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello SuperSkaiciuotuvas");

            SuperSkaiciuotuvas(ivedimas);

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
                ivedimas = Doubleivedimas().ToString();


                if (rezultatas == null)
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
                            if (rezultatas != null)

                                switch (ivedimas)
                                {

                                    case "1":
                                        Console.WriteLine("Pasirinkote nauja operacija");
                                        Reset();
                                        SubMenu(ivedimas);
                                        break;
                                    case "2":
                                        Console.WriteLine("Pasirinkote testi su rezultatu");
                                        SubMenu(ivedimas);
                                        break;
                                    case "3":
                                        Console.WriteLine("Pasirinkote iseiti is programos");
                                        Environment.Exit(0);
                                        break;

                                }
                    }

            }
        }

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
                        num1 = Doubleivedimas();
                        Console.WriteLine("Iveskite antraji skaičiu");
                        num2 = num1 = Doubleivedimas();
                        rezultatas = num1 + num2;
                        SuperSkaiciuotuvas(ivedimas);
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
                            SuperSkaiciuotuvas(ivedimas); 
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




            public static double Doubleivedimas()
            {

                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double sk))
                    {
                        return sk;
                    }
                    Console.WriteLine("neteisingas skaicius");
                }
            }


            /*
            }
            else if (rezultatas != null)
            {
                Console.WriteLine("1. Nauja operacija");
                Console.WriteLine("2. Testi su rezultatu");
                Console.WriteLine("3. Iseiti");
            moves.Add(ivedimas);


        }


        if (ivedimas == "1" || ivedimas == "2")
            {

                Console.WriteLine("1 Sudetis");
                Console.WriteLine("2 Atimtis");
                Console.WriteLine("3 Daugyba");
                Console.WriteLine("4 Dalyba");

            ivedimas = Doubleivedimas().ToString();
        }


            else if (ivedimas == "3")
            {
                Environment.Exit(0);
            }



            if (ivedimas == "1")
            {
                if (rezultatas == null)
                {
                    Console.WriteLine("Iveskite pirmajį skaičiu");

                    num1 = Doubleivedimas();

                    Console.WriteLine("Iveskite antraji skaičiu");
                     num2 = Doubleivedimas();
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
                SuperSkaiciuotuvas(ivedimas);
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





    static string FakeIvedimas()
    {
        if (moves.Count <= 0) { return Console.ReadLine(); }
        if (moves.Count > i) { return moves[i++]; }
        return "-1";
    }





    public static void Pradzia()
    {
      Console.WriteLine("1. Nauja operacija");
      Console.WriteLine("2. Iseiti");
      string ivedsimas;
      string ivedimas = Console.ReadLine();
        SuperSkaiciuotuvas(ivedimas);
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