using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Domain.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Column(Order = 0)]
        public int BlogId { get; set; }
        [Column(Order = 2)]
        public decimal Rating { get; set; }

        [Column("Blogname", Order = 1)]
        public string Name { get; set; }

        public virtual List<Post> Posts{ get; set; }
        public virtual IList<AuthorBlog> AuthorBlogs { get; set; }

    }
}
