namespace DemoTCR.Test
{
    public class ImprimanteTest
    {
        [Fact]
        public void TestPrixTotalZero()
        {
            var imprimante = new Imprimante(null);
            var ticket = imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalEtQuantitéZero()
        {
            var imprimante = new Imprimante(null);
            imprimante.DéfinirQuantité(2U);
            var ticket = imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalFixe()
        {
            var prixUnitaire = new decimal(1);

            var imprimante = new Imprimante(null);
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

            var imprimante = new Imprimante(null);
            imprimante.DéfinirPrixUnitaire(prixUnitaire);
            imprimante.DéfinirQuantité(quantité);
            var ticket = imprimante.Imprimer();

            var prix = (prixUnitaire * quantité).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }
    }
}