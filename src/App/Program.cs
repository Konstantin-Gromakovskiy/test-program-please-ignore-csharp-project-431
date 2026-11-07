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
            3 - Calc
            4 - GCD
            5 - Progression
            6 - Prime
            0 - Exit
            """
        );
        Console.Write("Your choice: ");
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
                Games.Even.Start();
                break;
            }
            case "3":
            {
                Games.Calc.Start();
                break;
            }
            case "4":
            {
                Games.Gcd.Start();
                break;
            }
            case "5":
            {
                Games.Progression.Start();
                break;
            }
            case "6":
            {
                Games.Prime.Start();
                break;
            }
            case "0":
            {
                Console.WriteLine("Программа завершена");
                return;
            }
            default:
            {
                Console.WriteLine("Неизвестный тип ответа");
                return;
            }
        }
    }
}
