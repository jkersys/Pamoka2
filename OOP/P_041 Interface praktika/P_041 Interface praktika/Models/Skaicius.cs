using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    public class Skaicius : IMatematika
    {
        public Skaicius()
        {
        }
        public Skaicius(int sveikasisSkaicius)
        {
            SveikasisSkaicius = sveikasisSkaicius;
        }

        public int SveikasisSkaicius { get;}
        public int Prideti(int skaicius)
        {
            return SveikasisSkaicius + skaicius;
        }
        public int Atimti(int skaicius)
        {
            return SveikasisSkaicius - skaicius;
        }

        public int Padalinti(int skaicius)
        {
            return SveikasisSkaicius / skaicius;
        }

        public int Padauginti(int skaicius)
        {
            return SveikasisSkaicius * skaicius;
        }

        public int PakeltiKubu()
        {
            return SveikasisSkaicius * SveikasisSkaicius * SveikasisSkaicius;
        }

        public double PakeltiKvadratu()
        {
            return SveikasisSkaicius * SveikasisSkaicius;
        }

        public void SpausdintiSkaiciu()
        {
            Console.WriteLine(SveikasisSkaicius);
        }
    }
}
