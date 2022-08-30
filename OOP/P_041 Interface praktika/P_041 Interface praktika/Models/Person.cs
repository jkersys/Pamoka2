using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    public class Person  : IPerson
    {
        public Person()
        {
        }

        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public Person(int id, string name, string lastName, List<IHobby> favoriteHobbies, List<IHobby> checkOutList) : this(id, name, lastName)
        {
            FavoriteHobbies = favoriteHobbies;
            CheckOutList = checkOutList;
        }

        public int Id { get; set; } 
        public string Name { get; set; } 
        public string LastName { get; set; }

        public List<IHobby> FavoriteHobbies { get; set; } = new List<IHobby>();
        List<IHobby> CheckOutList { get; set; } = new List<IHobby>();

        public List<string> FindMatchingGenres(Person person, string hobbyType)
        {
            throw new NotImplementedException();
        }

        public List<IHobby> FindSimilarHobbies(Person person)
        {
            throw new NotImplementedException();
        }

        public List<IHobby> FindSimilarHobbies(Person person, string hobbyType)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> GetEachHobbyAvgRating()
        {
            throw new NotImplementedException();
        }

        public List<IHobby> GetFavoriteFromEachHobby()
        {
            throw new NotImplementedException();
        }

        public IHobby GetFavoriteHobby()
        {
            throw new NotImplementedException();
        }

        public string GetFavoriteHobbyType()
        {
            throw new NotImplementedException();
        }

        public string GetFavoriteMusicGenre()
        {
            throw new NotImplementedException();
        }

        public void Interact(IHobby paduodamaReiksme)
        {
            Console.WriteLine($"“{Name} will now watch a {paduodamaReiksme.Name} which is a {paduodamaReiksme.Genre} movie");
        }

        public void ShareHobbies(Person person)
        {
            throw new NotImplementedException();
        }

        public void ShareOldMovies(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
