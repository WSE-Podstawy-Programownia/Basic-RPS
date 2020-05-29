using System;

class MainClass
{
    static void ReadMe()
    {
        Console.WriteLine("Welcome! You're playing rock, paper, scissors game! Game rules: Scissors beat paper, paper beats rock, rock beats scissors. The game ends when you beat an opponent three times. Good luck! Ready! Steady! Go! Press any key to continue");
        Console.ReadKey();
        Console.Clear();

    }

    static int GetPlayerInput(int playerIndex)
    {
        int playerChoice;
        bool playerOneParseSuccess;
        do
        {
            Console.WriteLine($"[Player {playerIndex}] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
            playerOneParseSuccess = Int32.TryParse(Console.ReadLine(), out playerChoice);
        } while (!playerOneParseSuccess || playerChoice <= 0 || playerChoice >= 4);

        return playerChoice;
    }

    static string DetermineWinner(int playerOneChoice, int playerTwoChoice)
    {
        int difference = playerOneChoice - playerTwoChoice;
        if (difference == 1 || difference == -2)
        {
            Console.WriteLine("Player 1 won!");
            return "Player 1 won!";
        }
        else if (difference == 0)
        {
            Console.WriteLine("Draw!!!");
            return "Draw!!!";
        }
        else
        {
            Console.WriteLine("Player 2 won!");
            return "Player 2 won!";
        }
    }

    static void Display(string[,] gamesRecord, int gamesRecordCurrentIndex)
    {
        Console.WriteLine("|Game No\t|Player 1\t|Player 2\t|Winner");
        for (int i = 0; i < gamesRecordCurrentIndex; ++i)
        {
            Console.WriteLine($"|{i + 1}\t\t|{gamesRecord[i, 0]}\t|{gamesRecord[i, 1]}\t|{gamesRecord[i, 2]}");
        }

    }

    public static void Main(string[] args)
    {
        ReadMe();

        string[,] gamesRecord = new string[10, 3];
        int gamesRecordCurrentIndex = 0;

        string[] lookupTable = new string[] { "rock\t", "paper\t", "scissors" };

        do
        {

            int playerOneChoice = GetPlayerInput(1);
            gamesRecord[gamesRecordCurrentIndex, 0] = lookupTable[playerOneChoice - 1];

            int playerTwoChoice = GetPlayerInput(2);
            gamesRecord[gamesRecordCurrentIndex, 1] = lookupTable[playerTwoChoice - 1];

            gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(playerOneChoice, playerTwoChoice);

            gamesRecordCurrentIndex++;
            Console.WriteLine("Do you want to quit? (y)");
        } while (gamesRecordCurrentIndex < 10 && Console.ReadLine() != "y");

        Display(gamesRecord, gamesRecordCurrentIndex);

    }

}