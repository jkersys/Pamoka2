using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class Knyga
    {
        public Knyga()
        {
            VirselioTipas = "Kietas";
            LapuSkaicius = 40;
            Autorius = "Marksas";
            Zanras = "Traktatas";
            savininkas = new Savininkas();
        }

        public Knyga(string virselioTipas, int lapuSkaicius, string autorius, int tirazoSkaicius, string leidykla, string zanras)
        {
            VirselioTipas = virselioTipas;
            LapuSkaicius = lapuSkaicius;
            Autorius = autorius;
            TirazoSkaicius = tirazoSkaicius;
            Leidykla = leidykla;
            Zanras = zanras;
        }
        public Knyga(Knyga knyga)
        {
            VirselioTipas = knyga.VirselioTipas;
            LapuSkaicius = knyga.LapuSkaicius;
            Autorius = knyga.Autorius;
            TirazoSkaicius = knyga.TirazoSkaicius;
            Leidykla = knyga.Leidykla;
            Zanras = knyga.Zanras;
        }

        public string VirselioTipas { get; set; }
        public int LapuSkaicius { get; set; }
        public string Autorius { get; set; }
        public int TirazoSkaicius  { get; set; }
        public string Leidykla { get; set; }
        public string Zanras { get; set; }
        public Savininkas savininkas;


    }
}
