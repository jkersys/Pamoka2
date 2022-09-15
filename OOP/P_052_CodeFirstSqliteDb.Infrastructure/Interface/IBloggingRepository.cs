using P052_CodeFirstSqliteDbDomain.Models;

namespace P_052_CodeFirstSqliteDb.Infrastructure.Interface
{
    public interface IBloggingRepository
    {
        public void AddPerson(Person person);
        public void AddPerson(string firstName, string lastName, DateTime? birthDay);
        public void PrintAllPersons();
        public void PrintAllPersonsSorted();
        public void AddAnimals(Animal animal);
        public void AddAnimals(string name, string type, DateTime? birthDay);
        public void PrintAllAnimals();
        public void PrintAllAnimalsSorted();


    }
}