using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Domain.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }

        //one to many
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
