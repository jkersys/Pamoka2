using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class Countries
    {
        public Countries()
        {
        }
        public Countries(string[] countryData)
        {
            Id = Convert.ToInt32(countryData[0]);
            Country = countryData[1];
            Capital = countryData[2];
            IsMarked = Convert.ToInt32(countryData[3]);
        }
        public int Id { get; set; }
        public string Country { get; set; }
        public string Capital { get; set; }
        public int IsMarked { get; set; }


    }
}
