using Pirma_uzduotis.Models;

namespace Pirma_uzduotis
{
    public interface INoteBookRepository
    {
        public void Create(NoteBook noteBook);
        public int Delete(string noteBookTitle);
        public IEnumerable<NoteBook> Get();
        public NoteBook Get(int noteBook);
        public void Update(NoteBook noteBookId);
    }
}