using P_054_batu_parduotuve.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Infrastructure.Database.InitialData
{
    public static class BatasInitialData
    {
        public static Batas[] DataSeed => new Batas[]
        {
            new Batas
            {
                    BatasId = 1,
                    Pavadinimas = "Kedai",
                    Tipas = "Vyriški",
                    Kaina = 100M,
            },
            new Batas
            {
                    BatasId = 2,
                    Pavadinimas = "Kedai",
                    Tipas = "Moteriški",
                    Kaina = 200M,
            },
            new Batas
            {
                    BatasId = 3,
                    Pavadinimas = "Kroksai",
                    Tipas = "Vaikiški",
                    Kaina = 20.21M,
            },
        };
    }
}
