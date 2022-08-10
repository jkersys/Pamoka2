using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class Salis
    {
        public Salis()
        {
            Zemynas = "Nenurodyta";
            GyventojuSkaicius = 50000;
            NacionalineKalba = "Nenurodyta";
            ValdymoForma = "Nenurodyta";
        }
        public Salis(string zemynas, int gyventojuSkaicius, string nacionalineKalba, string valdymoForma)
        {
            Zemynas = zemynas;
            GyventojuSkaicius = gyventojuSkaicius;
            NacionalineKalba = nacionalineKalba;
            ValdymoForma = valdymoForma;
        }

        public Salis(Salis salis)
        {
            Zemynas = salis.Zemynas;
            GyventojuSkaicius = salis.gyventojuSkaicius;
            NacionalineKalba = salis.nacionalineKalba;
            ValdymoForma = salis.valdymoForma;
        }

        public Salis(string zemynas, int gyventojuSkaicius, string nacionalineKalba, string valdymoForma, int populiacija, double plotas, ValdziosInstitucis valdziosInstitucis)
        {
            Zemynas = zemynas;
            GyventojuSkaicius = gyventojuSkaicius;
            NacionalineKalba = nacionalineKalba;
            ValdymoForma = valdymoForma;
            Populiacija = populiacija;
            Plotas = plotas;
            this.valdziosInstitucis = valdziosInstitucis;
        }

        private string zemynas;

        public string Zemynas
        {
            get { return zemynas; }
            private set { zemynas = value; }
        }

        private int gyventojuSkaicius;

        public int GyventojuSkaicius
        {
            get { return gyventojuSkaicius; }
            private set { gyventojuSkaicius = value; }
        }
        private string nacionalineKalba;

        public string NacionalineKalba
        {
            get { return nacionalineKalba; }
            private set { nacionalineKalba = value; }
        }
        private string valdymoForma;

        public string ValdymoForma
        {
            get { return valdymoForma; }
            private set { valdymoForma = value; }
        }
        private int populiacija;

        public int Populiacija
        {
            get { return populiacija; }
            private set { populiacija = value; }
        }
        private double plotas;

        public double Plotas
        {
            get { return plotas; }
            private set { plotas = value; }
        }
        private ValdziosInstitucis valdziosInstitucis { get; set; }

    }
}
