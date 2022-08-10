using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_032_OOPMetodaiDomain.Models
{
    internal class NamasPakeitimams
    {
        public NamasPakeitimams()
        {
            Tipas = "Murinis";
            AukstuSkaicius = 2;
            StogoTipas = "Slaitinis";
            SildymoBudas = "Grindinis";
        }

        public NamasPakeitimams(string tipas, int aukstuSkaicius, string stogoTipas, string sildymoBudas)
        {
            Tipas = tipas;
            AukstuSkaicius = aukstuSkaicius;
            StogoTipas = stogoTipas;
            SildymoBudas = sildymoBudas;
        }

        public NamasPakeitimams(NamasPakeitimams namasPakeitimams)
        {
            Tipas = namasPakeitimams.Tipas;
            AukstuSkaicius = namasPakeitimams.AukstuSkaicius;
            StogoTipas = namasPakeitimams.StogoTipas;
            SildymoBudas = namasPakeitimams.SildymoBudas;
        }

        public NamasPakeitimams(string tipas, int aukstuSkaicius, int statybosMetai, string stogoTipas, string sildymoBudas, int kambariuSkaicius, string medziagos)
        {
            Tipas = tipas;
            AukstuSkaicius = aukstuSkaicius;
            StatybosMetai = statybosMetai;
            StogoTipas = stogoTipas;
            SildymoBudas = sildymoBudas;
            KambariuSkaicius = kambariuSkaicius;
            this.medziagos = medziagos;
        }

        private string Tipas;
        private int AukstuSkaicius;
        private int StatybosMetai;
        private string StogoTipas;
        private string SildymoBudas;
        private int KambariuSkaicius;
        private string medziagos;

    }
}
