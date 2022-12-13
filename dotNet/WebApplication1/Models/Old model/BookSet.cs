using ApiMokymai.Models;
using ApiMokymai.Services;
using System;

public class BookSet : IBookSet
{
    public static List<Book> books = new List<Book>()
              {
              new Book(1, "Hobbit", "Tolkin",ECoverType.HardCover,2005, 5),
              new Book(2, "War and peace", "Leo Tolstoy",ECoverType.HardCover, 1992, 1 ),
              new Book(3, "Hamlet", "William Shakespeare", ECoverType.Paperback, 1993, 9),
              new Book(4, "The Odyssey", "Homer", ECoverType.Electronic, 1994, 6),
              new Book(5,   " Crime and Punishment", "Fyodor Dostoyevsky", ECoverType.HardCover, 1995, 4),
              new Book(6,   "Hobbit",   "Tolkin", ECoverType.HardCover,  1991, 2),
              new Book(7,   "War and peace",   "Leo Tolstoy", ECoverType.HardCover,  1992, 8),
              new Book(8,   " Heart of Darkness",   "Joseph Conrad", ECoverType.Paperback,  1998, 3),
              new Book(9,   "Great Expectations",   "Great Expectations", ECoverType.Electronic,  1999, 5),
              new Book(10,   "Hobbit",   "Tolkin", ECoverType.HardCover,  1991, 6),
          };
    public List<Book> Books { 
        get { return books;} 
        set { books = value;} 
    }
}
