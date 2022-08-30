using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Interface
{
    public interface IHobby
    {
        string Name { get; }
        string Publisher { get; }
        string Genre { get; }
        int Rating { get; }
        string GetHobbyName();
        string GetHobbyInformation();


    }
}
