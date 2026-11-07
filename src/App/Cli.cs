namespace App;

public static class Cli
{
    public static string Greeting()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.WriteLine("May I have your name?");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        return name ?? "";
    }
}
