using P_041_Interface_praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Interface
{
    internal interface IPerson
    {
        void Interact(IHobby atspausdinimas);
        string GetFavoriteHobbyType();
        IHobby GetFavoriteHobby();
        List<IHobby> GetFavoriteFromEachHobby();
        String GetFavoriteMusicGenre();
        Dictionary<string, int> GetEachHobbyAvgRating();
        void ShareHobbies(Person person);
        void ShareOldMovies(Person person);
        List<IHobby> FindSimilarHobbies(Person person);
        List<IHobby> FindSimilarHobbies(Person person, string hobbyType);
        List<string> FindMatchingGenres(Person person, string hobbyType);
    }
}
