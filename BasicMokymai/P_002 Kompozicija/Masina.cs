using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_002_Kompozicija
{
    //Klase aprasoma tik auto implementet properciais
    internal class Masina
    {
        public string Gamintojas { get; set; }
        public string modelis { get; set; }
        public int GamybosMetai { get; set; }
        public bool ArDrausta { get; set; }
        public string SavininkoVardas { get; set; }
        public int DuruKiekis { get; set; }
        public string VariklioTipas { get; set; }
        public double MaksimaliGalia { get; set; }
        public double EmisijuKiekis { get; set; }
        public int DidziausiasGreitis { get; set; }
        public int Pagreitis { get; set; }
        public string Spalva { get; set; }
        public double Aukstis { get; set; }
        public double Plotis { get; set; }
        public double Ilgis { get; set; }
        public double KedziuKiekis { get; set; }

        public ApsaugosSistema apsaugosSistema { get; set; }
    }
}
