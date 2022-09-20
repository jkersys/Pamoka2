using P_054_batu_parduotuve.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Services
{
    public interface IParduotuveRepository
    {
        List<Batas> GetBatai();
        void InsertPardavimasIrSumazintiKieki(int dydzioId, int kiekis);
    }
}

