using P_044_Estensions.Enum;
using P_044_Estensions.Models;
using Prakika.Models;
using Prakika.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Estensions.Interface
{
    public interface IUniversityBookStore
    {
        void Fill(string dataseed);
        void Buy(Book book, int qtty);
        void Sale(BookStorePerson person, string title, BookType bookType, int qtty);
     
    }

    public interface IUniversityBookStoreAccounting
    {
        void Stock();
        void Genres();
        void Sales();
    }

}
