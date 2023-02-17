namespace Exo03;
class Program
{
    // Write an expression that looks for a given integer if its third digit (right
    // to left) is 7.
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        if (input == null) {
            Console.WriteLine("Invalid input");
            return;
        }
        
        long n = long.Parse(input);
        long v = n;
        long remainder = 0;
        int i = 1;

        while (i < 4) {
            long exponent = (long) Math.Pow(10, i);
            remainder = v % exponent;
            v = v - remainder;
            Console.WriteLine("n" + i + " = " + v + " r = " + remainder);
            i++;
        }

        bool equals = remainder / (long) Math.Pow(10, 2) == 7;
        Console.WriteLine("The third digits is equals to 7: " + equals);
    }
}
