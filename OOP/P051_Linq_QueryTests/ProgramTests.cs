using Microsoft.VisualStudio.TestTools.UnitTesting;
using P051_Linq_Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P051_Linq_Query.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LyginiaiSkaiciaiTest()
        {
            var actual = Program.LyginiaiSkaiciai();
            var expected = new int[] { 0, 2, 4, 6, 8 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TeigiamiSkaiciaiTest()
        {
            var actual = Program.TeigiamiSkaiciai();
            var expected = new int[] { 1, 3, 12, 19, 6, 9, 10, 14 };
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SkaiciusKvadratuTest()
        {
            var actual = Program.SkaiciusKvadratu();
            var expected = new int[] { 9, 81, 4, 64, 36, 25 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}