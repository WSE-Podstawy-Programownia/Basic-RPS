using System;
using static System.Console;

class GameRecord {
 int gameRecordSize;
 string[,] gameRecord;
 int gameRecordCurrentIndex;
 int gameRecordCurrentSize;
public GameRecord (int recordSize = 10) {
  gameRecordSize = recordSize;
  gameRecord = new string[gameRecordSize,3];
  gameRecordCurrentIndex = 0;
  gameRecordCurrentSize = 0;
}
public void AddRecord (string playerOneChoice, string playerTwoChoice, string result) {
  gameRecord[gameRecordCurrentIndex, 0] = playerOneChoice;
  gameRecord[gameRecordCurrentIndex, 1] = playerTwoChoice;
  gameRecord[gameRecordCurrentIndex, 2] = result;
  
  gameRecordCurrentIndex = (gameRecordCurrentIndex + 1) % gameRecordSize;
  if (gameRecordCurrentSize < gameRecordSize){
    gameRecordCurrentSize++;
  }
}
 public void DisplayGameHistory (int lastRecordIndex = 0){
   int currentIndex;
  if (gameRecordCurrentSize < gameRecordSize){
  currentIndex = 0;
  }
  else {
  currentIndex = lastRecordIndex;
  }
  WriteLine ("Game score:");
  for (int i = 0; i < gameRecordCurrentSize; i++){
  WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gameRecord[currentIndex,0], gameRecord[currentIndex,1], gameRecord[currentIndex,2]);
  currentIndex = (currentIndex + 1) % gameRecordCurrentSize;
  }
  }
}
