using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_0021_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace P_0021_List.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void didziausiasSaraseTest()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = new List<int>(fake);

            Assert.AreEqual(expected, actual);
        }


            [TestMethod()]
            public void DIDESNIS_UZ_DIDZIAUSIA_Su_For()
            {
                var fake = new List<int> { 5, 1, 6, 8, 7 };
                var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = new List<int>(fake);

                CollectionAssert.AreEqual(expected, actual);
            }

        }
}