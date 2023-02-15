namespace Exo03;
class Program
{
    // Write a program, which compares correctly two real numbers with
    // accuracy at least 0.000001.
    static void Main(string[] args)
    {
        decimal a = 1.0000001m;
        decimal b = 1m;
        bool equals = Math.Abs(a - b) < 0.000001m;
        Console.WriteLine(equals);
    }
}
