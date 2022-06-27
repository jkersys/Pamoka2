namespace P010_Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            Console.WriteLine("Sukuriame pirma savo metoda");

            IsveskKazkaEkranan();//metodo kvietimas. kai metodas nieko negrąžina ir nieko nepriima
            Console.WriteLine("-----------------------");
            float kazkoksSkaicius = GautiAtsitiktiniSkaiciu(); //metodo kvietimas ir grąžinamos reikšmės priskyrimas
            Console.WriteLine($"kazkoksSkaicius = {kazkoksSkaicius}");

            Console.WriteLine("-----------------------");
            int a = 2;
            IsveskSkaiciuEkranan(a); //metodas su vienu parametru
            Console.WriteLine($"skaicius a is Main {a}");
            Console.WriteLine("-----------------------");

            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = DaugintiSkaicius(sk1, sk2);
            Console.WriteLine($"sudaugintiDuSkaiciai = {sudaugintiDuSkaiciai}"); // metodas su dviem patarmetrais grąžinantis int
            Console.WriteLine("-----------------------");

            int sudaugintiTrysSkaiciai = DaugintiSkaicius(sk1, sk2, 2);
            Console.WriteLine($"sudaugintiTrysSkaiciai = {sudaugintiTrysSkaiciai}"); //metodo overloadinimas, metodas priima 3 argumentus ir grąžina int
            Console.WriteLine("-----------------------");

            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d);
            Console.WriteLine($"sudaugintDuDoubleSkaiciai = {sudaugintDuDoubleSkaiciai}");

            double sudaugintDuDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d);
            Console.WriteLine($"sudaugintDuDoubleSkaiciai1 = {sudaugintDuDoubleSkaiciai1}");
            Console.WriteLine("-----------------------");

            IsveskTekstaEkranan();
            IsveskTekstaEkranan("kazkoks tekstas");


            Console.WriteLine("-----------------------");

            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tekstas");

            Console.WriteLine("-----------------------");
            int patikrintasSkaicius = SkaiciausPatikrinimas(20, 50, 100);
            Console.WriteLine($"patikrintasSkaicius = {patikrintasSkaicius}");

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51);
            Console.WriteLine($"patikrintasSkaicius1 = {patikrintasSkaicius1}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("vidurkis " + Vidurkis(2, 3));
            Console.WriteLine("vidurkis1 " + Vidurkis(2, 3, 8));
            Console.WriteLine("vidurkis2 " + Vidurkis(2, 3, 545, 87, 3, 78, 32, 78, 21, 65, 45, 121));


            Console.WriteLine("-----------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautasSkaicius = {gautasSkaicius}");
            Console.WriteLine("-----------------------");


            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reikšmės perdavimas per reference keičia reikšme kviečiančiame metode
            Console.WriteLine($"po ReferenceSkaicius rsk = {rsk}");
            Console.WriteLine("-----------------------");


            Console.WriteLine(Add(Convert.ToInt32(Console.ReadLine()), 2));
            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;
            }
        }



        /*
        Parašykite programą kurioje yra 2 metodai. 
         - Pirmas metodas į konsolę išveda "Sveiki visi"
         - Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
        */
        public static void SveikiVisi()
        {
            Console.WriteLine("Sveiki visi");
        }
        public static void LinkiuJumsGerosDienos()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        /*---------------------------------------------------
       Parašykite programą kurioje yra 2 metodai. 
        - Pirmas metodas naudotojo paprašo įvesti savo vardą ir  į konsolę išveda "Labas tai_kas_ivesta" 
          ir grąžina tai kas ivesta.
        - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta_pirmame_metode geros dienos"
       Pvz: 
       > Iveskite savo Varda:
       _ Petras
       > Labas Petras
       > Linkiu jums Petras geros dienos
       */
        public static string NuskaitytiIrIsvestiVarda()
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;
        }
        public static void LinkiuJumsGerosDienos1()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos");
        }


        /*---------------------------------------------------
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

        /*---------------------------------------------------
    Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
    - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
    - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį 
    - Main metode į ekraną išveskite tarpų kiekį
    Pvz: 
    > Iveskite teksta:
    _ as mokausi programuoti
    > Tarpu kiekis yra: 2
    */

        /*---------------------------------------------------
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
           Pvz: 
           > Iveskite teksta:
           _ ' as mokausi      '
           > Teksto ilgis yra: 10
        */

        public static void ReferenceSkaicius(ref int skaicius)
        {
            skaicius = 900;
        }


        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;
        }








        public static double Vidurkis(params int[] skaiciai)
        {
            double total = 0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total / skaiciai.Length;
        }

        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max)
            {
                return max;
            }
            return skaicius;


        }



        public static void IsveskTekstaEkranan(string tekstas = "tekstas neivestas")
        {
            Console.WriteLine("tekstas - " + tekstas);
        }

        public static void IsveskSkaiciuIrTekstaEkranan(int skaicius, string tekstas = "tekstas neivestas")
        {
            Console.WriteLine($"skaicius - {skaicius}, tekstas - {tekstas}");
        }




        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
            return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static void IsveskSkaiciuEkranan(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            float a = 4;
            return a + 4.686878f;
        }

        public static void IsveskKazkaEkranan()
        {
            Console.WriteLine("Isvedu kazka");
        }

    }
}