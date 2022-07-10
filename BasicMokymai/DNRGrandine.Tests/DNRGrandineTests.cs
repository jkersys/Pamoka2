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
        [TestMethod]
        public void ArGrandinejeYra_CAT_Grazina_True()
        {
            var fake = "ACG-CGA-CAT";
            var actual = Program.ArYraCat(ref fake);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void ArGrandinejeYra_CAT_Grazina_False()
        {
            var fake = "ACG-CGA-VAT";
            var expected = Program.ArYraCat(ref fake);
            Assert.AreEqual(false, expected);
        }

        [TestMethod]
        public void PakeistiGCT_I_AGG_GazinaTrue()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-AGG";
            var actual = DNRGrandine.Program.PakeistiGctIAgg(ref fake);

            Assert.AreEqual(expected, actual);
        }
          [TestMethod]
          public void PakeistiGCT_I_AGG_GazinaFalse()
          {
               var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCB";
              var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-AGG";
               var actual = DNRGrandine.Program.PakeistiGctIAgg(ref fake);

                Assert.AreEqual(expected, actual);

          }

        [TestMethod]
        public void IsvestiTreciaIrPenktaSegmentus()
        {   //palygina tik trecia segmenta
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "GAC";
            var actual = DNRGrandine.Program.TreciasIrPenktasSegmentas(ref fake);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekGrandinejeYRaRaidziu()
        {   //palygina tik trecia segmenta
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            int expected = 39;
            var actual = DNRGrandine.Program.KiekRaidziuGrandineje(ref fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekKartuKartojasiSegmentas()
        {   //palygina tik trecia segmenta
            var fake = "GAC-TAC-GAC-TAC-CGT-CAG-ACT-TAA-GAC-GTC-CAT-AGA-GCT";
            var fake2 = "GAC";
            int expected = 4;
            var actual = DNRGrandine.Program.KiekKartuKartojasiKodas(ref fake, fake2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IstrintiSegmenta()
        {   //palygina tik trecia segmenta
            string fake = "GAC-TAC-GAC";
            string fake2 = "TAC";
            string expected = "GAC--GAC";
            var actual = DNRGrandine.Program.IstrintiSegmenta(ref fake, fake2);

            Assert.AreEqual(expected, actual);
        }



    }

}