using P057_TransactionChangeTracking.Services;

namespace P057_TransactionChangeTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var manageDb = new ManageDb();
            manageDb.AddBlog("Programavimas");
            manageDb.AddBlog("Knygos");
            manageDb.AddPost("CSharp", 1);
            manageDb.AddPost("SQL", 1);
            manageDb.UpdateBlog(1, "Programavimas2");
            manageDb.UpdatePost(2, "T-SQL");
            manageDb.DeletePost(3);
            manageDb.GetBlogs_EagerLoading();

            manageDb.UpdateBlogToVipBlog();
        }
    }
}