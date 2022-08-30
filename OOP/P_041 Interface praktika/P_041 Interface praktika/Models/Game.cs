using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    internal class Game : IHobby
    {
        public Game()
        {
        }

        public Game(int id, string platform, bool isMultiPlayer, string name, string publisher, string genre, int rating)
        {
            Id = id;
            Platform = platform;
            IsMultiPlayer = isMultiPlayer;
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public int Id { get; set; }
        public string Platform { get; set; }
        public bool IsMultiPlayer { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public string GetHobbyInformation()
        {
            return $"Tai yra {Genre} žanro žaidimas, kurio įvertinimas yra {Rating}";
        }

        public string GetHobbyName()
        {
            return "Žaidimas";
        }
    }
}

