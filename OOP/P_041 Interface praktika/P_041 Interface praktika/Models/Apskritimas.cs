using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    public class Apskritimas : Figura, IGeometrija
    {
        public double Radius { get; }

        public Apskritimas(double radius) : base("Apskritimas")
        {
            Radius = radius;
        }

        public double Perimetras()
        {
            return 2 * Math.PI * Radius;
        }

        public double Plotas()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
