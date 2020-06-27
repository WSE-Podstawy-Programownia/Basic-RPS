using System;
using static System.Console;

class Game
{
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
    public string DetermineWinner(Player playerOne, string playerOneInput, Player playerTwo, string playerTwoInput)
    {
        if (playerOneInput == playerTwoInput)
        {
            WriteLine("It's a draw!");
            return "Draw";
        }
        else if ((playerOneInput == "Rock" && playerTwoInput == "Scissors") ||
         (playerOneInput == "Paper" && playerTwoInput == "Rock") ||
         (playerOneInput == "Scissors" && playerTwoInput == "Paper"))
        {
            string result = "Player " + playerOne.playerName + " won!";
            Console.WriteLine(result);
            return result;
        }
        else
        {
            string result = "Player " + playerTwo.playerName + " won!";
            Console.WriteLine(result);
            return result;
        }
    }
    public void Play()
    {
        Clear();
        string firstPlayerChoiceString = GetPlayerInput(playerOne);

        Clear();
        string secondPlayerChoiceString = GetPlayerInput(playerTwo);

        Clear();
        string gameResult = DetermineWinner(playerOne, firstPlayerChoiceString, playerTwo, secondPlayerChoiceString);

        gameRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult);

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }
}
