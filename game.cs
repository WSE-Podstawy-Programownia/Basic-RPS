 using System;
  using static System.Console;
class Game {

  Player playerOne, playerTwo;
  GamesRecord gamesRecord;
  

  public Game () {
    playerOne = new Player ();
    playerTwo = new Player ();
    gamesRecord = new GamesRecord ();
    MainMenuLoop ();
    
  }

  public void DisplayRules (bool withWelcomeMessage = true) {
    if (withWelcomeMessage) {
      WriteLine ("Welcome to a simple Rock-Paper-Scissors game!");
    }
    WriteLine ("\n\n Zasady gry są proste!\n Gracz Pierwszy wybiera: [1] Kamień lub [2] Papier lub [3] Nożyce\n Gracz Drugi wybiera: [1] Kamień lub [2] Papier lub [3] Nożyce\n\n *Pamiętajcie aby nie podglądać!\n\nWygrywa ten który wybrał silniejszy artefakt!\n\nDla przypomnienia:\n Nożycze niszczą Papier\n Papier neutralizuje Kamień\n Kamień tępi Nożyce\n\nPowodzenia!\n ");
  }
  public string GetPlayerInput (Player player){

    string rawInput;
    string properInput;
    WriteLine ("{0} proszę podać swój typ:\n(1) kamień\n(2) papier\n(3) nożyce", player.playerName);
    rawInput = ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
     WriteLine ("Zły klawisz. Proszę wybrać poprawny numer.\nWybierz:\n[1] Kamień\n[2] Papier\n[3] Nożyce");
      rawInput = ReadLine();
      }
    if (rawInput == "1") { properInput = "Kamień"; }
    else if (rawInput == "2") { properInput = "Papier"; }
    else { properInput = "Nożyce"; }
    return properInput;
  }

   public string DetermineWinner (string playerOneChoice, string playerTwoChoice){

    if (playerOneChoice == playerTwoChoice){ 
      WriteLine ("Remis!"); 
      return "Remis";
      } 
    else if ((playerOneChoice == "Kamień" && playerTwoChoice == "Nożyce") || 
    (playerOneChoice == "Papier" && playerTwoChoice == "Kamień") || 
    (playerOneChoice == "Nożyce" && playerTwoChoice == "Papier")){ 
      WriteLine ("Wygrał Pierwszy Gracz!"); return "Wygrał Pierwszy Gracz!"; 
    }
    else { 
      WriteLine ("Wygrał Drugi Gracz!"); 
      return "Wygrał Drugi Gracz!"; }
  } 

  public void Play () {
    Clear ();
    string firstPlayerChoiceString = GetPlayerInput(playerOne);
    Clear();
    WriteLine ("Wybrałeś: " + firstPlayerChoiceString + "\nWciśniej dowolny przycisk, aby kontynuować");
    Console.ReadKey();
    Clear ();
    string secondPlayerChoiceString = GetPlayerInput(playerTwo);
    Clear();
    WriteLine ("Wybrałeś: " + secondPlayerChoiceString + "\nWciśniej dowolny przycisk, aby kontynuować");
    Console.ReadKey();
    Clear ();

    string gameResult = DetermineWinner(firstPlayerChoiceString,
  secondPlayerChoiceString);

  gamesRecord.AddRecord (firstPlayerChoiceString,secondPlayerChoiceString, gameResult);

  WriteLine("Czy chcesz rozegrać kolejną rundę? Jeśli tak wciśnij [y] \n\nAby zakończyć rozgrywkę wciśnij dowolny przycisk"); 
  if (ReadKey(true).Key == ConsoleKey.Y){
    Play();
    }
  }


  public void MainMenuLoop (){
    ConsoleKeyInfo inputKey;
    do {
      Clear();
      WriteLine ("Papier Kamień Nożyce Menu:\n\t[1] Zagraj w grę\n\t[2] Pokaż zasady\n\t[3] Wyświetl poprzednie rozgrywki' zapis\n\t[ESC] Exit");
      inputKey = ReadKey(true);
      if (inputKey.Key == ConsoleKey.D1){
        Play();
      }
      else if (inputKey.Key == ConsoleKey.D2){
        DisplayRules(false);
      }
      else if (inputKey.Key == ConsoleKey.D3){
        gamesRecord.DisplayGamesHistory();
      }
      else { continue; }
        WriteLine ("Wciśnij dowolny przycisk");
        ReadKey(true);
    } 
      while(inputKey.Key != ConsoleKey.Escape);
  }

  

}