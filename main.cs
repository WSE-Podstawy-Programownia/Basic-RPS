using System;

class MainClass {
  // enum jako typ tylko do odczytu musi być zdefiniowany przed metodą Main
  enum Choices {
    Kamień,
    Papier,
    Nożyce
  }

  public static void Main (string[] args) {
    /* Na początku ciągu znaków umieściłem specjalny znak (verbatim literal), 
    który pozwala na kontynuację ciągu w wielu liniach */
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
    Choices secondPlayerChoice;
    if (secondPlayerChoiceString == "1"){
      secondPlayerChoice = Choices.Kamień;
    }
    else if (secondPlayerChoiceString == "2"){
      secondPlayerChoice = Choices.Papier;
    }
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
  }
}