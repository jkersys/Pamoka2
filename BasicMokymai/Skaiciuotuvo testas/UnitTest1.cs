//namespace Debug_Uzdavinys_Skaiciuotuvas
{
    [TestClass]
    public class Skaiciuotuvo_testas
    {
        [TestMethod]
        public void Skaiciuotuvas_test1()
        {
            //fakes
            var a = 4;
            var b = 2;
            var expected = 1.5;
            var actual = Debug_Uzdavinys_Skaiciuotuvas.Program.Skaiciuotuvas(a, b, "/");

            Assert.AreEqual(expected, actual);




        }






    }
}