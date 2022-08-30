using Prakika.Models.Abstract;
using Prakika.Models.Concrete;
using Prakika.Service;

namespace Prakika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
              Sukurkite abstract klasę Book
              Sukurkite klasę EBook pavaldėtą iš Book klasės.
              Sukurkite klasę AudioBook pavaldėtą iš Book klasės.
              Sukurkite klasę PaperbackBook pavaldėtą iš Book klasės.
              Sukurkite klasę HardcoverBook pavaldėtą iš Book klasės.
              - knygų duomenys pateikiami ir struktūra kaip - BookInitialData.DataSeedHtml
            */
            /*
             sukurkite interface IBookHtmlService kuris aprašo metodus
            - knygų iškodavimo iš html. Metodas <tipas> Decode(string dataSeed).   
            - knygų kodavimo į html. Metodas string Encode(Dictionary of Book key=(enum)BookType value=list of Book).  
             */

            /*
           sukurkite klasę/servisą BookService implementuojantį IBookHtmlService
           -implementuokite IBookHtmlService metodus unit-test
           */
            BookService books = new BookService();

            books.Encode(book);

            Book book = new EBook();


        }
    }
}