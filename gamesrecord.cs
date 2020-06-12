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
  gamesRecord[gamesRecordCurrentIndex, 1] = cp_2;
  gamesRecord[gamesRecordCurrentIndex, 2] = result;
  
  gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
  if (gamesRecordCurrentSize < gamesRecordSize){
    gamesRecordCurrentSize++;
  }
}

static void DisplayGamesHistory ()
{  // funkcja wyświetlajaca wyniki ostatnich gier


  int currentIndex;
    if (gamesRecordCurrentSize < gamesRecordSize){
              
              currentIndex = 0;
    }
    else {

          currentIndex = lastRecordIndex;
      
          }

 Console.WriteLine ("The scores are:");
   for (int i = 0; i < gamesRecordCurrentSize; i++){
      Console.WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
      currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
}


}