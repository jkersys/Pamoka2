using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P057_TransactionChangeTracking.Services
{
    public class ManageDb
    {
        public ManageDb()
        {
            using (var context = new BloggingContext())
            {
                context.Database.EnsureCreated();
            }
        }
        public virtual List<Blog> GetBlogs()
        {
            using (var context = new BloggingContext())
            {
                var blogs = context.Blogs.Include(b => b.Posts);
                return blogs.ToList();
            }

        }
        public void UpdateBlogToVipBlog()
        {
            using (var context = new BloggingContext())
            {
                using var dbContextTransaction = context.Database.BeginTransaction();
                context.Database.ExecuteSqlRaw(
                    @"Update blogs
                    SET Rating = 5
                    WHERE name LIKE 'Programavimas'");

                var postsHighRate = context.Posts
                    .Include(p => p.Blog)
                    .Where(p => p.Blog.Rating >= 5);

                foreach (var post in postsHighRate)
                {
                    post.Title += "[PREMIUM]";

                    context.SaveChanges();

                    dbContextTransaction.Commit();
                }
            }
        }

        public void GetBlogs_EagerLoading()
        {
            using (var context = new BloggingContext())
            {
                var blogs = context.Blogs.Include(b => b.Posts);
                foreach (var blog in blogs)
                {
                    System.Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                    foreach (var post in blog.Posts)
                    {
                        System.Console.WriteLine($"-{post.PostId}. {post.Title}");
                    }
                }
            }
        }



        public void AddBlog(string name)
        {
            using (var context = new BloggingContext())
            {
                context.Blogs.Add(new Blog { Name = name });
                context.SaveChanges();
            }
        }

        public void UpdateBlog(int blogId, string name)
        {
            using (var context = new BloggingContext())
            {
                var blog = context.Blogs.Find(blogId);
                blog.Name = name;
                context.SaveChanges();
            }
        }


        public void UpdatePost(int postId, string title)
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.Find(postId);
                post.Title = title;
                context.SaveChanges();
            }
        }
        public void DeletePost(int postId)
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.Find(postId);
                context.Posts.Remove(post);
                context.SaveChanges();
            }
        }



        public void AddPost(string title, int blogId)
        {
            using (var context = new BloggingContext())
            {
                var blog = context.Blogs.Find(blogId);
                blog.Posts.Add(new Post { Title = title, Content = "", BlogId = blogId });
                context.SaveChanges();
            }
        }




    }
}