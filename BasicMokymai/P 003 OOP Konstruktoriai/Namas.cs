using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class Namas
    {
        public Namas()
        {
            Tipas = "Murinis";
            AukstuSkaicius = 2;
            StatybosMetai = 1998;
            StogoTipas = "Slaitinis";
            SildymoBudas = "Geoterminis-Grindinis";
            KambariuSkaicius = 7;
        }
        public Namas(string tipas, int aukstuSkaicius, int statybosMetai, string stogoTipas, string sildymoBudas, int kambariuSkaicius)
        {
            Tipas = tipas;
            AukstuSkaicius = aukstuSkaicius;
            StatybosMetai = statybosMetai;
            StogoTipas = stogoTipas;
            SildymoBudas = sildymoBudas;
            KambariuSkaicius = kambariuSkaicius;           
        }


        public string Tipas;
        public int AukstuSkaicius;
        public int StatybosMetai;
        public string StogoTipas;
        public string SildymoBudas;
        public int KambariuSkaicius;
        public Medziagos medziagos;
    }
}
