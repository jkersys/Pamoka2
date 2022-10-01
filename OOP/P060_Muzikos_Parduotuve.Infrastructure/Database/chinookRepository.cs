using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using Muzikos_Parduotuve.Domain.Models;
using Muzikos_Parduotuve.Infrastructure.Interfaces;
using Superpower;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzikos_Parduotuve.Infrastructure.Database
{
    public class chinookRepository : IChinookRepository
    {
        public chinookRepository()
        {
            using var context = new chinookContext();
            // Naudojam kaip pavyzdi, kad zinoti, jog yra budas patikrinti ar duombaze siuo metu egzistuoja.
            // Jei neegzsituoja uz mus buna paleidziama CLI komanda update-datase
            context.Database.EnsureCreated();
        }
             


        public void AddUser(string firstName, string lastName, string? company, string? adress, string? city, string? state, string? country, string? postalCode, string? phone, string? fax, string email)
        {
            using var context = new chinookContext();

            Customer customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Company = company,
                Address = adress,
                City = city,
                State = state,
                Country = country,
                PostalCode = postalCode,
                Phone = phone,
                Fax = fax,
                Email = email

            };



            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public List<Customer> CustomerList()
        {
            using var context = new chinookContext();

            List<Customer> customers = context.Customers.ToList();
            return customers;              
        }

        public void EmployeeLogin()
        {
            const string pin = "1234";
            Console.WriteLine("Enter pin code");
            var pinGuess = Console.ReadLine();

            if (pinGuess == pin)
            {
                //to do
            }

         }            
        
        public List<Track> ShowCatalog()
        {
            using var context = new chinookContext();
           
            List<Track> activeTrack = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).ToList(); ;
            return activeTrack;
        }
       
        public void SearchBy()
        {
            using var context = new chinookContext();
            Console.WriteLine("Pasirinkite pagal ką norite ieškoti");
            Console.WriteLine("1.id");
            Console.WriteLine("2.Name");
            Console.WriteLine("3.Composer");
            Console.WriteLine("4.Genre");
            Console.WriteLine("5.Composer ir Album");
            Console.WriteLine("Q.Grįžti atgal");
            var input = Convert.ToInt64(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Iveskite dainos Id");
                var idInput = Convert.ToInt64(Console.ReadLine());
                var searchById = SongList().Where(i => i.TrackId == idInput).ToList();

                var songById = (from id in searchById
                                where id.TrackId == idInput
                                select id).ToList();

                foreach (var song in songById)
                {
                    Console.WriteLine($"{song.TrackId} {song.Name} {song.UnitPrice}");
                }

            }
            if (input == 2)
            {
                Console.WriteLine("Iveskite dainos pavadinimą");
                var nameInput = Console.ReadLine();
                var searchById = SongList().Where(i => i.Name == nameInput).ToList();

                var songById = (from id in searchById
                                where id.Name == nameInput
                                select id).ToList();

                foreach (var song in songById)
                {
                    Console.WriteLine($"{song.TrackId} {song.Name} {song.Album.Title} {song.UnitPrice} ");
                }
            }
            if (input == 3)
            {
                Console.WriteLine("Iveskite kompozitorių");
                var composerInput = Console.ReadLine();
                var searchById = SongList().Where(i => i.Composer == composerInput).ToList();

                var songById = (from id in searchById
                                where id.Composer == composerInput
                                select id).ToList();

                foreach (var song in songById)
                {
                    Console.WriteLine($"{song.TrackId} {song.Name} {song.Album.Title} {song.UnitPrice}");
                }
            }
            if (input == 4)
            {
                Console.WriteLine("Iveskite dainos žanrą");
                var genreInput = Console.ReadLine();
                var searchById = SongList().Where(i => i.Genre.Name == genreInput).ToList();

                var songById = (from id in searchById
                                where id.Genre.Name == genreInput
                                select id).ToList();

                foreach (var song in songById)
                {
                    Console.WriteLine($"{song.TrackId} {song.Name} {song.Album.Title} {song.UnitPrice}");
                }
            }
            if (input == 5)
            {
                Console.WriteLine("Iveskite kompozitorių");
                var composerInput = Console.ReadLine();
                var searchByComposer = SongList().Where(i => i.Composer == composerInput).ToList();

                var songByComposer = (from id in searchByComposer
                                where id.Composer == composerInput
                                select id).ToList();

                if (songByComposer.Count == 0)
                {
                    Console.WriteLine("Tokio kompozitoriaus saraše nėra");
                }

                Console.WriteLine("Iveskite albumo pavadinimą");
                var albumInput = Console.ReadLine();
                var searchByAlbum = songByComposer.Where(i => i.Album.Title == albumInput).ToList();

                var songByAlbum = (from id in searchByAlbum
                                   where id.Album.Title == albumInput
                                   select id).ToList();

                //if (songById.Count == 0)
                //{
                //    Console.WriteLine("Tokio kompozitoriaus saraše nėra");
                //}
                if (songByAlbum.Count == 0)
                {
                    Console.WriteLine("Tokio albumo saraše nėra");
                }

                else
                    foreach (var song in songByAlbum)
                    {
                        Console.WriteLine($"{song.TrackId} {song.Name} {song.UnitPrice}");
                    }
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Rastos dainos pagal pasirinktą kompozitorių ir albumą");
                foreach (var album in songByAlbum)
                {
                    Console.WriteLine($"{album.TrackId} {album.Name} {album.UnitPrice}");
                }

            }
            if (input == 6)
            {
                Console.WriteLine("Iveskite milisekundes");
                var lengthInput = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("1. Dainos ilgesnės nei įvestas milisekundžių skaičius");
                Console.WriteLine("2. Dainos trumpesnės nei įvestas milisekundžių skaičius");
                var optionInput = Convert.ToInt64(Console.ReadLine());


                if (optionInput == 1)
                {
                    var searchByLength = SongList().Where(i => i.Milliseconds > lengthInput).ToList();

                    var songByLength = (from id in searchByLength
                                    where id.Milliseconds > lengthInput
                                    select id).ToList();                                     
                }
                if (optionInput == 2)
                {
                    var searchByLength = SongList().Where(i => i.Milliseconds < lengthInput).ToList();

                    var songByLength = (from id in searchByLength
                                    where id.Milliseconds < lengthInput
                                    select id).ToList();
                  
                }


                
            }
        }




        //dainų sarašas kurį paduodu atliekant paieską ir rikiavimą
        public List<Track> SongList()
        {
            using var context = new chinookContext();
            {
                var trackList = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).ToList();

                // foreach (var track in trackList)
                // { Console.WriteLine($"Track Id. {track.TrackId} Track name. {track.Name} Track Composer {track.Composer} Track album. {track.Album.Title} Track genre. {track.Genre.Name} Track length. {track.Milliseconds} Track price. {track.UnitPrice}"); }
                return trackList;
            }
        }

        public void AddToBasket()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| #       | Pasirinkimas | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1       | Rasti dainą pagal Id | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 2       | Rasti dainą pagal pavadinimą | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 3       | Rasti dainas pagal albumo Id | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 4       | Rasti dainas pagal albumo pavadinimą | ");
            Console.WriteLine("--------------------------------------------------------------");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                   
                    Console.WriteLine($"'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
                    Console.ReadLine();
                    break;
                case 2:
                   
                    break;
                case 3:
                    //SongsByAlbumId();
                    break;
                case 4:
                   // SongsByAlbumName();
                    break;
                default:
                    break;
            }


        }               
             

        public List<Track> SortSongs()
        {
            using var context = new chinookContext();
            List<Track> tracksByName = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Name).ToList();
            return tracksByName;
    }

        public List<Track> TracksByNameDecending()
        {
            using var context = new chinookContext();
            var tracksByNameDecending = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderByDescending(x => x.Name).ToList();
            return tracksByNameDecending;
        }

        public List<Track> TracksByComposer()
        {
            using var context = new chinookContext();
            var tracksByComposer = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Composer).ToList();
            return tracksByComposer;
        }

        public List<Track> TracksByGenre()
        {
            using var context = new chinookContext();
            var tracksByGenre = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Genre.Name).ToList();
            return tracksByGenre;
        }

        public List<Track> TracksByComposerAndAlbum()
        {
            using var context = new chinookContext();
            var tracksByNameDecending = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(c => c.Composer).ThenBy(a => a.Album.Title).ToList();
            return tracksByNameDecending;
        }
      
        public void AddToBasket(int customerId, List<int> trackIds)
        {
            //invoice
        }

        public List<Track> SearchSongsById(int songId)
        {
                      
            var searchById = SongList().Where(i => i.TrackId == songId).ToList();
            var songById = (from id in searchById
                            where id.TrackId == songId
                            select id).ToList();

            return songById;
        }
        public List<Track> SearchBySongName(string songName)
        {
           
            
            var searchByName = SongList().Where(i => i.Name == songName).ToList();

            var songById = (from id in searchByName
                            where id.Name == songName
                            select id).ToList();
            
            return songById;
        }

        public List<Track> SearchSongsByAlbumId(int albumId)
        {
           
            var searchById = SongList().Where(i => i.AlbumId == albumId).ToList();

            var SongsByAlbumId = (from id in searchById
                                  where id.AlbumId == albumId
                                  select id).ToList();
          
            return SongsByAlbumId;
        }    

        public List<Track> SearchBySongAlbumName(string albumName)
        {
          
            var searchByName = SongList().Where(i => i.Album.Title == albumName).ToList();

            var SongsByAlbumName = (from id in searchByName
                                    where id.Album.Title == albumName
                                    select id).ToList();
         
            return SongsByAlbumName;
        }                 
             
        public List<Track> SearchByComposer(string composer)
        {
         
            
            var searchById = SongList().Where(i => i.Composer == composer).ToList();

            var songById = (from id in searchById
                            where id.Composer == composer
                            select id).ToList();

          
            return songById;
        }           

        public List<Track> SearchByGenre(string genre)
        {
            
            var searchById = SongList().Where(i => i.Genre.Name == genre).ToList();

            var songById = (from id in searchById
                            where id.Genre.Name == genre
                            select id).ToList();

          
            return songById;
        }

        public List<Track> SearchSongsByComposerAndAlbum(string composer, string album)
        {
          
            
            var searchByComposer = SongList().Where(i => i.Composer == composer).ToList();

            var songByComposer = (from id in searchByComposer
                                  where id.Composer == composer
                                  select id).ToList();

            if (songByComposer.Count == 0)
            {
                Console.WriteLine("Tokio kompozitoriaus saraše nėra");
            }

            Console.WriteLine("Iveskite albumo pavadinimą");
            
            var searchByAlbum = songByComposer.Where(i => i.Album.Title == album).ToList();

            var songByAlbum = (from id in searchByAlbum
                               where id.Album.Title == album
                               select id).ToList();
                   
            
            if (songByAlbum.Count == 0)
            {
                Console.WriteLine("Tokio albumo saraše nėra");
            }                     

            return songByAlbum;
        }

        public List<Track> SearchSongsByLength(int length, int choice)
        {
          
            List<Track> songByLength;

            if (choice == 1)
            {
                var searchByLength = SongList().Where(i => i.Milliseconds > length).ToList();

              songByLength = (from id in searchByLength
                                    where id.Milliseconds > length
                                    select id).ToList();
                return songByLength;
            }
            if (choice == 2)
            {
                var searchByLength = SongList().Where(i => i.Milliseconds < length).ToList();

               songByLength = (from id in searchByLength
                                    where id.Milliseconds < length
                                    select id).ToList();

                return songByLength;
            }
            return null;
        }


    }
}




