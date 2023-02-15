namespace Exo03;
class Program
{
    static void Main(string[] args)
    {
        decimal a = 1.0000001m;
        decimal b = 1m;
        bool equals = Math.Abs(a - b) < 0.000001m;
        Console.WriteLine(equals);
    }
}
