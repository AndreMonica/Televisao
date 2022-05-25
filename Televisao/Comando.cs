namespace Televisao;


public class Comando : Televisao
{
    public static void aumentarVolume()
    {
        Volume++;
        Televisao.consultar();
    }

    public static void diminuirVolume()
    {
        Volume--;
        Televisao.consultar();
    }

    public static void aumentarCanal()
    {
        Canal++;
        Televisao.consultar();
    }

    public static void diminuirCanal()
    {
        Canal--;
        Televisao.consultar();
    }
}