class Produkt
{
    // Właściwości produktu
    public string Producent { get; set; }
    public string Nazwa { get; set; }
    public string Kategoria { get; set; }
    public string KodProduktu { get; set; }
    public decimal Cena { get; set; }
    public string Opis { get; set; }

    public override string ToString()
    {
        return $"{Nazwa} ({Producent}), Cena: {Cena} PLN";
    }
}