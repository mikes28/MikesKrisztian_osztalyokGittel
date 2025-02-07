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
    }
}