namespace App;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the game number and press Enter.");
        Console.WriteLine(
            """
            1 - Greet
            2 - Even
            0 - Exit
            """
        );
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
            {
                Cli.Greeting();
                break;
            }
            case "2":
            {
                games.Even.Start();
                break;
            }
            case "0":
            {
                Console.WriteLine("Программа завершена");
                return;
            }
            default:
            {
                Console.WriteLine("Не известный тип ответа");
                return;
            }
        }
    }
}
