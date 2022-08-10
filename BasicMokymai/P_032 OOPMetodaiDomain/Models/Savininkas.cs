using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class Savininkas
    {
        public Savininkas()
        {
            Vardas = "Nenurodytas";
            Lytis = "Nenurodyta";
        }
        public string Lytis { get; set; }
        public string Vardas { get; set; }
        public int Amzius { get; set; }
    }
}
