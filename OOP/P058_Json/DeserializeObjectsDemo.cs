using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public class DeserializeObjectsDemo
    {
        internal static void Show()
        {
            string jsonString = @"{
    'name':'Vardenis Pvardenis',
'courses':['C#', 'T-SQL'],
'happy':true}";
            Author authorObj = JsonConvert.DeserializeObject<Author>(jsonString);
            Console.WriteLine($"Vardas yra {authorObj.Name}");
            authorObj.Name = "Jonas Jonaitis";
            Console.WriteLine($"Pakeistas vardas yra {authorObj.Name}");
        }
    }
}
