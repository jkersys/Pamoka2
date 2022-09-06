using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Interface
{
    public interface ITool
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public void PrintName();
    }
}
