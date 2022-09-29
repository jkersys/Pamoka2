using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P057_TransactionChangeTracking
{
    public class Blog
    {
        public virtual int BlogId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Rating { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>(); //Lazy loading

        public virtual IList<AuthorBlog> AuthorBlog { get; set; }
    }
}