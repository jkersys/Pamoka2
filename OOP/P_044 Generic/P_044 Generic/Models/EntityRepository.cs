using P_044_Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models
{
    public class EntityRepository<T> : IRepository<T> where T : IUser
    {
        public void Add(T input)
        {
            _entities.Add(input);
        }
        public void Remove(T input)
        {
            _entities.Remove(input);
        }
          
        public void Print()
        {
            foreach (var entity in _entities)
            {
                Console.WriteLine(entity.Name);
            }
        }

        public List<T> Fetch() => _entities;
     

        private List<T> _entities = new List<T>();

        public EntityRepository(List<T> entities)
        {
            _entities = entities;
        }

        public EntityRepository()
        {
        }
    }
}
