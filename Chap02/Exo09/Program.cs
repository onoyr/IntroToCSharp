namespace Exo09;
class Program
{
    // Declare two variables of type string and assign them a value “The
    // "use" of quotations causes difficulties.” (without the outer quotes).
    // In one of the variables use quoted string and in the other do not use it.
    static void Main(string[] args)
    {
        string withQuotes = "The \"use\" of quotations causes difficulties.";
        string withoutQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(withQuotes);
        Console.WriteLine(withoutQuotes);
    }
}
