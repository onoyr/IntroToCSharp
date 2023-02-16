namespace Exo13;
class Program
{
    // Declare two variables of type int. Assign to them values 5 and 10
    // respectively. Exchange (swap) their values and print them.
    static void Main(string[] args)
    {
        int a = 5;
        int b = 6;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("==SWP==");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
