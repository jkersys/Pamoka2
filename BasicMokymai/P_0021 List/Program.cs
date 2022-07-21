namespace P_0021_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<String> StringMasyvas = new List<String> { "Žodis1", "Žodis2", ".........." };
            List<int> IntgMasyvas = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<String> automobiliai = new List<String> { "Audi", "VW", "Opel", "Volvo" };


            //prideti elementa i saraso gala
            automobiliai.Add("BMW");


            Console.WriteLine(String.Join(", ", automobiliai));

            automobiliai[1] = "Subaru";


            //prideti daug elementu i gala
            List<String> daugiauautomobiliu = new List<String> { "BMW", "Mercedec", "Toyota" };
            automobiliai.AddRange(daugiauautomobiliu);


            //isvalyti lista
            //automobiliai.Clear();
            //Console.WriteLine("Isvalyta "  + (String.Join(", ", automobiliai));

            List<int> skaiciuMasyvas = new List<int> { 5, 1, 6, 8, 7 };

            DIDESNIS_UZ_DIDZIAUSIA_Su_For(skaiciuMasyvas);

        }
        /*
        DIDŽIAUSIAS SĄRAŠE
     Duotas vienmatis sveikų skaičių sąrašas.
     Parašykite programą, kuri suranda didžiausią skaičių saraše
        { 5, 1, 6, 8, 7 }
        rezultatas:  8
        */

        public static int didziausiasSarase(List<int> skaiciuMasyvas)
        {
            var didziausias = skaiciuMasyvas[0];
            for (int i = 0; i < skaiciuMasyvas.Count; i++)
            {
                if (skaiciuMasyvas[i] > didziausias)
                {
                    didziausias = skaiciuMasyvas[i];
                }
            }
            return didziausias;

        }
        //arba
        // skaiciuMasyvas.Sort();
        //return skaiciuMasyvas[skaiciuMasyvas.Count -1]


        /*
         DIDESNIS UŽ DIDŽIAUSIĄ
        Duotas vienmatis sveikų skaičių sąrašas. 
        Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią
        pvz:
        { 5, 1, 6, 8, 7 }
        rezultatas:  5, 1, 6, 8, 7, 9
        */


        public static int DIDESNIS_UZ_DIDZIAUSIA(List<int> skaiciuMasyvas)
        {
            skaiciuMasyvas.Sort();
            return skaiciuMasyvas[skaiciuMasyvas.Count - 1];
        }

        public static List<int> DIDESNIS_UZ_DIDZIAUSIA_Su_For(List<int> skaiciuMasyvas)
        {
            var didziausias = skaiciuMasyvas[0];
            for (int i = 0; i < skaiciuMasyvas.Count; i++)
            {
                if (skaiciuMasyvas[i] > didziausias)
                {
                    didziausias = skaiciuMasyvas[i];
                }
                skaiciuMasyvas.Add(didziausias + 1); 
            }
            return skaiciuMasyvas;



        }




    }
}