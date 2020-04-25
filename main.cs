using System;
using static System.Console;

class MainClass
{
    static int gamesRecordSize = 10;
    static string[,] gamesRecord = new string[gamesRecordSize, 3];
    static int gamesRecordCurrentIndex = 0;
    static int gamesRecordCurrentSize = 0;

    public static void Main(string[] args)
    {
        MainMenuLoop();
    }

    static void DisplayWelcomeMessage()
    {
        WriteLine("Welcome to Rock-Paper-Scissors!\nThe rules are very simple - each player chooses Rock, Paper or Scissors by pressing the button of their choice:\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirming it by pressing Enter.\n\nAfter both players have chosen, the winner is determined. After each game the application will ask the players if they want to continue, and if the player reponds with anything else than [y]es, the game ends and presents the record of the last up to 10 games.\n\nHave fun!\n");
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

    static void DisplayGamesHistory(string[,] gamesRecord, int gamesRecordSize, int gamesRecordCurrentSize = 10, int lastRecordIndex = 0, bool reverse = false)
    {
        int currentIndex;
        if (gamesRecordCurrentSize < gamesRecordSize)
        {
            currentIndex = reverse ? gamesRecordCurrentSize - 1 : 0;
        }
        else
        {
            currentIndex = reverse ? lastRecordIndex - 1 : lastRecordIndex;
        }

        int step = reverse ? -1 : 1;

        WriteLine("Last games history:");
        for (int i = 0; i < gamesRecordCurrentSize; i++)
        {
            WriteLine("Game #{0}:\t{1}\t-\t{2},\t{3}", 
                reverse ? gamesRecordCurrentSize - i : i + 1, 
                gamesRecord[currentIndex, 0], gamesRecord[currentIndex, 1], gamesRecord[currentIndex, 2]);
            currentIndex = (gamesRecordCurrentSize + currentIndex + step) % gamesRecordCurrentSize;
        }
    }

    static void MainMenuLoop()
    {
        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Rock-Paper-Scissors Menu:\n\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[4] Display last games' record reversed\n\t[ESC] Exit");
            inputKey = ReadKey(true);

            Clear();

            switch (inputKey.Key)
            {
                case ConsoleKey.D1:
                    PlayGame();
                    break;
                case ConsoleKey.D2:
                    DisplayWelcomeMessage();
                    break;
                case ConsoleKey.D3:
                    DisplayGamesHistory(gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex, false);
                    break;
                case ConsoleKey.D4:
                    DisplayGamesHistory(gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex, true);
                    break;
                default:
                    continue;
            }

            WriteLine("(press any key to continue)");
            ReadKey(true);

        } while (inputKey.Key != ConsoleKey.Escape);

    }

    static void PlayGame()
    {
        Clear();
       
        string firstPlayerChoiceString = GetPlayerInput();
        gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
        Clear();
        
        string secondPlayerChoiceString = GetPlayerInput();
        gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
        Clear();
        
        gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);
        gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
        if (gamesRecordCurrentSize < gamesRecordSize)
        {
            gamesRecordCurrentSize++;
        }
        
        WriteLine("Do you want to play again? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            PlayGame();
        }

    }

}