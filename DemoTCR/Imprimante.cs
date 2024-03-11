namespace DemoTCR;

public class Imprimante
{
    public const string PrixTotal = "Prix Total : ";
    public const string FormatPrix = "C";

    public string Imprimer()
    {
        var prixTotal = new decimal(0).ToString(FormatPrix);
        return PrixTotal + prixTotal;
    }
}