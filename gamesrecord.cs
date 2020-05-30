using System;
using static System.Console;

class GamesRecord
{
    int gamesRecordSize;
    string[,] gamesRecord;
    int gamesRecordCurrentIndex;
    int gamesRecordCurrentSize;

    public GamesRecord(int recordSize = 10)
    {
        gamesRecordSize = recordSize;
        gamesRecord = new string[gamesRecordSize, 3];
        gamesRecordCurrentIndex = 0;
        gamesRecordCurrentSize = 0;
    }
}
