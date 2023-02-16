namespace Exo02;
class Program
{
    // Write a Boolean expression that checks whether a given integer is
    // divisible by both 5 and 7, without a remainder.
    static void Main(string[] args)
    {
        int n = 35;
        bool divisible = (n % 5 == 0) && (n % 7 == 0);
        Console.WriteLine("n = " + n + " is divisible by 5 and 7: " + divisible);
    }
}
