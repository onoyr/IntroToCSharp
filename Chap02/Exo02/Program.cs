namespace Exo02;
class Program
{
    // Which of the following values can be assigned to variables of type float,
    // double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
    // 3456.091124875956542151256683467?
    static void Main(string[] args)
    {
        float a = 5f;
        float b = -5.01f;
        double c = 34.567839023d;
        float d = 12.345f;
        double e = 8923.1234857d;
        decimal f = 3456.091124875956542151256683467m;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.WriteLine("e = " + e);
        Console.WriteLine("f = " + f);
    }
}
