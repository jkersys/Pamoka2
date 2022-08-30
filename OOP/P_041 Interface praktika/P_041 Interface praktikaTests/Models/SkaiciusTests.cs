using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_041_Interface_praktika.Interface;
using P_041_Interface_praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models.Tests
{
    [TestClass()]
    public class SkaiciusTests
    {
        [TestMethod()]
        public void PridetiTest()
        {
            
            var expected = 10;
            var fakeObjektas = new Skaicius(5);
           
            var actual = fakeObjektas.Prideti(5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SkaiciuPakeltiKvadratu()
        {

            var expected = 100;
            IMatematika fakeObjektas = new Skaicius(10);

            var actual = fakeObjektas.PakeltiKvadratu();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PadaugintiSkaiciu()
        {

            var expected = 100;
            Skaicius fakeObjektas = new Skaicius(10);

            var actual = fakeObjektas.Padauginti(10);
            Assert.AreEqual(expected, actual);
        }
    }
}