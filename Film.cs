namespace MikesKrisztian_osztalyokGittel;

internal class Film
{
    public string? Cim { get; set; }
    public string? Rendezo { get; set; }
    public int HosszPercekben { get; set; }
    public string? Mufaj { get; set; }
    public int Megjelent { get; set; }




    public Film(string cim, string rendezo, int hosszPercekben, string mufaj, int megjelent)
    {
        Cim = cim;
        Rendezo = rendezo;
        HosszPercekben = hosszPercekben;
        Mufaj = mufaj;
        Megjelent = megjelent;

    }

    public Film(string cim, string rendezo)
    {
        Cim = cim;
        Rendezo = rendezo;
        HosszPercekben = 120;
        Mufaj = "Ismeretlen";
        Megjelent = 0;
    }



    public string Jatszas()
    {
        return $"{Cim} című film elkezdodott!";
    }
    public void MufajModositas(string ujMufaj)
    {
        Mufaj = ujMufaj;
    }
    public void HosszNovelese(int percek)
    {
        HosszPercekben += percek;
    }
    public override string? ToString()
    {
        return $"Cím: {Cim}, Rendező: {Rendezo}, Hossz: {HosszPercekben} perc, Műfaj: {Mufaj}, Megjelent: {Megjelent}";
    }
}
