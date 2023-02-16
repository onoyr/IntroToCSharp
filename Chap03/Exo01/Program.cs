namespace Exo01;
class Program
{
    // Write an expression that checks whether an integer is odd or even.
    static void Main(string[] args)
    {
        int n = 11;
        bool isOdd = n % 2 != 0;
        Console.WriteLine("n = " + n + " is odd: " + isOdd);
    }
}
