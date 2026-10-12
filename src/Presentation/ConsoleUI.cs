namespace FallenZenith.Presentation;

public class ConsoleUI
{
    public void ShowMainMenu()
    {
        string? mainMenuChoice = "";

        do
        {
            Console.WriteLine("Welcome to Fallen Zenith!");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit Game");
            mainMenuChoice = Console.ReadLine();

            switch (mainMenuChoice)
            {
                case "1":
                    Console.WriteLine("Starting game...");

                    break;
                case "2":
                    Console.WriteLine("Exiting game...");
                    // Add logic to exit the game
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (mainMenuChoice != "1" && mainMenuChoice != "2");

    }

    public void ShowFirstTurn(bool playerFirst)
    {
        if(playerFirst)
        {
            Console.WriteLine("Player Moves First");
            Console.WriteLine("Enemy Moves Second");
        }
        else
        {
            Console.WriteLine("Enemy Moves First");
            Console.WriteLine("Player Moves Second");
        }
    }

    public void ShowAttackResult(int damage, int remainingHP)
    {
        Console.WriteLine($"Damage dealt: {damage}");
        Console.WriteLine($"Remaining HP: {remainingHP}");
    }

    public void ShowBar(string label, int current, int maximum)
    {
        int width = 20;
        int filled = 0;

        if (maximum > 0)
        {
            if (current < 0)
            {
                current = 0;
            }
            else if (current > maximum)
            {
                current = maximum;
            }

            filled = current * width / maximum;
        }

        int empty = width - filled;

        string filledBar = new string('#', filled);
        string emptyBar = new string('-', empty);

        Console.WriteLine($"{label} [{filledBar}{emptyBar}] {current}/{maximum}");
    }

    public void ShowAttackResult(string attacker, string defender, int damage)
    {
        Console.WriteLine($"{attacker} attacks {defender}!");
        Console.WriteLine($"{defender} takes {damage} damage!");
    }
}