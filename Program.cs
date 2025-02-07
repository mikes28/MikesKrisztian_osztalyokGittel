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
    }
}