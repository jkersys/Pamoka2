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



        public List<Track> ShowCatalogForAdmin()
        {
            using var context = new chinookContext();

            List<Track> activeTrack = context.Tracks.Include(x => x.Genre).Include(x => x.Album).ToList(); ;
            return activeTrack;
        }






        //dainų sarašas kurį paduodu atliekant paieską ir rikiavimą
        public List<Track> SongList()
        {
            using var context = new chinookContext();

            var trackList = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).ToList();
            return trackList;

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

        public List<Employee> EmployeesList()
        {
            using var context = new chinookContext();

            List<Employee> employee = context.Employees.ToList();
            return employee;
        }

        public void UpdateSongStatus(int id, string status)
        {
            using var context = new chinookContext();
            {
                List<Track> tracks = ShowCatalogForAdmin();
                var track = tracks.First(s => s.TrackId == id);
                track.Status = status;
                context.SaveChanges();
            }
        }
    }
}




