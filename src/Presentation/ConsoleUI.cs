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


}