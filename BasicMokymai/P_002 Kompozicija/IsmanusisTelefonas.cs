using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_002_Kompozicija
{
    //Klase aprasom tik public fully describe properciais
    internal class IsmanusisTelefonas
    {
        private string dimensija;

        public string Dimensija
        {
            get { return dimensija; }
            set { dimensija = value; }
            
        }
        private double svoris;

        public double Svoris
        {
            get { return svoris; }
            set { svoris = value; }
        }
        private string stiklas;

        public string Stiklas
        {
            get { return stiklas; }
            set { stiklas = value; }
        }

        private double rezoliucija;

        public double Rezoliucija
        {
            get { return rezoliucija; }
            set { rezoliucija = value; }
        }
        private string modelis;

        public string Modelis
        {
            get { return modelis; }
            set { modelis = value; }
        }
        private int baterija;

        public int Baterija
        {
            get { return baterija; }
            set { baterija = value; }
        }
        private string kamera;

        public string Kamera
        {
            get { return kamera; }
            set { kamera = value; }
        }
        private int operacinesistema;

        public int OperacineSistema
        {
            get { return operacinesistema; }
            set { operacinesistema = value; }
        }




    }
}
