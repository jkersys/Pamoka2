using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktas
{
    internal class Produktas
    {
        public double Kaina { get; protected set; }
        public int Kiekis { get; protected set; }
        public string Pavadinimas { get; protected set; }

        public Produktas()
        {
          
        }
              
        
        public void ProduktoSpausdinimas()
        {
            Kaina = 1.50;
            Kiekis = 3;
            Pavadinimas = "Kivis";
            Console.WriteLine($"{Pavadinimas} kaina {Kaina}$ kiekis {Kiekis} vnt");
        }

    }
}
