using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekiuKrepselis
{
    public class SkaiciuKrepselis
    {
        public SkaiciuKrepselis()
        {

        }

        public SkaiciuKrepselis(List<int> skaiciai)
        {
            SkaiciuSarasas = skaiciai;
        }

        private List<int> SkaiciuSarasas { get; set; } = new List<int>();



        public void PridetiSkaiciu(int skaicius)
        {

            SkaiciuSarasas.Add(skaicius);
        }

        public double SkaiciuVidurkis()
        {
            var vidurkis = 0;
            foreach (var skaicius in SkaiciuSarasas)
            {
                vidurkis += skaicius;
            }

            vidurkis = vidurkis / SkaiciuSarasas.Count;

            return vidurkis;




        }
    }
}
        


    

