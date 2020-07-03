using System;
using static System.Console;

public class Game
{
    Player playerOne, playerTwo;
    public GamesRecord gamesRecord;

    public Game()
    {
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
                playerTwo = new Player();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                continue;
            }
            break;
        }

        gamesRecord = new GamesRecord();
    }

    int GetPlayerInput(Player player)
    {
        int playerChoice;
        bool playerOneParseSuccess;
        do
        {
            Console.WriteLine($"[Player {player.PlayerName}] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
            playerOneParseSuccess = Int32.TryParse(Console.ReadLine(), out playerChoice);
        } while (!playerOneParseSuccess || playerChoice <= 0 || playerChoice >= 4);

        return playerChoice;
    }

    string DetermineWinner(int playerOneChoice, int playerTwoChoice)
    {
        int difference = playerOneChoice - playerTwoChoice;
        if (difference == 1 || difference == -2)
        {
            Console.WriteLine(playerOne.PlayerName);
            return playerOne.PlayerName;
        }
        else if (difference == 0)
        {
            Console.WriteLine("Draw!!!");
            return "Draw";
        }
        else
        {
            Console.WriteLine(playerTwo.PlayerName);
            return playerTwo.PlayerName;
        }
    }

    public void PlayGame()
    {
        Clear();
        int playerOneChoice = GetPlayerInput(playerOne);

        Clear();
        int playerTwoChoice = GetPlayerInput(playerTwo);

        string winner = DetermineWinner(playerOneChoice, playerTwoChoice);

        gamesRecord.AddRecord(playerOneChoice, playerTwoChoice, winner);

        Console.WriteLine("Do you want to play another round? [y]");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            PlayGame();
        }

    }

    public void DuelMode()
    {
        playerOne.SetPlayerHealth();
        playerOne.SetPlayerDamage();
        playerTwo.SetPlayerHealth();
        playerTwo.SetPlayerDamage();

        while (playerOne.Health > 0 && playerTwo.Health > 0)
        {
            WriteLine($"{playerOne.PlayerName}: {playerOne.Health} HP.");
            WriteLine($"{playerTwo.PlayerName}: {playerTwo.Health} HP.");
            WriteLine("Press ENTER to continue...");
            ReadLine();
            Clear();
            int playerOneChoice = GetPlayerInput(playerOne);

            Clear();
            int playerTwoChoice = GetPlayerInput(playerTwo);

            string winner = DetermineWinner(playerOneChoice, playerTwoChoice);
            if (playerOne.PlayerName == winner)
            {
                playerTwo.Health -= playerOne.Damage;
            }
            else if (playerTwo.PlayerName == winner)
            {
                playerOne.Health -= playerTwo.Damage;
            }
        }
        if (playerOne.Health <= 0)
        {
            WriteLine($"{playerTwo.PlayerName} won!");
        }
        else if (playerTwo.Health <= 0)
        {
            WriteLine($"{playerOne.PlayerName} won!");
        }
    }


}