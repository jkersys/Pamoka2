using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirma_uzduotis.Database.Dapper
{
    public class DatabaseConfig
    {
        public DatabaseConfig()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnString = "Data source=" + Path.Join(path, "NoteBook.db");
        }

        public string ConnString { get; }
    }


}