using System;
class GamesRecord
{
    int gamesRecordSize;
    string[,] gamesRecord;
    int gamesRecordCurrentIndex;
    public GamesRecord (int recordSize = 10)
    {
        gamesRecordSize = recordSize;
        gamesRecord = new string[recordSize,3];
        gamesRecordCurrentIndex = 0;
    }
}