namespace RefaktorintasSuperSkaiciuotuvas
{
        public class Program
        {

            public static double? rezultatas = null;
            public static string ivedimas = "";
            public static string dabartineBusena = "0";
            public static double num1 = 0;
            public static double num2 = 0;
            public static string veiksmas = "";
            public static bool calculationSelected = false;
            public static bool continueCalculation = false;
            public static bool poApskaiciavimo = false;

            public static void Main(string[] args)
            {
                Console.WriteLine("Hello SuperSkaiciuotuvas");
            
            SkaiciuotuvoMenu();


            }

          
            public static void Reset()
            {
                continueCalculation = false;
                rezultatas = null;
            }

            public static double Rezultatas()
            {
                return rezultatas ?? 0;

            }

            //State machine
            public static void SuperSkaiciuotuvas(string ivedimas)
            {
                switch (dabartineBusena)
                {
                    case "0": //Pradine busena
                        if (ivedimas == "1")
                        {
                            dabartineBusena = "1";
                            return;
                        }
                        break;
                    case "1": //Pasirinkimo busena
                    if (double.Parse(ivedimas) > 4)
                    {
                        Console.WriteLine("Tokio pasirinkimo nera");
                        break;
                    }
                    dabartineBusena = continueCalculation ? "3" : "2";
                        veiksmas = ivedimas; //pasidaryti kad leistu tik 1-4
                   


                        break;
                    case "2": //Naujo skaiciavimo busena
                        dabartineBusena = "3";
                        rezultatas = double.Parse(ivedimas);
                        break;
                    case "3": //testinio skaiciavimo busena
                        dabartineBusena = "4";
                        num2 = double.Parse(ivedimas);


                        switch (veiksmas)
                        {
                            
                            case "1":
                                rezultatas += num2;
                                break;
                            case "2":
                                rezultatas -= num2;
                                break;
                            case "3":
                                rezultatas *= num2;
                                break;
                            case "4":
                          
                                if (num2 == 0)
                                {
                                    Console.WriteLine("Dalyba is 0 negalima");
                                   
                                }                            
                                else
                                rezultatas /= num2;
                                break;
                        default:
                            Console.WriteLine("Tokio pasirinkimo nera");
                            break;
                          




                    }
                        break;
                    case "4": //Busena po skaiciavimo busena
                        dabartineBusena = "4";
                        switch (ivedimas)
                        {
                            case "1":
                                dabartineBusena = "1";
                                Reset();
                                return;
                            case "2":
                                dabartineBusena = "1";
                                continueCalculation = true;
                                return;
                            default: return;

                        }


                }

            }

            //Bendravimas su vartotoju
            public static void SkaiciuotuvoMenu()
            {


                if (dabartineBusena == "0")
                {
                    Console.WriteLine("1. Nauja operacija");
                    Console.WriteLine("2. Iseiti");
                    ivedimas = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("1. Nauja operacija");
                    Console.WriteLine("2. Testi su rezultatu");
                    Console.WriteLine("3. Iseiti");
                    ivedimas = Console.ReadLine();

                }
                SuperSkaiciuotuvas(ivedimas);

                if (dabartineBusena == "1")
                {

                    Console.WriteLine("1 Sudetis");
                    Console.WriteLine("2 Atimtis");
                    Console.WriteLine("3 Daugyba");
                    Console.WriteLine("4 Dalyba");


                ivedimas = Console.ReadLine();
                }



                else if (ivedimas == "3")
                {
                    Environment.Exit(0);
                }
                SuperSkaiciuotuvas(ivedimas);


                if (dabartineBusena == "2")
                {


                    Console.WriteLine("Iveskite pirmajį skaičiu");
                    ivedimas = Console.ReadLine();
                    SuperSkaiciuotuvas(ivedimas);


                    Console.WriteLine("Iveskite antraji skaičiu");
                    ivedimas = Console.ReadLine();
                    SuperSkaiciuotuvas(ivedimas);

                    Console.WriteLine($"Rezultatas yra :{rezultatas}");




                    SkaiciuotuvoMenu();
                }
                else if (dabartineBusena == "3")
                {
                    Console.WriteLine("Tesiate su rezultatu");

                    Console.WriteLine("Iveskite antraji skaiciu");
                    ivedimas = Console.ReadLine();
                    SuperSkaiciuotuvas(ivedimas);

                    Console.WriteLine($"Rezultatas yra :{rezultatas}");
                    SkaiciuotuvoMenu();
                }

            }


        }









    //Console.WriteLine("Hello, World!");
    /* ## Super Skaiciuotuvas ## 
      Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
      1. Nauja operacija 2 Iseiti. 

      Pasirinkus 1 vada į submeniu:
      1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba

      Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
      o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori 
    atlikti nauja operacija ar testi su rezultatu. 
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




