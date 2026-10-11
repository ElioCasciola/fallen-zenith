using FallenZenith.Domain;
using FallenZenith.Presentation;

var consoleUI = new ConsoleUI();
consoleUI.ShowMainMenu();
var monster1 = new Monster("Ciccio",1,1,1,1,1,1,1,1,1,1,1, new List<Skill>());
Console.WriteLine(monster1.MaxHP);
