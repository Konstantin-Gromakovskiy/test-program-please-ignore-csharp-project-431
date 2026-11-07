using App;

namespace App.Games;

public static class Calc
{
    public static void Start()
    {
        string description = "What is the result of the expression?";
        var rounds = Enumerable
            .Range(0, Utils.RoundQuantity)
            .Select(_ =>
            {
                var random1 = Random.Shared.Next(Utils.MinNumber, Utils.MaxNumber);
                var random2 = Random.Shared.Next(Utils.MinNumber, Utils.MaxNumber);
                var randomOper = GetRandomOperator();
                var result = Calculate(random1, random2, randomOper);

                string question = $"{random1} {GetSign(randomOper)} {random2}";
                return (question: question, rightAnswer: result.ToString());
            });

        Engine.Start(rounds.ToArray(), description);
    }

    private static int Calculate(int arg1, int arg2, MathOperator oper)
    {
        return oper switch
        {
            MathOperator.Add => arg1 + arg2,
            MathOperator.Multiply => arg1 * arg2,
            MathOperator.Subtract => arg1 - arg2,
            _ => throw new ArgumentOutOfRangeException(nameof(oper), oper, null),
        };
    }

    private static MathOperator GetRandomOperator()
    {
        MathOperator[] opers = Enum.GetValues<MathOperator>();
        return opers[Random.Shared.Next(opers.Length)];
    }

    private static char GetSign(MathOperator oper) =>
        oper switch
        {
            MathOperator.Add => '+',
            MathOperator.Multiply => '*',
            MathOperator.Subtract => '-',
            _ => throw new ArgumentOutOfRangeException(nameof(oper), oper, null),
        };

    private enum MathOperator
    {
        Add,
        Subtract,
        Multiply,
    }
}
