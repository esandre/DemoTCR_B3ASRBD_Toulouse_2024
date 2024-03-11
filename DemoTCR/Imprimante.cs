namespace DemoTCR;

public class Imprimante
{
    private readonly IConsole _console;
    public const string PrixTotal = "Prix Total : ";
    public const string FormatPrix = "C";

    private readonly Calculatrice _articleUnique = new ();

    public Imprimante(IConsole console)
    {
        _console = console;
    }

    public void Imprimer()
    {
        _console.Write(PrixTotal + _articleUnique.PrixTotal.ToString(FormatPrix));
    }

    public void DéfinirPrixUnitaire()
    {
        var prixUnitaireRaw = _console.Read();
        var prixUnitaire = decimal.Parse(prixUnitaireRaw);
        _articleUnique.DéfinirPrixUnitaire(prixUnitaire);
    }

    public void DéfinirQuantité()
    {
        var quantitéRaw = _console.Read();
        var quantité = uint.Parse(quantitéRaw);
        _articleUnique.DéfinirQuantité(quantité);
    }
}