using System;
using static System.Console;
class GamesRecord
{
    int gamesRecordSize;
    string[,] gamesRecord;
    int gamesRecordCurrentIndex;

    int gamesRecordCurrentSize;

    static string[] lookupTable = new string[] { "rock\t", "paper\t", "scissors" };

    public GamesRecord()
    {

        while (true)
        {
            Console.WriteLine("Please enter number of games.");
            try
            {
                string playerInput = Console.ReadLine();
                int recordSize = Int32.Parse(playerInput);
                if (recordSize < 1)
                {
                    continue;
                }
            }
            catch (Exception e)
            {
                continue;
            }
            break;
        }

        gamesRecord = new string[gamesRecordSize, 3];
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }
    public GamesRecord(int recordSize)
    {
        if (recordSize < 1)
        {
            gamesRecordSize = 10;
            //throw new Exception("recordSize must be at least 1");
        }
        else
        {
            gamesRecordSize = recordSize;
        }
        gamesRecord = new string[recordSize, 3];
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

    public void DisplayGamesHistory ()
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
        WriteLine ("Last games history:");
        for (int i = 0; i < gamesRecordCurrentSize; i++)
        {
            WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[displayRecordIndex,0], gamesRecord[displayRecordIndex,1], gamesRecord[displayRecordIndex,2]);
            displayRecordIndex = (displayRecordIndex + 1) % gamesRecordCurrentSize;
        }
    }
}