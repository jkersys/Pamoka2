using P056_DB_Dapper.Database;
using P056_DB_Dapper.Database.Dapper;
using Pirma_uzduotis.Database.Services;

namespace P056_DB_Dapper
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

            IProductService productService = new ProductService();
            productService.Run();
        }
    }
}