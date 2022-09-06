using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class Administrator : IUser
    {
        public Administrator()
        {
        }

        public Administrator(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
