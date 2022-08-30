using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Interface
{
    public interface IMatematika
    {
        public int Prideti(int skaicius);
        public int Atimti(int skaicius);
        public int Padauginti(int skaicius);
        public int Padalinti(int skaicius);
        double PakeltiKvadratu();
        int PakeltiKubu();
    }
}