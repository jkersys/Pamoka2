using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirma_uzduotis.Database.Dapper
{
    public interface IDatabaseBootstrap
    {
        void Setup();
    }
}