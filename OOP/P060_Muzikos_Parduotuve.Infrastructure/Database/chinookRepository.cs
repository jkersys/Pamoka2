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
    public class ChinookRepository : IChinookRepository
    {
        public ChinookRepository()
        {
            using var context = new ChinookContext();
            // Naudojam kaip pavyzdi, kad zinoti, jog yra budas patikrinti ar duombaze siuo metu egzistuoja.
            // Jei neegzsituoja uz mus buna paleidziama CLI komanda update-datase
            context.Database.EnsureCreated();
        }



        public void AddUser(string firstName, string lastName, string? company, string? adress, string? city, string? state, string? country, string? postalCode, string? phone, string? fax, string email)
        {
            using var context = new ChinookContext();

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
            using var context = new ChinookContext();

            List<Customer> customers = context.Customers.ToList();
            return customers;
        }



        public List<Track> ShowCatalogForAdmin()
        {
            using var context = new ChinookContext();

            List<Track> activeTrack = context.Tracks.Include(x => x.Genre).Include(x => x.Album).ToList();
            return activeTrack;
        }






        //dainų sarašas kurį paduodu atliekant paieską ir rikiavimą
        public List<Track> SongList()
        {
            using var context = new ChinookContext();

            var trackList = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).ToList();
            return trackList;

        }




        public List<Track> SortSongs()
        {
            using var context = new ChinookContext();
            List<Track> tracksByName = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Name).ToList();
            return tracksByName;
        }

        public List<Track> TracksByNameDecending()
        {
            using var context = new ChinookContext();
            var tracksByNameDecending = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderByDescending(x => x.Name).ToList();
            return tracksByNameDecending;
        }

        public List<Track> TracksByComposer()
        {
            using var context = new ChinookContext();
            var tracksByComposer = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Composer).ToList();
            return tracksByComposer;
        }

        public List<Track> TracksByGenre()
        {
            using var context = new ChinookContext();
            var tracksByGenre = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Genre.Name).ToList();
            return tracksByGenre;
        }

        public List<Track> TracksByComposerAndAlbum()
        {
            using var context = new ChinookContext();
            var tracksByNameDecending = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(c => c.Composer).ThenBy(a => a.Album.Title).ToList();
            return tracksByNameDecending;
        }

        public void AddToBasket(int customerId, List<int> trackIds)
        {
            //invoice
        }

        public Track? GetSongById(long songId)
        {
            using var context = new ChinookContext();
            return context.Tracks.Include(x => x.Genre).Include(x => x.Album).First(x => x.TrackId == songId);

        }
        public List<Track> SearchBySongName(string songName)
        {

            using var context = new ChinookContext();
            var searchByName = SongList().Where(i => i.Name == songName).ToList();

            var songById = (from id in searchByName
                            where id.Name == songName
                            select id).ToList();

            return songById;
        }

        public List<Track> SearchSongsByAlbumId(int albumId)
        {
            using var context = new ChinookContext();
            var searchById = SongList().Where(i => i.AlbumId == albumId).ToList();

            var SongsByAlbumId = (from id in searchById
                                  where id.AlbumId == albumId
                                  select id).ToList();

            return SongsByAlbumId;
        }

        public List<Track> SearchBySongAlbumName(string albumName)
        {
            using var context = new ChinookContext();
            return context.Tracks.Where(i => i.Album.Title == albumName).Include(x => x.Genre).Include(x => x.Album).ToList();
        }

        public List<Track> SearchByComposer(string composer)
        {

            using var context = new ChinookContext();
            var searchById = SongList().Where(i => i.Composer == composer).ToList();

            var songById = (from id in searchById
                            where id.Composer == composer
                            select id).ToList();


            return songById;
        }

        public List<Track> SearchByGenre(string genre)
        {
            using var context = new ChinookContext();
            var searchById = SongList().Where(i => i.Genre.Name == genre).ToList();

            var songById = (from id in searchById
                            where id.Genre.Name == genre
                            select id).ToList();


            return songById;
        }

        public List<Track> SearchSongsByComposerAndAlbum(string composer, string album)
        {

            using var context = new ChinookContext();
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
            using var context = new ChinookContext();
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
            using var context = new ChinookContext();

            List<Employee> employee = context.Employees.ToList();
            return employee;
        }

        public void UpdateSongStatus(long id, string status)
        {
            using var context = new ChinookContext();
            {
                var track = context.Tracks.Find(id);
                if (track is not null)
                {
                    track.Status = status;
                    context.SaveChanges();
                }
            }
        }
        public List<Invoice> GetCustomerInvoices(int customerId)
        {
            using var context = new ChinookContext();
            var userInvoices = context.Invoices.Include(x => x.Customer)
                .Where(i => i.Customer.CustomerId == customerId).ToList();
            return userInvoices;
        }

        public List<Invoice> TotalIncome()
        {
            using var context = new ChinookContext();
            List<Invoice> invoices = context.Invoices.ToList();
            return invoices;

        }

        public void AddInvoice(Invoice invoice)
        {
            using var context = new ChinookContext();
            context.Invoices.Add(invoice);
            context.SaveChanges();
        }

        public List<Invoice> TotalIncomeByYear(string date)
        {
            using var context = new ChinookContext();
            List<Invoice> invoices = context.Invoices.Where(x => x.InvoiceDate.Year.ToString() == date).ToList();
            return invoices;
        }
        public void TotalGenreSold()
        {
            using var context = new ChinookContext();
            List<Invoice> customers = context.Invoices.Include(x => x.Customer).Where(x=>x.CustomerId == x.Total).ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer}");
            }
            //List<Customer> customers = context.Customers.Include(x => x.Invoices).ToList();
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"{customer.CustomerId} {customer.Invoices.}");
            //}
            //return tracks;



        }
    }
    }





