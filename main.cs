using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
  
  while(true){
      
      

    string WiadomoscPowitalna = "Player One, choose RPS: \n1 - Rock\n2 - Paper\n3 - Scissors";
    WriteLine(WiadomoscPowitalna);
    string inputPlayerOne;
    inputPlayerOne = ReadLine();
     if(inputPlayerOne == "1"){
      WriteLine("Player One choose Rock");
    }
    else if(inputPlayerOne == "2"){
      WriteLine("Player One choose Paper");
    }
    else if(inputPlayerOne == "3"){
      WriteLine("Player One choose Scissors");
    }
    else{
      WriteLine("Player wrote something wrong");
    } 

    WriteLine("Player Two, choose RPS:\n(1) Rock\n(2) Paper\n(3) Scissors"); 
    string inputPlayerTwo;
    inputPlayerTwo = ReadLine();

    if(inputPlayerTwo == "1"){
      WriteLine("Player Two choose Rock");
    }
    else if(inputPlayerTwo == "2"){
      WriteLine("Player Two choose Paper");
    }
    else if(inputPlayerTwo == "3"){
      WriteLine("Player Two choose Scissors");
    }
    else{
      WriteLine("Player wrote something wrong");
    }
    if(inputPlayerTwo == inputPlayerOne){
      WriteLine("Remis");
    }
    else if((inputPlayerOne == "1" && inputPlayerTwo == "3")
    || (inputPlayerOne == "2" && inputPlayerTwo == "1")
    || (inputPlayerOne == "3" && inputPlayerTwo == "2")){
      WriteLine("Player One won");
    }
    else if((inputPlayerTwo == "1" && inputPlayerOne == "3")
    || (inputPlayerTwo == "2" && inputPlayerOne == "1")
    || (inputPlayerTwo == "3" && inputPlayerOne == "2")){
      WriteLine("Player Two won");
    }
    else{
      WriteLine("Unexpected symbol was written");
    }

    WriteLine("DO you want to exit? [y]");
    string isExit = ReadLine();
    if(isExit == "y"){
      break;
    }
    Clear();
  }
  int gamesRecordSize = 10;
  string[,] gamesRecord = new string[10,3];
  int gamesRecordCurrentIndex = 0;
  string firstPlayerChoiceString = Console.ReadLine();
  gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
  string secondPlayerChoiceString = Console.ReadLine();
  gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
  gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
  gamesRecord[gamesRecordCurrentIndex, 2] = "First";
  gamesRecord[gamesRecordCurrentIndex, 2] = "Second";
  gamesRecordCurrentIndex += 1;
  gamesRecordCurrentIndex = (gamesRecordCurrentSize + 1) % gamesRecordSize;
  Console.WriteLine ("Game score:");
  int gamesRecordCurrentSize;
  for (int i = 0; i <gamesRecordCurrentSize; i++){
    int currentIndex;
    if (gamesRecordCurrentSize < gamesRecordSize){
      currentIndex = 0;
    }
    else {
      currentIndex = gamesRecordCurrentIndex;
    }
    Console.WriteLine ("Game #{0}: {1} - {2}, Player {3} won",
    i+1, gamesRecord[i,0], gamesRecord[i,1], gamesRecord[i,2]);
  }
  }
}