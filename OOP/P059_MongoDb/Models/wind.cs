using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P059_MongoDb.Models
{
    public class wind
    {
        public direction direction { get; set; }
        public string type { get; set; }
        public speed speed { get; set; }
    }
}
