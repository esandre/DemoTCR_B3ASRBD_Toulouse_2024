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
        public void TestPrixTotalEtQuantitéZero()
        {
            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.DéfinirQuantité(2U);
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
            imprimante.DéfinirPrixUnitaire(prixUnitaire);
            var ticket = imprimante.Imprimer();

            var prix = prixUnitaire.ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalEtQuantitéFixes()
        {
            var prixUnitaire = new decimal(1);
            const uint quantité = 2U;

            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.DéfinirPrixUnitaire(prixUnitaire);
            imprimante.DéfinirQuantité(quantité);
            var ticket = imprimante.Imprimer();

            var prix = (prixUnitaire * quantité).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }
    }
}