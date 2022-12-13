using CarApiAiskinimas.Database;
using CarApiAiskinimas.Models;

namespace CarApiAiskinimas.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> All()
        {
            return _context.Cars;
        }

        public int Count()
        {
            return _context.Cars.Count();
        }

        public int Create(Car entity)
        {
            _context.Cars.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public bool Exist(int id)
        {
            return _context.Cars.Any(x => x.Id == id);
        }

        public IEnumerable<Car> Find(System.Linq.Expressions.Expression<Func<Car, bool>> predicate)
        {
            return _context.Cars.Where(predicate);
        }

        public Car Get(int id)
        {
            return _context.Cars.First(x => x.Id == id);
        }

        public void Remove(Car entity)
        {
            _context.Cars.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Car entity)
        {
            _context.Cars.Update(entity);
            _context.SaveChanges();
        }
    }
}
