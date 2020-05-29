using System;

class MainClass
{
    static void ReadMe()
    {
        Console.WriteLine("Welcome! You're playing rock, paper, scissors game! Game rules: Scissors beat paper, paper beats rock, rock beats scissors. The game ends when you beat an opponent three times. Good luck! Ready! Steady! Go! Press any key to continue");
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

    static void PlayGame()
    {

        int playerOneChoice = GetPlayerInput(1);
        gamesRecord[gamesRecordCurrentIndex, 0] = lookupTable[playerOneChoice - 1];

        int playerTwoChoice = GetPlayerInput(2);
        gamesRecord[gamesRecordCurrentIndex, 1] = lookupTable[playerTwoChoice - 1];

        gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(playerOneChoice, playerTwoChoice);

        gamesRecordCurrentIndex++;

        Console.WriteLine("Do you want to play another round? [y]");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            PlayGame();
        }

    }

    static void MainMenuLoop()
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
                ReadMe();
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                Display(gamesRecord, gamesRecordCurrentIndex);
            }
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();

        } while (inputKey.Key != ConsoleKey.Escape);
    }

    public static void Main(string[] args)
    {
        MainMenuLoop();
    }

    static string[,] gamesRecord = new string[10, 3];
    static int gamesRecordCurrentIndex = 0;
    static string[] lookupTable = new string[] { "rock\t", "paper\t", "scissors" };

}