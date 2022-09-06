using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class Keyboard : ITool
    {
     
        public string Button { get; set; }
        public int Id { get; set ; }
        public int Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("This is a keyboard which is used for typing things into the computer.");
        }
    }
}
