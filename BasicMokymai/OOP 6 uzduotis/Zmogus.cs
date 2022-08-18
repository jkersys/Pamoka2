using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_uzduotis
{
    /*
     * Access Modifiers (Prieinamumo modifikuotojai)
     * 
     * public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.
     * private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje (ar struktūroje).
     * internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly(Projekto) kode, bet ne iš kito assembly kodo.
     * protected: (Eisim kada prieisime paveldimumo/inheritence tema)
     */
    public class Zmogus
    {
        public Zmogus() { }
        public Zmogus(int zmogausNamoKambariuSkaicius)
        {
            Namas = new Namas(zmogausNamoKambariuSkaicius)
            {
                YraDarzas = true
            };
        }

        public Zmogus(string pavarde)
        {
            Pavarde = pavarde;
        }

        public Zmogus(string vardas, string pavarde) : this(pavarde)
        {
            Vardas = vardas;
        }

        public Zmogus(string vardas, Namas namas, string pavarde) : this(pavarde)
        {
            Namas = namas;
            Vardas = vardas;
        }

        public Zmogus(string vardas, Namas namas, string pavarde, Bendrabutis bendrabutis, string pilnasVardas) : this(vardas, namas, pavarde)
        {
            Bendrabutis = bendrabutis;
            PilnasVardas = pilnasVardas;
        }

        public string Vardas { get; private set; }
        public Namas Namas { get; private set; }
        public string Pavarde { get; private set; }
        public Bendrabutis Bendrabutis { get; set; }
        public string PilnasVardas
        {
            get { return Vardas + " " + Pavarde; }
            set
            {
                var splittedVardas = value.Split(" ");
                Vardas = splittedVardas[0];
                Pavarde = splittedVardas[1];
            }
        }
    }
}