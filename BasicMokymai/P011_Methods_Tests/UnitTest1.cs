namespace P011_Methods_Tests
{
    [TestClass]
    public class P010_Methods
    {
        [TestMethod]
        public void KiekYraZodziu_()
        {
            var fake = "as mokausi programuoti";
            var expcted = 3;
            var actual = P010_Methods.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expcted, actual);

        }

        }
    }
}