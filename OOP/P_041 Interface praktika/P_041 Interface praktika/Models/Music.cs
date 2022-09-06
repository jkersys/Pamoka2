using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    internal class Music : IHobby
    {
        public Music()
        {
        }

        public Music(int id, double length, string artistName, string name, string publisher, string genre, int rating)
        {
            Id = id;
            Length = length;
            ArtistName = artistName;
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public int Id { get; set; }
        public double Length { get; set; }
        public string ArtistName { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public string GetHobbyInformation()
        {
            return $"Tai yra {Genre} žanro daina, kurios įvertinimas yra {Rating}, Leidėjas {Publisher}";
        }

        public string GetHobbyName()
        {
            return "Daina";
        }
    }
}
