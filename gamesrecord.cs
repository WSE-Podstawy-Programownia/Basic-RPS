using System;
using static System.Console;
class GamesRecord
{
    int gamesRecordSize;
    IRecord[] gamesRecord;
    int gamesRecordCurrentIndex;
    int gamesRecordCurrentSize;

    public GamesRecord()
    {
        while (true)
        {
            WriteLine("Please enter number of games.");
            try
            {
                string playerInput = ReadLine();
                int recordSize = Int32.Parse(playerInput);
                if (recordSize < 1)
                {
                    continue;
                }
                gamesRecordSize = recordSize;
            }
            catch (Exception e)
            {
                continue;
            }
            break;
        }

        gamesRecord = new IRecord[gamesRecordSize];
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }

    public GamesRecord(int recordSize = 10)
    {
        if (recordSize < 1)
        {
            gamesRecordSize = 10;
        }
        else
        {
            gamesRecordSize = recordSize;
        }
        gamesRecordSize = recordSize;
        gamesRecord = new IRecord[gamesRecordSize];
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }
    public static GamesRecord operator +(GamesRecord a, GamesRecord b)
    {
        int displayRecordIndex;
        if (b.gamesRecordCurrentSize < b.gamesRecordSize) displayRecordIndex = 0;
        else displayRecordIndex = b.gamesRecordCurrentIndex;
        for (int i = 0; i < b.gamesRecordCurrentSize; i++)
        {
            a.AddRecord(b.gamesRecord[displayRecordIndex]);
            displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
        }
        return a;
    }
    public void DisplayGamesHistory()
    {
        int currentIndex;
        if (gamesRecordCurrentSize < gamesRecordSize)
        {
            currentIndex = 0;
        }
        else
        {
            currentIndex = gamesRecordCurrentIndex;
        }
        WriteLine("Last games history:");
        for (int i = 0; i < gamesRecordCurrentSize; i++)
        {
            WriteLine ("Game #{0}:\t{1}", i+1, gamesRecord[currentIndex].ToString());
            currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
        }
    }
    public void AddRecord(IRecord record)
    {
        gamesRecord[gamesRecordCurrentIndex] = record;
        gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
        if (gamesRecordCurrentSize < gamesRecordSize)
        {
            gamesRecordCurrentSize++;
        }

    }
}