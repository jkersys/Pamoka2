namespace P_020_masyvu_kartojimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int[] masyvas = new int[] { 5, 3, 7, 6, 8, 7, 10 };

           // Console.WriteLine(SurikiuotiMasyvaIsEiles(masyvas));
        }


        /*
         *  1. Rasti mažiausią ##
      Duotas vienatis sveikų skaičių masyvas. 
      Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
      { 5, 3, 7, 6, 8, 7, 10 }
      rezultatas:  3
        */

        public static int MaziausiasSkaiciusMasyve(int[] masyvas)
        {
            int maziausias = masyvas[0];


            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] < maziausias)
                {
                    maziausias = masyvas[i];

                }
                
            }
                return maziausias;
        }
        /*
         * 2. ## Rasti didžiausią ##
   Duotas vienatis sveikų skaičių masyvas. 
   Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
   { 5, 3, 7, 6, 8, 7, 10 }
   rezultatas:  10
        */

        public static int RastiDidziausia(int[] masyvas)
        {
            int didziausias = masyvas[0];

            for (int i = 0; i < masyvas.Length; i++)
                if (masyvas[i] < didziausias)
                {
                    didziausias = masyvas[i];
                }
        
            return didziausias;
         }


        /*  Kazkodel braukia return

        public static int SurikiuotiMasyvaIsEiles(int[] masyvas)
        {
            

            for (int i = 0; i < masyvas.Length; i++)
            {
                for (int j = i + 1; j  < masyvas.Length; j++)
                {
                    if (masyvas[i] > masyvas[j])
                    {
                        int temp = masyvas[i];
                        masyvas[i] = masyvas[j];
                        masyvas[j] = temp;

                            
                    }
                }
               
            }
            Console.WriteLine(String.Join(", " masyvas));
             return masyvas;
        }

        */










    }
}