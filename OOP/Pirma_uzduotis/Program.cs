using Pirma_uzduotis.Database;
using Pirma_uzduotis.Database.Dapper;
using Pirma_uzduotis.Service;

namespace Pirma_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Fetching connection string..");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            Console.WriteLine("Fetching connection string..");
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete");

            INoteBookWritter noteBookWritter = new NoteBookWritter();
            noteBookWritter.Run();


        }
    }
}