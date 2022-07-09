namespace Metodų_uždaviniai_ir_testai
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.WriteLine($"------------------------");
            SveikiVisi();
            LinkiuGerosDienos();
            Console.WriteLine($"------------------------");

            LinkiuJumsGerosDienos();

            Console.WriteLine($"------------------------");


            /*Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
- Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
N.B. būtina validacija
- Į ekraną išveskite argumentų matematinę sumą.
Pvz:
> Iveskite pirmą skaičių:
_ 15
> Iveskite antrą skaičių:
_ 16
            */



            Console.WriteLine($"Iveskite pirma skaiciu");
            var sk1 =  Console.ReadLine();
            Console.WriteLine($"Iveskite antra skaiciu");
            var sk2 = Console.ReadLine();

            bool ArSk1Skaicius = int.TryParse(sk1, out int ParskintasSk1);
            bool ArSk2Skaicius = int.TryParse(sk2, out int ParskintasSk2);

            if (ArSk1Skaicius && ArSk2Skaicius)
            {
                SudetiSkaicius(ParskintasSk1, ParskintasSk2);
            }
            else
            {
                Console.WriteLine($"Neteisingai ivestas skaicius");
            }



            Console.WriteLine($"------------------------");
            /*
            Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
- Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
-Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
- Main metode į ekraną išveskite tarpų kiekį
Pvz:
> Iveskite teksta:
            _ as mokausi programuoti
            > Tarpu kiekis yra: 2
            */
            Console.WriteLine($"------------------------");

            Console.WriteLine($"Iveskite pet koki teksta su tarpais"); 
            var Tekstas = Console.ReadLine();
            Console.WriteLine($"Tarpu kiekis {TarpuSkaicius(Tekstas)}");
            





        }

        private static int TarpuSkaicius(string Tekstas)
        {
            return Tekstas.Length - Tekstas.Replace(" ", "").Length;
        }



        /*Parašykite programą kurioje yra 2 metodai.
- Pirmas metodas į konsolę išveda "Sveiki visi"
- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
        */

        public static void SveikiVisi()  
        {
            Console.WriteLine($"Sveiki visi");
        }

        public static void LinkiuGerosDienos() 
        {
            Console.WriteLine($"Linkiu jums geros dienos");
        }

        


        /* Parašykite programą kurioje yra 2 metodai.
-
- Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
- Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
Pvz:
> Iveskite savo Varda:
_ Petras
> Labas Petras
> Linkiu jums Petras geros dienos
        */

        public static string NuskaitytiIrIsvestiVarda()
        {
            Console.WriteLine($"Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;

        }

        public static void LinkiuJumsGerosDienos()
        {
            Console.WriteLine($"Linkiu Jums {NuskaitytiIrIsvestiVarda()} geros dienos");
        }




        public static void SudetiSkaicius(int ParsintasSk1, int ParskintasSk2)
        {
            Console.WriteLine($"Pirmas skaicius + antras skaicius = {ParsintasSk1 + ParskintasSk2}");
        }
        




    }
}