using P053_QueryingSqliteDb.Infrastructure.Database;

namespace P_053_querying_Sqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var manageDb = new ManageDb();

            //manageDb.AddBlog("Programavimas");
            //manageDb.AddBlog("Knygos");

            //manageDb.AddPost("CSharp", 1);
            //manageDb.AddPost("C++", 2);
            ManageDb.UpdateBlog(1, "Programavimas2");

        }
    }
}