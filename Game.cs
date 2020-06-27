using System;
using System.Collections.Generic;
using static System.Console;

class Game
{
    Dictionary<string, string> inputTable = new Dictionary<string, string>(){
        {"1", "Rock"},
        {"2", "Paper"},
        {"3", "Scissors"}
    };
    Player playerOne, playerTwo;
    public GameRecord gameRecord;

    public Game()
    {
        playerOne = new Player();
        playerTwo = new Player();
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

        WriteLine("Player " + player.playerName + " choose " + properInput);

        return properInput;
    }
    public string DetermineWinner(Player playerOne, Player playerTwo)
    {
        if (playerOne.lastInput == playerTwo.lastInput)
        {
            WriteLine("It's a draw!");
            return "Draw";
        }
        else if ((playerOne.lastInput == "Rock" && playerTwo.lastInput == "Scissors") ||
         (playerOne.lastInput == "Paper" && playerTwo.lastInput == "Rock") ||
         (playerOne.lastInput == "Scissors" && playerTwo.lastInput == "Paper"))
        {
            Console.WriteLine("{0} won!", playerOne.playerName);
            return String.Format("{0} won!", playerOne.playerName);
        }
        else
        {
            Console.WriteLine("{0} won!", playerTwo.playerName);
            return String.Format("{0} won!", playerTwo.playerName);
        }
    }
    public void Play()
    {
        Clear();
        playerOne.GetInput(inputTable);

        Clear();
        playerTwo.GetInput(inputTable);

        Clear();
        string gameResult = DetermineWinner(playerOne, playerTwo);

        gameRecord.AddRecord(playerOne.lastInput, playerTwo.lastInput, gameResult);

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }
}
