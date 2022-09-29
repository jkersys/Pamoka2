using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public class SerializeDeserializeDemo
    {
        public static void Show()
        {
            string json = InitialData.Samples.SingleJson();
            Console.WriteLine("Išvedame JSON tekstą");
            Console.WriteLine(json);
            Console.WriteLine("------------------------------------------");
            Author author = JsonConvert.DeserializeObject<Author>(json);
            Console.WriteLine($"vardas yra : {author.Name}");
            author.Name = "Jonas Jonaitis";
            Console.WriteLine($"vardas yra : {author.Name}");
            Console.WriteLine("------------------------------------------");
            string naujasJson = JsonConvert.SerializeObject(json);
            Console.WriteLine(naujasJson);
            //Console.WriteLine("------------------------------------------");
            //string naujasJson = JsonConvert.SerializeObject(author, );
            //Console.WriteLine(naujasJson);

        }

        public static void Uzdavinys1()
        {
            List<string> games = new List<string> { "Starcraft", "Halo", "Legend of Zelda" };
            string gamesJson = JsonConvert.SerializeObject(games);
            Console.WriteLine(gamesJson);
        }

        public static void Uzdavinys2()
        {
            Dictionary<string, int> points = new Dictionary<string, int>
        {
            { "James", 9001 },
            { "Jo", 3474 },
            { "Jess", 11926 }
        };

            string pointsJson = JsonConvert.SerializeObject(points, Formatting.Indented);
            Console.WriteLine(pointsJson);
        }

        public static void Uzdavinys3()
        {
            var account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
              {
                  "User",
                  "Admin"
              }
           
        };
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Objekto serelizavimas");
            string accountJson = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(accountJson);
        }
    }
}

