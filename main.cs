using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {

    bool continueGame = true;
    string[] RPS = new string[] {"CRAP", "Rock", "Paper", "Scissors"}; //zmienna typu string [] (symbol tablicy) + nazwa tablicy = new string [] (ograniczenie tablicy)
    string[ , ] gameOutput = new string[10, 3];  
    int gameNumber = 0; 

    while(continueGame) {

      WriteLine("Game number: {0}", gameNumber + 1);

      int inputPlayerOne;  // inputPlayerOne = integer - wartosć wpisana przez gracza jest traktowana jako liczba całkowita
      WriteLine("Dear player One, choose wisely:\n1 - Rock\n2 - Paper\n3- Scissors" );
      inputPlayerOne = Int32.Parse(ReadLine());  // change Readline to int (ciąg znaków na liczbę całkowitą)

      WriteLine("Player one has selected {0}", RPS[inputPlayerOne]);
      gameOutput[gameNumber, 0] = RPS[inputPlayerOne]; //kolejny wers w tablicy, co rozgrywkę "tablica zjeżdza w gół" 

      WriteLine("Select any key to continue");
      Read();
      Clear();

      WriteLine("Dear player Two, choose wisely:\n1 - Rock\n2 - Paper\n3- Scissors" );
      int inputPlayerTwo;
      inputPlayerTwo = Int32.Parse(ReadLine());

      WriteLine("Player two has selected {0}", RPS[inputPlayerOne]);
      gameOutput[gameNumber, 1] = RPS[inputPlayerTwo];

      WriteLine("Select any key to know the result.");
      Read();
      Clear();

      if(inputPlayerOne == inputPlayerTwo){
        WriteLine("Draw, another time guys.");
        gameOutput[gameNumber, 2] = "Draw";
      }
      else if (inputPlayerOne - inputPlayerTwo == -2 || inputPlayerOne - inputPlayerTwo == 1) { // || or \ + shift
        WriteLine("Player one has won");
        gameOutput[gameNumber, 2] = "Player one won";
      }
      else {
        WriteLine("Player two has won");
        gameOutput[gameNumber, 2] = "Player two won";
      }


      string playerChoice;
      WriteLine("Do you want to continue? y");
      playerChoice = ReadLine();
      if(playerChoice == "y") {
        continue; //no reason to do anything with variable, just go to next game
      }
      else {
        continueGame = false;
      }
      Read();
      Clear();
    }

    for (int i = 0; i <= gameNumber; i++) {
      WriteLine("WYNIK GRY {0}: Player one: {1} Player two: {2} Result: {3}", i+1, gameOutput[i, 0],
      gameOutput[i, 1], gameOutput[i, 2]);
    }

    gameNumber++; //number +1 /co kolejkę numer gry się po prostu zwiększa

  }
}