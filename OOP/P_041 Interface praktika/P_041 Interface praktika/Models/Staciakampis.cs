using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    internal class Staciakampis : Figura, IGeometrija
    {


        public Staciakampis()
        {

        }
        public Staciakampis(double ilgis, double plotis) : base("Staciakampis")
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public double Ilgis { get; }
        public double Plotis { get; }

        public double Perimetras()
        {
            return Ilgis + Ilgis + Plotis + Plotis;      
        }

        public double Plotas()
        {
            return Ilgis * Plotis;
        }
    }
}
