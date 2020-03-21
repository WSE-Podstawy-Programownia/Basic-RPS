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
}
}