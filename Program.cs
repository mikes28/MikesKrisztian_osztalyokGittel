using MikesKrisztian_osztalyokGittel;

internal class Program
{
    private static void Main(string[] args)
    {
        Konyv konyv1 = new("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
        Konyv konyv2 = new("A kis herceg", "Antoine de Saint-Exupéry");

        Console.WriteLine(konyv1);
        Console.WriteLine(konyv2);

        konyv1.Arnoveles(500);
        Console.WriteLine(konyv1);

        konyv1.Kedvezmeny(10);
        Console.WriteLine(konyv1);

        Console.WriteLine(konyv1.HanyOldalMaradt(50));
        Console.WriteLine(konyv1.HanyOldalMaradt(100));



        Film film1 = new("Titanic", "James Cameron", 195, "romantikus", 1997);
        Film film2 = new("Titanic", "James Cameron");

        Console.WriteLine(film1);
        Console.WriteLine(film2);

        film1.HosszNovelese(10);
        Console.WriteLine(film1);

        film1.MufajModositas("dráma");
        Console.WriteLine(film1);

        System.Console.WriteLine(film1.Jatszas());




        Karakter karakter1 = new("Gandalf", 20, 100, 50);
        Karakter karakter2 = new("Gandalf", 50);

        Console.WriteLine(karakter1);
        Console.WriteLine(karakter2);

        karakter1.Tamadas();
        karakter2.Tamadas();

        karakter1.Gyogyulas(20);
        karakter2.Gyogyulas(30);
        Console.WriteLine(karakter1);
        Console.WriteLine(karakter2);

        karakter1.Szintlepes();
        karakter2.Szintlepes();
        Console.WriteLine(karakter1);
        Console.WriteLine(karakter2);




        Urhajo urhajo1 = new("Millennium Falcon", 1000, 5, 100);
        Urhajo urhajo2 = new("Millennium Falcon", 5);

        Console.WriteLine(urhajo1);
        Console.WriteLine(urhajo2);

        urhajo1.Indulas();
        urhajo2.Indulas();
        Console.WriteLine(urhajo1);
        Console.WriteLine(urhajo2);

        urhajo1.Tankolas(10);
        urhajo2.Tankolas(10);
        Console.WriteLine(urhajo1);
        Console.WriteLine(urhajo2);

        urhajo1.Landolas();
        urhajo2.Landolas();
        Console.WriteLine(urhajo1);
        Console.WriteLine(urhajo2);

    }
}