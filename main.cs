using System;
using static System.Console;
class MainClass {
  static string DetermineWinner (string playerOne, string playerTwo){
    if (playerOne == playerTwo){
      WriteLine ("It's a draw!");
      return "Draw";
    }
    else if ((playerOne == "Rock" && playerTwo == "Scissors") ||
    (playerOne == "Paper" && playerTwo == "Rock")||
    (playerOne == "Scissors" && playerTwo == "Paper")){
      Console.Writeline ("Player One won!");
      return "Player One won";
    }
      else {
        Console.WriteLine ("Player Two won!");
        return "player Two won";

        gamesRecord[gamesRecordCurrentIndex, 2] = 
        DetermineWinner(theFirstPlayerChoiceString, theSecondPlayerChoiceString);
    }
  }

  enum Choices {
    Rock,
    Paper,
    Scissors
  }
static void DisplayWelcomeMessage (){
  WriteLine (@"Welcome in the game of Rock-Paper-Scissors!
    Rules are simple - the first player picks Rock, Paper or Scissors enternig accordingly 1, 2 or 3. Next, the second player makes a choice and score is displayed on screen.
    Press any key to continue..");
}
static string GetPlayerInput (string player){
  string rawInput;
  string properInput;
  WriteLine ("{0} Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player);
    rawInput = ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3"){
      WriteLine ("Wrong input. Please enter correct choice.\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors");
      rawInput = ReadLine();
    }
      if (rawInput == "1") { properInput = "Rock"; }
      else if (rawInput == "2") { properInput = "Paper"; }
      else { properInput = "Scissors"; }
      return properInput;
  
}
  public static void Main (string[] args) {
   
   DisplayWelcomeMessage();
    
    Console.ReadKey();
    
    string theFirstPlayerChoiceString = GetPlayerInput("Player One");
    
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
    Console.WriteLine ("You've chosen: {0}", theFirstPlayerChoiceString);
    Console.WriteLine ("Press any key to continue..");
    Console.ReadKey();

    // następnie czyścimy konsolę, żeby drugi gracz nie zobaczył wyboru pierwszego
    Console.Clear ();

    
    string theSecondPlayerChoiceString = GetPlayerInput("Player Two");
    
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
    Console.WriteLine ("You've chosen: {0}", theSecondPlayerChoiceString);
    Console.WriteLine ("Press any key to continue..");
    Console.ReadKey();

    // ponownie czyścimy konsolę przed pokazaniem wyniku
    Console.Clear ();

    // sprawdzamy wynik i wypisujemy na ekranie
    if (theFirstPlayerChoiceString == theSecondPlayerChoiceString){
       Console.WriteLine ("Draw!\n{0} - {1}", theFirstPlayerChoiceString, theSecondPlayerChoiceString);
    }
    else if ((theFirstPlayerChoiceString == "Rock" && theSecondPlayerChoiceString == "Scissors")
            ||
            (theFirstPlayerChoiceString == "Scissors" && theSecondPlayerChoiceString == "Paper")
            ||
            (theFirstPlayerChoiceString == "Paper" && theSecondPlayerChoiceString == "Rock")
    ){
      Console.WriteLine ("First player won!\n{0} - {1}", theFirstPlayerChoiceString, theSecondPlayerChoiceString);
    }
    else{
      Console.WriteLine ("Second player won!\n{0} - {1}", theFirstPlayerChoiceString, theSecondPlayerChoiceString);
    }
  }
}