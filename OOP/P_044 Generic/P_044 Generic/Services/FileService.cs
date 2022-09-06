using P_044_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Services
{
    public class FileService
    {
        readonly string _filePath;

        public FileService(string filePath)
        {
            _filePath = filePath;
        }
        public List<Countries> FetchCountriesFromCsv()
        {
            int countryColumnCount = 4;
            List<Countries> countryList = new List<Countries>();
            using StreamReader sr = new StreamReader(_filePath);
            string countryLine;
            string headers = sr.ReadLine();

            while((countryLine = sr.ReadLine()) != null)
            {
                string[] countryData = countryLine.Split(',');
                if (countryData.Length != countryColumnCount)
                {
                    break;
                }

                Countries countries = new Countries(countryData);
                countryList.Add(countries);
            }
            return countryList;
        }

    }
}
