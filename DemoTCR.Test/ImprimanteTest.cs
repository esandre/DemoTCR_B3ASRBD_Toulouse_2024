namespace DemoTCR.Test
{
    public class ImprimanteTest
    {
        [Fact]
        public void TestPrixTotalZero()
        {
            var imprimante = new Imprimante();
            var ticket = imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalEtQuantitéZero()
        {
            var imprimante = new Imprimante();
            imprimante.DéfinirQuantité(2U);
            var ticket = imprimante.Imprimer();

            var prix = new decimal(0).ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }

        [Fact]
        public void TestPrixTotalFixe()
        {
            var prixUnitaire = new decimal(1);

            var imprimante = new Imprimante();
            imprimante.DéfinirPrixUnitaire(prixUnitaire);
            var ticket = imprimante.Imprimer();

            var prix = prixUnitaire.ToString(Imprimante.FormatPrix);
            Assert.Equal(Imprimante.PrixTotal + prix, ticket);
        }
    }
}