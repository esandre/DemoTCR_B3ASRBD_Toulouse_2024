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
            imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            var ticket = consoleSpy.Contenu;
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalEtQuantit�Zero()
        {
            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.D�finirQuantit�(2U);
            imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            var ticket = consoleSpy.Contenu;
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalFixe()
        {
            var prixUnitaire = new decimal(1);

            var consoleSpy = new ConsoleSpy();
            var imprimante = new Imprimante(consoleSpy);
            imprimante.D�finirPrixUnitaire(prixUnitaire);
            imprimante.Imprimer();

            var prix = prixUnitaire.ToString(Imprimante.FormatPrix);
            var ticket = consoleSpy.Contenu;
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
            imprimante.Imprimer();

            var prix = (prixUnitaire * quantit�).ToString(Imprimante.FormatPrix);
            var ticket = consoleSpy.Contenu;
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }
    }
}