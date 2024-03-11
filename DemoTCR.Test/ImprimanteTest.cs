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
    }
}