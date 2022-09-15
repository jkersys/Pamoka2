using P_052_CodeFirstSqliteDb.Infrastructure.Database;
using P_052_CodeFirstSqliteDb.Infrastructure.Interface;

namespace P_052_CodeFirstSqliteDb
{
    internal class Program
    {
        private static IBloggingRepository _bloggingRepository = new BloggingRepository();
        static void Main(string[] args)
        {
            /*Uzduotis 1:Atnaujinkit Person, kad turetu Weight, Biography atributus (Nauja migracija turetu tureti tik siuos atnaujinimus). 
             * Sukurkite nauja klase Animal, kuri turetu Name, Type, BirthDate atributus.*/

/*Uzduotis 2:Sukurkite metodus, kurie leistu prideti nauja gyvuna, atspausdintu visus gyvunus, isgautu gyvunus kurie yra paduoto tipo, 
 * atspausdintu visus gyvunus surikiuotus pagal varda. 
 * Pridekite sias funkcijas I main programos pasirinkimu menu.*/


//technologija kuria naudosime SQl naudojimui SQLite
//Technologijakomunikacijai su DB: EntityFrameworkCore
//3 priejimai kaip galima aktyvuoti duombaziu kode:
//1. Database First.
//2. Model first.
//3. Code First. 

//Management Studio: https://sqlitebrowser.org/dl/

//Pradeti naudoti SQlite turime isirasyti siuos nuget
//1.
Console.WriteLine("Hello, World!");

while (true)
{
    Console.WriteLine($"\n1.Addd new user\nq.Quit)");
    char selection = Console.ReadKey().KeyChar;
    switch (selection)
    {
        case '1':
            Console.WriteLine($"Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"BirthDay:");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            _bloggingRepository.AddPerson(firstName, lastName, birthDay);
            break;
        case '2':
            _bloggingRepository.PrintAllPersons();
            break;
        case '3':
            _bloggingRepository.PrintAllPersonsSorted();
            break;
          case '4':
          Console.WriteLine($"Name:");
          string name = Console.ReadLine();
          Console.WriteLine($"Type:");
          string type = Console.ReadLine();
          Console.WriteLine($"BirthDay:");
          DateTime animalBirthDay = DateTime.Parse(Console.ReadLine());
          _bloggingRepository.AddAnimals(name, type, animalBirthDay);
          break;
          case '5':
          _bloggingRepository.PrintAllAnimals();
           break;
           case '6':
           _bloggingRepository.PrintAllAnimalsSorted();
           break;
           case 'q':
            return;
        default:
            Console.WriteLine("Input incorrect. Please try again.");
            break;
    }
}
}
}
}