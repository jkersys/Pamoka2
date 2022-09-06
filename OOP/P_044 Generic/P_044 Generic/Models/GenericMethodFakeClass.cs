using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class GenericMethodFakeClass
    {
        public bool Post<TPost>(TPost post) where TPost : IPost
        {
            if (typeof(TPost) == typeof(Tool) || typeof(TPost) == typeof(DateTime))
            {
                return false;
            }
            return true;
        }
        public void Print<T>(T pritableData)
        {
            Console.WriteLine(pritableData);
        }
    }
}
