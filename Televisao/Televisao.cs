namespace Televisao;

public class Televisao
{
    private static int volume = 0;
    private static int canal = 1;

    public Televisao()
    {
    }

    public static void consultar()
    {
        Console.WriteLine("Volume: {0}, Canal: {1}",volume,canal);
    }

    public static int Volume
    {
        get => volume;
        set => volume = value;
    }

    public static int Canal
    {
        get => canal;
        set => canal = value;
    }
}