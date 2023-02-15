namespace Exo11;
class Program
{
    // Write a program that reads your age from the console and prints your
    // age after 10 years.
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        var s = Console.ReadLine();
        if (s == null)
        {
            Console.WriteLine("You entered an invalid age");
            return;
        }
        var age = int.Parse(s);
        Console.WriteLine("After 10 years you will be " + (age + 10) + " years old");
    }
}
