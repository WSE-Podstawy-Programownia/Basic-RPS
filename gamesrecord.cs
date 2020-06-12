using System;

class GamesRecord {

 int gamesRecordSize;
 string[,] gamesRecord;
 int gamesRecordCurrentIndex;
 int gamesRecordCurrentSize;

    public GamesRecord (int recordSize = 10) {
      gamesRecordSize = recordSize;
      gamesRecord = new string[gamesRecordSize,3];
      gamesRecordCurrentIndex = 0;
      gamesRecordCurrentSize = 0;
    }

public void AddRecord (string c_p1, string c_p2, string result) {
  gamesRecord[gamesRecordCurrentIndex, 0] = c_p1;
  gamesRecord[gamesRecordCurrentIndex, 1] = c_p2;
  gamesRecord[gamesRecordCurrentIndex, 2] = result;
  
  gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
  if (gamesRecordCurrentSize < gamesRecordSize){
    gamesRecordCurrentSize++;
  }
}

public void DisplayGamesHistory()
{  // funkcja wyświetlajaca wyniki ostatnich gier

  int displayRecordIndex;
  if (gamesRecordCurrentSize < gamesRecordSize){
    displayRecordIndex = 0;
  }
  else {
    displayRecordIndex = gamesRecordCurrentIndex;
  }
  Console.WriteLine ("Last games history:");
  for (int i = 0; i < gamesRecordCurrentSize; i++){
    Console.WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[displayRecordIndex,0], gamesRecord[displayRecordIndex,1], gamesRecord[displayRecordIndex,2]);
    displayRecordIndex = (displayRecordIndex + 1) % gamesRecordCurrentSize;
  }
}

}

