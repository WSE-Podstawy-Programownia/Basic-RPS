using System;
using static System.Console;

public class Game
{
    Player playerOne, playerTwo;
    GamesRecord gamesRecord;

    public Game()
    {
        WriteLine("Set up Player 1:");
        while(true)
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
        while(true)
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

        gamesRecord = new GamesRecord ();
        MainMenuLoop();
    }

    public void DisplayRules (bool withWelcomeMessage = true) {
        if (withWelcomeMessage)
        {
            WriteLine ("Welcome to a simple Rock-Paper-Scissors game!");
        }
        WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
    }


    int GetPlayerInput(Player player)
    {
        int playerChoice;
        bool playerOneParseSuccess;
        do
        {
            Console.WriteLine($"[Player {player.playerName}] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
            playerOneParseSuccess = Int32.TryParse(Console.ReadLine(), out playerChoice);
        } while (!playerOneParseSuccess || playerChoice <= 0 || playerChoice >= 4);

        return playerChoice;
    }

    string DetermineWinner(int playerOneChoice, int playerTwoChoice)
    {
        int difference = playerOneChoice - playerTwoChoice;
        if (difference == 1 || difference == -2)
        {
            Console.WriteLine(playerOne.playerName);
            return playerOne.playerName;
        }
        else if (difference == 0)
        {
            Console.WriteLine("Draw!!!");
            return "Draw";
        }
        else
        {
            Console.WriteLine(playerTwo.playerName);
            return playerTwo.playerName;
        }
    }

    void PlayGame()
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

    void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Console.Clear();
            Console.WriteLine("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
            inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1)
            {
                PlayGame();
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                DisplayRules();
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                gamesRecord.DisplayGamesHistory();
            }
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();

        } while (inputKey.Key != ConsoleKey.Escape);
    }
}