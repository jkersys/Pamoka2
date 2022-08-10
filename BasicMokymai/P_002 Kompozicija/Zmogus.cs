using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_002_Kompozicija
{

    //class zmogus yra tas pats kas internal class zmogus
    internal class Zmogus
    {   //klase aprasome tik public fieldais (fieldai kai netirum get; ir set;)
        public string vardas;
        public string pavarde;
        public string gimimoMetai;
        public string pareigos;
        public string asmenybesTipas;
        public string akiuSpalva;
        public string lytis;
        public string gimimoSalis;
        public string megstamiausiasHobis;
        public string pinigai;
        public string issilavinimas;
        public List<string> masinos;
        public Augintinis augintinis;
    }
}
