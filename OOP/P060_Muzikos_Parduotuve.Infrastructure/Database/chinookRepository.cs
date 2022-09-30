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


        public void MainMenu()
        {

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| #       | Pasirinkimas | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1       | Prisijungti | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 2       | Registruoti | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 3       | Darbuotojų Parinktys | ");
            Console.WriteLine("--------------------------------------------------------------");



            // var veiksmas = Console.ReadKey().Key;

            // if (veiksmas == ConsoleKey.NumPad1) LogIn();
            // if (veiksmas == ConsoleKey.NumPad2) Registration(string firstName, string lastName, string ? company, string ? adress, string ? city, string ? state, string ? country, string ? postalCode, string ? phone, string ? fax, string email);
            // if (veiksmas == ConsoleKey.NumPad3) LogIn();

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

        public void LogIn()
        {
            using var context = new chinookContext();

            var customers = context.Customers;

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerId}. {customer.FirstName} {customer.LastName}");
            }
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

        public void RegistrationForm()
        {



            Console.WriteLine("Registration");
            Console.WriteLine($"\nName:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"\nLast name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"\nCompany");
            string company = Console.ReadLine();
            Console.WriteLine($"\nAdress");
            string adress = Console.ReadLine();
            Console.WriteLine($"\nCity");
            string city = Console.ReadLine();
            Console.WriteLine($"\nState");
            string state = Console.ReadLine();
            Console.WriteLine($"\nCountry");
            string country = Console.ReadLine();
            Console.WriteLine($"\nPostalCode");
            string postalCode = Console.ReadLine();
            Console.WriteLine($"\nPhone");
            string phone = Console.ReadLine();
            Console.WriteLine($"\nFax");
            string fax = Console.ReadLine();
            Console.WriteLine($"\nEmail");
            string email = Console.ReadLine();

            if (firstName.IsNullOrEmpty())
            {
                Console.WriteLine("Neivedėte vardo");
            }
            if (lastName.IsNullOrEmpty == null)
            {
                Console.WriteLine("Neivedėte Pavardės");
            }
            if (email.IsNullOrEmpty() && !email.Contains("@"))
            {
                Console.WriteLine("Neįvestas, arba neteisingai įvestas El. paštas");
            }
            else
            {
                return;
            }



            AddUser(firstName, lastName, company, adress, city, state, country, postalCode, phone, fax, email);
        }

        public void BuyMenu()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| #       | Pasirinkimas | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1       | Peržiūrėti katalogą | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 2       | Įdėti į krepšelį | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 3       | Peržiūrėti krepšelį  | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 3       | Peržiūrėti pirkimų istorija (Išrašai) | ");
            Console.WriteLine("--------------------------------------------------------------");


            char BuyMenu = Console.ReadKey().KeyChar;

            switch (BuyMenu)
            {
                //case '1':
                //    ShowCatalog();
                //    break;
                //case '2':
                //    KrepselioMetodas();
                //    break;
                //case '3':
                //    ViewBasket();
                //    UzbaigimoKomandos();
                //    break;
                //case '4':
                //    SalesHistoryData();
                //    break;
                //case 'q':
                //    Run();
                //    return;
                //case 'Q':
                //    Run();
                //        return;
                //    default:
                //        Console.WriteLine("No such case");
                //        break;
                //}


            }
        }
        public List<Track> ShowCatalog()
        {
            using var context = new chinookContext();
            //{
            List<Track> activeTrack = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).ToList(); ;
            //Console.WriteLine("-------------------------------------------------------------- ");
            //Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            //Console.WriteLine("-------------------------------------------------------------- ");
            //foreach (var track in ActiveTrack)
            //{
            //    Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
            //    Console.WriteLine("-------------------------------------------------------------- ");
            //}
            //}
            return activeTrack;
        }

        public void SortBy()
        {
            using var context = new chinookContext();


            Console.WriteLine("Rušiuoti pagal:");
            Console.WriteLine("1.Name abecėlės tvarka");
            Console.WriteLine("2.Name atvirkštine abecėlės tvarka");
            Console.WriteLine("3.Composer");
            Console.WriteLine("4.Genre");
            Console.WriteLine("5.Composer ir Album:");

            var input = Console.ReadLine();


            if (input == "1")
            {
                Console.Clear();
                var tracksByName = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Name);
                foreach (var track in tracksByName)
                {
                    Console.WriteLine($"Track Id. {track.TrackId} Track name. {track.Name} Track composer. {track.Composer} Track album. {track.Album.Title} Track genre. {track.Genre.Name} Track length. {track.Milliseconds} Track price. {track.UnitPrice}");
                }
            }

            if (input == "2")
            {
                var tracksByNameDecending = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderByDescending(x => x.Name);
                foreach (var track in tracksByNameDecending)
                { Console.WriteLine($"Track Id. {track.TrackId} Track name. {track.Name} Track composer. {track.Composer} Track album. {track.Album.Title} Track genre. {track.Genre.Name} Track length. {track.Milliseconds} Track price. {track.UnitPrice}"); }
            }
            if (input == "3")
            {
                var tracksByComposer = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Composer);
                foreach (var track in tracksByComposer)
                { Console.WriteLine($"Track Id. {track.TrackId} Track composer. {track.Composer} Track name. {track.Name} Track album. {track.Album.Title} Track genre. {track.Genre.Name} Track length. {track.Milliseconds} Track price. {track.UnitPrice}"); }
            }
            if (input == "4")
            {
                var tracksByGenre = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Genre.Name);
                foreach (var track in tracksByGenre)
                { Console.WriteLine($"Track genre. {track.Genre.Name} Track Id. {track.TrackId} Track name. {track.Name} Track album. {track.Album.Title} Track length. {track.Milliseconds} Track price. {track.UnitPrice}"); }
            }
            if (input == "5")
            {
                var tracksByNameDecending = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(c => c.Composer).ThenBy(a => a.Album.Title);
                foreach (var track in tracksByNameDecending)
                { Console.WriteLine($"Track Id. {track.TrackId} Track composer. {track.Composer} Track album. {track.Album.Title} Track name. {track.Name} Track genre. {track.Genre.Name} Track length. {track.Milliseconds} Track price. {track.UnitPrice}"); }
            }
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
                var searchById = SongList().Where(i => i.Composer == composerInput).ToList();

                var songById = (from id in searchById
                                where id.Composer == composerInput
                                select id).ToList();

                if (songById.Count == 0)
                {
                    Console.WriteLine("Tokio kompozitoriaus saraše nėra");
                }

                Console.WriteLine("Iveskite albumo pavadinimą");
                var albumInput = Console.ReadLine();
                var songByComposer = songById.Where(i => i.Album.Title == albumInput).ToList();

                var songByAlbum = (from id in songByComposer
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
                    foreach (var song in songById)
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
                    var searchById = SongList().Where(i => i.Milliseconds > lengthInput).ToList();

                    var songById = (from id in searchById
                                    where id.Milliseconds > lengthInput
                                    select id).ToList();

                    foreach (var song in songById)
                    {
                        Console.WriteLine($"{song.TrackId} {song.Name} {song.UnitPrice} {song.Milliseconds}");
                    }
                }
                if (optionInput == 2)
                {
                    var searchById = SongList().Where(i => i.Milliseconds < lengthInput).ToList();

                    var songById = (from id in searchById
                                    where id.Milliseconds < lengthInput
                                    select id).ToList();
                    foreach (var song in songById)
                    {
                        Console.WriteLine($"{song.TrackId} {song.Name} {song.UnitPrice} {song.Milliseconds}");
                    }
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

        public List<Track> SongsById()
        {
            Console.WriteLine("Iveskite dainos Id");
            var idInput = Convert.ToInt64(Console.ReadLine());
            var searchById = SongList().Where(i => i.TrackId == idInput).ToList();

            var songById = (from id in searchById
                            where id.TrackId == idInput
                            select id).ToList();
            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");

            foreach (var song in songById)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"{song.TrackId}| {song.Name}, {song.Composer}, {song.Genre.Name}, {song.Album.Title}, {song.Milliseconds}, {song.UnitPrice}");
                Console.WriteLine("--------------------------------------------------------------");
            }
            return songById;
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
                    SongsById();
                    Console.WriteLine($"'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
                    Console.ReadLine();
                    break;
                case 2:
                    SongsByName();
                    break;
                case 3:
                    SongsByAlbumId();
                    break;
                case 4:
                    SongsByAlbumName();
                    break;
                default:
                    break;
            }


        }

        public List<Track> SongsByName()
        {
            Console.WriteLine("Iveskite dainos Pavadinimą");
            var idInput = Console.ReadLine();
            var searchByName = SongList().Where(i => i.Name == idInput).ToList();

            var songById = (from id in searchByName
                            where id.Name == idInput
                            select id).ToList();
            foreach (var song in searchByName)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"{song.TrackId}| {song.Name}, {song.Composer}, {song.Genre.Name}, {song.Album.Title}, {song.Milliseconds}, {song.UnitPrice}");
                Console.WriteLine("--------------------------------------------------------------");
            }
            return songById;
        }

        public List<Track> SongsByAlbumId()
        {
            var idInput = Convert.ToInt64(Console.ReadLine());
            var searchById = SongList().Where(i => i.AlbumId == idInput).ToList();

            var SongsByAlbumId = (from id in searchById
                                  where id.AlbumId == idInput
                                  select id).ToList();
            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");

            foreach (var song in SongsByAlbumId)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"{song.TrackId}| {song.Name}, {song.Composer}, {song.Genre.Name}, {song.Album.Title}, {song.Milliseconds}, {song.UnitPrice}");
                Console.WriteLine("--------------------------------------------------------------");
            }
            return SongsByAlbumId;
        }

        public List<Track> SongsByAlbumName()
        {
            var idInput = Console.ReadLine();
            var searchByName = SongList().Where(i => i.Album.Title == idInput).ToList();

            var SongsByAlbumName = (from id in searchByName
                                    where id.Album.Title == idInput
                                    select id).ToList();
            foreach (var song in SongsByAlbumName)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"{song.TrackId}| {song.Name}, {song.Composer}, {song.Genre.Name}, {song.Album.Title}, {song.Milliseconds}, {song.UnitPrice}");
                Console.WriteLine("--------------------------------------------------------------");
            }
            return SongsByAlbumName;
        }

        public void SortSongs()
        {
            using var context = new chinookContext();
            var tracksByName = context.Tracks.Where(x => x.Status == "Active").Include(x => x.Genre).Include(x => x.Album).OrderBy(x => x.Name);
    }
    }
}




