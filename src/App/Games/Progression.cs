namespace App.Games;

public static class Progression
{
    private const string Description = "What number is missing in the progression?";
    private const int ProgressionLength = 10;
    private const int MinStep = 1;
    private const int MaxStep = 10;

    public static void Start()
    {
        var rounds = Enumerable
            .Range(0, Utils.RoundQuantity)
            .Select(_ =>
                GenerateProgression(
                        Random.Shared.Next(Utils.MinNumber, Utils.MaxNumber),
                        Random.Shared.Next(MinStep, MaxStep),
                        ProgressionLength
                    )
                    .ToArray()
            )
            .Select(progression =>
            {
                var answerIndex = Random.Shared.Next(0, progression.Length);
                var answer = progression[answerIndex].ToString();

                var question = string.Join(
                    " ",
                    progression.Select(
                        (item, index) => index == answerIndex ? ".." : item.ToString()
                    )
                );
                return (question, answer);
            });

        Engine.Start(rounds.ToArray(), Description);
    }

    private static IEnumerable<int> GenerateProgression(int start, int step, int length)
    {
        return Enumerable.Range(0, length).Select(index => start + index * step);
    }
}
