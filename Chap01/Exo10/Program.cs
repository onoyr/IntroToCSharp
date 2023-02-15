namespace Exo10;
class Program
{
    static void Main(string[] args)
    {
        var n = 2;

        for (int i = 0; i < 100; i++)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n * -1);
            }
            else
            {
                Console.WriteLine(n);
            }
            n++;
        }
    }
}
