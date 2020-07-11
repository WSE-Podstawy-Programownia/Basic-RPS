using System;
using System.Collections.Generic;
using static System.Console;

public class GameAlmostBlackJack : Game
{
    private Random random;
    public GameAlmostBlackJack(bool singlePlayer = false)
    {
        GameName = "Almost Black Jack";
        GameRules = "The rules are ridiculously complicated and can only be comprehended by criminal masterminds and gambling addicts.\n" + 
            "When the game starts, a value between 1 and 10 is randomly selected, which players do not know. Both players then start with a bet of 0.\n" + 
            "Then they take turns raising each other, until one of them passes. The player with the higher bet wins.\n" + 
            "If a player bets above the random value, they lose. Life is brutal. Deal with it.";

        inputTable = new Dictionary<int, string>()
        {
            {1, "Raise"},
            {2, "Pass"},
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
        int maxValue = random.Next(1, 11);

        int playerOneBet = 0;
        int playerTwoBet = 0;

        bool playerOnePassed = false;
        bool playerTwoPassed = false;

        string winner;

        while (true)
        {
            if (!playerOnePassed)
            {
                Clear();
                playerOne.GetInput(inputTable);

                if (playerOne.LastInput == "Raise")
                {
                    playerOneBet = playerTwoBet + 1;
                }
                else
                {
                    playerOnePassed = true;
                }

                if (playerOneBet > maxValue)
                {
                    Console.WriteLine($"{playerOne.PlayerName}, your hubris was your undoing. You fool!");
                    winner = playerTwo.PlayerName;
                    break;
                }
            }

            if (!playerTwoPassed)
            {
                Clear();
                playerTwo.GetInput(inputTable);

                if (playerTwo.LastInput == "Raise")
                {
                    playerTwoBet = playerOneBet + 1;
                }
                else
                {
                    playerTwoPassed = true;
                }

                if (playerTwoBet > maxValue)
                {
                    Console.WriteLine($"{playerTwo.PlayerName}, your hubris was your undoing. You fool!");
                    winner = playerOne.PlayerName;
                    break;
                }
            }

            if (playerOnePassed && playerTwoPassed)
            {
                if ( playerOneBet == playerTwoBet)
                {
                    winner = "DRAW";
                }
                else
                {
                    winner = playerOneBet > playerTwoBet ? playerOne.PlayerName : playerTwo.PlayerName;
                }
                break;
            }
        }

        gamesRecord.AddRecord(new RecordABJ(playerOneBet, playerTwoBet, maxValue, winner));

        WriteLine($"{winner} wins.");

        Console.WriteLine("Do you want to play another round? [y]");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            PlayGame();
        }

    }
}