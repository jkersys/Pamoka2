using System.Collections;
using System.Linq;

namespace P049_Linq_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Linq!");
            // LINQ - Language Integrated Query
            // "Data iteration engine", bet jei mes bandytume sutrumpinti kazkas versle nenorejo sio dalyko vadinti DIE

            // EXTENSION SYNTAX
            // IEnumerable sudaro 1 atributas
            // IEnumerator sudaro 2 pagrindiniai atributai: Current property ir Next() metodas
            // IEnumerable<int> result = GenerateNumbers(10); // Calling without Yield
            // Calling with yield                      
            //IEnumerable<int> result = GenerateNumbersWithYeld(10);

            //Pipeline of instructions - Grandine veiksmu seku
            IEnumerable<int> result = GenerateNumbersWithYeld(10).
            Where(n => n % 2 == 0)
            .Select(n => n * 3); // projection of element

            Console.WriteLine("Middle of process");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("End of process");
        }
        public static IEnumerable<int> GenerateNumbers(int maxValue)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < maxValue; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }
        //Yield naudojame tada kada mes zinome, kad nezinome koki duomenu kieki mums reikes laikyti
        //Nauda: Performance, speed, doesnt break the server application.
        public static IEnumerable<int> GenerateNumbersWithYeld(int maxValue)
        {
            for (int i = 0; i < maxValue; i++)
            {
                //uzdelstas reiksmes grazinimas
                yield return i;
            }
        }
    }
}