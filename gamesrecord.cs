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

public void AddRecord (string playerOneChoice, string playerTwoChoice, string result) {
  gamesRecord[gamesRecordCurrentIndex, 0] = playerOneChoice;
  gamesRecord[gamesRecordCurrentIndex, 1] = playerTwoChoice;
  gamesRecord[gamesRecordCurrentIndex, 2] = result;
  
  gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
  if (gamesRecordCurrentSize < gamesRecordSize){
    gamesRecordCurrentSize++;
  }
}


}

