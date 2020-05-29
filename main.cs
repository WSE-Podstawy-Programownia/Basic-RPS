using System;
using static System.Console;

class MainClass {

//zmienne  globalne - definiowanie tablicy wynikow - 2a 
  static int gamesRecordSize = 10; // rozmiar 10 wpisow
  static string[,] gamesRecord = new string[gamesRecordSize,3]; //tablica 10x3
  static int gamesRecordCurrentIndex = 0; //początkowy indeks 0
  static int gamesRecordCurrentSize = 0; // rozmiar tablicy

//funkcja -wiadomosc powitalna i zasady gry pod 2 zadanie 1a 
  static void DisplayWelcomeMessage (){
    WriteLine ("\n\nOh my!\nI see a new gambler on board!\nHow do they call you?");

    string nickName = ReadLine();

    WriteLine (nickName + "! what a pathetic name... humans... nevermind. Do you know the rules?\n");

    string YesNo = ReadLine();
    
    WriteLine (YesNo +"??? reallly?!!!! To be sure... the rules are simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined.\n\nAfter each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
  }

// funkcja pobierania danych i weryfikacji od gracza zadanie 1b
  static string GetPlayerInput (string player){

    // deklaracja zmiennej wpisanej i zmiennej poprawnej
    string rawInput;
    string properInput;

    // czas wyboru
    WriteLine ("{0}, time to choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player);
    
    // input gracza
    rawInput = ReadLine();

    // weryfikacja czy  input jest zły (petla while aż poda poprawne)
    while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
        WriteLine ("Hey - this is not correct, try again:\nPlayer One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
    }

    // weryfikacja  czy poprawny i tłumaczenie opisowe (warunki) - po pętli
    if (rawInput == "1") { properInput = "Rock"; }
    else if (rawInput == "2") { properInput = "Paper"; }
    else { properInput = "Scissors"; }

    return properInput; //zwrocenie wartosci
  }

//funkcja sprawdzajaca wynik  zadanie 1c
  static string DetermineWinner (string playerOne, string playerTwo){
    if (playerOne == playerTwo){
        WriteLine ("It's a draw!");
        return "Draw"; //wartość zwracana - remis
    }

    else if ((playerOne == "Rock" && playerTwo == "Scissors") ||
            (playerOne == "Paper" && playerTwo == "Rock") ||
            (playerOne == "Scissors" && playerTwo == "Paper")){
      Console.WriteLine ("Player One won!");
      return "Player One won"; // wartosc zwracana 1wygrywa
    }

    else {
      Console.WriteLine ("Player Two won!");
      return "Player Two won"; //wartosc zwracana 2wygrywa
    }
  }

// funkcja wypisujaca hisotrie wynikow zadanie 1d
  static void DisplayGamesHistory (string[,] gamesRecord, int gamesRecordSize, int gamesRecordCurrentSize = 10, int lastRecordIndex = 0){
    int currentIndex;
    if (gamesRecordCurrentSize < gamesRecordSize){
      currentIndex = 0; // najstarszy indeks 
    }
    else {
      currentIndex = lastRecordIndex;
    }

    WriteLine ("Last games history:");
    for (int i = 0; i < gamesRecordCurrentSize; i++){
        WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}",
        i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
        currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
    }
  }

// funkcja odpowiedzialna za rozegranie gry 2c
  static void PlayGame (){
    // czyszczenie konsoli dla npierwszego gracza
    Clear ();

    // wprowadzanie i zapis do historii gracz 1
    string firstPlayerChoiceString = GetPlayerInput("Player One");
    gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoiceString;
    
    // czyszczenie konsoli dla drugiego gracza
    Clear ();
    
    // wprowadzanie i zapis do historii gracz 2
    string secondPlayerChoiceString = GetPlayerInput("Player Two");
    gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoiceString;
    
    // czyszczenie finalne
    Clear ();

    // sprawdzanie wyniku poprzez funkcje DetermineWinner
    gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

    // zwiekszanie indeksu i historii 
    gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
    if (gamesRecordCurrentSize < gamesRecordSize){
      gamesRecordCurrentSize++;
    }

    // wywolanie funkcji -rekurencji PlayGame()
    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
      PlayGame();
    }
  }


//funkcja głównego menu zad 2b
  static void MainMenuLoop (){
    
    ConsoleKeyInfo inputKey;  // cichy klawisz inputu


    do {
     
      Clear();
      
      //wiadomosc menu 
      WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Run Away");
      inputKey = ReadKey(true);
      if (inputKey.Key == ConsoleKey.D1){
        PlayGame();
      }
      else if (inputKey.Key == ConsoleKey.D2){
        DisplayWelcomeMessage();
      }
      else if (inputKey.Key == ConsoleKey.D3){
        DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);
      }
      else { continue; }
      WriteLine ("(click anything and move on)");
      ReadKey(true);
    } while (inputKey.Key != ConsoleKey.Escape);
  }


  public static void Main (string[] args) {
    MainMenuLoop();
  }
}