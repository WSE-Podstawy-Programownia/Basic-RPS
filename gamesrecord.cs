using System;
using static System.Console;
class GamesRecord {
  int gamesRecordSize;
  string[,] gamesRecord;
  int gamesRecordCurrentIndex;
  int gamesRecordCurrentSize;

  public GamesRecord()
  {
    while(true)
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

  public GamesRecord (int recordSize = 10) {
    if (recordSize < 1)
        {
          gamesRecordSize = 10;
        }
      	else
        {
          gamesRecordSize = recordSize;
        }
    gamesRecordSize = recordSize;
    gamesRecord = new string[gamesRecordSize, 3];
    gamesRecordCurrentIndex = 0;
    gamesRecordCurrentSize = 0;
  }
  public static GamesRecord operator +(GamesRecord a, GamesRecord b) {
  int displayRecordIndex;
  if (b.gamesRecordCurrentSize < b.gamesRecordSize) displayRecordIndex = 0;
  else displayRecordIndex = b.gamesRecordCurrentIndex;
  for (int i = 0; i < b.gamesRecordCurrentSize; i++){
    a.AddRecord(b.gamesRecord[displayRecordIndex,0], 
    b.gamesRecord[displayRecordIndex,1], 
    b.gamesRecord[displayRecordIndex,2]);
    displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
  }
  return a;
}
  public void DisplayGamesHistory (){
      int currentIndex;
      if (gamesRecordCurrentSize < gamesRecordSize){
        currentIndex = 0;
      }
      else {
        currentIndex = gamesRecordCurrentIndex;
      }
      WriteLine ("Last games history:");
      for (int i =0; i < gamesRecordCurrentSize; i++){
        WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
        currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
        }
  }
  public void AddRecord (string playerOneChoice, string playerTwoChoice, string result){
    gamesRecord[gamesRecordCurrentIndex, 0] = playerOneChoice;
    gamesRecord[gamesRecordCurrentIndex, 1] = playerTwoChoice;
    gamesRecord[gamesRecordCurrentIndex, 2] = result;

    gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
    if (gamesRecordCurrentSize < gamesRecordSize){
      gamesRecordCurrentIndex++;
    }
  }
}