namespace DNRGrandine.Tests
{
    [TestClass]
    public class DNRGrandineTests
    {
        [TestMethod]
        public void NormalizuotiGrandine_GrandineSuTarpais_GrazinaGrandineBeTarpuIrBeMazujuRaidziu()
        {
            var grandine = " TAC-GcR ";
            Program.NormalizuotiGrandine(ref grandine);
            Assert.AreEqual("TAC-GCR", grandine);
        }

        [TestMethod]
        public void ArValidiGrandine_GrandineSuNeleistinaisSimboliais_GrazinaFalse()
        {
            var grandine = "AAA-BB-GG";
            var arValidi = Program.ArValidiGrandine(grandine);
            Assert.AreEqual(false, arValidi);
        }

        [TestMethod]
        public void ArValidiGrandine_GrandineSuValidziaisSimboliais_GrazinaTrue()
        {
            var grandine = "TACG-CCGA";
            var arValidi = Program.ArValidiGrandine(grandine);
            Assert.AreEqual(true, arValidi);
        }
    }
}