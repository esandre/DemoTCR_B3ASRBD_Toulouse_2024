namespace DemoTCR;

public class Imprimante
{
    public const string PrixTotal = "Prix Total : ";
    public const string FormatPrix = "C";

    private decimal _prixUnitaire = new (0);

    public string Imprimer()
    {
        var prixTotal = _prixUnitaire.ToString(FormatPrix);
        return PrixTotal + prixTotal;
    }

    public void DéfinirPrixUnitaire(decimal prixUnitaire)
    {
        _prixUnitaire = prixUnitaire;
    }

    public void DéfinirQuantité(uint quantité)
    {
    }
}