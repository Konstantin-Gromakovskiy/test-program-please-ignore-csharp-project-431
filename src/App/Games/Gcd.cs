namespace App.Games;

public static class Gcd
{
    private const string Description = "Find the greatest common divisor of given numbers.";

    public static void Start()
    {
        var rounds = Enumerable
            .Range(0, Utils.RoundQuantity)
            .Select(_ =>
            {
                var num1 = Random.Shared.Next(Utils.MinNumber, Utils.MaxNumber);
                var num2 = Random.Shared.Next(Utils.MinNumber, Utils.MaxNumber);

                var gcd = GetGcd(num1, num2);

                var question = $"{num1} {num2}";
                var answer = gcd.ToString();
                return (question, answer);
            });

        Engine.Start([.. rounds], Description);
    }

    private static int GetGcd(int num1, int num2)
    {
        while (num2 != 0)
        {
            var tmp = num2;
            num2 = num1 % num2;
            num1 = tmp;
        }
        return num1;
    }
}
