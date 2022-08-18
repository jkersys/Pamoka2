using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_uzduotis
{

    public class Bendrabutis
    {

        public int BendrabucioId { get; set; }
        public int KambariuSkaicius { get; set; }
        public double Kaina { get; set; }
        public List<Zmogus> Zmones { get; set; } = new List<Zmogus>();

        public Bendrabutis()
        {
            BendrabucioId = 0;
            KambariuSkaicius = 0;
            Kaina = 0;
            var Zmones = new List<Zmogus>();
           
            
    }
        public Bendrabutis(Zmogus zmogus)
        {
        Zmones.Add(zmogus);
        }
        

        public Bendrabutis(int bendrabucioId, int kambariuSkaicius, double kaina, List<Zmogus> zmones)
        {
            BendrabucioId = bendrabucioId;
            KambariuSkaicius = kambariuSkaicius;
            Kaina = kaina;
            Zmones = zmones.ToList();
        }
        

    }
}
