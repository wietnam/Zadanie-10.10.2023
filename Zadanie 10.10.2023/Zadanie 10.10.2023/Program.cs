using System;
using System.Collections.Generic;

class Program
{   //stworzenie listy produktów i magazynów aby można było je wyświetlać
    static List<Magazyn> magazyny = new List<Magazyn>();
    static List<Produkt> produkty = new List<Produkt>();


    static void Main(string[] args)
    {
        bool exit = false;
        //Przez tego while menu nie jest jednorazowego urzytku 
        while (!exit)
        {   //Menu główne
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1. Zarządzaj Produktami");
            Console.WriteLine("2. Zarządzaj Magazynami");
            Console.WriteLine("3. Wyświetl Produkty i Magazyny");
            Console.WriteLine("4. Wyjście");
            Console.Write("Wybierz opcję: ");

            int mainOption;
            if (int.TryParse(Console.ReadLine(), out mainOption))
            {
                switch (mainOption)
                {
                    case 1:
                        ZarzadzajProduktami();
                        break;
                    case 2:
                        ZarzadzajMagazynami();
                        break;
                    case 3:
                        WyswietlProduktyIMagazyny();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }
    }
    //Menu dotyczące produktów
    static void ZarzadzajProduktami()
    {
        bool exit = false;

        while (!exit)
        {   
            Console.WriteLine("==== Zarządzaj Produktami ====");
            Console.WriteLine("1. Dodaj Produkt");
            Console.WriteLine("2. Edytuj Produkt");
            Console.WriteLine("3. Usuń Produkt");
            Console.WriteLine("4. Powrót do Menu Głównego");
            Console.Write("Wybierz opcję: ");

            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        DodajProdukt();
                        break;
                    case 2:
                        EdytujProdukt();
                        break;
                    case 3:
                        UsunProdukt();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }
    }
    //dodawanie produktów
    static void DodajProdukt()
    {
        Produkt produkt = new Produkt();
        Console.WriteLine("==== Dodaj Produkt ====");
        Console.Write("Producent: ");
        produkt.Producent = Console.ReadLine();
        Console.Write("Nazwa: ");
        produkt.Nazwa = Console.ReadLine();
        Console.Write("Kategoria: ");
        produkt.Kategoria = Console.ReadLine();
        Console.Write("Kod Produktu: ");
        produkt.KodProduktu = Console.ReadLine();
        Console.Write("Cena: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal cena))
        {
            produkt.Cena = cena;
        }
        else
        {
            Console.WriteLine("Niepoprawna cena. Produkt nie został dodany.");
            return;
        }
        Console.Write("Opis: ");
        produkt.Opis = Console.ReadLine();

        produkty.Add(produkt);
        Console.WriteLine("Produkt został dodany.");
    }
    //edycja produktów
    static void EdytujProdukt()
    {
        Console.WriteLine("==== Edytuj Produkt ====");
        Console.WriteLine("Lista dostępnych produktów:");

        for (int i = 0; i < produkty.Count; i++)
        {
            Console.WriteLine($"{i}. {produkty[i]}");
        }

        Console.Write("Podaj indeks produktu do edycji: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < produkty.Count)
        {
            Produkt produkt = produkty[index];
            Console.Write("Nowy Producent: ");
            produkt.Producent = Console.ReadLine();
            Console.Write("Nowa Nazwa: ");
            produkt.Nazwa = Console.ReadLine();
            Console.Write("Nowa Kategoria: ");
            produkt.Kategoria = Console.ReadLine();
            Console.Write("Nowy Kod Produktu: ");
            produkt.KodProduktu = Console.ReadLine();
            Console.Write("Nowa Cena: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal cena))
            {
                produkt.Cena = cena;
            }
            else
            {
                Console.WriteLine("Niepoprawna cena. Produkt nie został zaktualizowany.");
            }
            Console.Write("Nowy Opis: ");
            produkt.Opis = Console.ReadLine();
            Console.WriteLine("Produkt został zaktualizowany.");
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks produktu.");
        }
    }
    //usuwanie produktów
    static void UsunProdukt()
    {
        Console.WriteLine("==== Usuń Produkt ====");
        Console.WriteLine("Lista dostępnych produktów:");

        for (int i = 0; i < produkty.Count; i++)
        {
            Console.WriteLine($"{i}. {produkty[i]}");
        }

        Console.Write("Podaj indeks produktu do usunięcia: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < produkty.Count)
        {
            produkty.RemoveAt(index);
            Console.WriteLine("Produkt został usunięty.");
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks produktu.");
        }
    }
    //Menu dotyczące magazynów
    static void ZarzadzajMagazynami()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("==== Zarządzaj Magazynami ====");
            Console.WriteLine("1. Dodaj Magazyn");
            Console.WriteLine("2. Edytuj Magazyn");
            Console.WriteLine("3. Usuń Magazyn");
            Console.WriteLine("4. Powrót do Menu Głównego");
            Console.Write("Wybierz opcję: ");

            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        DodajMagazyn();
                        break;
                    case 2:
                        EdytujMagazyn();
                        break;
                    case 3:
                        UsunMagazyn();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }
    }
    //dodawanie magazynu
    static void DodajMagazyn()
    {
        Magazyn magazyn = new Magazyn();
        Console.WriteLine("==== Dodaj Magazyn ====");
        Console.Write("Ulica: ");
        magazyn.AdresMagazynu = new Adres
        {
            Ulica = Console.ReadLine()
        };
        Console.Write("Kod Pocztowy: ");
        magazyn.AdresMagazynu.KodPocztowy = Console.ReadLine();
        Console.Write("Miejscowość: ");
        magazyn.AdresMagazynu.Miejscowosc = Console.ReadLine();
        Console.Write("Numer Posesji: ");
        magazyn.AdresMagazynu.NumerPosesji = Console.ReadLine();
        Console.Write("Numer Lokalu: ");
        magazyn.AdresMagazynu.NumerLokalu = Console.ReadLine();

        magazyny.Add(magazyn);
        Console.WriteLine("Magazyn został dodany.");
    }
    //edycja magazynu
    static void EdytujMagazyn()
    {
        Console.WriteLine("==== Edytuj Magazyn ====");
        Console.WriteLine("Lista dostępnych magazynów:");

        for (int i = 0; i < magazyny.Count; i++)
        {
            Console.WriteLine($"{i}. {magazyny[i]}");
        }

        Console.Write("Podaj indeks magazynu do edycji: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < magazyny.Count)
        {
            Magazyn magazyn = magazyny[index];
            Console.Write("Nowa Ulica: ");
            magazyn.AdresMagazynu.Ulica = Console.ReadLine();
            Console.Write("Nowy Kod Pocztowy: ");
            magazyn.AdresMagazynu.KodPocztowy = Console.ReadLine();
            Console.Write("Nowa Miejscowość: ");
            magazyn.AdresMagazynu.Miejscowosc = Console.ReadLine();
            Console.Write("Nowy Numer Posesji: ");
            magazyn.AdresMagazynu.NumerPosesji = Console.ReadLine();
            Console.Write("Nowy Numer Lokalu: ");
            magazyn.AdresMagazynu.NumerLokalu = Console.ReadLine();
            Console.WriteLine("Magazyn został zaktualizowany.");
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks magazynu.");
        }
    }
    //usuwanie magazynu
    static void UsunMagazyn()
    {
        Console.WriteLine("==== Usuń Magazyn ====");
        Console.WriteLine("Lista dostępnych magazynów:");

        for (int i = 0; i < magazyny.Count; i++)
        {
            Console.WriteLine($"{i}. {magazyny[i]}");
        }

        Console.Write("Podaj indeks magazynu do usunięcia: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < magazyny.Count)
        {
            magazyny.RemoveAt(index);
            Console.WriteLine("Magazyn został usunięty.");
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks magazynu.");
        }
    }

    static void WyswietlProduktyIMagazyny()
    {
        Console.WriteLine("==== Produkty ====");
        if (produkty.Count == 0)
        {
            Console.WriteLine("Brak dostępnych produktów.");
        }
        else
        {
            Console.WriteLine("Dostępne produkty:");
            for (int i = 0; i < produkty.Count; i++)
            {
                Console.WriteLine($"{i}. {produkty[i]}");
            }
        }

        Console.WriteLine("\n==== Magazyny ====");
        if (magazyny.Count == 0)
        {
            Console.WriteLine("Brak dostępnych magazynów.");
        }
        else
        {
            Console.WriteLine("Dostępne magazyny:");
            for (int i = 0; i < magazyny.Count; i++)
            {
                Console.WriteLine($"{i}. {magazyny[i]}");
            }
        }
    }
}