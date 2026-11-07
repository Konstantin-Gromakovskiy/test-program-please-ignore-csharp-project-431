namespace App.games;

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

        for (var i = 0; i < 3; i++)
        {
            var radomNumber = GenerateRandomNumber(0, 100);

            Console.WriteLine($"Question: {radomNumber}");
            var answer = Console.ReadLine();
            var correctAnswer = radomNumber % 2 == 0 ? "yes" : "no";

            if (answer != correctAnswer)
            {
                Console.WriteLine(
                    $"""
                    '{answer}' is wrong answer ;(. Correct answer was '{correctAnswer}'.
                    Let's try again, {name}!
                    """
                );
                return;
            }

            Console.WriteLine("Correct!");
        }

        Console.WriteLine($"Congratulations, {name}!");
    }

    private static int GenerateRandomNumber(int min, int max)
    {
        var random = new Random();
        return random.Next(min, max);
    }
}
