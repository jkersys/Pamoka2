using Castle.Core.Internal;
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

        private void EmployeeLogIn()
        {
            Console.Clear()
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
            Console.Clear()
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
            return;
            //nezinau kaip uzsetint kad zinotu kuris vartotojas paimtas
        }
    }
}
        

    

