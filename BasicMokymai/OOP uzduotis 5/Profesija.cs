using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_uzduotis_5
{
    internal class Profesija
    {
        public Profesija()
        {
            Id = 987654321;
            Tekstas = "Tekstas";
            TekstasLietuviskai = "TekstasLietuviskai";
        }

        public Profesija(int id, string tekstas, string tekstasLietuviskai)
        {
            Id = id;
            Tekstas = tekstas;
            TekstasLietuviskai = tekstasLietuviskai;
        }

        public int Id { get; private set; }
        public string  Tekstas { get; private set; }
        public string  TekstasLietuviskai { get; private set; }

    }
}
