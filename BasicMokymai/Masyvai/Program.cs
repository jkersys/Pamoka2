namespace Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai!");


            int skaicius1 = 100;
            int skaicius2 = 95;
            int skaicius3 = 92;

            //deklaravimas
            int[] skaiciai = { 100, 95, 92 };

            //tuscio masyvo deklaravimas
            int[] skaiciai2;

            //vietos isskyrimas
            int[] skaiciai3 = new int[10];
            string[] zodziai = new string[3];

            //reiksmiu irasymas
            skaiciai3[0] = 100;
            skaiciai3[1] = 95;
            skaiciai3[2] = 32;

            //daugiau budu masyvams deklaruoti
            int[] intMasyvas1 = new int[] { 100, 155, 95, 92, 87, 55, 50, 48, 40, 35, 10 };
            int[] intMasyvas2 = new[] { 100, 155, 95, 92, 87, 55, 50, 48, 40, 35, 10 };
            int[] intMasyvas3 = new int[1] { 100 };
            int[] intMasyvas4 = { 100, 155, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

            //masyvo reiksmes gavimas pagal indeksa
            Console.WriteLine(intMasyvas1[0]);

            // if (skaicius1 == skaiciai2)
            //{
            //   skaiciai2[0] = 100;
            //}



            /*

            //dvimacio masuvo deklaracimas
            int[,] divmatisMasyvas = new int[,]{ { 1, 2 }, { 3, 4 }, { 4, 5} };
            for (int i = 0; i < divmatisMasyvas.GetLength(0); i++)
            {
                for (int j= 0; j < divmatisMasyvas.GetLength(0); j++)
                {
                    BendraiBendrai "_"Console.Write($"{divmatisMasyvas[i, j]}");
                }
                Console.WriteLine();
            }

            */

            string[] dienos1 = new string[7];
            string[] dienos = { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Pentkadienis", "Sestadienis", "Sekmadienis", };

            //visu masuvo irasu atspausdinimas
            for (int i = 0; i < dienos.Length; i++)
            {
                Console.WriteLine(dienos[i]);
            }



            Uzduotis_6();






        }





        /* 3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
         * Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
         * Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
Pvz: 
3
Edvinas
Jonas
Petras----------
Petras
Jonas
Edvinas
        */

        public static void Uzduotis_3()
        {
            Console.WriteLine("Iveskite kiek zmoniu atejo i pamoka");
            int dalyvaujanciuPamokoje = Convert.ToInt32(Console.ReadLine());

            string[] dalyvaujanciuVardai = new string[dalyvaujanciuPamokoje];

            for (int i = 0; i < dalyvaujanciuPamokoje; i++)
            {
                Console.WriteLine("Iveskite pamakoje dalyvaujancio asmens varda");
                dalyvaujanciuVardai[i] = Console.ReadLine();

            }
            Console.WriteLine("Dalyvauja");
            for (int i = dalyvaujanciuVardai.Length -1; i >= 0; i--)
            {
                Console.WriteLine("Ilgiausi vardai");
                Console.WriteLine(dalyvaujanciuVardai[i]);
            }


        }


        /*

        4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
        Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
        ada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane. 
        Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.            
        Pvz:             
        3            
        Edvinas
        Jonas
        Petras---------------------
        Edvinas

        */

        public static void Uzduotis_4()
        {
            Console.WriteLine("Iveskite kiek zmoniu atejo i paskaita");
            int atejoIpamoka = Convert.ToInt32(Console.ReadLine());
            string[] vardai = new string[atejoIpamoka];
            int Max = 0;

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.WriteLine("Iveskite varda");
                vardai[i] = Console.ReadLine();
            }

            //Susikuriam kintamaji ir susirandame masyve, kuris indeksas yra ilgiausias, bei priskiriame ji naujam kintamajam
            for (int i = 0; i < vardai.Length; i++)
            {
                if (vardai[i].Length > Max)
                {
                    Max = vardai[i].Length;
                }
            }

            // paleidziame nauja cikla, kuris suranda naujai sukurto kintamajo reiksmes ir kai jas randa isveda i ekrana
            Console.WriteLine("Ilgiausius vardus turi");
            for (int i = 0; i < vardai.Length; i++)
            {
                if (vardai[i].Length == Max) 
                { 
                    Console.WriteLine(vardai[i]); 
                }
            }
        }


        /*         * 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane         
         *         * PVZ: 1,2,2,4,2,7,6,1        
         *         * Pasikartojantys skaiciai: 1, 2         */


        public static void Uzduotis_5()
        {
            int[] skaiciaiMasyve = new int[] { 1, 2, 2, 4, 2, 7, 6, 1 };

            for (int i = 0; i < skaiciaiMasyve.Length; i++)
            {
                int pasikartojantysskaiciai = 0;
                for (int j = 0; j < skaiciaiMasyve.Length; j++)
                {

                    if (skaiciaiMasyve[i] == skaiciaiMasyve[j])
                        pasikartojantysskaiciai = pasikartojantysskaiciai + 1;
                }
                Console.WriteLine("\t\n " + skaiciaiMasyve[i] + " Pasikartoja " + pasikartojantysskaiciai + " Kartus");
            }
            Console.ReadKey();

        }

        
        /*
       * 6. Uzdavinys.Programa praso ivesti eiluciu ir stulpeliu kieki.Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
               PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3
        */
        static void Uzduotis_6()
        {
             Console.WriteLine("Iveskite eiluciu kieki");
                int eilutes = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Iveskite stulpeliu kieki");
                int stulpeliai = Convert.ToInt32(Console.ReadLine());

            int[,] masyvas = new int[eilutes, stulpeliai];

            Console.WriteLine("Iveskite skaicius");

            for (int i = 0; i < stulpeliai; i++)
            {
                for (int j = 0; j < eilutes; j++)
                {
                    masyvas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < masyvas.GetLength(0); i++)
            {
                for (int j = 0; j < masyvas.GetLength(1); j++)
                {
                    Console.Write($"  {masyvas[i, j]} ");
                }
                Console.WriteLine();
            }
        }





    }

}
