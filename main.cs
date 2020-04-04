using System;

class MainClass {
  // enum jako typ tylko do odczytu musi być zdefiniowany przed metodą Main
  enum Choices {
    Kamień,
    Papier,
    Nożyce
  }

  public static void Main (string[] args) {
    int gamesRecordSize = 10;
    string[,] gamesRecord = new string[gamesRecordSize,3];
    int gamesRecordCurrentIndex = 0;
    int gamesRecordCurrentSize = 0;
    do {
      /* Na początku ciągu znaków umieściłem specjalny znak (verbatim literal), 
      który pozwala na kontynuację ciągu w wielu liniach z literalną interpretacją białych znaków */
      Console.WriteLine (@"Witaj w grze Kamień-Papier-Nożyce!
      Zasady są proste - gracz pierwszy wybiera Kamień, Papier lub Nożyce
      wpisując odpowiednio 1, 2 lub 3. Następnie to samo wpisuje gracz drugi
      i na ekranie wyświetli się wynik.
      Naciśnij dowolny klawisz aby kontynuować..");
      
      // Poniżej używam funkcji do wczytania klawisza z klawiatury, nie ciągu znaków
      Console.ReadKey();
      Console.WriteLine (@"[Gracz 1] Wybierz
      (1) Kamień
      (2) Papier
      (3) Nożyce");
      string firstPlayerChoiceString = Console.ReadLine();
      gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;

      Choices firstPlayerChoice;
      if (firstPlayerChoiceString == "1"){
        firstPlayerChoice = Choices.Kamień;
      }
      else if (firstPlayerChoiceString == "2"){
        firstPlayerChoice = Choices.Papier;
      }
      else{
        firstPlayerChoice = Choices.Nożyce;
      }
      // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
      Console.WriteLine ("Wybrałeś: {0}", firstPlayerChoice);
      Console.WriteLine ("Naciśnij dowolny klawisz aby kontynuować..");
      Console.ReadKey();

      // następnie czyścimy konsolę, żeby drugi gracz nie zobaczył wyboru pierwszego
      Console.Clear ();
      
      // drugi gracz ponawia proces pierwszego gracza
      Console.WriteLine (@"[Gracz 2] Wybierz
      (1) Kamień
      (2) Papier
      (3) Nożyce");
      string secondPlayerChoiceString = Console.ReadLine();
      gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
      Choices secondPlayerChoice;
      if (secondPlayerChoiceString == "1"){
        secondPlayerChoice = Choices.Kamień;
      }
      else if (secondPlayerChoiceString == "2"){
        secondPlayerChoice = Choices.Papier;
      } // tu można zwrócić uwagę
      else{
        secondPlayerChoice = Choices.Nożyce;
      }
      // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
      Console.WriteLine ("Wybrałeś: {0}", secondPlayerChoice);
      Console.WriteLine ("Naciśnij dowolny klawisz aby kontynuować..");
      Console.ReadKey();

      // ponownie czyścimy konsolę przed pokazaniem wyniku
      Console.Clear ();

      // sprawdzamy wynik i wypisujemy na ekranie
      if (firstPlayerChoice == secondPlayerChoice){
        Console.WriteLine ("Remis!\n{0} - {1}", firstPlayerChoice, secondPlayerChoice);
        gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
      }
      else if ((firstPlayerChoice == Choices.Kamień && secondPlayerChoice == Choices.Nożyce)
              ||
              (firstPlayerChoice == Choices.Nożyce && secondPlayerChoice == Choices.Papier)
              ||
              (firstPlayerChoice == Choices.Papier && secondPlayerChoice == Choices.Kamień)
      ){
        Console.WriteLine ("Pierwszy gracz wygrał!\n{0} - {1}", firstPlayerChoice, secondPlayerChoice);
      }
      else{
        Console.WriteLine ("Drugi gracz wygrał!\n{0} - {1}", firstPlayerChoice, secondPlayerChoice);
      }
      gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
      gamesRecordCurrentSize = gamesRecordCurrentSize < gamesRecordSize ? gamesRecordCurrentSize + 1 : gamesRecordSize;
      Console.WriteLine ("Czy chcesz zakończyć rozgrywkę? (t)");
    } while (Console.ReadLine() != "t");
    Console.WriteLine ("Uzyskane wyniki to:");
    for (int i = 0; i < gamesRecordCurrentIndex; i++){
      Console.WriteLine ("Gra #{0}: {1} - {2}, wygrał gracz {3}", 
        i+1, gamesRecord[i,0], gamesRecord[i,1], gamesRecord[i,2]);
    }
  }
}