using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
  WriteLine("gracz jeden, wybierz cos:\n1 Rock\n2 Paper\n3 Scissors");
  string inputPlayerOne;
  inputPlayerOne = ReadLine();

    if(inputPlayerOne == "1"){
    WriteLine("Gracz łan wybrał kamień");
  }
  else if(inputPlayerOne == "2"){
    WriteLine("gracz łan wybrał papier");
  }
  else if(inputPlayerOne == "3"){
    WriteLine("łan wybrał nozyce");
  }
  else{
    WriteLine("gracz łan zrobił coś źle");
  }

 WriteLine("gracz dwa, wybierz cos:\n1 Rock\n2 Paper\n3 Scissors");
  string inputPlayerTwo;
  inputPlayerTwo = ReadLine();

   if(inputPlayerTwo == "1"){
    WriteLine("Gracz tu wybrał kamień");
  }
  else if(inputPlayerTwo == "2"){
    WriteLine("gracz tu wybrał papier");
  }
  else if(inputPlayerTwo == "3"){
    WriteLine("tu wybrał nozyce");
  }
  else{
    WriteLine("gracz tu zrobił coś źle");
  }


if(inputPlayerOne == inputPlayerTwo){
  WriteLine("remis");
}
else if((inputPlayerOne == "1" && inputPlayerTwo == "3") || (inputPlayerOne == "2" && inputPlayerTwo == "1") || (inputPlayerOne == "3" && inputPlayerTwo == "2")){
  WriteLine("wygrywa łan");
}
else if((inputPlayerOne == "3" && inputPlayerTwo == "1") || (inputPlayerOne == "1" && inputPlayerTwo == "2") || (inputPlayerOne == "2" && inputPlayerTwo == "3")){
  WriteLine("wygrywa tu");
 }
// WriteLine("chcesz skonczyc te runde? [y]");
 //string isExit = ReadLine();

 //if(isExit == "y"){
 //  break;
// }
 //Clear();


 int gamesRecordSize = 10;
 string [,] gamesRecordv= new string[10,3];
 int gamesRecordCurrentIndex = 0;
 string firstPlayerChoiceString = Console.ReadLine();
 gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
 string secondPlayerChoiceString = Console.ReadLine();
 gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
 gamesRecord[gamesRecordCurrentIndex, 2] = "remis";
 gamesRecord[gamesRecordCurrentIndex, 2] = "pierwszy";
 gamesRecord[gamesRecordCurrentIndex, 2] = "drugi";
 gamesRecordCurrentIndex +- 1;
 gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
 Console.WriteLine ("Game score: ");
 int gamesRecordCurrentSize;
 for (int i = 0; i <gamesRecordCurrentSize; i++){
   int currentIndex;
   if (gamesRecordCurrentSize < gamesRecordSize){
     currentIndex = 0;
   }
   else {
     currentIndex = gamesRecordCurrentIndex;
   }
   Console.WriteLine (" Gra #{0}: {1} - {2}, Grasz {3} wygrywa"), i+1, gamesRecord[i,0], gamesRecord [i,1], gamesRecord [i, 2]);
 } 
} 
}