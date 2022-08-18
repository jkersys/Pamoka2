using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_033_OOP_Metodai
{
    public class Staciakampis
    {
        public Staciakampis(double ilgis, double plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public double Ilgis { get; set; }
        public double Plotis { get; set; }

        //naudojam non-static metoda tam kad galetume dirbti su konkrecia instancija/objektu
        public double ApskaiciuotiPlota() // statinis Program Main metodas
        {
            return Ilgis * Plotis;
        }
    }
}
