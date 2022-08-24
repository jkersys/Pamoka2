using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_0035_Data_Reading.Modeliai
{
    public class User
    {
        //public User(string[] userData)
        //{
        //    Id = Convert.ToInt32(userData[0]);
        //    Name = userData[1];
        //}
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public User(string[] userData)
        {
            Id= Convert.ToInt32(userData[0]);
            Name= userData[1];
            LastName = userData[2];
            ElPastas = userData[3];
            Lytis = userData[4];

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Lytis { get; set; }
        public string ElPastas { get; set; }

    }
}
