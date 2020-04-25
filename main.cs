using System;
using static System.Console;

class MainClass
{

    public static void Main(string[] args)
    {
        // declaration and initialization of the global game variables
        int gamesRecordSize = 10;
        string[,] gamesRecord = new string[gamesRecordSize, 3];
        int gamesRecordCurrentIndex = 0;
        int gamesRecordCurrentSize = 0;

        // Welcome message to the game
        DisplayWelcomeMessage();
        
        // Use the ReadKey() method to get any key as input
        ReadKey();

        do
        {
            // Clear the console before the round
            Clear();

            // FirstPlayer makes his choice with data validation
            string firstPlayerChoiceString = GetPlayerInput();
            gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;

            // Clear the console so the SecondPlayer doesn't see what the FirstPlayer chose
            Clear();

            // SecondPlayer makes his choice with data validation
            string secondPlayerChoiceString = GetPlayerInput();
            gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;

            // Clear the console before announcing the winner
            Clear();

            // Check the result
            gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

            // Increment the games index counter and current history size
            gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
            if (gamesRecordCurrentSize < gamesRecordSize)
            {
                gamesRecordCurrentSize++;
            }

            // Ask the players if they want to continue
            WriteLine("Do you want to play again? [y]");
        } while (ReadLine() == "y");

        // Present the games' history
        WriteLine("Last 10 games results:");
        int currentIndex;
        if (gamesRecordCurrentSize < gamesRecordSize)
        {
            currentIndex = 0;
        }
        else
        {
            currentIndex = gamesRecordCurrentIndex;
        }
        for (int i = 0; i < gamesRecordCurrentSize; i++)
        {
            WriteLine("Game #{0}: {1} - {2}, {3}",
            i + 1, gamesRecord[currentIndex, 0], gamesRecord[currentIndex, 1], gamesRecord[currentIndex, 2]);
            currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
        }
    }

    static void DisplayWelcomeMessage()
    {
        WriteLine("Welcome to a simple Rock-Paper-Scissors game. \nThe rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\nAfter both players have chosen, the winner is determined. After each game the application will ask the players if they want to continue, and if the player reponds with anything else than [y]es, the game ends and presents the record of the last up to 10 games.\n\nHave fun!\n(press any key to continue)");
    }

    static string GetPlayerInput()
    {
        // Variable declaration
        string rawInput;
        string properInput;
        WriteLine("Choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine("Wrong input. Please enter the correct value.\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }
       
        if (rawInput == "1") { properInput = "Rock"; }
        else if (rawInput == "2") { properInput = "Paper"; }
        else { properInput = "Scissors"; }

        return properInput;
    }

    static string DetermineWinner(string playerOne, string playerTwo)
    {
        if (playerOne == playerTwo)
        {
            WriteLine("It's a draw!");
            return "Draw";
        }
        else if ((playerOne == "Rock" && playerTwo == "Scissors") ||
         (playerOne == "Paper" && playerTwo == "Rock") ||
         (playerOne == "Scissors" && playerTwo == "Paper"))
        {
            Console.WriteLine("Player One wins!");
            return "Player One wins";
        }
        else
        {
            Console.WriteLine("Player Two wins!");
            return "Player Two wins";
        }
    }


}