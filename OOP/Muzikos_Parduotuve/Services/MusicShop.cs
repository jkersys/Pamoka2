using Castle.Core.Internal;
using Muzikos_Parduotuve.Domain.Models;
using Muzikos_Parduotuve.Infrastructure.Database;
using Muzikos_Parduotuve.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzikos_Parduotuve.Services
{

    public class MusicShop : IMusicShop
    {

        IChinookRepository context = new chinookRepository();

        public virtual Customer activeCustomer { get; set; }

        public virtual List<Track>? TracksSelected { get; set; }


        public void StartShop()
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

            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    ChangeSongStatus();
                    break;
                case '2':
                    RegistrationForm();
                    break;
                case '3':
                    EmployeeLogin();
                    break;
                case 'q':
                    Environment.Exit(0);
                    return;
                case 'Q':
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;

            }
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
            Console.WriteLine("| 4       | Peržiūrėti pirkimų istorija (Išrašai) | ");
            Console.WriteLine("--------------------------------------------------------------");


            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':

                    ShowAllTracks();
                    FilterMenu();
                    break;
                case '2':
                    AddToBasketMenu();
                    break;
                case '3':


                    break;
                case '4':

                    break;
                case 'q':
                    Console.WriteLine("Ar tikrai norite atsijungti y: taip n: ne");
                    var logOut = Console.ReadLine();
                    if (logOut == "y")
                    {
                        activeCustomer = null;
                        StartShop();
                    }
                    if (logOut == "n")
                    {
                        BuyMenu();
                    }

                    StartShop();
                    return;
                case 'Q':
                    StartShop();
                    return;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
        }

        public void ShowAllTracks()
        {

            List<Track> tracksList = context.SongList();

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }

        }

        public void FilterMenu()
        {
            Console.WriteLine("Q. Grįžti");
            Console.WriteLine("O. Rikiuoti");
            Console.WriteLine("S. Paieška");

            var input = Console.ReadLine();
            if (input == "q")
            {
                BuyMenu();
            }
            if (input == "o")
            {
                SortByMenu();
            }
            if (input == "s")
            {
                SearchByMenu();
            }
        }

        private void EmployeeLogIn()
        {
            Console.Clear();
            const string pin = "1234";
            Console.WriteLine("Įveskite pin kodą");
            var pinGuess = Console.ReadLine();

            if (pinGuess == pin)
            {
                //to do
            }
        }

        private void RegistrationForm()
        {
            Console.Clear();
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

            //if (firstName.IsNullOrEmpty())
            //{
            //    Console.WriteLine("Neivedėte vardo");
            //}
            //if (lastName.IsNullOrEmpty == null)
            //{
            //    Console.WriteLine("Neivedėte Pavardės");
            //}
            //if (email.IsNullOrEmpty() && !email.Contains("@"))
            //{
            //    Console.WriteLine("Neįvestas, arba neteisingai įvestas El. paštas");
            //}
            //else
            //{
            //    return;
            context.AddUser(firstName, lastName, company, adress, city, state, country, postalCode, phone, fax, email);
        }

        private void CustomerLogIn()
        {
            Console.Clear();
            List<Customer> customerList = context.CustomerList();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.CustomerId} {customer.FirstName} {customer.LastName}");
            }

            Console.WriteLine("Iveskite vartotojo Id prie kurio norite prisijungti");
            var customerId = Convert.ToInt32(Console.ReadLine());
            while (customerId > customerList.Count)
            {
                Console.WriteLine("Tokio vartotojo nėra, įveskite kitą Id ");
                customerId = Convert.ToInt32(Console.ReadLine());
            }

            activeCustomer = customerList.First(c => c.CustomerId == customerId);
            Console.WriteLine("Pasirinktas vartotojas");
            Console.WriteLine($"{activeCustomer.CustomerId} {activeCustomer.FirstName} {activeCustomer.LastName}");

            BuyMenu();
            return;
        }

        public void SortByMenu()
        {
            Console.WriteLine("Rušiuoti pagal:");
            Console.WriteLine("1.Name abecėlės tvarka");
            Console.WriteLine("2.Name atvirkštine abecėlės tvarka");
            Console.WriteLine("3.Composer");
            Console.WriteLine("4.Genre");
            Console.WriteLine("5.Composer ir Album:");
            Console.WriteLine("Q.Grįžti atgal:");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SortSongsAToZ();
                    break;
                case "2":
                    SortSongDescending();
                    break;
                case "3":
                    SortSongsByComposer();
                    break;
                case "4":
                    SortSongsByGenre();
                    break;
                case "5":
                    SortSongsByComposerAndAlbum();
                    break;
                case "q":
                    FilterMenu();
                    break;
                case "Q":
                    FilterMenu();
                    break;
                default:
                    break;
            }

        }

        public void SortSongsAToZ()
        {
            List<Track> tracksList = context.SortSongs();

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SortByMenu();
        }

        public void SortSongDescending()
        {
            List<Track> tracksList = context.TracksByNameDecending();

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SortByMenu();
        }

        public void SortSongsByComposer()
        {
            List<Track> tracksList = context.TracksByComposer();

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SortByMenu();
        }

        public void SortSongsByGenre()
        {
            List<Track> tracksList = context.TracksByGenre();

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SortByMenu();
        }

        public void SortSongsByComposerAndAlbum()
        {
            List<Track> tracksList = context.TracksByComposerAndAlbum();

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SortByMenu();
        }


        public void SearchByMenu()
        {
            Console.WriteLine("Pasirinkite pagal ką norite ieškoti");
            Console.WriteLine("1.Id");
            Console.WriteLine("2.Name");
            Console.WriteLine("3.Composer");
            Console.WriteLine("4.Genre");
            Console.WriteLine("5.Composer ir Album");
            Console.WriteLine("Q.Grįžti atgal");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SearchById();
                    break;
                case "2":
                    SearchByName();
                    break;
                case "3":
                    SearchByComposer();
                    break;
                case "4":
                    SearchByGenre();
                    break;
                case "5":
                    SearchByComposerAndAlbum();
                    break;
                case "6":
                    SearchByLength();
                    break;
                case "q":
                    FilterMenu();
                    break;
                case "Q":
                    FilterMenu();
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }

        }
        public void SearchById()
        {
            Console.WriteLine("Įveskite dainos Id");
            int songId = Convert.ToInt32(Console.ReadLine());

            List<Track> tracksList = context.SearchSongsById(songId);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SearchByMenu();
        }
        public void SearchByName()
        {
            Console.WriteLine("Įveskite dainos pavadinimą");
            string songName = Console.ReadLine();

            List<Track> tracksList = context.SearchBySongName(songName);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SearchByMenu();
        }
        public void SearchByComposer()
        {
            Console.WriteLine("Įveskite kompzitoriaus pavadinimą");
            string composer = Console.ReadLine();

            List<Track> tracksList = context.SearchByComposer(composer);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SearchByMenu();
        }
        public void SearchByGenre()
        {
            Console.WriteLine("Įveskite dainos žanro pavadinimą");
            string genre = Console.ReadLine();

            List<Track> tracksList = context.SearchByGenre(genre);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SearchByMenu();
        }
        public void SearchByComposerAndAlbum()
        {
            Console.WriteLine("Įveskite dainos autorių");
            string composer = Console.ReadLine();
            Console.WriteLine("Įveskite albumo pavadinimą");
            string album = Console.ReadLine();

            List<Track> tracksList = context.SearchSongsByComposerAndAlbum(composer, album);



            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SearchByMenu();
        }
        public void SearchByLength()
        {
            Console.WriteLine("Įveskite milisekundžių skaičių");
            int miliseconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Dainos ilgesnės nei įvestas milisekundžių skaičius");
            Console.WriteLine("2. Dainos trumpesnės nei įvestas milisekundžių skaičius");
            int choice = Convert.ToInt32(Console.ReadLine());

            List<Track> tracksList = context.SearchSongsByLength(miliseconds, choice);



            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            SearchByMenu();
        }
        public void SearchByAlbumId()
        {

            Console.WriteLine("Įveskite albumo Id");
            int albumId = Convert.ToInt32(Console.ReadLine());

            List<Track> tracksList = context.SearchSongsByAlbumId(albumId);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            //Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
            //var input = Console.ReadLine();
            //if (input == "q")
            //{
            //    AddToBasketMenu();
            //}
            //if (input == "y")
            //{
            //    foreach (var track in tracksList)
            //    {
            //        TracksSelected.Add(track);

            AddToBasketMenu();
        }

        public void SearchByAlbumName()
        {
            Console.WriteLine("Įveskite albumo Id");
            string albumName = Console.ReadLine();

            List<Track> tracksList = context.SearchBySongAlbumName(albumName);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            AddToBasketMenu();
        }
        public void SearchByIdToBuy()
        {
            Console.WriteLine("Įveskite dainos Id");
            int songId = Convert.ToInt32(Console.ReadLine());

            List<Track> tracksList = context.SearchSongsById(songId);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }

            //Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
            //var input = Console.ReadLine();
            //if (input == "q")
            //{
            //    AddToBasketMenu();
            //}
            //if (input == "y")
            //{
            //    foreach (var track in tracksList)
            //    {
            //        TracksSelected.Add(track);
            //    }

            //}
            AddToBasketMenu();
        }
        public void SearchByNameToBuy()
        {
            Console.WriteLine("Įveskite dainos pavadinimą");
            string songName = Console.ReadLine();

            List<Track> tracksList = context.SearchBySongName(songName);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            AddToBasketMenu();
        }


        public void AddToBasketMenu()
        {
            Console.WriteLine("1.Daina pagal Id");
            Console.WriteLine("2.Daina pagal pavadinimą");
            Console.WriteLine("3.Dainos pagal albumo Id");
            Console.WriteLine("4.Dainos pagal albumo pavadinimą");
            Console.WriteLine("Q.Grįžti");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SearchByIdToBuy();
                    break;
                case "2":
                    SearchByNameToBuy();
                    break;
                case "3":
                    SearchByAlbumId();
                    break;
                case "4":
                    SearchByAlbumName();
                    break;
                case "q":
                    BuyMenu();
                    break;
                case "Q":
                    BuyMenu();
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
        }
        //public void AddToBasketSongs()
        //{
        //    Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
        //    var input = Console.ReadLine();
        //    if(input == "q")
        //    {
        //        AddToBasketMenu();
        //    }
        //    if(input == "y")
        //    {

        //    }

        //}

        public void ShowBasket()
        {

            Console.WriteLine("'q' - Grįžti atgal || 'y' - Užbaigti pirkimą");
            var input = Console.ReadLine();
            if (input == "q")
            {
                BuyMenu();
            }
            if (input == "y")
            {

            }


        }

        public void InvoiceFieldsToPrint()
        {
            Console.WriteLine($"Name:{activeCustomer.FirstName}");
            Console.WriteLine($"Name:{activeCustomer.LastName}");
            Console.WriteLine($"Name:{activeCustomer.Address}");
            Console.WriteLine($"Name:{activeCustomer.Phone}");

            //show songs

            Console.WriteLine($"Total without Tax:");
            Console.WriteLine($"Tax: 21%");
            Console.WriteLine($"Total: Total+21%");

            Console.WriteLine("Q grįžti į pirkimo ekraną");

        }

        public void EmployeeLogin()
        {
            Console.Clear();
            const string pin = "1234";
            Console.WriteLine("Enter pin code");
            string pinGuess = Console.ReadLine();
            List<Employee> employeeList = context.EmployeesList();

            if (pinGuess == pin)
            {
                foreach (Employee emlpoyee in employeeList)
                {
                    Console.WriteLine($"{emlpoyee.EmployeeId} {emlpoyee.FirstName} {emlpoyee.LastName}");
                }

            }
            AdminMenu();
        }

        public void AdminMenu()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| #       | Pasirinkimas | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1       | Keisti klientų duomenis | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 2       | Pakeisti dainos statusą  | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 3       | Statistika (Darbuotojams) | ");
            Console.WriteLine("--------------------------------------------------------------");

            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    AdminMenuModifyBuyers();
                    break;
                case '2':
                    ChangeSongStatus();
                    break;
                case '3':
                    //Statistic();
                    break;
                case 'q':
                    Environment.Exit(0);
                    return;
                case 'Q':
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
        }

        public void AdminMenuModifyBuyers()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| #       | Pasirinkimas | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1       | Gauti pirkėjų sąrašą | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 2       | Pašalinti pirkėją pagal ID  | ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 3       | Modifikuoti pirkėjo duomenis | ");
            Console.WriteLine("--------------------------------------------------------------");

            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    CustomerLogIn();
                    break;
                case '2':
                    RegistrationForm();
                    break;
                case '3':
                    EmployeeLogin();
                    break;
                case 'q':
                    Environment.Exit(0);
                    return;
                case 'Q':
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;

            }

        }
        public void ChangeSongStatus()
        {
            Console.WriteLine("1.Gauti dainu sarasa");
            Console.WriteLine("2.Keisti dainos statusą");

            List<Track> tracksList = context.ShowCatalogForAdmin();
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("-------------------------------------------------------------- ");
                Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
                Console.WriteLine("-------------------------------------------------------------- ");
                foreach (var track in tracksList)
                {

                    Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                    Console.WriteLine("-------------------------------------------------------------- ");
                    
                }
            }
            
                if (input == "2")
                {
                    Console.WriteLine("Iveskite dainos id");
                    int songId = Convert.ToInt32(Console.ReadLine());
                    Track track = tracksList.First(s => s.TrackId == songId);
                    Console.WriteLine($"{track.TrackId} {track.Name} {track.Status}");

                    Console.WriteLine("1.Jeigu norite keisti dainos status į active arba inactive");
                    Console.WriteLine("Q jeigu norite grįžti");
                    var choice = Console.ReadLine();


                    if (choice == "1" && track.Status == "Active")
                    {
                        context.UpdateSongStatus(songId, "Inactive");
                    return;
                    }
                    if (choice == "1" && track.Status == "Inactive")
                    {
                        context.UpdateSongStatus(songId, "Active");
                    return;
                    }
                    if (choice == "q")
                    {
                        AdminMenu();
                    }
                }
            ChangeSongStatus();
            }
        


        public void Statistic()
        {

        }
    }
}
        

    

