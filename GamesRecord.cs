using System;
using static System.Console;

class GamesRecord 
{
  int gamesRecordSize;
  IRecord[] gamesRecord;
  int gamesRecordCurrentIndex;
  int gamesRecordCurrentSize; 
  int displayRecordIndex;

  public GamesRecord (int recordSize =10)
  {
    try
    {
      gamesRecordSize = recordSize; 
      gamesRecord = new IRecord[gamesRecordSize];
    }
    catch (OverflowException e) 
    {
      WriteLine("OverflowException during Games Record initialization: \"{0}\"\nrecodSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
      gamesRecordSize = 10;
      gamesRecord = new IRecord[gamesRecordSize];
    }
    gamesRecordCurrentIndex = 0;
    gamesRecordCurrentSize = 0;
  }

  public void AddRecord (IRecord record)
  {
    gamesRecord[gamesRecordCurrentIndex] = record;
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
    for (int i = 0; i < gamesRecordCurrentSize; i++)
    {
        WriteLine ("Game #{0}: \t{1}", i+1, gamesRecord[displayRecordIndex].ToString());
        displayRecordIndex = (displayRecordIndex +1) % gamesRecordCurrentSize;
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
      a.AddRecord(b.gamesRecord[displayRecordIndex]);
      displayRecordIndex = (displayRecordIndex + 1) % b.gamesRecordCurrentSize;
    }
    return a;
  }
}