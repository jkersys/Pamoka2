using Dapper;
using Microsoft.Data.Sqlite;
using Pirma_uzduotis.Database.Dapper;
using Pirma_uzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirma_uzduotis
{
    public class NoteBookRepository : INoteBookRepository
    {
     
        private readonly DatabaseConfig _databaseConfig;

        public NoteBookRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        // CRUD -> Create, Read, Update, Delete
        // Pridedame eilute i lentele
        // INSERT INTO Product (Name, Description) -> Mes norime ideti nauja eilute su 2 reiksmemis: Name, Description
        // VALUES (@Name, @Description) -> Mes norime ideti i paminetus stulpelius sias dvi reiksmes
        public void Create(NoteBook noteBook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO NoteBook (Title, Description, Priority)
                VALUES (@Title, @Description, @Priority);", noteBook);
        }

        public IEnumerable<NoteBook> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // SELECT rowid AS Id -> Traukiam rowid, bet pervadinam ir grazinam Id pavadinimu
            // rowid yra SQLite sugebejimas rasti kurioje eiluteje mes randame irasa
            return connection.Query<NoteBook>(@"
                SELECT *
                FROM NoteBook");
        }

        public int Delete(string noteBookTitle)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // DELETE -> norim istrinti viska eiluteje/eilutese
            // FROM Product -> Is Product lenteles
            // 
            var affectedRows = connection.Execute(@"
                DELETE
                FROM NoteBook
                WHERE Title = @Title;", new { Title = noteBookTitle });

            return affectedRows;
        }
        public void Update(NoteBook noteBook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var updateQuery = @"
                UPDATE Notebook (
                SET Title = @Title, Description = @Description, @Priority = @Priority
                Where Id = @Id;";

            connection.Execute(updateQuery, noteBook);
              
        }

        public NoteBook Get(int noteBookId)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            return connection.Query<NoteBook>(@"
                SELECT *
                FROM NoteBook
                WHERE Id = @Id;", new { Id = noteBookId })
                .FirstOrDefault(); 
        }
    }
}
  