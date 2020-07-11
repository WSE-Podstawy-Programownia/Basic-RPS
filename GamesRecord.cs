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
            a.AddRecord(b.gamesRecord[displayRecordIndex]);
            displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
        }
        return a;
    }
    int gamesRecordSize;
    IRecord[] gamesRecord;
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

        gamesRecord = new IRecord[gamesRecordSize];
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }
    public GamesRecord(int recordSize = 10)
    {
        try
        {
            gamesRecordSize = recordSize;
            gamesRecord = new IRecord[gamesRecordSize];
        }
        catch (OverflowException e)
        {
            WriteLine("OverflowException during GamesRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
            WriteLine("Press Enter to continue");
            ReadLine();
            gamesRecordSize = 10;
            gamesRecord = new IRecord[gamesRecordSize];

        }
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
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
            WriteLine ("Game #{0}:\t{1}", i+1, gamesRecord[displayRecordIndex].ToString());
            displayRecordIndex = (displayRecordIndex + 1) % gamesRecordCurrentSize;
        }
    }
}