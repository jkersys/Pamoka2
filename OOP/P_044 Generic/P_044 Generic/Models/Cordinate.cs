using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class Cordinate<T> : ICordinate
    {
        public Cordinate()
        {
        }

        public Cordinate(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; } 
        public T Y { get; set; } 

        public string GetCordinate()
        {
         return $"{X.ToString()};{Y.ToString()}";
        }

        public void ResetCordinate()
        {
            X = default(T);
            Y = default(T); 
        }
    }
}
