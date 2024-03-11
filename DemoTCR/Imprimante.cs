namespace DemoTCR;

public class Imprimante
{
    private readonly IConsole _console;
    public const string PrixTotal = "Prix Total : ";
    public const string FormatPrix = "C";

    private readonly Calculatrice _article = new ();

    public Imprimante(IConsole console)
    {
        _console = console;
    }

    public void Imprimer()
    {
        var prixTotal = _article.PrixTotal.ToString(FormatPrix);
        var sortie = PrixTotal + prixTotal;

        _console.Write(sortie);
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