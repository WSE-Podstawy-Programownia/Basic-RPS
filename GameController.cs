using System;
using System.Collections.Generic;
using static System.Console;
class GameController
{
    GameRPS game;
    GamesRecord gamesRecord;
        
    Dictionary<ConsoleKey, string> menuOptions = new Dictionary<ConsoleKey, string> ()
    {
        {ConsoleKey.D1, "Player vs Player"},
        {ConsoleKey.D2, "Player vs AI"},
        {ConsoleKey.D3, "Show rukes"},
        {ConsoleKey.D4, "Display the record of recent games"},
        {ConsoleKey.D5, "Duel Mode"},
        {ConsoleKey.Escape, "Exit"},
    };
    
    public GameController()
    {
        gamesRecord = new GamesRecord(100);
    }


    public void DisplayRules(bool withWelcomeMessage = true)
    {
        if (withWelcomeMessage)
        {
            WriteLine("Welcome to a simple Rock-Paper-Scissors game!");
        }
        WriteLine("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
    }
    public void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Console.Clear();
            Console.WriteLine("Rock-Paper-Scissors Menu:");

            foreach (var k in menuOptions)
            {
                Console.WriteLine($"\t{k.Key.ToString()}: {k.Value}");
            }

            inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1)
            {
                game = new GameRPS();
                game.PlayGame();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                game = new GameRPS(true);
                game.PlayGame();
                gamesRecord += game.gamesRecord;
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                DisplayRules();
            }
            else if (inputKey.Key == ConsoleKey.D4)
            {
                gamesRecord.DisplayGamesHistory();
            }
            else if (inputKey.Key == ConsoleKey.D5)
            {
                game = new GameRPS();
                game.DuelMode();
            }
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();

        } while (inputKey.Key != ConsoleKey.Escape);
    }
}
