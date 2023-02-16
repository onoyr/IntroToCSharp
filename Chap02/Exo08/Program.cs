namespace Exo08;
class Program
{
    // Declare two variables of type string and give them values "Hello" and
    // "World". Assign the value obtained by the concatenation of the two
    // variables of type string (do not miss the space in the middle) to a
    // variable of type object. Declare a third variable of type string and
    // initialize it with the value of the variable of type object (you should use
    // type casting).
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object helloWorldObj = hello + " " + world;
        string helloWorld = (string) helloWorldObj;

        Console.WriteLine(helloWorld);
    }
}
