using System;
using static System.Console;

class MainClass
{
    public static void Main(string[] args)
    {
        int gamesRecordSize = 10;
        int gamesRecordCurrentSize = 0;
        string[,] gamesRecord = new string[gamesRecordSize, 3];
        int gamesRecordCurrentIndex = 0;

        while (true)
        {
            string WiadomoscPowitalna = "Player One, choose RPS: \n1 - Rock\n2 - Paper\n3 - Scissors";
            WriteLine(WiadomoscPowitalna);
            string inputPlayerOne = ReadLine();
            gamesRecord[gamesRecordCurrentIndex, 0] = inputPlayerOne;

            if (inputPlayerOne == "1")
            {
                WriteLine("Player One choose Rock");
            }
            else if (inputPlayerOne == "2")
            {
                WriteLine("Player One choose Paper");
            }
            else if (inputPlayerOne == "3")
            {
                WriteLine("Player One choose Scissors");
            }
            else
            {
                WriteLine("Player wrote something wrong");
            }

            WriteLine("Player Two, choose RPS:\n(1) Rock\n(2) Paper\n(3) Scissors");
            string inputPlayerTwo;
            inputPlayerTwo = ReadLine();
            gamesRecord[gamesRecordCurrentIndex, 1] = inputPlayerTwo;
            if (inputPlayerTwo == "1")
            {
                WriteLine("Player Two choose Rock");
            }
            else if (inputPlayerTwo == "2")
            {
                WriteLine("Player Two choose Paper");
            }
            else if (inputPlayerTwo == "3")
            {
                WriteLine("Player Two choose Scissors");
            }
            else
            {
                WriteLine("Player wrote something wrong");
            }
            if (inputPlayerTwo == inputPlayerOne)
            {
                WriteLine("Remis");
                gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
            }
            else if ((inputPlayerOne == "1" && inputPlayerTwo == "3")
            || (inputPlayerOne == "2" && inputPlayerTwo == "1")
            || (inputPlayerOne == "3" && inputPlayerTwo == "2"))
            {
                WriteLine("Player One won");
                gamesRecord[gamesRecordCurrentIndex, 2] = "Player One won";
            }
            else if ((inputPlayerTwo == "1" && inputPlayerOne == "3")
            || (inputPlayerTwo == "2" && inputPlayerOne == "1")
            || (inputPlayerTwo == "3" && inputPlayerOne == "2"))
            {
                WriteLine("Player Two won");
                gamesRecord[gamesRecordCurrentIndex, 2] = "Player Two won";
            }
            else
            {
                WriteLine("Unexpected symbol was written");
                gamesRecord[gamesRecordCurrentIndex, 2] = "Unexpected symbol";
            }
            gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
            if (gamesRecordCurrentSize < gamesRecordSize)
            {
                gamesRecordCurrentSize++;
            }

            WriteLine("DO you want to exit? [y]");
            string isExit = ReadLine();
            if (isExit == "y")
            {
                break;
            }
            Clear();
        }
        Console.WriteLine("Game score:");

        for (var i = 0; i < gamesRecordCurrentSize; i++)
        {
            Console.WriteLine("Game #{0}: {1} - {2}, {3}", i + 1, gamesRecord[i, 0], gamesRecord[i, 1], gamesRecord[i, 2]);
        }
    }
}