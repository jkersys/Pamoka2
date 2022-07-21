using P_0021_ForEach;

namespace ForEach_testai

{
    [TestClass]
    public class Skaiciuotuvo_testas
    {
        [TestMethod]
        public void ApskaiciuotiVidurki()
        {
            //fakes
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 5;
            var actual = Program.ApskaiciuotiVidurki(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrintiSkaiciausTeigiamuma()
        {
            //fakes
            var teigiamoTekstas = "Teigiamas";
            var neigiamoTekstas = "Neigiamas";
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 5;
            var actual = Program.TikrintiSkaiciausTeigiamuma(fake);

            Assert.AreEqual(expected, actual);
        }

       












    }
}