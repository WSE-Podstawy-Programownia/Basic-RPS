using System;
using static System.Console;

class GameController
{
    Game game;
    GamesRecord gamesRecord;
    public GameController()
    {        
        gamesRecord = new GamesRecord();        
    }

    public void MainMenuLoop()
    {        
        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Rock-Paper-Scissors Menu:\n\t[1] Play\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
            inputKey = ReadKey(true);
            if (inputKey.Key == ConsoleKey.D1)
            {
                game = new Game();
                game.Play();
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                DisplayRules();
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                gamesRecord.DisplayGamesHistory();
            }
            else { continue; }
            WriteLine("(Press any key to continue)");
            ReadKey(true);
        } while (inputKey.Key != ConsoleKey.Escape);
    }

    public void DisplayRules()
    {
        Clear();        
        WriteLine("The rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n" +
            "[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\n" +
            "\nAfter both players have chosen, the winner is determined. " +
            "After each game the application will ask the players if they want to continue, " +
            "and if the player reponds with anything else than [y]es, " +
            $"the game ends and presents the record of the last up to {gamesRecord.gamesRecordSize} games.\n\n" +
            "Have fun!\n");
    }

    private void DisplayWelcome()
    {
        WriteLine("Welcome to a simple Rock-Paper-Scissors game!");
    }
}