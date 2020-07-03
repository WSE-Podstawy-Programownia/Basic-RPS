using System;
using static System.Console;


public class GamesRecord
{
    public static GamesRecord operator +(GamesRecord a, GamesRecord b)
    {
        int displayRecordIndex;
        if (b.gamesRecordCurrentSize < b.gamesRecordSize) displayRecordIndex = 0;
        else displayRecordIndex = b.gamesRecordCurrentIndex;
        for (int i = 0; i < b.gamesRecordCurrentSize; i++)
        {
            a.AddRecord(b.gamesRecord[displayRecordIndex, 0],
            b.gamesRecord[displayRecordIndex, 1],
            b.gamesRecord[displayRecordIndex, 2]);
            displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
        }
        return a;
    }
    int gamesRecordSize;
    string[,] gamesRecord;
    int gamesRecordCurrentIndex;

    int gamesRecordCurrentSize;

    static string[] lookupTable = new string[] { "rock\t", "paper\t", "scissors" };

    public GamesRecord()
    {

        while (true)
        {
            Console.WriteLine("Please capacity of games record.");
            try
            {
                string playerInput = Console.ReadLine();
                gamesRecordSize = Int32.Parse(playerInput);
                if (gamesRecordSize < 1)
                {
                    WriteLine("The number of games must be positive.");
                    continue;
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                continue;
            }
            break;
        }

        gamesRecord = new string[gamesRecordSize, 3];
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }
    public GamesRecord(int recordSize = 10)
    {
        try
        {
            gamesRecordSize = recordSize;
            gamesRecord = new string[gamesRecordSize, 3];
        }
        catch (OverflowException e)
        {
            WriteLine("OverflowException during GamesRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
            WriteLine("Press Enter to continue");
            ReadLine();
            gamesRecordSize = 10;
            gamesRecord = new string[gamesRecordSize, 3];

        }
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }


    public void AddRecord(int playerOneChoice, int playerTwoChoice, string result)
    {
        gamesRecord[gamesRecordCurrentIndex, 0] = lookupTable[playerOneChoice - 1];
        gamesRecord[gamesRecordCurrentIndex, 1] = lookupTable[playerTwoChoice - 1];
        gamesRecord[gamesRecordCurrentIndex, 2] = result;

        gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
        gamesRecordCurrentSize = System.Math.Min(gamesRecordCurrentSize + 1, gamesRecordSize);
    }
    public void AddRecord(string playerOneChoice, string playerTwoChoice, string result)
    {
        gamesRecord[gamesRecordCurrentIndex, 0] = playerOneChoice;
        gamesRecord[gamesRecordCurrentIndex, 1] = playerTwoChoice;
        gamesRecord[gamesRecordCurrentIndex, 2] = result;

        gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
        gamesRecordCurrentSize = System.Math.Min(gamesRecordCurrentSize + 1, gamesRecordSize);
    }
    public void DisplayGamesHistory()
    {
        int displayRecordIndex;
        if (gamesRecordCurrentSize < gamesRecordSize)
        {
            displayRecordIndex = 0;
        }
        else
        {
            displayRecordIndex = gamesRecordCurrentIndex;
        }
        WriteLine("Last games history:");
        for (int i = 0; i < gamesRecordCurrentSize; i++)
        {
            WriteLine("Game #{0}: {1}-\t{2}{3}", i + 1, gamesRecord[displayRecordIndex, 0].PadRight(12), gamesRecord[displayRecordIndex, 1].PadRight(12), gamesRecord[displayRecordIndex, 2].PadRight(16));
            displayRecordIndex = (displayRecordIndex + 1) % gamesRecordCurrentSize;
        }
    }
}