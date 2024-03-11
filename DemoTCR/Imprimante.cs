namespace DemoTCR;

public class Imprimante
{
    public const string PrixTotal = "Prix Total : ";
    public const string FormatPrix = "C";

    private readonly Calculatrice _article = new ();

    public Imprimante(IConsole console)
    {
    }

    public string Imprimer()
    {
        var prixTotal = _article.PrixTotal.ToString(FormatPrix);
        return PrixTotal + prixTotal;
    }

    public void DéfinirPrixUnitaire(decimal prixUnitaire)
    {
        _article.DéfinirPrixUnitaire(prixUnitaire);
    }

    public void DéfinirQuantité(uint quantité)
    {
        _article.DéfinirQuantité(quantité);
    }
}