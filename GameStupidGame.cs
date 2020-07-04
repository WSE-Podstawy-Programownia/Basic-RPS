using System;
using System.Collections.Generic;
using static System.Console;

public class GameStupidGame : Game
{
    private Random random;
    public GameStupidGame(bool singlePlayer = false)
    {
        GameName = "Stupid Game Haha";
        GameRules = "The rules are very simple. You have no control. The winner is picked randomly.";

        inputTable = new Dictionary<int, string>()
        {
            {1, "It does not matter."},
            {2, "It matters not."},
            {3, "Did I mention it does not matter?"},
            {4, "Seriously, nothing matters here."},
        };

        WriteLine("Set up Player 1:");
        while (true)
        {
            try
            {
                playerOne = new Player();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                continue;
            }
            break;
        }

        WriteLine("Set up Player 2:");
        while (true)
        {
            try
            {
                playerTwo = singlePlayer ? new AIPlayer() : new Player();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                continue;
            }
            break;
        }

        gamesRecord = new GamesRecord();

        random = new Random();
    }

    public override int GetPlayerInput(Player player)
    {
        return 1;
    }

    public override void PlayGame()
    {
        Clear();
        playerOne.GetInput(inputTable);

        Clear();
        playerTwo.GetInput(inputTable);

        string winner = random.Next(0, 2) == 0 ? playerOne.PlayerName : playerTwo.PlayerName;

        gamesRecord.AddRecord(playerOne.LastInput, playerTwo.LastInput, winner);

        WriteLine($"{winner} wins.");

        Console.WriteLine("Do you want to play another round? [y]");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            PlayGame();
        }

    }
}