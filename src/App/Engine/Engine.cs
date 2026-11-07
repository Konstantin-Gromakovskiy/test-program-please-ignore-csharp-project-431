namespace App;

public static class Engine
{
    public static void Start((string question, string rightAnswer)[] parameters, string userName)
    {
        foreach (var parameter in parameters)
        {
            Console.WriteLine($"Question: {parameter.question}");
            var input = Console.ReadLine();
            Console.WriteLine($"Your answer: {input}");

            if (parameter.rightAnswer == input)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine(
                    $"""
                    '{input}' is wrong answer ;(. Correct answer was '{parameter.rightAnswer}'
                    Let's try again, {userName}
                    """
                );
                return;
            }
        }
        Console.WriteLine($"Congratulations, {userName}!");
    }
}
