﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_003_OOP_Konstruktoriai
{
    internal class Augintinis
    {
        public Augintinis()
        {
            Vardas = "Bevardis";
            GimimoMetai = 1900;
        }

        public string Vardas { get; set; }
        public int GimimoMetai { get; set; }
        public string Rusis { get; set; }
        public string Budas { get; set; }
    }
}