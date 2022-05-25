namespace Televisao;


public class Comando : Televisao
{
    public static void aumentarVolume()
    {
        if (Volume < 100)
        {
            Volume++;
            Televisao.consultar();
        }
        else
        {
            Console.WriteLine("Volume Maximo");
        }
    }

    public static void diminuirVolume()
    {
        if (Volume > 0)
        {
            Volume--;
            Televisao.consultar();
        }
        else
        {
            Console.WriteLine("Vulume a 0");
        }
    }

    public static void aumentarCanal()
    {
        if (Canal < 999)
        {
            Canal++;
            Televisao.consultar();
        }
        else
        {
            Canal = 1;
            Televisao.consultar();
        }
    }

    public static void diminuirCanal()
    {
        if (Canal > 1 )
        {
            Canal--;
            Televisao.consultar();
        }
        else
        {
            Canal = 999;
            Televisao.consultar();
        }
    }
}