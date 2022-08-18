using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_uzduotis_5
{
    internal class Hobis
    {
        public Hobis()
        {
            Id = 123456789;
            Tekstas = "Nenurodytas";
            TekstasLietuviskai = "Nenurodytas";
        }

        public Hobis(string tekstas, string tekstasLietuviskai)
        {
            Tekstas = tekstas;
            TekstasLietuviskai = tekstasLietuviskai;
        }

        public int Id { get; set; }
        public string Tekstas { get; private set; }
        public string TekstasLietuviskai { get; private set; }

    }
}
