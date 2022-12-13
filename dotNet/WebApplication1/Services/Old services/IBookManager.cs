using ApiMokymai.Models.Dto;

namespace ApiMokymai.Services
{
    public interface IBookManager
    {
        List<GetBookDto> Get();
        GetBookDto Get(int id);
        bool Exists(int id);
        List<GetBookDto> Filter(Dictionary<string, string> filter);
        int Add(CreateBookDto book);
        void Update(UpdateBookDto book);
        void Delete(int id);
    }
}
