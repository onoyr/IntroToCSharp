namespace Exo01;
class Program
{
    //     Declare several variables by selecting for each one of them the most
    // appropriate of the types sbyte, byte, short, ushort, int, uint, long
    // and ulong in order to assign them the following values: 52,130; -115;
    // 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
    // 1990; 123456789123456789.
    static void Main(string[] args)
    {
        sbyte a = 52;
        byte b = 130;
        sbyte c = -115;
        int d = 4825932;
        sbyte e = 97;
        short f = -10000;
        short g = 20000;
        byte h = 224;
        short i = 970;
        int j = 970_700_000;
        sbyte k = 112;
        sbyte l = -44;
        int m = -1_000_000;
        short n = 1990;
        long o = 123456789123456789;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.WriteLine("e = " + e);
        Console.WriteLine("f = " + f);
        Console.WriteLine("g = " + g);
        Console.WriteLine("h = " + h);
        Console.WriteLine("i = " + i);
        Console.WriteLine("j = " + j);
        Console.WriteLine("k = " + k);
        Console.WriteLine("l = " + l);
        Console.WriteLine("m = " + m);
        Console.WriteLine("n = " + n);
        Console.WriteLine("o = " + o);
    }
}
