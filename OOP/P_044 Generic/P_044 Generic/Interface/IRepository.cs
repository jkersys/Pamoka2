using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Interface
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Print();
        List<T> Fetch();
    }
}
