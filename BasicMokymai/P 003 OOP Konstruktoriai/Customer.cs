using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class Customer
    {
        // Tuscio konstruktoriaus deklaravimas
        public Customer()
        {
            Vardas = "Stiuartas";
        }

        public Customer(string vardas)
        {
            Vardas = vardas;
        }


        public string Vardas { get; set; }
    }
}