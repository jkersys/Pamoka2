using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class Fork : Tool, ITool
    {
        public Fork() { }

        public Fork(string name) { }

        public int Id { get; set; }
        public int Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("This is a fork which is used for eating hard food.");
        }

        public override string ToString()
        {
            return "I am a fork. Here is some text that I wanted to say.";
        }
    }
}