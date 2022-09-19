using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Infrastructure.Database
{
    public class ManageDb
    {
        public ManageDb()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }
        

        public void AddBlog(string name)
        {
            using var context = new BloggingContext();
            context.Blogs.Add(new Domain.Models.Blog { Name = name });
            context.SaveChanges();
        }


    }
}
