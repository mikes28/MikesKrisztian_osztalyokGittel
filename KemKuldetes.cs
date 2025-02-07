namespace MikesKrisztian_osztalyokGittel;

internal class KemKuldetes
{
    public string? Kodnev { get; set; }
    public string? Orszag { get; set; }
    public int VeszelySzint { get; set; }
    public double SikerEsej { get; set; }



    public KemKuldetes(string kodnev, string orszag, int veszelySzint, double sikerEsej)
    {
        Kodnev = kodnev;
        Orszag = orszag;
        VeszelySzint = veszelySzint;
        SikerEsej = sikerEsej;
    }

    public KemKuldetes(string kodnev, string orszag)
    {
        Kodnev = kodnev;
        Orszag = orszag;
        VeszelySzint = 5;
        SikerEsej = 50.0;
    }


    public void KuldetesInditasa()
    {
        Console.WriteLine("A küldetés elkezdődött.");
    }

    public void VeszelySzintNovelese(int mennyiseg)
    {
        VeszelySzint += mennyiseg;
    }

    public void SikerEsejNovelese(int szazalek)
    {
        SikerEsej += szazalek;
    }

    public override string ToString()
    {
        return $"Kódnév: {Kodnev}, Ország: {Orszag}, Veszélyszint: {VeszelySzint}, Siker esély: {SikerEsej}%";
    }
}
