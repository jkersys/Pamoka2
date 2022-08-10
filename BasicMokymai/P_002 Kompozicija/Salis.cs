using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_002_Kompozicija
{
    internal class Salis
    {
        private string zemynas;

        public string Zemynas
        {
            get { return zemynas; }
            set { zemynas = value; }
        }

        private int gyventojuSkaicius;

        public int GyventojuSkaicius
        {
            get { return gyventojuSkaicius; }
            set { gyventojuSkaicius = value; }
        }
        private string nacionalineKalba;

        public string NacionalineKalba
        {
            get { return nacionalineKalba; }
            set { nacionalineKalba = value; }
        }
        private string valdymoForma;

        public string ValdymoForma
        {
            get { return valdymoForma; }
            set { valdymoForma = value; }
        }
        private int populiacija;

        public int Populiacija
        {
            get { return populiacija; }
            set { populiacija = value; }
        }
        private double plotas;

        public double Plotas
        {
            get { return plotas; }
            set { plotas = value; }
        }
        public ValdziosInstitucis valdziosInstitucis { get; set; }

    }
}
