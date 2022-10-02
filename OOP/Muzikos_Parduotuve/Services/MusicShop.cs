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
        private readonly IChinookRepository repository;
        private Customer? activeCustomer { get; set; }

        private List<Track> tracksSelected { get; set; } = new List<Track>();

        public MusicShop()
        {
            repository = new ChinookRepository();
        }



        const string pin = "1234";


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
                    ShowBasket();
                    break;
                case '4':
                    ShowAllInvoices();
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

            List<Track> tracksList = repository.SongList();

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


        //Uztikrint kad ivestu privalomus laukus, neismetant is reg formos
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

            if (firstName.IsNullOrEmpty())
            {
                while (firstName.IsNullOrEmpty())
                {
                    Console.WriteLine("Vardas privalo būti įvestas");
                    firstName = Console.ReadLine();
                }
                
                while (lastName.IsNullOrEmpty())
                {
                    Console.WriteLine("Neivedėte Pavardės");
                    lastName = Console.ReadLine();
                }
                
                while (email.IsNullOrEmpty() || !email.Contains("@"))
                {
                    Console.WriteLine("Neįvestas, arba neteisingai įvestas El. paštas");
                    email = Console.ReadLine();
                }
            }


            repository.AddUser(firstName, lastName, company, adress, city, state, country, postalCode, phone, fax, email);

            StartShop();
        }



        private void CustomerLogIn()
        {
            Console.Clear();
            List<Customer> customerList = repository.CustomerList();
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
            List<Track> tracksList = repository.SortSongs();

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
            List<Track> tracksList = repository.TracksByNameDecending();

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
            List<Track> tracksList = repository.TracksByComposer();

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
            List<Track> tracksList = repository.TracksByGenre();

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
            List<Track> tracksList = repository.TracksByComposerAndAlbum();

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
            long songId = Convert.ToInt64(Console.ReadLine());

            Track track = repository.GetSongById(songId);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");

            Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
            Console.WriteLine("-------------------------------------------------------------- ");

            SearchByMenu();
        }
        public void SearchByName()
        {
            Console.WriteLine("Įveskite dainos pavadinimą");
            string songName = Console.ReadLine();

            List<Track> tracksList = repository.SearchBySongName(songName);

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

            List<Track> tracksList = repository.SearchByComposer(composer);

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

            List<Track> tracksList = repository.SearchByGenre(genre);

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

            List<Track> tracksList = repository.SearchSongsByComposerAndAlbum(composer, album);



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

            List<Track> tracksList = repository.SearchSongsByLength(miliseconds, choice);



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

            List<Track> tracksList = repository.SearchSongsByAlbumId(albumId);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
            var input = Console.ReadLine();
            if (input == "q")
            {
                AddToBasketMenu();
            }
            if (input == "y")
            {

                tracksSelected.AddRange(tracksList);

                AddToBasketMenu();
            }
        }

        public void SearchByAlbumName()
        {
            Console.WriteLine("Įveskite albumo Id");
            string albumName = Console.ReadLine();

            List<Track> tracksList = repository.SearchBySongAlbumName(albumName);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
            var input = Console.ReadLine();
            if (input == "q")
            {
                AddToBasketMenu();
            }
            if (input == "y")
            {

                tracksSelected.AddRange(tracksList.ToList());

                AddToBasketMenu();
            }
        }
        public void SearchByIdToBuy()
        {
            Console.WriteLine("Įveskite dainos Id");
            int songId = Convert.ToInt32(Console.ReadLine());

            var track = repository.GetSongById(songId);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
            Console.WriteLine("-------------------------------------------------------------- ");

            Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
            var input = Console.ReadLine();
            if (input == "q")
            {
                AddToBasketMenu();
            }
            if (input == "y")
            {

                tracksSelected.Add(track);

                AddToBasketMenu();
            }
        }
        public void SearchByNameToBuy()
        {
            Console.WriteLine("Įveskite dainos pavadinimą");
            string songName = Console.ReadLine();

            List<Track> tracksList = repository.SearchBySongName(songName);

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
            Console.WriteLine("'q' - Grįžti atgal || 'y' - Įdeda į krepšelį visas rastas dainas");
            var input = Console.ReadLine();
            if (input == "q")
            {
                AddToBasketMenu();
            }
            if (input == "y")
            {

                tracksSelected.AddRange(tracksList.ToList());

                AddToBasketMenu();
            }
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


        //sudeti i invoice irpadaryti, kad rodytu total suma. nes reikes traukiant invoice sarasus
        public void ShowBasket()
        {

            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksSelected)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }

            Console.WriteLine("'q' - Grįžti atgal || 'y' - Užbaigti pirkimą");
            var input = Console.ReadLine();
            if (input == "q")
            {
                BuyMenu();
            }
            if (input == "y")
            {
                InvoiceFieldsToPrint();
                var invoice = new Invoice();
                invoice.InvoiceDate = DateTime.Now;
                invoice.BillingAddress = activeCustomer.Address;
                invoice.CustomerId = activeCustomer.CustomerId;
                invoice.BillingAddress = activeCustomer.Address;
                invoice.BillingState = activeCustomer.State;
                invoice.BillingCity = activeCustomer.City;
                invoice.BillingCountry = activeCustomer.Country;
                invoice.BillingPostalCode = activeCustomer.PostalCode;


                invoice.InvoiceItems = new List<InvoiceItem>();
                foreach (var track in tracksSelected)
                {
                    invoice.InvoiceItems.Add(new InvoiceItem
                    {
                        TrackId = track.TrackId
                    });
                }

                invoice.Total = Math.Round(TotalPrice() + (TotalPrice() * 0.21), 2);
                repository.AddInvoice(invoice);
                tracksSelected.Clear();
            }


        }

        public double TotalPrice()
        {
            double sumNoTax = 0;
            foreach (var price in tracksSelected)
            {
                sumNoTax = sumNoTax + price.UnitPrice.Value;
            }
            return sumNoTax;
        }

        public void InvoiceFieldsToPrint()
        {
            Console.WriteLine($"Name:{activeCustomer.FirstName}");
            Console.WriteLine($"Last Name:{activeCustomer.LastName}");
            Console.WriteLine($"Adress:{activeCustomer.Address}");
            Console.WriteLine($"Phone:{activeCustomer.Phone}");
            Console.WriteLine($"Email:{activeCustomer.Email}");
            double sumNoTax = 0;

            foreach (var track in tracksSelected)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
                sumNoTax = sumNoTax + track.UnitPrice.Value;
            }

            Console.WriteLine($"Total without Tax: {Math.Round(sumNoTax, 2)}");
            Console.WriteLine($"Tax: 21%");
            Console.WriteLine($"Total: {Math.Round(sumNoTax + sumNoTax * 0.21, 2)}");
            Console.WriteLine("");
            Console.WriteLine("Q. grįžti į pirkimo ekraną");
            Console.WriteLine("L. Išeiti");

            var input = Console.ReadLine();

            if (input == "q")
            { BuyMenu(); }
            if (input == "l")
            { Environment.Exit(0); }

        }

        //nezinau kaip istraukt
        public void ShowAllInvoices()
        {
            int customerId = (int)activeCustomer.CustomerId;
            List<Invoice> invoices = repository.GetCustomerInvoices(customerId);

            foreach (var invoice in invoices)
            {
                Console.WriteLine($"Invoice Id {invoice.InvoiceId}");
                Console.WriteLine($"Name:{invoice.Customer.FirstName}");
                Console.WriteLine($"Last Name:{invoice.Customer.LastName}");
                Console.WriteLine($"Adress:{invoice.Customer.Address}");
                Console.WriteLine($"Phone:{invoice.Customer.Phone}");
                Console.WriteLine($"Email:{invoice.Customer.Email}");
                double sumNoTax = 0;


                //Console.Writeline("-------------------------------------------------------------- ");
                //Console.Writeline("| #   |  name, composer, genre, album, milliseconds, price | ");
                //Console.Writeline("-------------------------------------------------------------- ");
                //Console.Writeline($"{(invoice)}| {track.name}, {track.composer}, {track.genre.name}, {track.album.title}, {track.milliseconds}, {track.unitprice}");
                //Console.Writeline("-------------------------------------------------------------- ");
                //sumnotax = sumnotax + track.unitprice.value;


                Console.WriteLine($"Total without Tax: {invoice.Total}");
                Console.WriteLine($"Tax: 21%");
                Console.WriteLine($"Total: {Math.Round(invoice.Total * 0.21, 2)}");
                Console.WriteLine("*******************************************************************");

            }

            Console.WriteLine("Q. grįžti į pirkimo ekraną");
        }






        public void EmployeeLogin()
        {
            Console.Clear();
            Console.WriteLine("Enter pin code");
            string pinGuess = Console.ReadLine();
            List<Employee> employeeList = repository.EmployeesList();

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
                    Console.WriteLine("Enter pin code");
                    string pinGuess = Console.ReadLine();
                    if (pinGuess == pin)
                    {
                        Statistic();
                    }
                    else
                        Console.WriteLine("Neteisingas pin");
                    AdminMenu();
                    Statistic();
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
                    GetCustomerList();
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
        public void GetCustomerList()
        {
            Console.Clear();
            List<Customer> customerList = repository.CustomerList();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.CustomerId} {customer.FirstName} {customer.LastName}");
            }
            Console.WriteLine("Q. Grižti");
            var input = Console.ReadLine();
            if (input == "q")
            { AdminMenuModifyBuyers(); }

        }

        //status keitimo
        public void ChangeSongStatus()
        {
            Console.WriteLine("1.Gauti dainu sarasa");
            Console.WriteLine("2.Keisti dainos statusą");

            List<Track> tracksList = repository.ShowCatalogForAdmin();
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
                var songId = Convert.ToInt64(Console.ReadLine());
                Track track = tracksList.First(s => s.TrackId == songId);

                var statusMsg = (track.Status == "Active") ? "Dainos statusas Active" : "Dainos statusas Inactive";
                Console.WriteLine($"Dainos Id: {track.TrackId}, dainos pavadinimas: {track.Name}, Dainos statusas yra {statusMsg}, ar norite pakeisti");


                Console.WriteLine("1.Jeigu norite pakeisti dainos status");
                Console.WriteLine("Q jeigu norite grįžti");
                var choice = Console.ReadLine();


                if (choice == "1" && track.Status == "Active")
                {
                    repository.UpdateSongStatus(songId, "Inactive");
                    ChangeSongStatus();
                }
                if (choice == "1" && track.Status == "Inactive")
                {
                    repository.UpdateSongStatus(songId, "Active");
                    ChangeSongStatus();
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
            Console.WriteLine("| 1.  | Išgauti visas kliento atąskaitas pagal kliento ID   |  ");
            Console.WriteLine("| 2.  | Išgauti veiklos pelna (Neatskaičius mokesčių pilna suma)    |  ");
            Console.WriteLine("| 3.  | Išgauti veiklos pelną pagal paduotus metus  |  ");
            Console.WriteLine("| 4.  | Išgauti kiek kokio žanro kūrinių buvo nupirkta (Rikiuota pagal dydį) |  ");
            Console.WriteLine("| 5.  | Išgauti kiek kiekvienas klienas išleido pinigų  |  ");


            var input = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (input)
            {
                case '1':
                    Console.WriteLine("Iveskite Kliento Id");
                    int customerId = Convert.ToInt32(Console.ReadLine());
                    List<Invoice> invoices = repository.GetCustomerInvoices(customerId);
                    foreach (var invoice in invoices)
                    {
                        Console.WriteLine($"Sąskaitos id {invoice.InvoiceId} kliento id {invoice.CustomerId}, " +
                        $"sąskaitos data{invoice.InvoiceDate}, sąskaitos suma {invoice.Total}");
                    }
                    Statistic();
                    break;
                case '2':
                    List<Invoice> invoiceForTotalIncomeCount = repository.TotalIncome();
                    double totalIncome = 0;
                    foreach (var invoice in invoiceForTotalIncomeCount)
                    {
                        totalIncome = totalIncome + invoice.Total;
                    }
                    Console.WriteLine($"Visas pelnas be mokesčių yra: {Math.Round(totalIncome, 2)}");

                    Statistic();
                    break;
                case '3':
                    Console.WriteLine("Įveskite metus (yyyy)");
                    var date = Console.ReadLine();
                    List<Invoice> invoiceForTotalIncomePerYearCount = repository.TotalIncomeByYear(date);
                    if (invoiceForTotalIncomePerYearCount.Count == 0)
                    { Console.WriteLine("Šiais metais pardavimų nebuvo"); }
                    double totalIncomePerYear = 0;
                    foreach (var invoice in invoiceForTotalIncomePerYearCount)
                    {
                        totalIncomePerYear = totalIncomePerYear + invoice.Total;
                    }
                    Console.WriteLine($"Visas pelnas {date} metais yra: {Math.Round(totalIncomePerYear, 2)}");

                    Statistic();
                    break;
                case '4':
                    repository.TotalGenreSold();
                    break;
                case '5':

                    break;
                case 'q':

                    break;
                case 'Q':

                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
        }

    }
    }
    



     

    

