namespace App;

/// <summary>
/// Общие константы и вспомогательные методы для игр.
/// </summary>
public static class Utils
{
    /// <summary>
    /// Количество раундов в одной игре.
    /// </summary>
    public const int RoundQuantity = 3;

    /// <summary>
    /// Верхняя граница случайных чисел по умолчанию (не включительно).
    /// </summary>
    public const int MaxNumber = 100;

    /// <summary>
    /// Нижняя граница случайных чисел по умолчанию (включительно).
    /// </summary>
    public const int MinNumber = 1;

    /// <summary>
    /// Возвращает случайное целое число из диапазона.
    /// </summary>
    /// <param name="min">Нижняя граница (включительно).</param>
    /// <param name="max">Верхняя граница (не включительно).</param>
    /// <returns>
    /// Случайное число от <paramref name="min"/> до <paramref name="max"/> - 1.
    /// </returns>
    public static int GenerateRandomNumber(int min, int max)
    {
        return Random.Shared.Next(min, max);
    }
}
