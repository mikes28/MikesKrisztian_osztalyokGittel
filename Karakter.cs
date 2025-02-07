namespace MikesKrisztian_osztalyokGittel;

internal class Karakter
{
    public string? Nev { get; set; }
    public int Szint { get; set; }
    public int Eletero { get; set; }
    public int Ero { get; set; }





    public Karakter(string nev, int szint, int eletero, int ero)
    {
        Nev = nev;
        Szint = szint;
        Eletero = eletero;
        Ero = ero;

    }


    public Karakter(string nev, int ero)
    {
        Nev = nev;
        Szint = 1;
        Eletero = 100;
        Ero = ero;

    }


    public void Tamadas()
    {
        Console.WriteLine($"{Nev} támad {Ero} erővel.");
    }

    public void Gyogyulas(int mennyiseg)
    {
        Eletero += mennyiseg;
        
    }

    public void Szintlepes()
    {
        Szint++;
        Ero += 5; 
    }

    public override string? ToString()
    {
        return $"Név: {Nev}, Szint: {Szint}, Életerő: {Eletero}, Erő: {Ero}";
    }
}
