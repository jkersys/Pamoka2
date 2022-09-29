using Pirma_uzduotis.Database.Dapper;
using Pirma_uzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirma_uzduotis.Service
{
    public class NoteBookWritter : INoteBookWritter
    {

        private readonly DatabaseConfig _databaseConfig;
        private readonly INoteBookRepository _notebookRepository;

        public NoteBookWritter()
        {
            _databaseConfig = new DatabaseConfig();
            _notebookRepository = new NoteBookRepository(_databaseConfig);
        }
        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add NoteBook");
                Console.WriteLine("2. List NoteBook");
                Console.WriteLine("3. Remove NoteBooks with name");
                Console.WriteLine("4. Update NooteBook By ID");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddNoteBook();
                        break;
                    case '2':
                        DisplayNoteBooks();
                        break;
                    case '3':
                        RemoveNoteBook();
                        break;
                    case '4':
                        UpdateNoteBook();
                        break;
                    case 'q':
                        return;
                    default:
                        break;
                }

                PauseScreen();
            }
        }

        private void UpdateNoteBook()
        {
            Console.WriteLine("\n\nPlease select NoteBook ID to update:");
            DisplayNoteBooks();


            int updateNotebookId = Convert.ToInt32(Console.ReadLine());
            NoteBook noteBook = _notebookRepository.Get(updateNotebookId);

            if(noteBook == null)
            {
                Console.WriteLine($"\n\n No nootebook found with {noteBook?.Id} ID.");
                return;
            }

            var newProduct = new NoteBook();
            Console.WriteLine("\n\nPlease enter new title of the NoteBook:");
            noteBook.Title = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter new description of the NoteBook:");
            noteBook.Description = Console.ReadLine();
       

            _notebookRepository.Update(noteBook);

            Console.WriteLine($"\n{noteBook.Id} - {noteBook.Title} updated to the database\n");
        }

        public void DisplayNoteBooks()
        {
            var notebooks = _notebookRepository.Get();

            Console.WriteLine();

            foreach (var notebook in notebooks)
            {
                Console.WriteLine($"{notebook.Id}. {notebook.Title} ({notebook.CreationDateTime}) - {notebook.Description}");
            }
        }

        public void AddNoteBook()
        {
            var newProduct = new NoteBook();
            Console.WriteLine("\n\nPlease enter name of the NoteBook:");
            newProduct.Title = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter description of the NoteBook:");
            newProduct.Description = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter description of the NoteBook:");
            newProduct.Priority = Console.ReadLine();

            _notebookRepository.Create(newProduct);

            Console.WriteLine($"\n{newProduct.Title} - {newProduct.Description} added to the database\n");
        }

        private void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }

        public void RemoveNoteBook()
        {
            Console.WriteLine("\n\nPlease enter name of the notebook that should be deleted:");
            string notebookNameToDelete = Console.ReadLine();

            int notebookDeletedCount = _notebookRepository.Delete(notebookNameToDelete);

            Console.WriteLine($"\n{notebookDeletedCount} called {notebookNameToDelete} were removed.\n");
        }
    }
}

        
    

