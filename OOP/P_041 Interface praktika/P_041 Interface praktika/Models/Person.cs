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
            Dictionary<string, int> favoriteHobbyOCCurance = new Dictionary<string, int>();
            List<string> allHobbyType = GetHobbyType();cf
            foreach (string hobby in allHobbyType)
            {
                favoriteHobbyOCCurance.Add(hobby, 0);
            }
            foreach (IHobby hobby in FavoriteHobbies)
            {
                favoriteHobbyOCCurance[hobby.GetHobbyName()] += 1;
            }
            favoriteHobbyOCCurance.Sort
        }
        private List<string> GetHobbyType()
        {
            List<string> result = new List<string>();

            foreach (var hobby in FavoriteHobbies)
            {
                string hobbyName = hobby.GetHobbyName();
                if(!result.Contains(hobbyName))
                result.Contains(hobby.GetHobbyName());
            }
            return result;
        }

        public string GetFavoriteHobbyType()
        {
          FavoriteHobbies.Sort((h1, h2) => h1.Rating.CompareTo(h2.Rating));
            return FavoriteHobbies.FirstOrDefault().Name;
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
