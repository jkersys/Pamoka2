using P057_TransactionChangeTracking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P057_TransactionChangeTracking
{
    public class AuthorBlog
    {
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Author Author { get; set; }

    }
}

