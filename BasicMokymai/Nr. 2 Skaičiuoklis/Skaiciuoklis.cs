using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr._2_Skaičiuoklis
{
    internal class Skaiciuoklis
    {
        private int Skaicius { get; set; }
        public int skaicius;

        public Skaiciuoklis()
        {

        }

        public Skaiciuoklis(int skaicius)
        {
            Skaicius = skaicius;
            
        }

        public void Didinti()
        {
            Skaicius++;
        }

        public void Mazinti()
        {
            if (Skaicius != 0)
            Skaicius--;
            else 
            {
                Console.WriteLine("Skaicius negali buti lygus nuliui");
                return;
            }


        }

        public void Atspausdinimas()
        {
            Console.WriteLine($"Skaičius: {Skaicius}");
        }


        public int Reset() 
        {
            return this.skaicius;
       
        }


    }
}
