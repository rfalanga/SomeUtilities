using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Assembly: {Assembly.GetExecutingAssembly().GetName().Name}");
    }
}   