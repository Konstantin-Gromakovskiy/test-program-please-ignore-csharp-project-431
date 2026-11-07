public static class Cli
{
    public static void Greeting()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.WriteLine("May I have your name?");
        var input = Console.ReadLine();
        Console.WriteLine($"Hello, {input}!");
    }
}
