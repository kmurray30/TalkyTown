// See https://aka.ms/new-console-template for more information
using TalkyTown;

class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine("Hello, World!");
        Console.WriteLine(args.Length);

        GameLoop();
    }

    static void GameLoop()
    {
        WorldView TrueView = new WorldView();

        while (true)
        {
            var input = Console.ReadLine();
            Console.WriteLine("You said: " + input);
        }
    }
}