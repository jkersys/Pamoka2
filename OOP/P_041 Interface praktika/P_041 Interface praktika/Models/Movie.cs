using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    internal class Movie : IHobby
    {
        public Movie()
        {
        }

        public Movie(int id, int creationDate, string name, string publisher, string genre, int rating)
        {
            Id = id;
            CreationDate = creationDate;
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public int Id { get; set; }
        public int CreationDate { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public string GetHobbyInformation()
        {
            return $"Tai yra filmas {Genre} žanro filmas, kurio įvertinimas yra {Rating}";
        }

        public string GetHobbyName()
        {
            return "Filmas";
        }
    }
}
