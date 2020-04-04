using System;

class MainClass {
  // enum jako typ tylko do odczytu musi być zdefiniowany przed metodą Main
  enum Choices {
    Rock,
    Paper,
    Scissors
  }

  public static void Main (string[] args) {
    /* Na początku ciągu znaków umieściłem specjalny znak (verbatim literal), 
    który pozwala na kontynuację ciągu w wielu liniach */
    Console.WriteLine (@"Welcome in the game of Rock-Paper-Scissors!
    Rules are simple - the first player picks Rock, Paper or Scissors enternig accordingly 1, 2 or 3. Next, the second player makes a choice and score is displayed on screen.
    Press any key to continue..");
    
    // Poniżej używam funkcji do wczytania klawisza z klawiatury, nie ciągu znaków
    Console.ReadKey();
    Console.WriteLine (@"[Player 1] Choose
    (1) Rock
    (2) Paper
    (3) Scissors");
    string theFirstPlayerChoiceString = Console.ReadLine();
    Choices theFirstPlayerChoice;
    if (theFirstPlayerChoiceString == "1"){
      theFirstPlayerChoice = Choices.Rock;
    }
    else if (theFirstPlayerChoiceString == "2"){
      theFirstPlayerChoice = Choices.Paper;
    }
    else{
      theFirstPlayerChoice = Choices.Scissors;
    }
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
    Console.WriteLine ("You've chosen: {0}", theFirstPlayerChoice);
    Console.WriteLine ("Press any key to continue..");
    Console.ReadKey();

    // następnie czyścimy konsolę, żeby drugi gracz nie zobaczył wyboru pierwszego
    Console.Clear ();
    
    // drugi gracz ponawia proces pierwszego gracza
    Console.WriteLine (@"[Player 2] Choose
    (1) Rock
    (2) Paper
    (3) Scissors");
    string theSecondPlayerChoiceString = Console.ReadLine();
    Choices theSecondPlayerChoice;
    if (theSecondPlayerChoiceString == "1"){
      theSecondPlayerChoice = Choices.Rock;
    }
    else if (theSecondPlayerChoiceString == "2"){
      theSecondPlayerChoice = Choices.Paper;
    }
    else{
      theSecondPlayerChoice = Choices.Scissors;
    }
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
    Console.WriteLine ("You've chosen: {0}", theSecondPlayerChoice);
    Console.WriteLine ("Press any key to continue..");
    Console.ReadKey();

    // ponownie czyścimy konsolę przed pokazaniem wyniku
    Console.Clear ();

    // sprawdzamy wynik i wypisujemy na ekranie
    if (theFirstPlayerChoice == theSecondPlayerChoice){
       Console.WriteLine ("Draw!\n{0} - {1}", theFirstPlayerChoice, theSecondPlayerChoice);
    }
    else if ((theFirstPlayerChoice == Choices.Rock && theSecondPlayerChoice == Choices.Scissors)
            ||
            (theFirstPlayerChoice == Choices.Scissors && theSecondPlayerChoice == Choices.Paper)
            ||
            (theFirstPlayerChoice == Choices.Paper && theSecondPlayerChoice == Choices.Rock)
    ){
      Console.WriteLine ("First player won!\n{0} - {1}", theFirstPlayerChoice, theSecondPlayerChoice);
    }
    else{
      Console.WriteLine ("Second player won!\n{0} - {1}", theFirstPlayerChoice, theSecondPlayerChoice);
    }
  }
}