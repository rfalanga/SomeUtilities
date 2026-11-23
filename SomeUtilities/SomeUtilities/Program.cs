using System.Reflection;

// Small change to trigger a build
class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            if (args[0] == "--version")
            {
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                Console.WriteLine($"Version: {version}");
            }
            else
            {
                Console.WriteLine("Unknown argument. Use --version to get the version.");
            }
        }
        else
        {
            Console.WriteLine("SomeUtilities --version");
        }
    }
}   