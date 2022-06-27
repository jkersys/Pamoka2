namespace Metodai_uzdaviniai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            Parašykite programą kurioje yra 2 metodai.
- Pirmas metodas į konsolę išveda "Sveiki visi"
- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
            */
            SveikiVisi();
            LinkiuJumsGerosDienos();

            Console.WriteLine("Iveskite pirma skaiciu");
           var sk1 = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu");
           var sk2 = Console.ReadLine();

            Console.WriteLine($"{DaugintiSkaicius}");
            //Console.WriteLine($"{DaugintiSkaicius}");

        }



            public static void SveikiVisi()
        {
            Console.WriteLine($"Sveiki visi");
        }

        public static void LinkiuJumsGerosDienos()
        {
            Console.WriteLine($"Linkiu jums geros dienos");
        }

        /*
        Parašykite programą kurioje yra 2 metodai.
-
- Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
- Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
Pvz:
> Iveskite savo Varda:
_ Petras
> Labas Petras
> Linkiu jums Petras geros dienos
        */


        public static string? NuskaitytiIrIvestiVarda()
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;
        }

        public static void LinkiuJumsGerosDIenos()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIvestiVarda()} geros dienos");
        }


        /*
          Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
- Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
N.B. būtina validacija
- Į ekraną išveskite argumentų matematinę sumą.
Pvz:
> Iveskite pirmą skaičių:
_ 15
> Iveskite antrą skaičių:
_ 16
> Rezultatas: 31
        */


        public static int DaugintiSkaicius(int sk1, int sk2)
        { //validacija darom su tryparse
           if (Int32.TryParse(sk1, out _))
            {
                
            }
            
        }

        






    }
    }
