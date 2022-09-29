using Muzikos_Parduotuve.Infrastructure.Database;
using Muzikos_Parduotuve.Infrastructure.Interfaces;

namespace Muzikos_Parduotuve
{
    internal class Program
    {
        private static IChinookRepository _chinookRepository = new chinookRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //IChinookRepository musicShop = new chinookRepository();
            //musicShop.Main();
            //musicShop.PrintCustomers();
            
            //_chinookRepository.ShowCatalog();
            //_chinookRepository.SortBy();
            _chinookRepository.SearchBy();


            
            //   _chinookRepository.MainMenu();
            //while (true)
            //{
            //    char selection = Console.ReadKey().KeyChar;

            //    switch (selection)
            //    {
            //        case '1':
            //            _chinookRepository.LogIn();
            //            break;
            //        case '2':
            //            _chinookRepository.RegistrationForm();
                        
            //            break;
            //            //case '3':
            //            //    _bloggingRepository.PrintAllPersonsSorted();
            //            //    break;
            //            //case 'q':
            //            //    return;
            //            //default:
            //            //    Console.WriteLine("Input incorrect. Please try again.");
            //            break;

                }
            }
        }
    
