using System;
using System.Collections.Generic;
using static System.Console;

class GameRPS : Game
{
    public GameRPS(bool singleplayer = false)
    {        
        inputTable = new Dictionary<string, string>()
        {
            {"1", "Rock"},
            {"2", "Paper"},
            {"3", "Scissors"}
        };

        playerOne = new Player();
        if (singleplayer) playerTwo = new AIPlayer();
        else playerTwo = new Player();
        gamesRecord = new GamesRecord();

        GameName = "Rock-Paper-Scissors";
        GameRules = "The rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n" +
            "[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\n" +
            "\nAfter both players have chosen, the winner is determined. " +
            "After each game the application will ask the players if they want to continue, " +
            "and if the player reponds with anything else than [y]es, " +
            $"the game ends and presents the record of the last up to {gamesRecord.gamesRecordSize} games.\n\n" +
            "Have fun!\n";
    }

    public override string GetPlayerInput(Player player)
    {
        string rawInput;
        string properInput;
        WriteLine($"{player.PlayerName}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine($"Wrong input. Please enter correct one.\n{player.PlayerName}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }
        if (rawInput == "1") { properInput = "Rock"; }
        else if (rawInput == "2") { properInput = "Paper"; }
        else { properInput = "Scissors"; }
        return properInput;
    }

    string DetermineWinner(Player playerOne, Player playerTwo)
    {
        if (playerOne.LastInput == playerTwo.LastInput)
        {
            WriteLine("It's a draw!");
            return "Draw";
        }
        else if ((playerOne.LastInput == "Rock" && playerTwo.LastInput == "Scissors") ||
                (playerOne.LastInput == "Paper" && playerTwo.LastInput == "Rock") ||
                (playerOne.LastInput == "Scissors" && playerTwo.LastInput == "Paper"))
        {
            Console.WriteLine("{0} won!", playerOne.PlayerName);
            return String.Format("{0} won!", playerOne.PlayerName);
        }
        else
        {
            Console.WriteLine("{0} won!", playerTwo.PlayerName);
            return String.Format("{0} won!", playerTwo.PlayerName);
        }
    }

    public override void Play()
    {
        Clear();
        playerOne.GetInput(inputTable);

        Clear();
        playerTwo.GetInput(inputTable);

        Clear();

        string gameResult = DetermineWinner(playerOne, playerTwo);
        gamesRecord.AddRecord(playerOne.LastInput, playerTwo.LastInput, gameResult);

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }
}