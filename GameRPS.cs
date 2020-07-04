using System;
using System.Collections.Generic;
using static System.Console;

public class GameRPS
{
    Player playerOne, playerTwo;
    public GamesRecord gamesRecord;

    Dictionary<int, string> inputTable = new Dictionary<int, string> () 
    {
      {1, "Rock"},
      {2, "Paper"},
      {3, "Scissors"}
    };
    

    public GameRPS(bool singlePlayer = false)
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

    public string DetermineWinner (Player playerOne, Player playerTwo)
    {
        if (playerOne.LastInput == playerTwo.LastInput){
            WriteLine ("It's a draw!");
            return "Draw";
        }
        else if ((playerOne.LastInput == "Rock" && playerTwo.LastInput == "Scissors") ||
                (playerOne.LastInput == "Paper" && playerTwo.LastInput == "Rock") ||
                (playerOne.LastInput == "Scissors" && playerTwo.LastInput == "Paper")){
            Console.WriteLine ("{0} won!", playerOne.PlayerName);
            return String.Format("{0} won!", playerOne.PlayerName);
        }
        else{
            Console.WriteLine ("{0} won!", playerTwo.PlayerName);
            return String.Format("{0} won!", playerTwo.PlayerName);
        }
    }


    public void PlayGame()
    {
        Clear();
        // int playerOneChoice = GetPlayerInput(playerOne);
        playerOne.GetInput(inputTable);

        Clear();
        // int playerTwoChoice = GetPlayerInput(playerTwo);
        playerTwo.GetInput(inputTable);

        string winner = DetermineWinner(playerOne, playerTwo);

        gamesRecord.AddRecord(playerOne.LastInput, playerTwo.LastInput, winner);

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
            // int playerOneChoice = GetPlayerInput(playerOne);
            playerOne.GetInput(inputTable);

            Clear();
            // int playerTwoChoice = GetPlayerInput(playerTwo);
            playerTwo.GetInput(inputTable);

            string winner = DetermineWinner(playerOne, playerTwo);

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