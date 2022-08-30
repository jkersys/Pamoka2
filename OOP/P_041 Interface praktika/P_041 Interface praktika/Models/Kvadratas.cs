using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
   
        public class Kvadratas : Figura, IGeometrija
        {
        public Kvadratas()
        {

        }
            public double Krastine { get; }

            public Kvadratas(double krastine) : base("Kvadratas")
            {
                Krastine = krastine;
            }

            public double Perimetras()
            {
                return 4 * Krastine;
            }

            public double Plotas()
            {
                return Krastine * Krastine;
            }
        }
    }

