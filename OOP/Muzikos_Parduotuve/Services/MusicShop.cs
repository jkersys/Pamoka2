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
                    SignUp();
                    break;
                case '2':
                    RegistrationForm();
                    break;
                case '3':
                    EmployeeLogIn();
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
                    break;
                case '2':

                    break;
                case '3':


                    break;
                case '4':

                    break;
                case 'q':
                    //MainMenu();
                    return;
                case 'Q':
                    //MainMenu();
                    return;
                case 'o':
                    //SortByMenu();
                    return;
                case 'O':
                    //SortByMenu();
                    return;
                case 's':
                    StartShop();
                    return;
                case 'S':
                    StartShop();
                    return;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }

        public void ShowAllTracks()
        {
            
            List<Track> tracksList = context.ShowCatalog();

    Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("| #   |  Name, Composer, Genre, Album, Milliseconds, Price | ");
            Console.WriteLine("-------------------------------------------------------------- ");
            foreach (var track in tracksList)
            {
                Console.WriteLine($"{track.TrackId}| {track.Name}, {track.Composer}, {track.Genre.Name}, {track.Album.Title}, {track.Milliseconds}, {track.UnitPrice}");
                Console.WriteLine("-------------------------------------------------------------- ");
            }
           Console.WriteLine("Q. grįžti");
           Console.WriteLine("O. Rikiuoti");
           Console.WriteLine("S. Paieška");

            var input = Console.ReadLine();
            if(input == "q")
            {
                BuyMenu();
            }
            if (input == "o")
            {
                BuyMenu();
            }
            if (input == "s")
            {
                BuyMenu();
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
    

        private void SignUp()
        {
            Console.Clear();
            context.LogIn();

            Console.WriteLine("Iveskite vartotojo Id prie kurio norite prisijungti");
            Console.ReadLine();
            //sutvarkyt
            BuyMenu();
            return;
            //nezinau kaip uzsetint kad zinotu kuris vartotojas paimtas
        }

        public void SortByMenu()
        {
            Console.WriteLine("Rušiuoti pagal:");
            Console.WriteLine("1.Name abecėlės tvarka");
            Console.WriteLine("2.Name atvirkštine abecėlės tvarka");
            Console.WriteLine("3.Composer");
            Console.WriteLine("4.Genre");
            Console.WriteLine("5.Composer ir Album:");

            var input = Console.ReadLine()    

            switch (input)
            {
                default:
                    break;
            }

        }
    }
}
        

    

