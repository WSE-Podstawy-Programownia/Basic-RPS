using System;
using System.Collections.Generic;
using static System.Console;

class GameRPS : Game
{
    // Dictionary<string, string> inputTable = new Dictionary<string, string>(){
    //     {"1", "Rock"},
    //     {"2", "Paper"},
    //     {"3", "Scissors"}
    // };
    // Player playerOne, playerTwo;
    // public GameRecord gameRecord;

    public GameRPS(bool singleplayer = false)
    {
        GameName = "Rock_Paper_Scissors";
        GameRules = "The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!";
        inputTable = new Dictionary<string, string>()
        {
            {"1", "Rock"},
            {"2", "Paper"},
            {"3", "Scissors"}
        };
        playerOne = new Player();
        if (singleplayer) playerTwo = new AIPlayer();
        else playerTwo = new Player();
        gameRecord = new GameRecord();
    }

    public string GetPlayerInput(Player player)
    {
        string rawInput;
        string properInput;
        WriteLine("Choose one: \n1 - Rock\n2 - Paper\n3 - Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine("Wrong input. Please enter correct one.\nChoose one:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }

        if (rawInput == "1") { properInput = "Rock"; }
        else if (rawInput == "2") { properInput = "Paper"; }
        else { properInput = "Scissors"; }

        WriteLine("Player " + player.PlayerName + " choose " + properInput);

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

        gameRecord.AddRecord(playerOne.LastInput, playerTwo.LastInput, gameResult);

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }
}
