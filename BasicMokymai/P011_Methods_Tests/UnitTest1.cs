//namespace P_014_Debug
{
    [TestClass]
    public class P011_Methods_Tests
    {/*
        [TestMethod]
        public void DecimalHour_Test()
        {
            var fake = "30.30";
            var expcted = "Decimal hour: 30.5";
            var actual = P_014_Debug.Program.DecimalHour(fake);
            Assert.AreEqual(expcted, actual);
        }
            [TestMethod]
            public void DecimalHour_Test1()
            {
                var fake = "20.30.30";
                var expcted = "Decimal hour: 20.5083";
                var actual = P_014_Debug.Program.DecimalHour(fake);
                Assert.AreEqual(expcted, actual);

             }

        [TestMethod]
        public void DecimalHour()
        {
            var fake = "20";
            var expcted = "Invalid time";
            var actual = P_014_Debug.Program.DecimalHour(fake);
            Assert.AreEqual(expcted, actual);
        }
        */
        [TestMethod]
        public void Skaiciuotuvas_test()
        {
            var a = 3;
            var b = 2;

            var expected = 1.5;
            var actual = Debug_Uzdavinys_Skaiciuotuvas.Program.Skaiciuotuvas(a, b, "/");

            Assert.AreEqual(expected, actual);


        }
        }
    }
