class Magazyn
{
    // Właściwości magazynu
    public List<Produkt> Produkty { get; private set; } = new List<Produkt>();
    public Adres AdresMagazynu { get; set; }

    public override string ToString()
    {
        return AdresMagazynu.ToString();
    }
}