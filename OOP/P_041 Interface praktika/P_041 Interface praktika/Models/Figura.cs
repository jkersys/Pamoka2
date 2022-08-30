using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    public class Figura
    {
        public Figura()
        {
        }

        public Figura(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public string Pavadinimas { get;}
    }
}
