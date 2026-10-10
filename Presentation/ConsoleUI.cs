namespace FallenZenith.Presentation;

public class ConsoleUI
{
    public void ShowMainMenu()
    {   string mainMenuChoice ="";

        do
        {
            Console.WriteLine("Welcome to Fallen Zenith!");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit Game");
            mainMenuChoice = Console.ReadLine();

            switch(mainMenuChoice)
            {
                case "1":
                    Console.WriteLine("Starting game...");
                    // Add logic to start the game
                    break;
                case "2":
                    Console.WriteLine("Exiting game...");
                    // Add logic to exit the game
                    return;
                default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
            }
        } while(mainMenuChoice !="1" && mainMenuChoice!="2");

    }
}