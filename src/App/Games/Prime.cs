namespace App.Games;

public static class Prime
{
    private const string Description =
        "Answer 'yes' if given number is prime. Otherwise answer 'no'.";

    public static void Start()
    {
        var rounds = Enumerable
            .Range(0, Utils.RoundQuantity)
            .Select(_ =>
            {
                var number = Random.Shared.Next(Utils.MinNumber, Utils.MaxNumber);

                var question = number.ToString();
                var answer = IsPrime(number) ? "yes" : "no";
                return (question, answer);
            });

        Engine.Start(rounds.ToArray(), Description);
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (var divisor = 2; divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }
}
