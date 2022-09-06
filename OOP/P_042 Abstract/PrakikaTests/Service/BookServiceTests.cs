using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prakika.Models.Abstract;
using Prakika.Models.Concrete;
using Prakika.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakika.Service.Tests
{
    [TestClass()]
    public class BookServiceTests
    {
        [TestMethod()]
        public void EncodeTest()
        {
            List<Book> fake = new List<Book>
            {
                new EBook {Genre = "Fantasy", Title = "Harry Potter", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 10.0},
                new AudioBook {Genre = "Fantasy", Title = "Harry Potter", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 10.0},
                new Paperbook {Genre = "Adventure", Title = "Harry Potter", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 10.0}
            }

            Assert.Fail();
        }
    }
}