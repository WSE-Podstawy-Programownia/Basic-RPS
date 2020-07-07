using System;
using static System.Console;

class GamesRecord 
{
  int gamesRecordSize;
  string[,] gamesRecord;
  int gamesRecordCurrentIndex;
  int gamesRecordCurrentSize; 

  public GamesRecord (int recordSize =10)
  {
    try
    {
      gamesRecordSize = recordSize; 
      gamesRecord = new string[gamesRecordSize, 3];
    }
    catch (OverflowException e) 
    {
      WriteLine("OverflowException during Games Record initialization: \"{0}\"\nrecodSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
      gamesRecordSize = 10;
      gamesRecord = new string[gamesRecordSize, 3];
    }
    gamesRecordCurrentIndex = 0;
    gamesRecordCurrentSize = 0;
  }

  public void AddRecord (string playerOneChoice, string playerTwoChoice, string result)
  {
    gamesRecord[gamesRecordCurrentIndex, 0] = playerOneChoice;
    gamesRecord[gamesRecordCurrentIndex, 1] = playerTwoChoice;
    gamesRecord[gamesRecordCurrentIndex, 2] = result;

    gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize; 
    if (gamesRecordCurrentSize < gamesRecordSize)
    {
      gamesRecordCurrentSize++;
    }
  }

  public void DisplayGamesHistory ()
  {
    int currentIndex;
    if (gamesRecordCurrentSize < gamesRecordSize){
      currentIndex = 0;
    }
    else {
      currentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
    }

    WriteLine ("Last games history:");
    for (int i = 0; i < gamesRecordCurrentSize; i++){
        WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}",
        i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
        currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
    }
  }

  public static GamesRecord operator +(GamesRecord a, GamesRecord b)
  {
    int displayRecordIndex; 
    if (b.gamesRecordCurrentSize < b.gamesRecordSize) displayRecordIndex = 0;
    else displayRecordIndex = b.gamesRecordCurrentIndex; 
    for (int i = 0; i < b.gamesRecordCurrentSize; i++)
    {
      a.AddRecord (b.gamesRecord[displayRecordIndex, 0],  
                    b.gamesRecord[displayRecordIndex, 1],
                    b.gamesRecord[displayRecordIndex, 2]);
      displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
    }
    return a;
  }
}