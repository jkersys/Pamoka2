using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    public class StatusisTrikampis : Figura, IGeometrija
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public StatusisTrikampis(double a, double b, double c) : base("Statusis trikampis")
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimetras()
        {
            return A + B + C;
        }

        public double Plotas()
        {
            return ((A * B) / 2);
        }
    }
}
