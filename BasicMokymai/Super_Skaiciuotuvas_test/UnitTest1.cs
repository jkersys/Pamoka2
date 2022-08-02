using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefaktorintasSuperSkaiciuotuvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace RefaktorintasSuperSkaiciuotuvas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.SuperSkaiciuotuvas(move);
            }
            var actual = RefaktorintasSuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            RefaktorintasSuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                RefaktorintasSuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = RefaktorintasSuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            RefaktorintasSuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                RefaktorintasSuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = RefaktorintasSuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }
    }
}