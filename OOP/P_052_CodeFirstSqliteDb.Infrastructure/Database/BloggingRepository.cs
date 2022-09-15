using P_052_CodeFirstSqliteDb.Infrastructure.Interface;
using P052_CodeFirstSqliteDbDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_052_CodeFirstSqliteDb.Infrastructure.Database
{

    public class BloggingRepository : IBloggingRepository
    {
        public BloggingRepository()
        {
            using var context = new BloggingContext();
            // naudojam kaip pavyzdi, kad zinoti jog yra budas patikrinti ar duonbaze siuo metu egzistuoja
            //Jei neegzistuoja uz mus buna paleidziam komanda update-database
            context.Database.EnsureCreated();

        }
              

        public void AddPerson(Person person)
        {
            using var context = new BloggingContext();
            context.Persons.Add(person);//pridedam perduota person i musu DbContext
            context.SaveChanges();//tai yra galutine vieta, kuri igyvendina jau suformuota uzklausa EntityFramework pagalba
        }

        public void AddPerson(string firstName, string lastName, DateTime? birthDay)
        {
            using var context = new BloggingContext();

            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDay = birthDay
            };

            context.Persons.Add(person); // Pridedame perduota person i musu DbContext
            context.SaveChanges();
        }
        public void AddAnimals(Animal animal)
        {
            using var context = new BloggingContext();
            context.Animals.Add(animal);//pridedam perduota animal i musu DbContext
            context.SaveChanges();//tai yra galutine vieta, kuri igyvendina jau suformuota uzklausa EntityFramework pagalba
        }

        public void AddAnimals(string name, string type, DateTime? animalBirthDay)
        {
            using var context = new BloggingContext();

            Animal animal = new Animal
            {
                Name = name,
                Type = type,
                BirthDate = animalBirthDay,
            };

            context.Animals.Add(animal); // Pridedame perduota person i musu DbContext
            context.SaveChanges();
        }

        public void PrintAllAnimals()
        {
            using var context = new BloggingContext();
            var animals = context.Animals;

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId}. {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }

        public void PrintAllAnimalsSorted()
        {
            using var context = new BloggingContext();
            var animals = context.Animals
            .OrderBy(a => a.Name);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId}. {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }

        public void PrintAllPersons()
        {
            using var context = new BloggingContext();
            var persons = context.Persons;

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.BirthDay}");
            }
        }

        public void PrintAllPersonsSorted()
        {
            using var context = new BloggingContext();
            var persons = context.Persons
            .OrderBy(p => p.FirstName);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.LastName}");
            }
        }
    }
}