﻿using P_054_batu_parduotuve.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Infrastructure.Database.InitialData
{
    public static class BatuDydisInitialData
    {
        public static BatuDydis[] DataSeed => new BatuDydis[]
        {
        new BatuDydis {Id = 1, BatasId = 1, Dydis = 42, Kiekis = 10 },
        new BatuDydis {Id = 2, BatasId = 1, Dydis = 43, Kiekis = 11 },
        new BatuDydis {Id = 3, BatasId = 1, Dydis = 44, Kiekis = 12 },
        new BatuDydis {Id = 4, BatasId = 1, Dydis = 45, Kiekis = 13 },
        //--------------------------------------------
        new BatuDydis {Id = 5, BatasId = 2, Dydis = 36, Kiekis = 10 },
        new BatuDydis {Id = 6, BatasId = 2, Dydis = 37, Kiekis = 11 },
        new BatuDydis {Id = 7, BatasId = 2, Dydis = 38, Kiekis = 12 },
        new BatuDydis {Id = 8, BatasId = 2, Dydis = 39, Kiekis = 13 },
        //-----------------------------
        new BatuDydis {Id = 9, BatasId = 3, Dydis = 30, Kiekis = 10 },
        new BatuDydis {Id = 10, BatasId = 3, Dydis = 31, Kiekis = 11 },
        new BatuDydis {Id = 11, BatasId = 3, Dydis = 32, Kiekis = 12 },
        new BatuDydis {Id = 12, BatasId = 3, Dydis = 33, Kiekis = 13 },
        };
    }
}
