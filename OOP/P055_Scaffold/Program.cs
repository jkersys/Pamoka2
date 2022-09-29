using p055_scaffold.service;
using P055_Scaffold.Service;

namespace P055_Scaffold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Scaffold - DbContext "DataSource=C:\Users\Justinas\source\repos\Pamoka2\OOP\P055_Scaffold\chinook.db" Microsoft.EntityFrameworkCore.Sqlite
            ICountry country = new Country();
            country.PrintCustomers();
            }
        }
    }
