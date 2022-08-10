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
            Savininkas = new Savininkas();
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

        public Knyga(string virselioTipas, int lapuSkaicius, string autorius, int tirazoSkaicius, string leidykla, string zanras, Savininkas savininkas) : this(virselioTipas, lapuSkaicius, autorius, tirazoSkaicius, leidykla, zanras)
        {
            Savininkas = savininkas;
        }

        public string VirselioTipas { get; private set; }
        public int LapuSkaicius { get; private set; }
        public string Autorius { get; private set; }
        public int TirazoSkaicius  { get; private set; }
        public string Leidykla { get; private set; }
        public string Zanras { get; private set; }
        public Savininkas Savininkas { get; private set; } = new Savininkas();


    }
}
