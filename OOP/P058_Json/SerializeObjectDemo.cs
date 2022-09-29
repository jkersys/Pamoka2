using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public class SerializeObjectDemo
    {
        public static void Show()
        {
            var author = new Author
            {
                Name = "Vardenis Pavardenis",
                Courses = new string[] { "C#", "Java" },
                Happy = true,
            };
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Objekto serelizavimas");
            string json = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(json);

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Kolekcijos serelizavimas");
            //string json = JsonConvert.SerializeObject(author, Formatting.Indented);
            //Console.WriteLine(json);
        }
    }
}
