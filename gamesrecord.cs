using System;
using static System.Console;

public class GamesRecord {
public int gamesRecordSize;
public string[,] gamesRecord;
public int gamesRecordCurrentIndex;
public int gamesRecordCurrentSize;

public GamesRecord (int recordSize = 10) {
   gamesRecordSize = recordSize;
   gamesRecord = new string[gamesRecordSize,3];
   gamesRecordCurrentIndex = 0;
   gamesRecordCurrentSize = 0;
}



}

