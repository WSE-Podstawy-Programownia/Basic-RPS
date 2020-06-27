using System;
using static System.Console;

class GameController
{
    Game game;
    GameRecord gameRecord;
    public GameController()
    {
        gameRecord = new GameRecord();
    }
    public void DisplayRules(bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine("Welcome to a simple Rock-Paper-Scissors game!");
        }
        WriteLine("The rules are very simple - each player chooses Rock, Paper or Scissors, the choice is made by entering its number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both players choise is made, the winner is determined. After each game the application will ask the player if they want to continue, and if the player repond with anything else than [y]es than the game ends and the record of the last up to 10 games is presented.\n\nHave fun!");
    }
    public void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Rock-Paper-Scissors Menu:\n[1] Player vs Player\n[2] Player vs Computer\n[3] Show rules\n[4] Game Score\n[ESC] Exit");
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                game = new Game();
                game.Play();
                gameRecord += game.gameRecord;
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                game = new Game(true);
                game.Play();
                gameRecord += game.gameRecord;
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                DisplayRules(false);
            }
            else if (inputKey.Key == ConsoleKey.D4)
            {
                gameRecord.DisplayGameHistory();
            }
            else { continue; }
            WriteLine("(click any key to continue)");
            ReadKey(true);
        }
        while (inputKey.Key != ConsoleKey.Escape);
    }
}