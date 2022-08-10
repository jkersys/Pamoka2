using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    /*public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.     
     * * private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje ar struktūroje.     
     * * internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly kode, bet ne iš kito assembly kodo.     
     * * protected: tipą arba narį galima pasiekti tik pagal kodą toje pačioje klasėje arba klasėje, kuri yra išvesta iš tos klasės(Paveldėta).
    */

    internal class PrieinamumoPavyzdineKlase
    {
        public string vardas;
        private string pavarde;
    }
}