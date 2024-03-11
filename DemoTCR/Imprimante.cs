namespace DemoTCR;

public class Imprimante
{
    public const string PrixTotal = "Prix Total : ";
    public const string FormatPrix = "C";

    public string Imprimer()
    {
        return PrixTotal + "0.00 €";
    }
}