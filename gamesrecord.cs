using System;
using static System.Console;

public class GamesRecord {
public int gamesRecordSize;
public IRecord[] gamesRecord;
public int gamesRecordCurrentIndex;
public int gamesRecordCurrentSize;

public GamesRecord (int recordSize = 10) {
  try {
    gamesRecordSize = recordSize;
    gamesRecord = new IRecord[gamesRecordSize];
    }
    catch (OverflowException e) {
      WriteLine("OverflowException during GamesRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
      gamesRecordSize = 10;
      gamesRecord = new IRecord[gamesRecordSize];
    }
    gamesRecordCurrentIndex = 0;
    gamesRecordCurrentSize = 0;
}

public static GamesRecord operator +(GamesRecord a, GamesRecord b) {
  int displayRecordIndex;
  if (b.gamesRecordCurrentSize < b.gamesRecordSize) displayRecordIndex = 0;
  else displayRecordIndex = b.gamesRecordCurrentIndex;
  for (int i = 0; i < b.gamesRecordCurrentSize; i++){
    a.AddRecord(b.gamesRecord[displayRecordIndex]);
    displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
  }
  return a;
}



public void AddRecord (IRecord record) {
gamesRecord[gamesRecordCurrentIndex] = record;
 
  gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
  if (gamesRecordCurrentSize < gamesRecordSize){
    gamesRecordCurrentSize++;
  }
}

public void DisplayGamesHistory () {
  int displayRecordIndex;
  if (gamesRecordCurrentSize < gamesRecordSize){
    displayRecordIndex = 0;
  }
  else {
    displayRecordIndex = gamesRecordCurrentIndex;
  }
  WriteLine ("Last games history:");
  for (int i = 0; i < gamesRecordCurrentSize; i++){
    WriteLine ("Game #{0}:\t{1}", i+1, gamesRecord[displayRecordIndex].ToString());
    displayRecordIndex = (displayRecordIndex + 1) % gamesRecordCurrentSize;
  }
}


}

