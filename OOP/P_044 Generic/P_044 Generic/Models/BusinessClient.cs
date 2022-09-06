using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class BusinessClient : IUser
    {
        public BusinessClient()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
