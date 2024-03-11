using DemoTCR.Test.Utilities;

namespace DemoTCR.Test
{
    public class ImprimanteTest
    {
        [Fact]
        public void TestPrixTotalZero()
        {
            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            var ticket = imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalEtQuantit�Zero()
        {
            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.D�finirQuantit�(2U);
            var ticket = imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalFixe()
        {
            var prixUnitaire = new decimal(1);

            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.D�finirPrixUnitaire(prixUnitaire);
            var ticket = imprimante.Imprimer();

            var prix = prixUnitaire.ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalEtQuantit�Fixes()
        {
            var prixUnitaire = new decimal(1);
            const uint quantit� = 2U;

            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.D�finirPrixUnitaire(prixUnitaire);
            imprimante.D�finirQuantit�(quantit�);
            var ticket = imprimante.Imprimer();

            var prix = (prixUnitaire * quantit�).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }
    }
}