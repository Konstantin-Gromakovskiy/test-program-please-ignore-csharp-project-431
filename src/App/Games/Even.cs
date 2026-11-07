namespace App.Games;

public static class Even
{
    public static void Start()
    {
        Console.WriteLine(
            """
            Welcome to the Brain Games!
            May I have your name?
            """
        );

        var name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Please enter a name.");
            return;
        }

        Console.WriteLine($"Hello {name}!");
        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'.");

        var parameter = Enumerable
            .Range(0, int.MaxValue)
            .Select(_ => GenerateRandomNumber(0, 100))
            .Select(number => (number.ToString(), number % 2 == 0 ? "yes" : "no"));

        Engine.Start([.. parameter.Take(3)], name);
    }

    private static int GenerateRandomNumber(int min, int max)
    {
        var random = new Random();
        return random.Next(min, max);
    }
}
