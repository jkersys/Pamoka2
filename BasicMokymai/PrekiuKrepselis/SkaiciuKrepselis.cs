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
            Skaiciai = skaiciai;
        }

        public List<int> Skaiciai { get; set; } = new List<int>();




     



         public void PridetiSkaiciu(int skaicius)
        {
            var skaiciai = new List<int>();
            skaiciai.Add(skaicius);
        }
           
            
           
            
        }

        //public static void ApskaiciuotiVidurki()
        //{
        
        //}


    }

