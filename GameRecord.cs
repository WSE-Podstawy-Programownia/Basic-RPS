using System;
using static System.Console;

class GameRecord
{
    int gameRecordSize;
    IRecord[] gameRecord;
    int gameRecordCurrentIndex;
    int gameRecordCurrentSize;

    public GameRecord(int recordSize = 10)
    {
        try
        {
            gameRecordSize = recordSize;
            gameRecord = new IRecord[gameRecordSize];
        }
        catch (OverflowException e)
        {
            WriteLine("OverflowException during GameRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
            gameRecordSize = 10;
            gameRecord = new IRecord[gameRecordSize];
        }
        gameRecordCurrentIndex = 0;
        gameRecordCurrentSize = 0;
    }

    public static GameRecord operator +(GameRecord a, GameRecord b)
    {
        int displayRecordIndex;
        if (b.gameRecordCurrentSize < b.gameRecordSize) displayRecordIndex = 0;
        else displayRecordIndex = b.gameRecordCurrentIndex;
        for (int i = 0; i < b.gameRecordCurrentSize; i++)
        {
            a.AddRecord(b.gameRecord[displayRecordIndex]);
            displayRecordIndex = (displayRecordIndex + 1) % b.gameRecordCurrentSize;
        }
        return a;
    }
    public void AddRecord(IRecord record)
    {
        gameRecord[gameRecordCurrentIndex] = record;
        gameRecordCurrentIndex = (gameRecordCurrentIndex + 1) % gameRecordSize;
        if (gameRecordCurrentSize < gameRecordSize)
        {
            gameRecordCurrentSize++;
        }
    }
    public void DisplayGameHistory()
    {
        int displayRecordIndex = 0;

        WriteLine("Game score:");
        for (int i = 0; i < gameRecordCurrentSize; i++)
        {
            WriteLine("Game #{0}:\t{1}", i + 1, gameRecord[displayRecordIndex].ToString());
            displayRecordIndex = (displayRecordIndex + 1) % gameRecordCurrentSize;
        }
    }
}
