using Pirma_uzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_DB_Dapper.Database
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public IEnumerable<Product> Get();
        public int Delete(string name);
    }
}
