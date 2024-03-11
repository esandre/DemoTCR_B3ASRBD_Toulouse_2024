namespace DemoTCR;

internal class Calculatrice
{
    private decimal _prixUnitaire = new (0);
    private uint _quantité = 1;

    public decimal PrixTotal => _quantité * _prixUnitaire;

    public void DéfinirPrixUnitaire(decimal prixUnitaire)
    {
        _prixUnitaire = prixUnitaire;
    }

    public void DéfinirQuantité(uint quantité)
    {
        _quantité = quantité;
    }
}