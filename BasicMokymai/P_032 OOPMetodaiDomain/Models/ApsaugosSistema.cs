﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class ApsaugosSistema
    {
        public ApsaugosSistema()
        {
            Pavadinimas = "Nenurodyta";
            Gamintojas = "Nenurodyta";
        }

        public int Lygis { get; set; }
        public string Pavadinimas { get; set; }
        public string Gamintojas { get; set; }
        public string Rusis { get; set; }
    }
}