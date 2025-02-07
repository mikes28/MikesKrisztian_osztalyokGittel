namespace MikesKrisztian_osztalyokGittel;

public class Urhajo
{
    public string? Nev { get; set; }
    public double Sebesseg { get; set; }
    public int UtasKapacitas { get; set; }
    public double UzemanyagSzint { get; set; }




    public Urhajo(string nev, double sebesseg, int utasKapacitas, double uzemanyagSzint)
    {
        Nev = nev;
        Sebesseg = sebesseg;
        UtasKapacitas = utasKapacitas;
        UzemanyagSzint = uzemanyagSzint;

    }



        public Urhajo(string nev, int utasKapacitas)
    {
        Nev = nev;
        Sebesseg = 0;
        UtasKapacitas = utasKapacitas;
        UzemanyagSzint = 100;

    }


    public void Indulas()
    {
        if (UzemanyagSzint > 0)
        {
            Sebesseg += 10;
            UzemanyagSzint -= 5;
        }
        else
        {
            Console.WriteLine("Nincs elegendő üzemanyag az induláshoz.");
        }
    }



    public void Tankolas(int mennyiseg)
    {
        UzemanyagSzint += mennyiseg;
    }

    public void Landolas()
    {
        Sebesseg = 0;
    }

    public override string ToString()
    {
        return $"Név: {Nev}, Sebesség: {Sebesseg}, Utas Kapacitás: {UtasKapacitas}, Üzemanyag Szint: {UzemanyagSzint}";
    }
}
