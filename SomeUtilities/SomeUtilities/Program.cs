using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Assembly: {Assembly.GetExecutingAssembly().GetName().Name}");

        if (args.Length > 0)
        {
            Console.WriteLine($"Arguments: {string.Join(", ", args)}");
        }
        else
        {
            Console.WriteLine("SomeUtilities --version");
        }
    }
}   