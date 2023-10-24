class Adres
{
    // Właściwości adresu
    public string Ulica { get; set; }
    public string KodPocztowy { get; set; }
    public string Miejscowosc { get; set; }
    public string NumerPosesji { get; set; }
    public string NumerLokalu { get; set; }

    public override string ToString()
    {
        return $"{Ulica}, {KodPocztowy} {Miejscowosc}";
    }
}