using Prakika.Enums;
using Prakika.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakika.Interface
{
    public interface IBookHtmlService
    {
        Dictionary<BookType, List<Book>> Decode(string dataSeed);
        string Encode(Dictionary<BookType, List<Book>> books);
    }
}
