using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_002_Kompozicija
{
    internal class Knyga
    {
        public string VirselioTipas { get; set; }
        public int LapuSkaicius { get; set; }
        public string Autorius { get; set; }
        public int TirazoSkaicius  { get; set; }
        public string Leidykla { get; set; }
        public string Zanras { get; set; }
        public Savininkas savininkas;


    }
}
