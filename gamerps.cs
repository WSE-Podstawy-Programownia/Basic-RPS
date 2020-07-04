using System;
using System.Collections.Generic;
using static System.Console;

class GameRPS : Game
{
    public GameRPS()
    {        
    }

    protected override Dictionary<string, string> InputTable => new Dictionary<string, string>()
        {
            {"1", "Rock"},
            {"2", "Paper"},
            {"3", "Scissors"}
        };

    public override string GameName => "Rock-Paper-Scissors";

    public override string GameRules => "The rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n" +
            "[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\n" +
            "\nAfter both players have chosen, the winner is determined. " +
            "After each game the application will ask the players if they want to continue, " +
            "and if the player reponds with anything else than [y]es, " +
            $"the game ends and presents the record of the last up to {gamesRecord.gamesRecordSize} games.\n\n" +
            "Have fun!\n";

    protected override string DetermineWinner()
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
            Console.WriteLine($"{playerOne.PlayerName} won!");
            return String.Format($"{playerOne.PlayerName} won!");
        }
        else
        {
            Console.WriteLine($"{playerTwo.PlayerName} won!");
            return String.Format($"{playerTwo.PlayerName} won!");
        }
    }
}