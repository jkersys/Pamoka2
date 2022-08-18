using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr._2_Skaičiuoklis
{
    internal class Skaiciuoklis
    {
        private int? Skaicius { get; set; }

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


        public void Reset() 
        {
            //nesigavo nuresetint be param
       
        }


    }
}
