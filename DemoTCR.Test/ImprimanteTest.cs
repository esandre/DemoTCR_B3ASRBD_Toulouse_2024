namespace DemoTCR.Test
{
    public class ImprimanteTest
    {
        [Fact]
        public void TestHelloWorld()
        {
            var imprimante = new Imprimante();
            var ticket = imprimante.Imprimer();

            Assert.Equal(Imprimante.HelloWorld, ticket);
        }
    }
}