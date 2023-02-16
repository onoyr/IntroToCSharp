namespace Exo05;
class Program
{
    // Declare a variable of type char and assign it as a value the character,
    // which has Unicode code, 72 (use the Windows calculator in order to find
    // hexadecimal representation of 72)
    static void Main(string[] args)
    {
        char c = '\u0048';
        Console.WriteLine(c);
    }
}
