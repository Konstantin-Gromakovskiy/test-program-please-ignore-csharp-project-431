namespace App.Games;

public static class Even
{
    public static void Start()
    {
        var parameter = Enumerable
            .Range(0, int.MaxValue)
            .Select(_ => Utils.GenerateRandomNumber(Utils.MinNumber, Utils.MaxNumber))
            .Select(number => (number.ToString(), number % 2 == 0 ? "yes" : "no"));

        Engine.Start(
            [.. parameter.Take(Utils.RoundQuantity)],
            "Answer 'yes' if the number is even, otherwise answer 'no'."
        );
    }
}
