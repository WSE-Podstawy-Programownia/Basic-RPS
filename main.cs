using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {

    bool continueGame = true;

    while(continueGame) {

      int inputPlayerOne;  // inputPlayerOne = integer - wartosć wpisana przez gracza jest traktowana jako liczba całkowita
      

      WriteLine("Dear player One, choose wisely:\n1 - Rock\n2 - Paper\n3- Scissors" );
      inputPlayerOne = Int32.Parse(ReadLine());  // change Readline to int (ciąg znaków na liczbę całkowitą)

      string[] RPS = new string[] {"CRAP", "Rock", "Paper", "Scissors"}; //zmienna typu string [] (symbol tablicy) + nazwa tablicy = new string [] (ograniczenie tablicy)

      WriteLine("Player one has selected {0}", RPS[inputPlayerOne]);

      WriteLine("Select any key to continue");
      Read();
      Clear();

      WriteLine("Dear player Two, choose wisely:\n1 - Rock\n2 - Paper\n3- Scissors" );
      int inputPlayerTwo;
      inputPlayerTwo = Int32.Parse(ReadLine());

      WriteLine("Player two has selected {0}", RPS[inputPlayerOne]);

      WriteLine("Select any key to know the result.");
      Read();
      Clear();

      if(inputPlayerOne == inputPlayerTwo){
        WriteLine("Draw, another time guys.");
      }
      else if (inputPlayerOne - inputPlayerTwo == -2 || inputPlayerOne - inputPlayerTwo == 1) { // || or \ + shift
        WriteLine("Player one has won");
      }
      else {
        WriteLine("Player two has won");
      }

      string playerChoice;
      WriteLine("Do you want to continue? y");
      playerChoice = ReadLine();
      if(playerChoice == "y") {
        continueGame = true;
      }
      else {
        continueGame = false;
      }
      Read();
      Clear();


    }
  }
}