using System;
using static System.Console
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

}
